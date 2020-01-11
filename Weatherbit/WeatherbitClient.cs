using System;
using System.Collections.Generic;

namespace Weatherbit {
	public class WeatherbitClient : API {
		private const string ApiBase = "https://api.weatherbit.io/v2.0/";

		public WeatherbitClient(IDictionary<string, string> defaultParameters) : base(new Uri(ApiBase), defaultParameters) { }

		
	}
}
