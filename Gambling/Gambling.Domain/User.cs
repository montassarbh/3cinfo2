using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.Domain
{
    public partial class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(15)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public virtual ICollection<Rat> Rats { get; set; }
        public virtual ICollection<Bet> Bets { get; set; }
    }
}
