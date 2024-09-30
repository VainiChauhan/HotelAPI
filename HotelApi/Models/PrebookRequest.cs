namespace HotelApi.Models
{
    public class PrebookRequest
    {
        public string HotelId {  get; set; }
        public int Rooms {  get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
