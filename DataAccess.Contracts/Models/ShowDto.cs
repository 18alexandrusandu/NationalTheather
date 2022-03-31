namespace DataAccess.Contracts.Models
{
    public class ShowDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Date date { get; set; }
        public string Genre { get; set; }
        public string  DistributionList{ get; set; }
        public int NumberOfTickets { get; set; }
    }
}
