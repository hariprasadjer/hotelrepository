using HotelInventoryMiddleware.Models;

namespace HotelInventoryMiddleware.Services
{
    public interface IHotelService
    {
        Task<SearchResponse> SearchHotelsAsync(SearchRequest request, CancellationToken cancellationToken = default);
    }

    public class HotelService : IHotelService
    {
        private readonly ITspService _tspService;

        public HotelService(ITspService tspService)
        {
            _tspService = tspService;
        }

        public async Task<SearchResponse> SearchHotelsAsync(SearchRequest request, CancellationToken cancellationToken = default)
        {
            try
            {
                var hotels = await _tspService.SearchAllAsync(request, cancellationToken);
                return new SearchResponse { Success = true, Hotels = hotels.ToList() };
            }
            catch (Exception ex)
            {
                return SearchResponse.Failure(ex.Message);
            }
        }
    }
}
