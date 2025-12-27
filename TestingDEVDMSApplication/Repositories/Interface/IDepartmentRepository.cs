using TestingDEVDMSApplication.Entity;

namespace TestingDEVDMSApplication.Repositories.Interface
{
    public interface IDepartmentRepository
    {
        List<Department> GetAllDepartment();
        Department GetDepartmentById(int id);
    }
}
