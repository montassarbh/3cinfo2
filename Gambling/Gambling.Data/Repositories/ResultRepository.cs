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
    public class ResultRepository : RepositoryBase<Result>, IResultRepository
    {
        public ResultRepository(DatabaseFactory db)
            : base(db)
        {

        }

    }
    public interface IResultRepository : IRepository<Result>
    {


    }

}
