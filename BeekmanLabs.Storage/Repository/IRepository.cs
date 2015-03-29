using System.Collections.Generic;

namespace BeekmanLabs.Storage.Repository
{
    public interface IRepository<THasId, TId>
    {
        IEnumerable<TItem> SelectAll<TItem>() where TItem : class, THasId;
        TItem SelectById<TItem>(TId id) where TItem : class, THasId;
        TItem Insert<TItem>(TItem item) where TItem : class, THasId;
        TItem Update<TItem>(TItem item) where TItem : class, THasId;
        void Delete<TItem>(TId id) where TItem : class, THasId;
        bool Exists<TItem>(TId id) where TItem : class, THasId;
        bool IsServerAvailable();
    }
}
