using CallRepairer.Entities;

namespace CallRepairer.Repositories;

public interface IRepository<T> : IReadRepositories<T>, IWriteRepository<T> 
    where T : class, IEntity
{
}
