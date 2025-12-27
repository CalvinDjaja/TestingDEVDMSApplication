using TestingDEVDMSApplication.Context;
using TestingDEVDMSApplication.Entity;
using TestingDEVDMSApplication.Repositories.Interface;

namespace TestingDEVDMSApplication.Repositories
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(DmsDbContext context) : base(context) { }

        public List<Department> GetAllDepartment()
        {
            return GetAll().ToList();
        }

        public Department GetDepartmentById(int id)
        {
            return GetById(id);
        }

    }

}