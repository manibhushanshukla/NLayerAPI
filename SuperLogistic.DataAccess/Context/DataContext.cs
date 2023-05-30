using Microsoft.EntityFrameworkCore;
using SuperLogistic.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperLogistic.Domain.Enitities.Platform;
using SuperLogistic.Domain.Enitities.Company;
using SuperLogistic.Domain.Enitities.Employee;
using SuperLogistic.Domain.Enitities.Customer;

namespace SuperLogistic.DataAccess.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<PlatformUser> platform_user { get; set; }
        public DbSet<PlatformOTP> platform_otp { get; set; }
        public DbSet<PlatformRoles> platform_role { get; set; }

        public DbSet<CompanyUser> company_user { get; set; }
        public DbSet<CompanyOTP> company_otp { get; set; }
        public DbSet<CompanyRoles> company_role { get; set; }

        public DbSet<Employee> employee_detail { get; set; }
        public DbSet<CustomerDetails> customer_detail { get; set; }
        public DbSet<SurveyDetails> survey_detail { get; set; }



    }
}
