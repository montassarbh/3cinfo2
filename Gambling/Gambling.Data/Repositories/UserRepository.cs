using Gambling.Data.Contracts;
using Gambling.Data.Infrastructure;
using Gambling.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>,IUserRepository
    {
        public UserRepository(DatabaseFactory db):base(db)
        {
            
        }
       
    }
    public interface IUserRepository:IRepository<User>
    {


    }

}
