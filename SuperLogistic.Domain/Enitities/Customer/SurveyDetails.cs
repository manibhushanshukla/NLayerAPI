using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLogistic.Domain.Enitities.Customer
{
    public class SurveyDetails
    {
        [Key, Required]
        public Guid customer_id { get; set; }
        [Required]
        public Guid employee_id { get; set; }

        public string moving_from { get; set; } = string.Empty;
        public string moving_to { get; set; } = string.Empty;
        public DateTime shifting_date { get; set; }
        public DateTime shifting_time { get; set; }
        public string room_configuration { get; set; } = string.Empty;
        public string item_list { get; set; } = string.Empty;

        public bool survey_created { get; set; }
    }
}
