using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Common.Token
{
    public class generateToken
    {
        public static string GenerateToken()
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var token = new string(Enumerable.Repeat(chars, 32) // Generate a 32-character token
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return token;
        }
    }
}
