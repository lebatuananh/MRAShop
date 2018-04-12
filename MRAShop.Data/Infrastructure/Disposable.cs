using System;

namespace MRAShop.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool isDisposed;

        ~Disposable()//hủy dồi tượng Dispose
        {
            Dispose(false);//sẽ không dispose nữa
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);//gọi GC để thu hoạch bộ nhớ
        }
        //khi có this sẽ hủy rác
        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }


        protected virtual void DisposeCore()
        {

        }
    }
}