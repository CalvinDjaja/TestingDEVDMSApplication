using System.ComponentModel.DataAnnotations.Schema;

namespace TestingDEVDMSApplication.Models
{
    [Table("CustomerVT")]
    public class CustomerVT
    {
        public int ID { get; set; }
        public string CustomerCode { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string CustomerAddress { get; set; } = string.Empty;
        public bool IsMarriage { get; set; } = false;
        public int ManyKids { get; set; }
        public int EducationID { get; set; }
        public string BankAddress { get; set; } = string.Empty;
        public int OwnershipOfResidenceID { get; set; }
        public int OccupiedTime { get; set; }
        public int CompanyCategoryID { get; set; }
        public int DepartmentID { get; set; }
        public int WorkTime { get; set; }
        public decimal EarningTHP { get; set; } = 0;
        public bool IsTabungan { get; set; } = false;
        public bool IsGiro { get; set; } = false;
        public bool IsDeposito { get; set; } = false;
        public decimal SaldoRate { get; set; } = 0;
        public int RecordPaymentTrack { get; set; }
        public int PemilikanKartuKredit { get; set; }
        public int Tenor { get; set; }
        public int DebtServiceRatio { get; set; }
        public int HasilAppraisal { get; set; }
        public int LuasBangun { get; set; }
        public int TujuanDariPembiayaan { get; set; }
        public int LTV { get; set; }




    }
}
