using SuperLogistic.DataAccess.Context;
using SuperLogistic.Domain.Enitities.Customer;
using SuperLogistic.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SuperLogistic.DataAccess.Implementation
{
    public class CustomerDetailsRepository:GenericRepository<CustomerDetails>,ICustomerDetailsRepository
    {
        public CustomerDetailsRepository(DataContext context):base(context)
        {
            
        }
    }
}
