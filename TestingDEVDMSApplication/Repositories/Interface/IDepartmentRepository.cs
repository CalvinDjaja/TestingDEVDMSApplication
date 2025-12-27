using TestingDEVDMSApplication.Entity;

namespace TestingDEVDMSApplication.Repositories.Interface
{
    public interface IDepartmentRepository
    {
        List<Department> GetAllDepartment();
        Department GetById(int id);
    }
}
