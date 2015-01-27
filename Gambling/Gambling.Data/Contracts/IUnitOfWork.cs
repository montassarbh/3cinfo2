using Gambling.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.Data.Contracts
{
    public interface IUnitOfWork
    {
         void Commit();
        UserRepository UserRepository { get; }
        RaceRepository RaceRepository{get;}
        ResultRepository ResultRepository{get;}
        BetRepository BetRepository{get;}
        RatRepository RatRepository{get;}


    }
}
