using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLogistic.Domain.Enitities.Company
{
    public class CompanyUser
    {
        [Key, Required]
        public Guid user_id { get; set; }
        [Required]
        public string company_name { get; set; } = string.Empty;
        public string company_type { get; set; } = string.Empty;

        [RegularExpression(@"^\d{10}$", ErrorMessage = "Contact number must be 10 digits")]
        public string company_contact_number { get; set; } = string.Empty;

        [Required]

        public string gst_number { get; set; } = string.Empty;
        [Required]
        public int number_of_employees { get; set; }

        public string password_creation_token { get; set; } = string.Empty;
        public DateTime creation_time { get; set; }


        [Required, RegularExpression(@"^\d{10}$", ErrorMessage = "Contact number must be 10 digits")]
        public string contact_number { get; set; } = string.Empty;

        [Required]
        public string contact_name { get; set; } = string.Empty;

        public Guid company_id { get; set; }

        [RegularExpression(@"^\d{10}$", ErrorMessage = "Contact number must be 10 digits")]


        [Required, EmailAddress]
        public string email { get; set; } = string.Empty;

        [Required]
        public string company_address { get; set; } = string.Empty;
        [Required]
        public Guid role_id { get; set; }


        public byte[]? password_hash { get; set; }

        public byte[]? password_salt { get; set; }
        public bool pasword_creation_status { get; set; }
    }
}
