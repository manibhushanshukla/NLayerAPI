using SuperLogistic.DataAccess.Context;
using SuperLogistic.Domain.Enitities.Platform;
using SuperLogistic.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLogistic.DataAccess.Implementation
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly DataContext _context;
        public UnitOfWork(DataContext context)
        {
            _context = context;
            Platform_User = new PlatformUserRepository(_context);
            Platform_OTP = new PlatformOTPRepository(_context);
            Company_User = new CompanyUserRepository(_context);
            Company_OTP = new CompanyOTPRepository(_context);
            employee = new EmployeeRepository(_context);
            Customer_Details = new CustomerDetailsRepository(_context);
            Survey_Details = new SurveyDetailsRepository(_context);
        }
        public  IPlatformUserRepository Platform_User { get; private set; }
       public  IPlatformOTPRepository Platform_OTP { get; private set; }
       public ICompanyUserRepository Company_User { get; private set; }
       public  ICompanyOTPRepository Company_OTP { get; private set; }
       public  IEmployeeRepository employee { get; private set; }
       public ICustomerDetailsRepository Customer_Details { get; private set; }
       public ISurveyDetailsRepository Survey_Details { get; private set; }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
