using TestingDEVDMSApplication.Entity;

namespace TestingDEVDMSApplication.Repositories.Interface
{
    public interface IEducationRepository
    {
        List<Education> GetAllEducation();
        Education GetEducationById(int id);
    }
}
