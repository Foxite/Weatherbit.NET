using System;
using Newtonsoft.Json;

namespace Weatherbit.Model {
	public class Observation {
#nullable disable
		[JsonProperty("lat")]
		public float Latitude { get; }

		[JsonProperty("lon")]
		public float Longitude { get; }

		[JsonProperty("sunrise")]
		public DateTime Sunrise { get; }

		[JsonProperty("sunset")]
		public DateTime Sunset { get; }

		[JsonProperty("timezone")]
		public TimeZoneInfo Timezone { get; }

		[JsonProperty("station")]
		public string Station { get; }

		[JsonProperty("ob_time")]
		public DateTime ObservationTime { get; }

		[JsonProperty("datetime")]
		public DateTime CurrentCycleHour { get; } // TODO what is this?

		[JsonProperty("city_name")]
		public string CityName { get; } // TODO City class

		[JsonProperty("country_code")]
		public string CountryCode { get; } // TODO remove and add to City class

		[JsonProperty("state_code")]
		public string StateCode { get; } // item

		[JsonProperty("pres")]
		public float Pressure { get; } // millibar

		[JsonProperty("slp")]
		public float SeaLevelPressure { get; } // millibar

		[JsonProperty("wind_spd")]
		public float WindSpeed { get; } // m/s

		[JsonProperty("wind_dir")]
		public float WindDirection { get; } // degrees

		[JsonProperty("wind_cdir")]
		public string VerbalWindDirectionAbbr { get; }

		[JsonProperty("wind_cdir_full")]
		public string VerbalWindDirection { get; }

		[JsonProperty("temp")]
		public float Temperature { get; } // celcius

		[JsonProperty("app_temp")]
		public float ApparentTemperature { get; } // celcius

		[JsonProperty("rh")]
		public float RelativeHumidity { get; } // %

		[JsonProperty("dewpt")]
		public float DewPoint { get; } // celcius

		[JsonProperty("clouds")]
		public float CloudCoverage { get; } // %

		[JsonProperty("pod")]
		public string PartOfDay { get; } // "d" or "n" for day/night

		[JsonProperty("lat")]
		public Weather Weather { get; }

		[JsonProperty("vis")]
		public float Visibility { get; } // km

		[JsonProperty("precip")]
		public float Precipation { get; } // mm/h

		[JsonProperty("snow")]
		public float Snowfall { get; } // mm/h

		[JsonProperty("code")]
		public byte UVIndex { get; } // says "0-11+". in the example it's a number, not a string, not sure why there's a +.

		[JsonProperty("aqi")]
		public short AirQualtiyIndex { get; } // "US - EPA standard 0 - +500"

		[JsonProperty("dhi")]
		public float DiffuseHorizontalSolarIrradiance { get; } // w/m2 - clear sky

		[JsonProperty("dni")]
		public float DirectNormalSolarIrradiance { get; } // w/m2 - clear sky

		[JsonProperty("ghi")]
		public float GlobalHorizontalSolarIrradiance { get; } // w/m2 - clear sky

		[JsonProperty("solar_rad")]
		public float EstimatedSolarRadiation { get; } // w/m2

		[JsonProperty("solar_angle")]
		public float SolarElevationAngle { get; } // degrees

		[JsonProperty("h_angle")]
		public float SolarHourAngle { get; } // degrees
#nullable restore
	}
}
