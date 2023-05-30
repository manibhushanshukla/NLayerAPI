using SuperLogistic.DataAccess.Context;
using SuperLogistic.Domain.Enitities.Company;
using SuperLogistic.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLogistic.DataAccess.Implementation
{
    public class CompanyOTPRepository :GenericRepository<CompanyOTP>,ICompanyOTPRepository

        
    {
        public CompanyOTPRepository(DataContext context):base(context)
        {
            
        }
    }
}
