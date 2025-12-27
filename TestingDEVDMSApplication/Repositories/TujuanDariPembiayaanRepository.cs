using TestingDEVDMSApplication.Context;
using TestingDEVDMSApplication.Entity;
using TestingDEVDMSApplication.Repositories.Interface;

namespace TestingDEVDMSApplication.Repositories
{
    public class TujuanDariPembiayaanRepository : BaseRepository<TujuanDariPembiayaan>, ITujuanDariPembiayaanRepository
    {
        public TujuanDariPembiayaanRepository(DmsDbContext context) : base(context) { }

        public List<TujuanDariPembiayaan> GetAllTujuanDariPembiayaan()
        {
            return GetAll().ToList();
        }

        public TujuanDariPembiayaan GetTujuanDariPembiayaanById(int id)
        {
            return GetById(id);
        }

    }

}