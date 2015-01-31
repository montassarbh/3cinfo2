using Gambling.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.Data.Infrastructure
{
    public class UnitOfWork:IUnitOfWork,IDisposable

    {
        GamblingContext cxt;
        DatabaseFactory db;
        public UnitOfWork(DatabaseFactory db)
        {
            this.db = db;
            cxt = this.db.Get();
        }
        

        public void Commit()
        {
            cxt.SaveChanges();
            
        }

        Repositories.UserRepository userRepository;
        public Repositories.UserRepository UserRepository
        {
            get { return userRepository = new Repositories.UserRepository(db); }
        }
        Repositories.RaceRepository raceRepository;
        public Repositories.RaceRepository RaceRepository
        {
            get { return raceRepository = new Repositories.RaceRepository(db); }
        }
        Repositories.ResultRepository resultRepository;
        public Repositories.ResultRepository ResultRepository
        {
            get { return resultRepository = new Repositories.ResultRepository(db); }
        }

        Repositories.BetRepository betRepository;
        public Repositories.BetRepository BetRepository
        {
            get { return betRepository = new Repositories.BetRepository(db); }
        }

        Repositories.RatRepository ratRepository;
        public Repositories.RatRepository RatRepository
        {
            get { return ratRepository = new Repositories.RatRepository(db); }
        }

        void IDisposable.Dispose()
        {
            db.Dispose();
        }
    }
}
