using System;

namespace api_bd
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
