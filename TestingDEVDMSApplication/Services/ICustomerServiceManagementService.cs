

using TestingDEVDMSApplication.Context;
using TestingDEVDMSApplication.Entity;
using TestingDEVDMSApplication.Models;
using TestingDEVDMSApplication.Repositories.Interface;

namespace TestingDEVDMSApplication.Services.Interface
{
    public class CustomerService : ICustomerService
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

        public CustomerService(DmsDbContext context,
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

        public IList<Customer> GetAllCustomer()
        {
            return customerRepository.GetAllCustomer();
        }


        public IList<CustomerVT> GetIndexAllCustomer()
        {
            var customers = customerRepository.GetAllCustomer().ToList();
            var groups = scoreGroupRepository.GetAllScoreGroup().ToList();
            var groupItems = scoreGroupItemRepository.GetAllScoreGroupItem().ToList();
            var scoreItems = scoreItemRepository.GetAllScoreItem().ToList();

            var result = new List<CustomerVT>();

            foreach (var c in customers)
            {
                decimal finalScore = 0;

                foreach (var g in groups)
                {
                    var items = groupItems.Where(x => x.GroupID == g.ID);

                    decimal groupTotal = 0;

                    foreach (var gi in items)
                    {
                        var options = scoreItems.Where(x => x.ScoreGroupItemID == gi.ID);

                        decimal scoreF = GetScoreF(gi.ItemName, c, options);

                        groupTotal += gi.BobotD * scoreF;
                    }

                    finalScore += groupTotal * g.BobotB;
                }

                result.Add(new CustomerVT
                {
                    ID = c.ID,
                    CustomerCode = c.Code,
                    CustomerName = c.Name,
                    BirthDate = c.BirthDate,
                    InfromasiScore = finalScore / 10000m
                });
            }

            return result;
        }



        public Customer GetCustomerByID(int ID)
        {
            return customerRepository.GetCustomerById(ID);

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

        public async Task<string> InsertCustomer(CreateOrUpdateCustomerRequest request)
        {
            string rs = "";
            await using var transaction = await context.Database.BeginTransactionAsync();

            try
            {
                var addCustomer = new Customer()
                {
                    Code = request.Code,
                    Name = request.Name,
                    BirthDate = request.BirthDate,
                    BirthPlace = request.BirthPlace,
                    Gender = request.Gender,
                    PostalCode = request.PostalCode,
                    Address = request.Address,
                    IsMarriage = request.IsMarriage,
                    ManyKids = request.ManyKids,
                    EducationID = request.EducationID,
                    BankAddress = request.BankAddress,
                    OwnershipOfResidenceID = request.OwnershipOfResidenceID,
                    OccupiedTime = request.OccupiedTime,
                    CompanyCategoryID = request.CompanyCategoryID,
                    DepartmentID = request.DepartmentID,
                    WorkTime = request.WorkTime,
                    EarningTHP = request.EarningTHP,
                    IsTabungan = request.IsTabungan,
                    IsGiro = request.IsGiro,
                    IsDeposito = request.IsDeposito,
                    SaldoRate = request.SaldoRate,
                    RecordPaymentTrackID = request.RecordPaymentTrackID,
                    TrackDataSLIKID = request.TrackDataSLIKID,
                    PemilikanKartuKreditID = request.PemilikanKartuKreditID,
                    Tenor = request.Tenor,
                    DebtServiceRatio = request.DebtServiceRatio,
                    HasilAppraisal = request.HasilAppraisal,
                    LuasBangun = request.LuasBangun,
                    TujuanDariPembiayaanID = request.TujuanDariPembiayaanID,
                    LTV = request.LTV,
                    RowStatus = 1
                };

                var add = customerRepository.Add(addCustomer);
                rs = "Success";

                await context.SaveChangesAsync();

                await transaction.CommitAsync();
            }
            catch (Exception Ex)
            {
                await transaction.RollbackAsync();
                rs = Ex.Message;
            }

            return rs;
        }

        private decimal GetScoreF(string itemName, Customer c, IEnumerable<ScoreItem> options)
        {
            if (itemName == "Umur Pemohon")
            {
                int age = (int)((DateTime.Today - c.BirthDate).TotalDays / 365.25);

                if (age >= 31 && age <= 45) return options.First(x => x.ItemLabel == "31 - 45 Tahun").ScoreF;
                if (age >= 46 && age <= 55) return options.First(x => x.ItemLabel == "46 - 55 Tahun").ScoreF;
                if (age >= 56 && age <= 65) return options.First(x => x.ItemLabel == "56 - 65 Tahun").ScoreF;
                if (age >= 21 && age <= 30) return options.First(x => x.ItemLabel == "21 - 30 Tahun").ScoreF;
            }

            if (itemName == "Umur Pemohon + Tenor")
            {
                int age = (int)((DateTime.Today - c.BirthDate).TotalDays / 365.25) + c.Tenor;

                if (age > 65) return options.First(x => x.ItemLabel == "Diatas Ketentuan").ScoreF;
                else return options.First(x => x.ItemLabel == "Dibawah Ketentuan").ScoreF;

            }

            if (itemName == "Status Perkawinan")
            {
                if (c.IsMarriage == false && c.ManyKids > 2) return options.First(x => x.ItemLabel == "Belum Kawin dengan > 2 tanggungan").ScoreF;
                if (c.IsMarriage == false && c.ManyKids <= 2) return options.First(x => x.ItemLabel == "Belum Kawin dengan <= 2 tanggungan").ScoreF;
                if (c.IsMarriage == false && c.ManyKids == 0) return options.First(x => x.ItemLabel == "Belum Kawin dengan 0 tanggungan").ScoreF;
                if (c.IsMarriage == true && c.ManyKids > 2) return options.First(x => x.ItemLabel == "Kawin dengan > 2 tanggungan").ScoreF;
                if (c.IsMarriage == true && c.ManyKids <= 2) return options.First(x => x.ItemLabel == "Kawin dengan <= 2 tanggungan").ScoreF;

            }

            if (itemName == "Pendidikan")
            {
                var Education = educationRepository.GetEducationById(c.EducationID).Name;
                if (Education == "SMA atau dibawahnya") return options.First(x => x.ItemLabel == "SMA atau dibawahnya").ScoreF;
                if (Education == "D1, D2, D3, D4") return options.First(x => x.ItemLabel == "D1, D2, D3, D4").ScoreF;
                if (Education == "S1") return options.First(x => x.ItemLabel == "S1").ScoreF;
                if (Education == "Master atau diatasnya (S2, S3)") return options.First(x => x.ItemLabel == "Master atau diatasnya (S2, S3)").ScoreF;

            }

            return 0m;
        }

    }
}
