using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.Domain
{
    public partial class Bet
    {
        [Key]
        public int Id { get; set; }
        public int? IdBettor { get; set; }
        public Nullable <int> IdRace { get; set; }
        public int? IdRat { get; set; }

        public DateTime DateOfBet { get; set; }
        [DataType(DataType.Currency)]
        public float BetAmount { get; set; }
        [Range(0,Int32.MaxValue)]
        public int TicketOfficeNumber { get; set; }

        [ForeignKey("IdBettor")]
        public virtual User Bettor { get; set; }
        [ForeignKey("IdRace")]
        public virtual Race Race { get; set; }

        [ForeignKey("IdRat")]
        public virtual Rat Rat { get; set; }

        
    }
}
