using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.Domain
{
    public partial class Bettor:User
    {
        [DataType(DataType.Currency)]
        public float MoneyCash { get; set; }


    }
}
