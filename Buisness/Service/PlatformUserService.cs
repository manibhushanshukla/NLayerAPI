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

namespace Buisness.Service
{
    public class PlatformUserService
    {

        private readonly IRepository<PlatformUsers> _userRepository;
        public PlatformUserService(IRepository<PlatformUsers> userRepository)
        {
            _userRepository = userRepository;
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

                await _userRepository.AddAsync(user);
                await _userRepository.SaveChangesAsync();

                // Generate token and send email
                var token = generateToken.GenerateToken();
                var expirationTime = DateTime.UtcNow.AddHours(1);
                var link = $"http://192.168.1.3:3000/create-pass/&token={token}&expires={expirationTime}&role=platform_user";
                user.password_creation_token = token;
                user.creation_time = expirationTime;

                await _userRepository.UpdateAsync(user);

                await EmailService.SendEmailWithLink(user.email, link);



                return user;
            }
           
        }
}
