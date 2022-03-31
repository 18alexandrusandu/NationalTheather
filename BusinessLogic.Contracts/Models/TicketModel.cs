namespace BusinessLogic.Contracts.Models
{
    public class TicketModel
    {
        public int Id { get; set; }
        public ShowModel show { get; set; }
        public int SeatNumber { get; set; }
        public int SeatRow { get; set; }
        public double price{ get; set; }
    }
}
