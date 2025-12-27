

using TestingDEVDMSApplication.Entity;

namespace TestingDEVDMSApplication.Services.Interface
{
    public interface ICustomerService
    {
        IList<Customer> GetAllCustomer();
        IList<Education> GetAllEducation();
        IList<OwnershipOfResidence> GetAllKepemilikan();
        IList<CompanyCategory> GetAllKategoriPerushaan();
        IList<Department> GetAllJabatan();
        IList<RecordPaymentTrack> GetAllRecordPaymentTrack();
        IList<TrackDataSLIK> GetAllTrackDataSLIK();
        IList<PemilikanKartuKredit> GetAllPemilikanKartuKredit();
        IList<TujuanDariPembiayaan> GetAllTujuanDariPembiayaan();
    }
}
