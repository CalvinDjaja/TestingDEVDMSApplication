using TestingDEVDMSApplication.Entity;

namespace TestingDEVDMSApplication.Repositories.Interface
{
    public interface IRecordPaymentTrackRepository
    {
        List<RecordPaymentTrack> GetAllRecordPaymentTrack();
        RecordPaymentTrack GetRecordPaymentTrackById(int id);
    }
}
