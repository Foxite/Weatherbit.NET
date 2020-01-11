using System;

namespace Weatherbit.Model {
	public class City {
		public int ID { get; }
		public string Name { get; }
		public string CountryCode { get; }
		public string? State { get; }

		internal City(int id, string name, string countryCode, string? state) {
			ID = id;
			Name = name;
			CountryCode = countryCode;
			State = state;
		}
		
		public static City GetCity(int id) => throw new NotImplementedException();
		public static City[] GetCity(string name, string? state, string? countryCode) => throw new NotImplementedException();
	}
}