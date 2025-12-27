using TestingDEVDMSApplication.Entity;

namespace TestingDEVDMSApplication.Repositories.Interface
{
    public interface ICompanyCategoryRepository
    {
        List<CompanyCategory> GetAllCompanyCategory();
        CompanyCategory GetById(int id);
    }
}
