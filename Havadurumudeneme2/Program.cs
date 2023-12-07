using Havadurumudeneme2;
using System;

class Program
{
    static void Main()
    {
        Weather weather = new Weather();
        CityWeather cityWeather = new CityWeather();

        cityWeather = weather.GetWeather("istanbul");
        Yazdir(cityWeather);
        cityWeather = weather.GetWeather("ankara");
        Yazdir(cityWeather);
        cityWeather = weather.GetWeather("izmir");
        Yazdir(cityWeather);
    }
    static void Yazdir(CityWeather cityWeather)
    {
        Console.WriteLine("City : " + cityWeather.City);
        Console.WriteLine("Description : " + cityWeather.Description);
        Console.WriteLine("Humidity : " + cityWeather.Humidity);
        Console.WriteLine("Temperature : " + cityWeather.Temperature);
        Console.WriteLine("Wind : " + cityWeather.Wind);
    }

}
