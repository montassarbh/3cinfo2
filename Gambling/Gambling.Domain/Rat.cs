using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.Domain
{
    public class Rat
    {
        [Key]
        public int Id { get; set; }
        public int? IdOwner { get; set; }
        [StringLength(15)]
        public string Name { get; set; }

        public RatColor Color { get; set; }
        [DataType(DataType.Currency)]
        public float Price { get; set; }

        public bool Assigned { get; set; }
        [ForeignKey("IdOwner")]
        public virtual User Owner { get; set; }

        public virtual ICollection<Bet> Bets { get; set; }

        public virtual ICollection<Result> Results { get; set; }

    }
}
