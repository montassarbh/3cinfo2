using Gambling.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.Data.Configurations
{
    public class ResultConfiguration:EntityTypeConfiguration<Result>
    {
        public ResultConfiguration()
        {
            HasKey(r => new { r.IdRace, r.IdRat});

            

        }
    }
}
