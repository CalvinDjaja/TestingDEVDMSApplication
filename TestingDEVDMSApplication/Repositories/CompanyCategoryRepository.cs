using TestingDEVDMSApplication.Context;
using TestingDEVDMSApplication.Entity;
using TestingDEVDMSApplication.Repositories.Interface;

namespace TestingDEVDMSApplication.Repositories
{
    public class CompanyCategoryRepository : BaseRepository<CompanyCategory>, ICompanyCategoryRepository
    {
        public CompanyCategoryRepository(DmsDbContext context) : base(context) { }

        public List<CompanyCategory> GetAllCompanyCategory()
        {
            return GetAll().ToList();
        }

        public CompanyCategory GetById(int id)
        {
            return GetById(id);
        }

    }

}