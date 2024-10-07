using CallRepairer.Entities;
using Microsoft.EntityFrameworkCore;

namespace CallRepairer.Repositories;

public class SqlRepository<T> : IRepository<T> where T : class, IEntity, new()
{
    private readonly DbSet<T> _dbSet;
    
    private readonly DbContext _dbContext;

    public SqlRepository() { }

    public SqlRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<T>();
    }

    public void Add(T entity) => _dbSet.Add(entity);

    public int GetCount() => _dbSet.Count();

    public IEnumerable<T> GetAll() => _dbSet.ToList();

    public T GetById(int id) => _dbSet.Find(id);

    public void Remove(T entity) => _dbSet.Remove(entity);

    public void Save() => _dbContext.SaveChanges();
}
