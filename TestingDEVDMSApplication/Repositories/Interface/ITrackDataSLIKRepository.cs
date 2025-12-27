using TestingDEVDMSApplication.Entity;

namespace TestingDEVDMSApplication.Repositories.Interface
{
    public interface ITrackDataSLIKRepository
    {
        List<TrackDataSLIK> GetAllTrackDataSLIK();
        TrackDataSLIK GetTrackDataSLIKById(int id);
    }
}
