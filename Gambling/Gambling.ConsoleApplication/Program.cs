using Gambling.Data;
using Gambling.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           
            User u = new User {Login = "foulen@benfoulen.com", Password = "p@$$w0rd", Name = "Foulen" };
            GamblingContext cxt = new GamblingContext();
            cxt.Users.Add(u);
            cxt.SaveChanges();
            Imen i = new Imen();
            
        }
    }
}
