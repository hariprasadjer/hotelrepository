using HotelInventoryMiddleware.Adapters;
using HotelInventoryMiddleware.Models;

namespace HotelInventoryMiddleware.Services
{
    public interface ITspService
    {
        Task<IEnumerable<Hotel>> SearchAllAsync(SearchRequest request, CancellationToken cancellationToken = default);
    }

    public class TspService : ITspService
    {
        private readonly IEnumerable<ITspAdapter> _adapters;

        public TspService(IEnumerable<ITspAdapter> adapters)
        {
            _adapters = adapters;
        }

        public async Task<IEnumerable<Hotel>> SearchAllAsync(SearchRequest request, CancellationToken cancellationToken = default)
        {
            var hotels = new List<Hotel>();
            foreach (var adapter in _adapters)
            {
                var result = await adapter.SearchAsync(request, cancellationToken);
                if (result.Success)
                {
                    hotels.AddRange(result.Hotels);
                }
            }
            return hotels;
        }
    }
}
