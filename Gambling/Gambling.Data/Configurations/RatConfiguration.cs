using Gambling.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.Data.Configurations
{
    public class RatConfiguration:EntityTypeConfiguration<Rat>
    {
        public RatConfiguration()
        {
            Property(r => r.Id).IsRequired();
            Property(r => r.Name).IsOptional().HasMaxLength(20);
            Property(r => r.Color).IsOptional();
            Property(r => r.Price).IsRequired();

            HasMany(r => r.Bets).WithOptional(b => b.Rat).HasForeignKey(b => b.IdRat).WillCascadeOnDelete(false);
            HasMany(r => r.Results).WithRequired(b => b.Rat).HasForeignKey(b => b.IdRat).WillCascadeOnDelete(false);

          



        }
    }
}
