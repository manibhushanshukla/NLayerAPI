using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLogistic.Domain.Enitities.Platform
{
    public class PlatformOTP
    {
        [Key, Required]
        public Guid user_id { get; set; }
        public string otp { get; set; } = string.Empty;
        public DateTime? otp_expiry_time { get; set; }
        public bool verification_status { get; set; }
    }
}
