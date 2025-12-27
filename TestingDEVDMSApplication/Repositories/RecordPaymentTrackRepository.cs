using TestingDEVDMSApplication.Context;
using TestingDEVDMSApplication.Entity;
using TestingDEVDMSApplication.Repositories.Interface;

namespace TestingDEVDMSApplication.Repositories
{
    public class RecordPaymentTrackRepository : BaseRepository<RecordPaymentTrack>, IRecordPaymentTrackRepository
    {
        public RecordPaymentTrackRepository(DmsDbContext context) : base(context) { }

        public List<RecordPaymentTrack> GetAllRecordPaymentTrack()
        {
            return GetAll().ToList();
        }

        public RecordPaymentTrack GetRecordPaymentTrackById(int id)
        {
            return GetById(id);
        }

    }

}