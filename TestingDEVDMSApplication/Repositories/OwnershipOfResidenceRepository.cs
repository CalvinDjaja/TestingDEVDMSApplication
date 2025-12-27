using TestingDEVDMSApplication.Context;
using TestingDEVDMSApplication.Entity;
using TestingDEVDMSApplication.Repositories.Interface;

namespace TestingDEVDMSApplication.Repositories
{
    public class OwnershipOfResidenceRepository : BaseRepository<OwnershipOfResidence>, IOwnershipOfResidenceRepository
    {
        public OwnershipOfResidenceRepository(DmsDbContext context) : base(context) { }

        public List<OwnershipOfResidence> GetAllOwnershipOfResidence()
        {
            return GetAll().ToList();
        }

        public OwnershipOfResidence GetById(int id)
        {
            return GetById(id);
        }

    }

}