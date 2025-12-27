

using TestingDEVDMSApplication.Entity;
using TestingDEVDMSApplication.Repositories.Interface;

namespace TestingDEVDMSApplication.Services.Interface
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;
        private readonly IEducationRepository educationRepository;
        private readonly IOwnershipOfResidenceRepository ownershipOfResidenceRepository;
        private readonly ICompanyCategoryRepository companyCategoryRepository;
        private readonly IDepartmentRepository departmentRepository;
        private readonly IRecordPaymentTrackRepository recordPaymentTrackRepository;
        private readonly ITrackDataSLIKRepository trackDataSLIKRepository;
        private readonly IPemilikanKartuKreditRepository pemilikanKartuKreditRepository;
        private readonly ITujuanDariPembiayaanRepository tujuanDariPembiayaanRepository;

        public CustomerService(ICustomerRepository customerRepository,
                               IEducationRepository educationRepository,
                               IOwnershipOfResidenceRepository ownershipOfResidenceRepository,
                               ICompanyCategoryRepository companyCategoryRepository,
                               IDepartmentRepository departmentRepository,
                               IRecordPaymentTrackRepository recordPaymentTrackRepository,
                               ITrackDataSLIKRepository trackDataSLIKRepository,
                               IPemilikanKartuKreditRepository pemilikanKartuKreditRepository,
                               ITujuanDariPembiayaanRepository tujuanDariPembiayaanRepository)
        {
            this.customerRepository = customerRepository;
            this.educationRepository = educationRepository;
            this.ownershipOfResidenceRepository = ownershipOfResidenceRepository;
            this.companyCategoryRepository = companyCategoryRepository;
            this.departmentRepository = departmentRepository;
            this.recordPaymentTrackRepository = recordPaymentTrackRepository;
            this.trackDataSLIKRepository = trackDataSLIKRepository;
            this.pemilikanKartuKreditRepository = pemilikanKartuKreditRepository;
            this.tujuanDariPembiayaanRepository = tujuanDariPembiayaanRepository;
        }

        public IList<Customer> GetAllCustomer()
        {
            return customerRepository.GetAllCustomer();

        }

        public IList<Education> GetAllEducation()
        {
            return educationRepository.GetAllEducation();
        }

        public IList<Department> GetAllJabatan()
        {
            return departmentRepository.GetAllDepartment();
        }

        public IList<CompanyCategory> GetAllKategoriPerushaan()
        {
            return companyCategoryRepository.GetAllCompanyCategory();
        }

        public IList<OwnershipOfResidence> GetAllKepemilikan()
        {
            return ownershipOfResidenceRepository.GetAllOwnershipOfResidence();
        }

        public IList<PemilikanKartuKredit> GetAllPemilikanKartuKredit()
        {
            return pemilikanKartuKreditRepository.GetAllPemilikanKartuKredit();
        }

        public IList<RecordPaymentTrack> GetAllRecordPaymentTrack()
        {
            return recordPaymentTrackRepository.GetAllRecordPaymentTrack();
        }

        public IList<TrackDataSLIK> GetAllTrackDataSLIK()
        {
            return trackDataSLIKRepository.GetAllTrackDataSLIK();
        }

        public IList<TujuanDariPembiayaan> GetAllTujuanDariPembiayaan()
        {
            return tujuanDariPembiayaanRepository.GetAllTujuanDariPembiayaan();
        }
    }
}
