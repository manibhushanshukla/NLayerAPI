using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PlatformLogin
    {
        [Required,EmailAddress]
        public string email { get; set; } = string.Empty;
        [Required, MinLength(6), RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]+$", ErrorMessage = "Password should be a combination of uppercase,lowercase,special char,numeric")]

        public string password { get; set; } = string.Empty;
    }
}
