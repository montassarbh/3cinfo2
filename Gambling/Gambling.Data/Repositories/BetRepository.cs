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
    public class BetRepository : RepositoryBase<Bet>, IBetRepository
    {
        public BetRepository(DatabaseFactory db)
            : base(db)
        {

        }

    }
    public interface IBetRepository : IRepository<Bet>
    {


    }

}
