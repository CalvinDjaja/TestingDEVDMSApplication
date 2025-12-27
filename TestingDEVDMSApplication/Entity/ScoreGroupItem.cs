using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestingDEVDMSApplication.Entity
{
    [Table("ScoreGroupItem")]
    public class ScoreGroupItem
    {
        [Key] public int ID { get; set; }
        public int GroupID { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public decimal BobotD { get; set; }

    }
}
