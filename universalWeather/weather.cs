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

        // Attributes for respectively longitude and latitude
        private float longitude;
        private float latitude;

        // Attributes for respectively main description and description with more precisions
        private string mainDescription;
        private string precisedDescription;

        // Attributes for all datas concerning temperature
        private float temperature;
        private float feelingLikeTemperature;
        private float minTemperature;
        private float maxTemperature;

        // Attributes for respectively pressure and humidity
        private float pressure;
        private float humidity;

        // Attributes for all datas concerning wind
        private float windSpeed;
        private int windDeg;
        private float windGust;

        // Attributes for respectively sunrise and sunset times as timestamp
        private long sunrise;
        private long sunset;

        // Attributes for all datas concerning wished location
        private string countryCode;
        private string cityName;

        // Attributes for all datas concerning UV
        private int uvIndex;
        private string uvRisk;

        /**** weather class' properties (to return each relative data's corresponding value)  *****/

        // Properties for respectively longitude and latitude
        public float Longitude { get { return this.longitude; } }
        public float Latitude { get { return this.latitude; } }

        // Properties for respectively main description and description with more precisions
        public string MainDescription { get { return this.mainDescription; } }
        public string PrecisedDescription { get { return this.precisedDescription; } }

        // Properties for all datas concerning temperature
        public float Temperature { get { return this.temperature; } }
        public float FeelingLikeTemperature { get { return this.feelingLikeTemperature; } }
        public float MinTemperature { get { return this.minTemperature; } }
        public float MaxTemperature { get { return this.maxTemperature; } }

        // Properties for respectively pressure and humidity
        public float Pressure { get { return this.pressure; } }
        public float Humidity { get { return this.humidity; } }

        // Properties for all datas concerning wind
        public float WindSpeed { get { return this.windSpeed; } }
        public int WindDeg { get { return this.windDeg; } }
        public float WindGust { get { return this.windGust; } }

        // Properties for respectively sunrise and sunset times as timestamp
        public long Sunrise { get { return this.sunrise; } }
        public long Sunset { get { return this.sunset; } }

        // Properties for all datas concerning wished location
        public string CountryCode { get { return this.countryCode; } }
        public string CityName { get { return this.cityName; } }

        // Properties for all datas concerning UV
        public int UvIndex { get { return this.uvIndex; } }
        public string UvRisk { get { return this.uvRisk; } }

        //Class Weather's constructor
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
            //Creation of the current instance of Weather class: weatherTest
            Weather weatherTest = new Weather("<city>", "<apiKey>");
        }
    }
}
