using TestingDEVDMSApplication.Entity;

namespace TestingDEVDMSApplication.Repositories.Interface
{
    public interface IOwnershipOfResidenceRepository
    {
        List<OwnershipOfResidence> GetAllOwnershipOfResidence();
        OwnershipOfResidence GetById(int id);
    }
}
