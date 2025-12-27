using TestingDEVDMSApplication.Entity;

namespace TestingDEVDMSApplication.Repositories.Interface
{
    public interface ICompanyCategoryRepository : IBaseRepository<CompanyCategory>
    {
        List<CompanyCategory> GetAllCompanyCategory();
        CompanyCategory GetCompanyCategoryById(int id);
    }
}
