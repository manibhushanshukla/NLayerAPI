using SuperLogistic.DataAccess.Context;
using SuperLogistic.Domain.Enitities.Customer;
using SuperLogistic.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLogistic.DataAccess.Implementation
{
    public class SurveyDetailsRepository:GenericRepository<SurveyDetails>,ISurveyDetailsRepository
    {
        public SurveyDetailsRepository(DataContext context):base(context)
        {
            
        }
    }
}
