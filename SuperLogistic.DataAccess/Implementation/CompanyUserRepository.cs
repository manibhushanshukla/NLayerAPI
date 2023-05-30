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
    public class CompanyUserRepository:GenericRepository<CompanyUser>,ICompanyUserRepository
    {
        public CompanyUserRepository(DataContext context):base(context)
        {
            
        }
    }
}
