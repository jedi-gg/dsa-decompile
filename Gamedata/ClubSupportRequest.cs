using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ClubSupportRequest : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public uint AmountGranted
		{
			[Address(RVA="0xF43B20", Offset="0xF43B20", VA="0xF43B20")]
			get
			{
				return new uint();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF43AEC", Offset="0xF43AEC", VA="0xF43AEC", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint MaxRequestPerDay
		{
			[Address(RVA="0xF43B28", Offset="0xF43B28", VA="0xF43B28")]
			get
			{
				return new uint();
			}
		}

		public ulong RequestFulfilledInboxMessage
		{
			[Address(RVA="0xF43B30", Offset="0xF43B30", VA="0xF43B30")]
			get
			{
				return new ulong();
			}
		}

		public ClubSupportRequestType RequestType
		{
			[Address(RVA="0xF43B18", Offset="0xF43B18", VA="0xF43B18")]
			get
			{
				return new ClubSupportRequestType();
			}
		}

		[Address(RVA="0xF43B00", Offset="0xF43B00", VA="0xF43B00")]
		public ClubSupportRequest __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ClubSupportRequest();
		}

		[Address(RVA="0xF43AF4", Offset="0xF43AF4", VA="0xF43AF4", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2323628", Offset="0x2323628", VA="0x2323628")]
		public static void AddAmountGranted(FlatBufferBuilder builder, uint amountGranted)
		{
		}

		[Address(RVA="0x23235EC", Offset="0x23235EC", VA="0x23235EC")]
		public static void AddMaxRequestPerDay(FlatBufferBuilder builder, uint maxRequestPerDay)
		{
		}

		[Address(RVA="0x23235B0", Offset="0x23235B0", VA="0x23235B0")]
		public static void AddRequestFulfilledInboxMessage(FlatBufferBuilder builder, ulong requestFulfilledInboxMessage)
		{
		}

		[Address(RVA="0x2323664", Offset="0x2323664", VA="0x2323664")]
		public static void AddRequestType(FlatBufferBuilder builder, ClubSupportRequestType requestType)
		{
		}

		[Address(RVA="0x2323520", Offset="0x2323520", VA="0x2323520")]
		public static Offset<ClubSupportRequest> CreateClubSupportRequest(FlatBufferBuilder builder, ClubSupportRequestType request_type = 0, uint amount_granted = 0, uint max_request_per_day = 0, ulong request_fulfilled_inbox_message = 0L)
		{
			return new Offset<ClubSupportRequest>();
		}

		[Address(RVA="0x23236A0", Offset="0x23236A0", VA="0x23236A0")]
		public static Offset<ClubSupportRequest> EndClubSupportRequest(FlatBufferBuilder builder)
		{
			return new Offset<ClubSupportRequest>();
		}

		[Address(RVA="0x23232C0", Offset="0x23232C0", VA="0x23232C0")]
		public static ClubSupportRequest GetRootAsClubSupportRequest(FlatBuffers.ByteBuffer _bb)
		{
			return new ClubSupportRequest();
		}

		[Address(RVA="0x23232CC", Offset="0x23232CC", VA="0x23232CC")]
		public static ClubSupportRequest GetRootAsClubSupportRequest(FlatBuffers.ByteBuffer _bb, ClubSupportRequest obj)
		{
			return new ClubSupportRequest();
		}

		[Address(RVA="0x2323720", Offset="0x2323720", VA="0x2323720")]
		public static void StartClubSupportRequest(FlatBufferBuilder builder)
		{
		}
	}
}