namespace BIMS.Server.Models
{
    public class Sale
    {
        public int ID { get; set; }

        public string? CustomerName { get; set; }

        public int? PID { get; set; }

        public int? ItemCount { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
