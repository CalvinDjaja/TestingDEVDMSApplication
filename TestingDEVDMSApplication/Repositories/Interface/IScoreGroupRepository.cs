using TestingDEVDMSApplication.Entity;

namespace TestingDEVDMSApplication.Repositories.Interface
{
    public interface IScoreGroupRepository : IBaseRepository<ScoreGroup>
    {
        List<ScoreGroup> GetAllScoreGroup();
        ScoreGroup GetScoreGroupById(int id);
    }
}
