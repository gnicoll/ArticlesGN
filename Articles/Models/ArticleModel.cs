using Newtonsoft.Json;
namespace Articles.Models
{
    public class ArticleModel
    {
       [JsonProperty("title")]
       public string ArticleTitle { get; set; }

       [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("readTime")]
        public int ReadTime { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }
    }
}
