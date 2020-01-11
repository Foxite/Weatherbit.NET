using Weatherbit.Model;

namespace Weatherbit {
	public interface IWeatherbitAPI {
		Language Language { get; set; }
		Units Units { get; set; }

		// Actual weather: https://www.weatherbit.io/api/weather-current
		Weather GetCurrentWeather(float lat, float lon);
		Weather GetCurrentWeather(City city);
		Weather GetCurrentWeather(string postalCode, string? countryCode);
		[LicenseRequirement(License.Advanced | License.Enterprise)] Weather GetCurrentWeather(params Station[] stations); // max 100
		[LicenseRequirement(License.Advanced | License.Enterprise)] Weather GetCurrentWeather(params City[] cities); // max 100

		// To do:
		// Weather forecast (hourly): https://www.weatherbit.io/api/weather-forecast-120-hour
		// Weather forecast (daily): https://www.weatherbit.io/api/weather-forecast-16-day
		// Alerts: https://www.weatherbit.io/api/alerts
		// Historical observations (hourly): https://www.weatherbit.io/api/weather-history-hourly
		// Historical observations (daily): https://www.weatherbit.io/api/weather-history-daily
		// Air quality (actual): https://www.weatherbit.io/api/airquality-current
		// Air quality (forecast): https://www.weatherbit.io/api/airquality-forecast
		// Air quality (historical): https://www.weatherbit.io/api/airquality-history
		// Degree day forecast: https://www.weatherbit.io/api/weather-energy-forecast
		// Historical energy weather: https://www.weatherbit.io/api/weather-energy
		// Agriculture weather forecast: https://www.weatherbit.io/api/ag-weather-api-forecast
		// Agriculture weather history: https://www.weatherbit.io/api/ag-weather-api
		// There's a solar irradiance api but the documentation links to hourly historical weather
	}
}
