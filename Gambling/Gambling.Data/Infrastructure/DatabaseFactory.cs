using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.Data.Infrastructure
{
    public class DatabaseFactory:Disposable, IDatabaseFactory
    {
        GamblingContext _gContext = null;
        public GamblingContext Get()
        {
            return _gContext ??(_gContext= new GamblingContext());
        }
        protected override void DisposeCore()
        {
            _gContext.Dispose();
        }
    }
    public interface IDatabaseFactory
    {
        GamblingContext Get();
    }
}
