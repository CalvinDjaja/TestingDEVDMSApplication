using Microsoft.Data.SqlClient;

namespace TestingDEVDMSApplication.Repositories.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        T Add(T entity);
        void Update(T entity);
    }
}
