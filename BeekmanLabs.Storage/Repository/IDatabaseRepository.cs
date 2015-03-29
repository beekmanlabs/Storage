using BeekmanLabs.Storage.Model;
using System;
using System.Data.Entity;

namespace BeekmanLabs.Storage.Repository
{
    public interface IDatabaseRepository : IRepository<IHasLongId, long>, IDisposable
    {
        void Save();
        void SetState<TItem>(TItem item, EntityState entityState) where TItem : class;
    }
}

