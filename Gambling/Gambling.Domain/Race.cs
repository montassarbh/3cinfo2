using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.Domain
{
   public class Race
    {
       [Key]
        public int Id { get; set; }

        public string Place { get; set; }

        public string Type { get; set; }

        public virtual ICollection<Bet> Bets { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
