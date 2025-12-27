using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestingDEVDMSApplication.Entity
{
    [Table("ScoreGroup")]
    public class ScoreGroup
    {
        [Key] public int ID { get; set; }
        public string GroupName { get; set; } = string.Empty;
        public decimal BobotB { get; set; }

    }
}
