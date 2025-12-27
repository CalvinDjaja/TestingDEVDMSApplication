using Microsoft.Data.SqlClient;

namespace TestingDEVDMSApplication.Repositories.Interface
{
    public interface IBaseRepository
    {
        SqlConnection GetConnection();
    }
}
