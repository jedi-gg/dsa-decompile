using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi.Nearby
{
	public struct NearbyConnectionConfiguration
	{
		[FieldOffset(Offset="0x0")]
		public const int MaxUnreliableMessagePayloadLength = 1168;

		[FieldOffset(Offset="0x0")]
		public const int MaxReliableMessagePayloadLength = 4096;

		[FieldOffset(Offset="0x0")]
		private readonly Action<InitializationStatus> mInitializationCallback;

		[FieldOffset(Offset="0x8")]
		private readonly long mLocalClientId;

		public Action<InitializationStatus> InitializationCallback
		{
			[Address(RVA="0xF2FEF4", Offset="0xF2FEF4", VA="0xF2FEF4")]
			get
			{
				return null;
			}
		}

		public long LocalClientId
		{
			[Address(RVA="0xF2FEEC", Offset="0xF2FEEC", VA="0xF2FEEC")]
			get
			{
				return new long();
			}
		}

		[Address(RVA="0xF2FEE4", Offset="0xF2FEE4", VA="0xF2FEE4")]
		public NearbyConnectionConfiguration(Action<InitializationStatus> callback, long localClientId)
		{
		}
	}
}