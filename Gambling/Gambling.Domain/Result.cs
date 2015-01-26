using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.Domain
{
    public partial class Result
    {
      
        
        public int Rank { get; set; }
       // [Key]
        public int IdRace { get; set; }
        //[Key]
        public int IdRat { get; set; }
        public virtual Race Race { get; set; }
        public virtual Rat Rat { get; set; }
    }
}
