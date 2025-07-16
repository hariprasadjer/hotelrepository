using HotelInventoryMiddleware.Models;

namespace HotelInventoryMiddleware.Adapters
{
    public interface ITspAdapter
    {
        string TspCode { get; }
        Task<SearchResponse> SearchAsync(SearchRequest request, CancellationToken cancellationToken = default);
    }
}
