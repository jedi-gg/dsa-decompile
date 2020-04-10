using Il2CppDummyDll;
using System;

namespace GooglePlayGames
{
	public static class GameInfo
	{
		[FieldOffset(Offset="0x0")]
		private const string UnescapedApplicationId = "APP_ID";

		[FieldOffset(Offset="0x0")]
		private const string UnescapedIosClientId = "IOS_CLIENTID";

		[FieldOffset(Offset="0x0")]
		private const string UnescapedWebClientId = "WEB_CLIENTID";

		[FieldOffset(Offset="0x0")]
		private const string UnescapedNearbyServiceId = "NEARBY_SERVICE_ID";

		[FieldOffset(Offset="0x0")]
		public const string ApplicationId = "88217213846";

		[FieldOffset(Offset="0x0")]
		public const string IosClientId = "__IOS_CLIENTID__";

		[FieldOffset(Offset="0x0")]
		public const string WebClientId = "88217213846-jp38dku9tmqalphdq9k843tis8ad05ag.apps.googleusercontent.com";

		[FieldOffset(Offset="0x0")]
		public const string NearbyConnectionServiceId = "";

		[Address(RVA="0x12D3A28", Offset="0x12D3A28", VA="0x12D3A28")]
		public static bool ApplicationIdInitialized()
		{
			return new bool();
		}

		[Address(RVA="0x12D3B18", Offset="0x12D3B18", VA="0x12D3B18")]
		public static bool IosClientIdInitialized()
		{
			return new bool();
		}

		[Address(RVA="0x12D3C50", Offset="0x12D3C50", VA="0x12D3C50")]
		public static bool NearbyConnectionsInitialized()
		{
			return new bool();
		}

		[Address(RVA="0x12D3AC4", Offset="0x12D3AC4", VA="0x12D3AC4")]
		private static string ToEscapedToken(string token)
		{
			return null;
		}

		[Address(RVA="0x12D3BB4", Offset="0x12D3BB4", VA="0x12D3BB4")]
		public static bool WebClientIdInitialized()
		{
			return new bool();
		}
	}
}