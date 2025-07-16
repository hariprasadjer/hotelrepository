namespace HotelInventoryMiddleware.Models
{
    public class Hotel : BaseEntity
    {
        public string TspHotelId { get; set; } = string.Empty;
        public string TspCode { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int StarRating { get; set; }
        public ICollection<Room> Rooms { get; set; } = new List<Room>();
    }
}
