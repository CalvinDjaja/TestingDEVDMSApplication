using TestingDEVDMSApplication.Context;
using TestingDEVDMSApplication.Entity;
using TestingDEVDMSApplication.Repositories.Interface;

namespace TestingDEVDMSApplication.Repositories
{
    public class ScoreItemRepository : BaseRepository<ScoreItem>, IScoreItemRepository
    {
        public ScoreItemRepository(DmsDbContext context) : base(context) { }

        public List<ScoreItem> GetAllScoreItem()
        {
            return GetAll().ToList();
        }

        public ScoreItem GetScoreItemById(int id)
        {
            return GetById(id);
        }

    }

}