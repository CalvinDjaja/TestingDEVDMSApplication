using TestingDEVDMSApplication.Entity;

namespace TestingDEVDMSApplication.Repositories.Interface
{
    public interface IScoreGroupItemRepository : IBaseRepository<ScoreGroupItem>
    {
        List<ScoreGroupItem> GetAllScoreGroupItem();
        ScoreGroupItem GetScoreGroupItemById(int id);
    }
}
