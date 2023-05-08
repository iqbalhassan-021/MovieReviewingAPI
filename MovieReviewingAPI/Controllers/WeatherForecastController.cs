using MovieReviewingAPI.Model;
using Microsoft.AspNetCore.Mvc;
using MovieReviewingAPI.Data;

namespace MovieReviewingAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly MovieData _MovieData;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, MovieData MovieData)
        {
            _logger = logger;
            _MovieData = MovieData;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

     
        [HttpPost("SaveData")]
        public void SaveData(AdminPage adminPage)
        {
            _MovieData.Add(adminPage);
            _MovieData.SaveChanges();
        }
        [HttpGet("GetData")]
        public IEnumerable<AdminPage> GetData()
        {
            return _MovieData.MovieDatas;
        }
        /*   public string GetData(String MovieName, float RatingonIDM, string MovieDesc, AdminPage adminPage)
           {

               return "Movie Name: "+ MovieName+" IMD Ratings: "+ RatingonIDM + " Descriprion: "+ MovieDesc;
           }*/
    }
}