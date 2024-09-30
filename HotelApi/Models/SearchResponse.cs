namespace HotelApi.Models
{
    public class SearchResponse
    {
        public List<Hotel> Hotels { get; set; }
    }
    public class Hotel
    {
        public string HotelId { get; set; }
        public string HotelName { get; set; }
        public bool IsAvailable { get; set; }
        public decimal Price { get; set; }
    }
}
