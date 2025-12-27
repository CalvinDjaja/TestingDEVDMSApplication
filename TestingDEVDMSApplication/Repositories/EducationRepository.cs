using TestingDEVDMSApplication.Context;
using TestingDEVDMSApplication.Entity;
using TestingDEVDMSApplication.Repositories.Interface;

namespace TestingDEVDMSApplication.Repositories
{
    public class EducationRepository : BaseRepository<Education>, IEducationRepository
    {
        public EducationRepository(DmsDbContext context) : base(context) { }

        public List<Education> GetAllEducation()
        {
            return GetAll().ToList();
        }

        public Education GetById(int id)
        {
            return GetById(id);
        }

    }

}