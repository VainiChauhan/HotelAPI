using HotelApi.Models;

namespace HotelApi.Services
{
    public interface IHotelService
    {
        Task<SearchResponse> SearchHotels(SearchRequest request);
        Task<AvailabilityResponse> CheckAvailability(AvailabilityRequest request);
        Task<PrebookResponse> Prebook(PrebookRequest request);
    }
}