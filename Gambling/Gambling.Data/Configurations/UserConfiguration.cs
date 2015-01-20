using Gambling.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.Data.Configurations
{
    public class UserConfiguration:EntityTypeConfiguration<User>
    {

        public UserConfiguration()
        {
            Property(u => u.Id).IsRequired();

            Property(u => u.Login).IsRequired();
            Property(u => u.Password).IsRequired();
            Property(u => u.Name).IsOptional().HasMaxLength(20);

            HasMany(u => u.Rats).WithOptional(r => r.Owner).HasForeignKey(r => r.IdOwner).WillCascadeOnDelete(true);

            HasMany(u => u.Bets).WithOptional(b => b.Bettor).HasForeignKey(b => b.IdBettor).WillCascadeOnDelete(false);
            Map<Owner>(u=>u.Requires("UserType").HasValue(1)).Map<Admin>(u => u.Requires("UserType").HasValue(2));

        }


    }
}
