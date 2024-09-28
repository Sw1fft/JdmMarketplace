namespace JdmMarketplace.Services.CatalogAPI.DTO.Responses
{
    public class ResponseDTO
    {
        public object? Result { get; set; }
        public bool IsSuccess { get; set; } = false;
        public int StatusCode { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
    }
}
