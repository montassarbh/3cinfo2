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
    public class RaceRepository : RepositoryBase<Race>, IRaceRepository
    {
        public RaceRepository(DatabaseFactory db)
            : base(db)
        {

        }

    }
    public interface IRaceRepository : IRepository<Race>
    {


    }

}
