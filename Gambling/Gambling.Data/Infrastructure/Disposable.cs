using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        bool isDisposed = false;
        ~Disposable()
        {
            Dispose(false);
        }
        public void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void DisposeCore()
        {
        }
    }
}
