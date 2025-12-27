using TestingDEVDMSApplication.Context;
using TestingDEVDMSApplication.Entity;
using TestingDEVDMSApplication.Repositories.Interface;

namespace TestingDEVDMSApplication.Repositories
{
    public class TrackDataSLIKRepository : BaseRepository<TrackDataSLIK>, ITrackDataSLIKRepository
    {
        public TrackDataSLIKRepository(DmsDbContext context) : base(context) { }

        public List<TrackDataSLIK> GetAllTrackDataSLIK()
        {
            return GetAll().ToList();
        }

        public TrackDataSLIK GetById(int id)
        {
            return GetById(id);
        }

    }

}