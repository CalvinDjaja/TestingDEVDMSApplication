

using TestingDEVDMSApplication.Entity;
using TestingDEVDMSApplication.Models;

namespace TestingDEVDMSApplication.Services.Interface
{
    public interface IScoreGroupService
    {
        IList<ScoreGroup> GetAllScoreGroup();
        IList<ScoreGroupItem> GetAllScoreGroupItem();
        IList<ScoreItem> GetAllScoreItem();
        Task<string> InsertScoreItem(CreateOrUpdateScoreItemsRequest request);
        Task<string> UpdateScoreItem(CreateOrUpdateScoreItemsRequest request);
    }
}
