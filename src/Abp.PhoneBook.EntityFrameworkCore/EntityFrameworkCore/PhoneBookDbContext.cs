using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Abp.PhoneBook.Authorization.Roles;
using Abp.PhoneBook.Authorization.Users;
using Abp.PhoneBook.MultiTenancy;

namespace Abp.PhoneBook.EntityFrameworkCore
{
    public class PhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User, PhoneBookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PhoneBookDbContext(DbContextOptions<PhoneBookDbContext> options)
            : base(options)
        {
        }
    }
}
