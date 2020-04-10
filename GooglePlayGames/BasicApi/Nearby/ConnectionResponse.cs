using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi.Nearby
{
	public struct ConnectionResponse
	{
		[FieldOffset(Offset="0x0")]
		private readonly static byte[] EmptyPayload;

		[FieldOffset(Offset="0x0")]
		private readonly long mLocalClientId;

		[FieldOffset(Offset="0x8")]
		private readonly string mRemoteEndpointId;

		[FieldOffset(Offset="0x10")]
		private readonly ConnectionResponse.Status mResponseStatus;

		[FieldOffset(Offset="0x18")]
		private readonly byte[] mPayload;

		public long LocalClientId
		{
			[Address(RVA="0xF2FE00", Offset="0xF2FE00", VA="0xF2FE00")]
			get
			{
				return new long();
			}
		}

		public byte[] Payload
		{
			[Address(RVA="0xF2FE18", Offset="0xF2FE18", VA="0xF2FE18")]
			get
			{
				return null;
			}
		}

		public string RemoteEndpointId
		{
			[Address(RVA="0xF2FE08", Offset="0xF2FE08", VA="0xF2FE08")]
			get
			{
				return null;
			}
		}

		public ConnectionResponse.Status ResponseStatus
		{
			[Address(RVA="0xF2FE10", Offset="0xF2FE10", VA="0xF2FE10")]
			get
			{
				return new ConnectionResponse.Status();
			}
		}

		[Address(RVA="0x1EC62C8", Offset="0x1EC62C8", VA="0x1EC62C8")]
		static ConnectionResponse()
		{
		}

		[Address(RVA="0xF2FDF8", Offset="0xF2FDF8", VA="0xF2FDF8")]
		private ConnectionResponse(long localClientId, string remoteEndpointId, ConnectionResponse.Status code, byte[] payload)
		{
		}

		[Address(RVA="0x1EC6208", Offset="0x1EC6208", VA="0x1EC6208")]
		public static ConnectionResponse Accepted(long localClientId, string remoteEndpointId, byte[] payload)
		{
			return new ConnectionResponse();
		}

		[Address(RVA="0x1EC6234", Offset="0x1EC6234", VA="0x1EC6234")]
		public static ConnectionResponse AlreadyConnected(long localClientId, string remoteEndpointId)
		{
			return new ConnectionResponse();
		}

		[Address(RVA="0x1EC6174", Offset="0x1EC6174", VA="0x1EC6174")]
		public static ConnectionResponse EndpointNotConnected(long localClientId, string remoteEndpointId)
		{
			return new ConnectionResponse();
		}

		[Address(RVA="0x1EC60E0", Offset="0x1EC60E0", VA="0x1EC60E0")]
		public static ConnectionResponse InternalError(long localClientId, string remoteEndpointId)
		{
			return new ConnectionResponse();
		}

		[Address(RVA="0x1EC604C", Offset="0x1EC604C", VA="0x1EC604C")]
		public static ConnectionResponse NetworkNotConnected(long localClientId, string remoteEndpointId)
		{
			return new ConnectionResponse();
		}

		[Address(RVA="0x1EC5FB8", Offset="0x1EC5FB8", VA="0x1EC5FB8")]
		public static ConnectionResponse Rejected(long localClientId, string remoteEndpointId)
		{
			return new ConnectionResponse();
		}

		public enum Status
		{
			[FieldOffset(Offset="0x0")]
			Accepted,
			[FieldOffset(Offset="0x0")]
			Rejected,
			[FieldOffset(Offset="0x0")]
			ErrorInternal,
			[FieldOffset(Offset="0x0")]
			ErrorNetworkNotConnected,
			[FieldOffset(Offset="0x0")]
			ErrorEndpointNotConnected,
			[FieldOffset(Offset="0x0")]
			ErrorAlreadyConnected
		}
	}
}