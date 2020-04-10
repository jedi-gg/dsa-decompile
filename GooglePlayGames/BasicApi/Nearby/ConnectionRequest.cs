using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi.Nearby
{
	public struct ConnectionRequest
	{
		[FieldOffset(Offset="0x0")]
		private readonly EndpointDetails mRemoteEndpoint;

		[FieldOffset(Offset="0x18")]
		private readonly byte[] mPayload;

		public byte[] Payload
		{
			[Address(RVA="0xF2FC30", Offset="0xF2FC30", VA="0xF2FC30")]
			get
			{
				return null;
			}
		}

		public EndpointDetails RemoteEndpoint
		{
			[Address(RVA="0xF2FC1C", Offset="0xF2FC1C", VA="0xF2FC1C")]
			get
			{
				return new EndpointDetails();
			}
		}

		[Address(RVA="0xF2FC14", Offset="0xF2FC14", VA="0xF2FC14")]
		public ConnectionRequest(string remoteEndpointId, string remoteEndpointName, string serviceId, byte[] payload)
		{
		}
	}
}