using System;

namespace Weatherbit {
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class LicenseRequirementAttribute : Attribute {
		public License LicenseRequired { get; }

		public LicenseRequirementAttribute(License licenseRequired) {
			LicenseRequired = licenseRequired;
		}
	}
}