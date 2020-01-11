namespace Weatherbit.Model {
	// weather station or airport
	// TODO
	public class Station {
		public StationType Type { get; }
		public string Code { get; }
	}

	public enum StationType {
		WeatherStation,
		Airport
	}
}