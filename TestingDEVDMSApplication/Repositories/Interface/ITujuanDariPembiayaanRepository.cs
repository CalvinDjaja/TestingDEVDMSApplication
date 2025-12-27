using TestingDEVDMSApplication.Entity;

namespace TestingDEVDMSApplication.Repositories.Interface
{
    public interface ITujuanDariPembiayaanRepository
    {
        List<TujuanDariPembiayaan> GetAllTujuanDariPembiayaan();
        TujuanDariPembiayaan GetTujuanDariPembiayaanById(int id);
    }
}
