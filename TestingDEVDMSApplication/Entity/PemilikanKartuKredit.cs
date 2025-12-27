using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestingDEVDMSApplication.Entity
{
    [Table("PemilikanKartuKredit")]
    public class PemilikanKartuKredit
    {
        [Key] public int ID { get; set; }
        public string Name { get; set; } = string.Empty;

    }
}
