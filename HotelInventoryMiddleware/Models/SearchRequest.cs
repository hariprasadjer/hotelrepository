namespace HotelInventoryMiddleware.Models
{
    public class SearchRequest
    {
        public string CityLocationId { get; set; } = string.Empty;
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int Adults { get; set; }
    }
}
