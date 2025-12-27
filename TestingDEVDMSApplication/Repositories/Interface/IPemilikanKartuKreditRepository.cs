using TestingDEVDMSApplication.Entity;

namespace TestingDEVDMSApplication.Repositories.Interface
{
    public interface IPemilikanKartuKreditRepository
    {
        List<PemilikanKartuKredit> GetAllPemilikanKartuKredit();
        PemilikanKartuKredit GetPemilikanKartuKreditById(int id);
    }
}
