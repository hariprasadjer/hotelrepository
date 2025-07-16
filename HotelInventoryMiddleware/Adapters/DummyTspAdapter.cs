using HotelInventoryMiddleware.Models;

namespace HotelInventoryMiddleware.Adapters
{
    public class DummyTspAdapter : ITspAdapter
    {
        public string TspCode => "DUMMY";

        public Task<SearchResponse> SearchAsync(SearchRequest request, CancellationToken cancellationToken = default)
        {
            var hotel = new Hotel
            {
                Id = Guid.NewGuid(),
                TspHotelId = "1",
                TspCode = TspCode,
                Name = "Sample Hotel",
                StarRating = 4,
                Rooms = new List<Room>
                {
                    new Room
                    {
                        Id = Guid.NewGuid(),
                        HotelId = Guid.Empty,
                        TspRoomId = "R1",
                        RoomTypeName = "Standard",
                        BasePrice = 100
                    }
                }
            };

            var response = new SearchResponse
            {
                Success = true,
                Hotels = new List<Hotel> { hotel }
            };

            return Task.FromResult(response);
        }
    }
}
