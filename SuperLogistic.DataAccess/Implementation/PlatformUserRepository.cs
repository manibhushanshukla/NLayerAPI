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
    public class PlatformUserRepository:GenericRepository<PlatformUser>,IPlatformUserRepository
    {
        public PlatformUserRepository(DataContext context):base(context)
        {
            
        }
    }
}
