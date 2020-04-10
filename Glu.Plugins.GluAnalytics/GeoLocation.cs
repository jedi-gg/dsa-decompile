using Il2CppDummyDll;
using System;

namespace Glu.Plugins.GluAnalytics
{
	public class GeoLocation
	{
		[FieldOffset(Offset="0x10")]
		public readonly string IPAddress;

		[FieldOffset(Offset="0x18")]
		public readonly string CountryCode;

		[Address(RVA="0x14ECCBC", Offset="0x14ECCBC", VA="0x14ECCBC")]
		public GeoLocation(string ipAddress, string countryCode)
		{
		}

		[Address(RVA="0x14ECCF4", Offset="0x14ECCF4", VA="0x14ECCF4", Slot="3")]
		public override string ToString()
		{
			return null;
		}
	}
}