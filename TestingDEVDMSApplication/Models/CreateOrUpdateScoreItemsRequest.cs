namespace TestingDEVDMSApplication.Models
{
    public class CreateOrUpdateScoreItemsRequest
    {
        public int ID { get; set; }
        public int ScoreGroupItemID { get; set; }
        public string ItemLabel { get; set; } = string.Empty;
        public int ScoreF { get; set; }

    }
}