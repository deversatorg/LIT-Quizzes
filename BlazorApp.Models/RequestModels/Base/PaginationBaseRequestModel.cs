using Newtonsoft.Json;

namespace BlazorApp.Models.RequestModels
{
    public class PaginationBaseRequestModel
    {
        [JsonProperty("limit")]
        public int Limit { get; set; } = 10;

        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;
    }
}
