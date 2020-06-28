using System;
using System.IO;
using System.Net;
using System.Text;

namespace universalweather.universalWeather
{
    // Definition of the weather class
    class Weather
    {
        /**** weather class' attributes (to store each relative data)  *****/

        //
        private float longitude;
        private float latitude;

        //
        private string mainDescription;
        private string precisedDescription;

        //
        private float temperature;
        private float feelingLikeTemperature;
        private float minTemperature;
        private float maxTemperature;

        //
        private float pressure;
        private float humidity;

        //
        private float windSpeed;
        private int windDeg;
        private float windGust;

        //
        private long sunrise;
        private long sunset;

        //
        private string countryCode;
        private string cityName;

        //
        private int uvIndex;
        private string uvRisk;

        /**** weather class' properties (to return each relative data's corresponding value)  *****/

        //
        public float Longitude { get { return this.longitude; } }
        public float Latitude { get { return this.latitude; } }

        //
        public string MainDescription { get { return this.mainDescription; } }
        public string PrecisedDescription { get { return this.precisedDescription; } }

        //
        public float Temperature { get { return this.temperature; } }
        public float FeelingLikeTemperature { get { return this.feelingLikeTemperature; } }
        public float MinTemperature { get { return this.minTemperature; } }
        public float MaxTemperature { get { return this.maxTemperature; } }

        //
        public float Pressure { get { return this.pressure; } }
        public float Humidity { get { return this.humidity; } }

        //
        public float WindSpeed { get { return this.windSpeed; } }
        public int WindDeg { get { return this.windDeg; } }
        public float WindGust { get { return this.windGust; } }

        //
        public long Sunrise { get { return this.sunrise; } }
        public long Sunset { get { return this.sunset; } }

        //
        public string CountryCode { get { return this.countryCode; } }
        public string CityName { get { return this.cityName; } }

        //
        public int UvIndex { get { return this.uvIndex; } }
        public string UvRisk { get { return this.uvRisk; } }

        //Constructeur de la classe weather
        Weather(string city, string openWeatherMapApiKey)
        {
            // URL definition to get all datas about weather 
            string url = String.Concat("https://api.openweathermap.org/data/2.5/weather?q=", city, "&appid=", openWeatherMapApiKey);

            // Create a request for the URL.
            WebRequest weatherRequest = WebRequest.Create(url);

            // Get the response.
            WebResponse weatherResponse = weatherRequest.GetResponse();

            // Display the status.
            Console.WriteLine(((HttpWebResponse)weatherResponse).StatusDescription);

            // Get the stream containing content returned by the server.
            // The using block ensures the stream is automatically closed.
            using (Stream weatherDataStream = weatherResponse.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader weatherReader = new StreamReader(weatherDataStream);

                // Read the content.
                string weatherResponseFromServer = weatherReader.ReadToEnd();

                // Display the content.
                Console.WriteLine(weatherResponseFromServer);
            }

            // Close the response.
            weatherResponse.Close();
        }

        //Main function to test the current api
        public static void Main()
        {
            Weather weatherTest = new Weather("Paris", "5222a1c311ca31001b0877137d584c36");
        }
    }
}
