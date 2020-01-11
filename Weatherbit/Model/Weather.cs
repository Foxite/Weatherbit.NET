using Newtonsoft.Json;

namespace Weatherbit.Model {
	public class Weather {
#nullable disable
		// https://www.weatherbit.io/api/codes
		[JsonProperty("icon")]
		public string Icon { get; }

		// https://www.weatherbit.io/api/codes
		[JsonProperty("code")]
		public string Code { get; }

		[JsonProperty("description")]
		public string Description { get; }
#nullable restore
	}
}