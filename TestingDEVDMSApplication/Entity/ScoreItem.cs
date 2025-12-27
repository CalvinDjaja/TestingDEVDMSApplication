using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestingDEVDMSApplication.Entity
{
    [Table("ScoreItem")]
    public class ScoreItem
    {
        [Key] public int ID { get; set; }
        public int ScoreGroupItemID { get; set; }
        public string ItemLabel { get; set; } = string.Empty;
        public decimal ScoreF { get; set; }

    }
}
