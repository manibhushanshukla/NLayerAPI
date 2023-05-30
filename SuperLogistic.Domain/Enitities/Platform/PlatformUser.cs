using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLogistic.Domain.Enitities.Platform
{
    public class PlatformUser
    {
        [Key, Required]
        public Guid user_id { get; set; }
        [Required]
        public string name { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string email { get; set; } = string.Empty;

        public string password_creation_token { get; set; } = string.Empty;
        public DateTime creation_time { get; set; }

        [Required]
        public Guid role_id { get; set; }

        [RegularExpression(@"^\+\d{1,3}\d{9}$", ErrorMessage = "Contact number must start with a '+' sign, followed by the country code (1-3 digits), and then 9 digits")]
        public string contact { get; set; } = string.Empty;
        public byte[]? password_hash { get; set; }
        public byte[]? password_salt { get; set; }
        [Required]
        public bool password_creation_status { get; set; }
    }
}
