using Entities.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Common.JWTToken
{
    public class JwtToken
    {
        //creating JSON Web Token
        public static string CreateToken(PlatformUsers user)
        {
            //List<Claim> claims = new List<Claim>
            //{
            //    new Claim(ClaimTypes.Name, user.email),

            //};
            //// Retrieve the roles associated with the user
            //var roles = _context.platform_role
            //                      .Where(ur => ur.role_id == user.role_id)
            //                      .Select(ur => ur.role_name)
            //                      .ToList();

            // Add the roles as claims to the list of claims
            //foreach (var role in roles)
            //{
            //    claims.Add(new Claim(ClaimTypes.Role, role));
            ////}
            //var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("MySuperSecretKey12345678"));
            //var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            //var token = new JwtSecurityToken(
            //     issuer: "4.240.84.193",
            //     audience: "http://4.240.84.193", // add the audience claim
            //   // claims: claims,
            //    expires: DateTime.Now.AddDays(1),
            //    signingCredentials: creds
            //    );
            //var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            //return jwt;



            // Generate a 512-bit key
            var keyBytes = new byte[64]; // 512 bits = 64 bytes
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(keyBytes);
            }

            var key = new SymmetricSecurityKey(keyBytes);
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                issuer: "4.240.84.193",
                audience: "http://4.240.84.193",
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
            );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;



        }
    }
}
