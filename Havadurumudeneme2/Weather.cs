using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Havadurumudeneme2
{
    internal class Weather
    {
        public Weather()
        {
        }


        public CityWeather GetWeather(string cityName)
        {
            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            {
                // return için oluşturuldu
                CityWeather cityWeather = new CityWeather();//şehir ismi boş gelebiliyor, default atama yapıldı
                cityWeather.City = cityName;
                try
                {
                    string apiUrl = $"https://goweather.herokuapp.com/weather/{cityName}";
                    var response = client.GetStringAsync(apiUrl).Result;

                    // JSON to CityWeather sınıfına dönüştürüyor
                    cityWeather = Newtonsoft.Json.JsonConvert.DeserializeObject<CityWeather>(response);

                    
                    return cityWeather;
                }
                catch (Exception ex)
                {
                    cityWeather.Description = ex.Message;
                    return cityWeather;
                }
            }
        }
    }
}

