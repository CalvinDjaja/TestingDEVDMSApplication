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

        public T GetById(Guid id)
        {
            return _dbContext.Set<T>().Find(id);
        }
    }

}
