namespace HotelApi.Models
{
    public class AvailabilityRequest
    {
        public string HotelId {  get; set; }    
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
