using HotelApi.Models;

namespace HotelApi.Services
{
    public class HotelService : IHotelService
    {
        public async Task<SearchResponse> SearchHotels(SearchRequest request)
        {
            var hotels = new List<Hotel>
            {
                new Hotel {HotelId = "DXB001", Price = 306, HotelName="York International", IsAvailable=true },
                new Hotel {HotelId = "DXB002", Price = 306, HotelName="Days Hotel by Whyndam", IsAvailable=true },
            };

            var response = new SearchResponse { Hotels = hotels };
            return await Task.FromResult(response);
        }
        public async Task<AvailabilityResponse> CheckAvailability(AvailabilityRequest request)
        {
            var response = new AvailabilityResponse
            {
                HotelId = request.HotelId,
                IsAvailable = true,
                AvailableRooms = 2
            };
            return await Task.FromResult(response);
        }
        public async Task<PrebookResponse> Prebook(PrebookRequest request)
        {
            var response = new PrebookResponse
            {
               PrebookId  = Guid.NewGuid().ToString(),
               IsCheckedRooms = true,
               Price = request.Rooms *100
            };
            return await Task.FromResult(response);
        }
        public async Task<BookResponse> Book(BookRequest request)
        {
            var response = new BookResponse
            {
                BookId = Guid.NewGuid().ToString(),
                IsBooked = true,
                Price = request.Rooms * 100
            };
            return await Task.FromResult(response);
        }
    }
}
