using GooglePlayGames.BasicApi;
using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi.Nearby
{
	public struct AdvertisingResult
	{
		[FieldOffset(Offset="0x0")]
		private readonly ResponseStatus mStatus;

		[FieldOffset(Offset="0x8")]
		private readonly string mLocalEndpointName;

		public string LocalEndpointName
		{
			[Address(RVA="0xF2F978", Offset="0xF2F978", VA="0xF2F978")]
			get
			{
				return null;
			}
		}

		public ResponseStatus Status
		{
			[Address(RVA="0xF2F970", Offset="0xF2F970", VA="0xF2F970")]
			get
			{
				return new ResponseStatus();
			}
		}

		public bool Succeeded
		{
			[Address(RVA="0xF2F960", Offset="0xF2F960", VA="0xF2F960")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0xF2F958", Offset="0xF2F958", VA="0xF2F958")]
		public AdvertisingResult(ResponseStatus status, string localEndpointName)
		{
		}
	}
}