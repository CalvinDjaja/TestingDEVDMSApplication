

using TestingDEVDMSApplication.Entity;
using TestingDEVDMSApplication.Models;

namespace TestingDEVDMSApplication.Services.Interface
{
    public interface ICustomerService
    {
        IList<Customer> GetAllCustomer();
        IList<CustomerVT> GetIndexAllCustomer();
        Customer GetCustomerByID(int ID);
        IList<Education> GetAllEducation();
        IList<OwnershipOfResidence> GetAllKepemilikan();
        IList<CompanyCategory> GetAllKategoriPerushaan();
        IList<Department> GetAllJabatan();
        IList<RecordPaymentTrack> GetAllRecordPaymentTrack();
        IList<TrackDataSLIK> GetAllTrackDataSLIK();
        IList<PemilikanKartuKredit> GetAllPemilikanKartuKredit();
        IList<TujuanDariPembiayaan> GetAllTujuanDariPembiayaan();
        Task<string> InsertCustomer(CreateOrUpdateCustomerRequest request);
    }
}
