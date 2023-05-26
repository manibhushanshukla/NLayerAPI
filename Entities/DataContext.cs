using Entities.Concrete;
using Entities.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        DbSet<PlatformUsers> platform_user { get; set; }

        public async Task<PlatformUsers> FirstOrDefaultAsync(Func<PlatformUsers, bool> predicate)
        {

            var userList = await platform_user.ToListAsync();
            var user = userList.FirstOrDefault(u => predicate(u));
            return user;
        }

        public async Task UpdateAsync(PlatformUsers user)  
        {
            platform_user.Update(user);
            await SaveChangesAsync();
        }
    }
}
