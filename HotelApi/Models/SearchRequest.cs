namespace HotelApi.Models
{
    public class SearchRequest
    {
        public string Destination { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int Guests {  get; set; }    
    }
}
