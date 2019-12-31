

namespace Micro.API.Service.Domain.Domain
{
    using System; 
    using System.Threading;
    using System.Threading.Tasks;
    public interface IUnitofWork: IDisposable
    {
        Task<Int64> SaveChangesAsync (CancellationToken cancellationToken = default(CancellationToken))

        Task<Int64> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken))
 
    }

    public interface IAggregateRoot { }

    interface IRepository<T> where T:IAggregateRoot
    {
        IUnitofWork UnitofWork { get; }
    }
}
