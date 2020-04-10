using Glu.Plugins.GluAnalytics;
using Il2CppDummyDll;
using System;

namespace Glu.Plugins.GluAnalytics.Implementation
{
	public static class MarshallingUtil
	{
		[Address(RVA="0x14F3B84", Offset="0x14F3B84", VA="0x14F3B84")]
		public static GeoLocation GeoLocationFromString(string location)
		{
			return null;
		}

		[Address(RVA="0x14ECD68", Offset="0x14ECD68", VA="0x14ECD68")]
		public static string GeoLocationToString(GeoLocation location)
		{
			return null;
		}

		[Address(RVA="0x14EEFDC", Offset="0x14EEFDC", VA="0x14EEFDC")]
		public static string JsonArg(object val)
		{
			return null;
		}

		[Serializable]
		private class SerializableGeoLocation
		{
			[FieldOffset(Offset="0x10")]
			public string ipAddress;

			[FieldOffset(Offset="0x18")]
			public string countryCode;

			[Address(RVA="0x14F3B28", Offset="0x14F3B28", VA="0x14F3B28")]
			public SerializableGeoLocation(GeoLocation location)
			{
			}

			[Address(RVA="0x14F3BE8", Offset="0x14F3BE8", VA="0x14F3BE8")]
			public GeoLocation ToGeoLocation()
			{
				return null;
			}
		}
	}
}