namespace HotelInventoryMiddleware.Models
{
    public class SearchResponse
    {
        public bool Success { get; set; }
        public List<Hotel> Hotels { get; set; } = new();
        public string ErrorMessage { get; set; } = string.Empty;

        public static SearchResponse Failure(string error)
        {
            return new SearchResponse { Success = false, ErrorMessage = error };
        }
    }
}
