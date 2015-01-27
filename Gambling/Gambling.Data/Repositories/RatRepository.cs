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
    public class RatRepository : RepositoryBase<Rat>, IRatRepository
    {
        public RatRepository(DatabaseFactory db)
            : base(db)
        {

        }

    }
    public interface IRatRepository : IRepository<Rat>
    {


    }

}
