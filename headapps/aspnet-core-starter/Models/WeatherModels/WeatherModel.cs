using Sitecore.AspNetCore.SDK.LayoutService.Client.Response.Model.Fields;
using Sitecore.AspNetCore.SDK.RenderingEngine.Binding.Attributes;
using System.Text.Json.Serialization;

namespace Sitecore.AspNetCore.Starter.Models.WeatherModels
{
    public class WeatherModel : BaseModel
    {
        [SitecoreComponentField(Name = "Image")]
        public ImageField? ImageField { get; set; }

        public WeatherData? Data { get; set; }
    }

    public class WeatherData
    {
        [JsonPropertyName("coord")]
        public LonLat? Coordinates { get; set; }

        [JsonPropertyName("weather")]
        public Weather[]? Weather { get; set; }

        [JsonPropertyName("main")]
        public WeatherMain? Main { get; set; }

        [JsonPropertyName("name")]
        public string? CityName { get; set; }
    }

    public class WeatherMain
    {
        [JsonPropertyName("temp")]
        public float Temp { get; set; }

        public string TempFormatted 
        { 
            get
            {
                return $"{(Temp / 10):F2}";
            }
        }

        [JsonPropertyName("feels_like")]
        public float FeelsLike { get; set; }

        public string FeelsLikeFormatted
        {
            get
            {
                return $"{(FeelsLike / 10):F2}";
            }
        }

        [JsonPropertyName("temp_min")]
        public float TempMin { get; set; }

        public string TempMinFormatted
        {
            get
            {
                return $"{(TempMin / 10):F2}";
            }
        }

        [JsonPropertyName("temp_max")]
        public float TempMax { get; set; }

        public string TempMaxFormatted
        {
            get
            {
                return $"{(TempMax / 10):F2}";
            }
        }
    }

    public class Weather
    {
        [JsonPropertyName("main")]
        public string? Main { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }

    public class LonLat
    {
        [JsonPropertyName("lon")]
        public  float Longitude { get; set; }

        [JsonPropertyName("lat")]
        public float Latitude { get; set; }
    }
}
