using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLogistic.Domain.Repository
{
    public interface IUnitOfWork:IDisposable
    {
        IPlatformUserRepository Platform_User { get; }
        IPlatformOTPRepository Platform_OTP { get; }
        ICompanyUserRepository Company_User { get; }
        ICompanyOTPRepository Company_OTP { get; }
        IEmployeeRepository employee { get; }
        ICustomerDetailsRepository Customer_Details { get; }
        ISurveyDetailsRepository Survey_Details { get; }

        int Save();

    }
}
