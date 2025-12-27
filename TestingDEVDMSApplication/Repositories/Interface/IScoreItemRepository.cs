using TestingDEVDMSApplication.Entity;

namespace TestingDEVDMSApplication.Repositories.Interface
{
    public interface IScoreItemRepository : IBaseRepository<ScoreItem>
    {
        List<ScoreItem> GetAllScoreItem();
        ScoreItem GetScoreItemById(int id);
    }
}
