namespace HotelApi.Models
{
    public class AvailabilityResponse
    {
        public string HotelId {  get; set; }
        public bool IsAvailable {  get; set; }
        public int AvailableRooms {  get; set; }
    }
}
