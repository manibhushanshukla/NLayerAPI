using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLogistic.Domain.Enitities.Company
{
    public class CompanyOTP
    {
        [Key]
        [Required]
        public Guid user_id { get; set; }

        [RegularExpression(@"^\d{6}$", ErrorMessage = "The OTP must be a 6-digit number")]
        [Required]
        public string otp { get; set; } = string.Empty;
        [Required]
        public DateTime otp_expiry_time { get; set; }

        public bool verification_status { get; set; }
    }
}
