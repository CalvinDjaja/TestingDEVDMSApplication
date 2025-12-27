using TestingDEVDMSApplication.Entity;

namespace TestingDEVDMSApplication.Repositories.Interface
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
        List<Customer> GetAllCustomer();
        Customer GetCustomerById(int id);
    }
}
