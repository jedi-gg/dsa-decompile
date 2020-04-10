using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi.Nearby
{
	public struct EndpointDetails
	{
		[FieldOffset(Offset="0x0")]
		private readonly string mEndpointId;

		[FieldOffset(Offset="0x8")]
		private readonly string mName;

		[FieldOffset(Offset="0x10")]
		private readonly string mServiceId;

		public string EndpointId
		{
			[Address(RVA="0xF2FE28", Offset="0xF2FE28", VA="0xF2FE28")]
			get
			{
				return null;
			}
		}

		public string Name
		{
			[Address(RVA="0xF2FE30", Offset="0xF2FE30", VA="0xF2FE30")]
			get
			{
				return null;
			}
		}

		public string ServiceId
		{
			[Address(RVA="0xF2FE38", Offset="0xF2FE38", VA="0xF2FE38")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF2FE20", Offset="0xF2FE20", VA="0xF2FE20")]
		public EndpointDetails(string endpointId, string name, string serviceId)
		{
		}
	}
}