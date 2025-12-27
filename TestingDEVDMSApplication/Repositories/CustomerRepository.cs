using TestingDEVDMSApplication.Context;
using TestingDEVDMSApplication.Entity;
using TestingDEVDMSApplication.Repositories.Interface;

namespace TestingDEVDMSApplication.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DmsDbContext context) : base(context) { }

        public List<Customer> GetAllCustomer()
        {
            return GetAll().ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return GetById(id);
        }

    }

}