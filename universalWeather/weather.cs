using System;
using System.Collections.Generic;
using System.Text;

namespace universalweather.universalWeather
{
    class weather
    {
        /****   *****/

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

        /****   *****/

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

        weather()
        {

        }
    }
}
