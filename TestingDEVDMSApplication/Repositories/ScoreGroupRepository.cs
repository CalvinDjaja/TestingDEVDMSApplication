using TestingDEVDMSApplication.Context;
using TestingDEVDMSApplication.Entity;
using TestingDEVDMSApplication.Repositories.Interface;

namespace TestingDEVDMSApplication.Repositories
{
    public class ScoreGroupRepository : BaseRepository<ScoreGroup>, IScoreGroupRepository
    {
        public ScoreGroupRepository(DmsDbContext context) : base(context) { }

        public List<ScoreGroup> GetAllScoreGroup()
        {
            return GetAll().ToList();
        }

        public ScoreGroup GetScoreGroupById(int id)
        {
            return GetById(id);
        }

    }

}