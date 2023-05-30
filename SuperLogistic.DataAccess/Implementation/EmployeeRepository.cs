using SuperLogistic.DataAccess.Context;
using SuperLogistic.Domain.Enitities.Employee;
using SuperLogistic.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLogistic.DataAccess.Implementation
{
    public class EmployeeRepository:GenericRepository<Employee>,IEmployeeRepository
    {
        public EmployeeRepository(DataContext context):base(context)
        {
            
        }
    }
}
