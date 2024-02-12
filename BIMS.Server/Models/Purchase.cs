namespace BIMS.Server.Models
{
    public class Purchase
    {
        public int ID { get; set; }
        public string? ClientName { get; set; }
        public int? PID { get; set; }
        public int? ItemCount { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
