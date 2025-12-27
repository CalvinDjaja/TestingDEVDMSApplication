using Microsoft.EntityFrameworkCore;

namespace TestingDEVDMSApplication.Repositories
{
    public abstract class BaseRepository<T> where T : class
    {
        protected readonly DbContext _dbContext;

        protected BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IReadOnlyList<T> GetAll()
        {
            return _dbContext.Set<T>().AsNoTracking().ToList();
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public T Add(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Added;
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
            _dbContext.ChangeTracker.Clear();
            return entity;
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
            _dbContext.ChangeTracker.Clear();
        }

    }

}
