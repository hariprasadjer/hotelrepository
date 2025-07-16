namespace HotelInventoryMiddleware.Models
{
    public class Room : BaseEntity
    {
        public Guid HotelId { get; set; }
        public string TspRoomId { get; set; } = string.Empty;
        public string RoomTypeName { get; set; } = string.Empty;
        public decimal BasePrice { get; set; }
    }
}
