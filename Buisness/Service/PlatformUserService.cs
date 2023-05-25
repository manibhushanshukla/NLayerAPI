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

namespace Buisness.Service
{
    public class PlatformUserService
    {
        private readonly DataContext _context;

        public PlatformUserService(DataContext context)
        {
            _context = context;
        }
        
        //private readonly IRepository<PlatformUsers> _userRepository;

        //public PlatformUserService(IRepository<PlatformUsers> userRepository)
        //{
        //    _userRepository = userRepository;
        //}

        public async Task<PlatformUsers> SuperRegistration(PlatformRegistration register)
        {

                PlatformUsers user = new PlatformUsers()
                {
                    name = register.name,
                    email = register.email,
                    user_id = Guid.NewGuid(),
                    role_id = register.role_id,
                    contact = register.contact
                };

                await _context.AddAsync(user);

                //// Generate token and send email
                //var token = GenerateToken();
                //var expirationTime = DateTime.UtcNow.AddHours(1);
                //var link = $"http://192.168.1.3:3000/create-pass/&token={token}&expires={expirationTime}&role=platform_user";
                //user.password_creation_token = token;
                //user.creation_time = expirationTime;

                //await _userRepository.UpdateAsync(user);

                //await SendEmailWithLink(user.email, link);



                return user;
            }
           
        }
}
