using TestingDEVDMSApplication.Context;
using TestingDEVDMSApplication.Entity;
using TestingDEVDMSApplication.Repositories.Interface;

namespace TestingDEVDMSApplication.Repositories
{
    public class ScoreGroupItemRepository : BaseRepository<ScoreGroupItem>, IScoreGroupItemRepository
    {
        public ScoreGroupItemRepository(DmsDbContext context) : base(context) { }

        public List<ScoreGroupItem> GetAllScoreGroupItem()
        {
            return GetAll().ToList();
        }

        public ScoreGroupItem GetScoreGroupItemById(int id)
        {
            return GetById(id);
        }

    }

}