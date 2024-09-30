namespace HotelApi.Models
{
    public class BookRequest
    {
        public string PrebookId {  get; set; }
        public string HotelId { get; set; }
        public int Rooms {  get; set; }
    }
}
