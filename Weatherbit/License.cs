using System;

namespace Weatherbit {
	[Flags]
	public enum License {
		Free,
		Starter,
		Developer,
		Advanced,
		Enterprise
	}
}