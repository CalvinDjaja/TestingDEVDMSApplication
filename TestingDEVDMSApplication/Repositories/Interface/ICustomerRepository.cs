using TestingDEVDMSApplication.Entity;

namespace TestingDEVDMSApplication.Repositories.Interface
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomer();
        Customer GetById(int id);
    }
}
