using CallRepairer.Entities;

namespace CallRepairer.Repositories;

public interface IReadRepositories<out T> where T : class, IEntity
{
    IEnumerable<T> GetAll();

    T GetById(int id);

    public int GetCount();
}
