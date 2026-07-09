using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_Dispose_Pattern_
{
    public class BigData : IDisposable
    {
        // Великий масив (100 МБ)
        private byte[]? buffer = new byte[100 * 1024 * 1024];

        private bool disposed = false;

        public void Fill()
        {
            if (disposed)
                throw new ObjectDisposedException(nameof(BigData));

            for (int i = 0; i < buffer!.Length; i++)
            {
                buffer[i] = 1;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    buffer = null;
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~BigData()
        {
            Dispose(false);
        }
    }
}
