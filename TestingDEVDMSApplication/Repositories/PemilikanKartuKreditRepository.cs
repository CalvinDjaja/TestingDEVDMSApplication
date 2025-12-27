using TestingDEVDMSApplication.Context;
using TestingDEVDMSApplication.Entity;
using TestingDEVDMSApplication.Repositories.Interface;

namespace TestingDEVDMSApplication.Repositories
{
    public class PemilikanKartuKreditRepository : BaseRepository<PemilikanKartuKredit>, IPemilikanKartuKreditRepository
    {
        public PemilikanKartuKreditRepository(DmsDbContext context) : base(context) { }

        public List<PemilikanKartuKredit> GetAllPemilikanKartuKredit()
        {
            return GetAll().ToList();
        }

        public PemilikanKartuKredit GetPemilikanKartuKreditById(int id)
        {
            return GetById(id);
        }

    }

}