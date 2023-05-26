using Buisness.Common.Token;
using DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Buisness.Common.EmailService;
using Buisness.Common;
using Microsoft.EntityFrameworkCore;
using Buisness.Common.HashSalt;

namespace Buisness.Service
{
    public class PlatformUserService:IPlatformUserService
    {

        //private readonly IRepository<PlatformUsers> _userRepository;
        //public PlatformUserService(IRepository<PlatformUsers> userRepository)
        //{
        //    _userRepository = userRepository;
        //}
        private readonly DataContext _context;
        public PlatformUserService(DataContext context)
        {
            _context = context;
            
        }

        public async Task<PlatformUsers> SuperRegistration(PlatformRegistration register)
        {

                PlatformUsers user = new PlatformUsers()
                {
                    user_id = Guid.NewGuid(),
                    name = register.name,
                    email = register.email,
                    role_id = register.role_id,
                    contact = register.contact
                };

                await _context.AddAsync(user);
                await _context.SaveChangesAsync();

                // Generate token and send email
                var token = generateToken.GenerateToken();
                var expirationTime = DateTime.UtcNow.AddHours(1);
                var link = $"http://192.168.1.3:3000/create-pass/&token={token}&expires={expirationTime}&role=platform_user";
                user.password_creation_token = token;
                user.creation_time = expirationTime;

                await _context.UpdateAsync(user);

                await EmailService.SendEmailWithLink(user.email, link);



                return user;
        }

        public async Task<PlatformUsers> CreatePassword(Platform_CreatePassword create)
        {
            var user = await _context.FirstOrDefaultAsync(u => u.password_creation_token == create.token);
            if (user == null)
            {
                throw new Exception("Invalid token");
            }
            if (DateTime.UtcNow > user.creation_time)
            {
                throw new Exception("Token Expired");
            }


            HashSalt.CreatePasswordHash(create.password, out byte[] passwordHash, out byte[] passwordSalt);

            user.password_hash = passwordHash;
            user.password_salt = passwordSalt;


            user.password_creation_status = true;
            await _context.SaveChangesAsync();


            return user;

        }

        public async Task<string> Login(string email,string password)
        {
            PlatformUsers user = await _context.FirstOrDefaultAsync(u => u.email == email);
            if (user == null)
            {
                //    _logger.LogError($"User not found for {email}", email);
                throw new Exception("User Not Found");
            }

            if (!HashSalt.VerifyPasswordHash(password, user.password_hash, user.password_salt))
            {
                // _logger.LogError($"Invalid password for user {email}", email);
                throw new Exception("Wrong Password");

            }
            var token = Common.JWTToken.JwtToken.CreateToken(user);

            return token;

        }




    }
}
