using Gambling.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.Data.Configurations
{
    public class RaceConfiguration:EntityTypeConfiguration<Race>

    {
        public RaceConfiguration()
        {
            HasKey(r => r.Id);


            HasMany(r => r.Bets).WithOptional(a => a.Race).HasForeignKey(r => r.IdRace).WillCascadeOnDelete(false);
            HasMany(r => r.Results).WithRequired(x => x.Race).HasForeignKey(r => r.IdRace).WillCascadeOnDelete(false);
        
        }


    
    }
}
