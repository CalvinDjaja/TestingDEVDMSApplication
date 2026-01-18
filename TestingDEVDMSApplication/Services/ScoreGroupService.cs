using TestingDEVDMSApplication.Context;
using TestingDEVDMSApplication.Entity;
using TestingDEVDMSApplication.Models;
using TestingDEVDMSApplication.Repositories.Interface;

namespace TestingDEVDMSApplication.Services.Interface
{
    public class ScoreGroupService : IScoreGroupService
    {
        private readonly DmsDbContext context;

        private readonly ICustomerRepository customerRepository;
        private readonly IEducationRepository educationRepository;
        private readonly IOwnershipOfResidenceRepository ownershipOfResidenceRepository;
        private readonly ICompanyCategoryRepository companyCategoryRepository;
        private readonly IDepartmentRepository departmentRepository;
        private readonly IRecordPaymentTrackRepository recordPaymentTrackRepository;
        private readonly ITrackDataSLIKRepository trackDataSLIKRepository;
        private readonly IPemilikanKartuKreditRepository pemilikanKartuKreditRepository;
        private readonly ITujuanDariPembiayaanRepository tujuanDariPembiayaanRepository;

        private readonly IScoreGroupRepository scoreGroupRepository;
        private readonly IScoreGroupItemRepository scoreGroupItemRepository;
        private readonly IScoreItemRepository scoreItemRepository;

        public ScoreGroupService(DmsDbContext context,
                               ICustomerRepository customerRepository,
                               IEducationRepository educationRepository,
                               IOwnershipOfResidenceRepository ownershipOfResidenceRepository,
                               ICompanyCategoryRepository companyCategoryRepository,
                               IDepartmentRepository departmentRepository,
                               IRecordPaymentTrackRepository recordPaymentTrackRepository,
                               ITrackDataSLIKRepository trackDataSLIKRepository,
                               IPemilikanKartuKreditRepository pemilikanKartuKreditRepository,
                               ITujuanDariPembiayaanRepository tujuanDariPembiayaanRepository,
                               IScoreGroupRepository scoreGroupRepository,
                               IScoreGroupItemRepository scoreGroupItemRepository,
                               IScoreItemRepository scoreItemRepository)
        {
            this.context = context;
            this.customerRepository = customerRepository;
            this.educationRepository = educationRepository;
            this.ownershipOfResidenceRepository = ownershipOfResidenceRepository;
            this.companyCategoryRepository = companyCategoryRepository;
            this.departmentRepository = departmentRepository;
            this.recordPaymentTrackRepository = recordPaymentTrackRepository;
            this.trackDataSLIKRepository = trackDataSLIKRepository;
            this.pemilikanKartuKreditRepository = pemilikanKartuKreditRepository;
            this.tujuanDariPembiayaanRepository = tujuanDariPembiayaanRepository;
            this.scoreGroupRepository = scoreGroupRepository;
            this.scoreGroupItemRepository = scoreGroupItemRepository;
            this.scoreItemRepository = scoreItemRepository;
        }

        public IList<ScoreGroup> GetAllScoreGroup()
        {
            return scoreGroupRepository.GetAllScoreGroup();
        }

        public IList<ScoreGroupItem> GetAllScoreGroupItem()
        {
            return scoreGroupItemRepository.GetAllScoreGroupItem();
        }

        public IList<ScoreItem> GetAllScoreItem()
        {
            return scoreItemRepository.GetAllScoreItem();
        }

        public Task<string> InsertScoreItem(CreateOrUpdateScoreItemsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateScoreItem(CreateOrUpdateScoreItemsRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
