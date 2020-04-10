using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct InboxMessageAttachment : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF5A918", Offset="0xF5A918", VA="0xF5A918", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint Count
		{
			[Address(RVA="0xF5A94C", Offset="0xF5A94C", VA="0xF5A94C")]
			get
			{
				return new uint();
			}
		}

		public ulong ItemId
		{
			[Address(RVA="0xF5A944", Offset="0xF5A944", VA="0xF5A944")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF5A92C", Offset="0xF5A92C", VA="0xF5A92C")]
		public InboxMessageAttachment __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new InboxMessageAttachment();
		}

		[Address(RVA="0xF5A920", Offset="0xF5A920", VA="0xF5A920", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2516B08", Offset="0x2516B08", VA="0x2516B08")]
		public static void AddCount(FlatBufferBuilder builder, uint count)
		{
		}

		[Address(RVA="0x2516ACC", Offset="0x2516ACC", VA="0x2516ACC")]
		public static void AddItemId(FlatBufferBuilder builder, ulong itemId)
		{
		}

		[Address(RVA="0x2516A64", Offset="0x2516A64", VA="0x2516A64")]
		public static Offset<InboxMessageAttachment> CreateInboxMessageAttachment(FlatBufferBuilder builder, ulong item_id = 0L, uint count = 0)
		{
			return new Offset<InboxMessageAttachment>();
		}

		[Address(RVA="0x2516B44", Offset="0x2516B44", VA="0x2516B44")]
		public static Offset<InboxMessageAttachment> EndInboxMessageAttachment(FlatBufferBuilder builder)
		{
			return new Offset<InboxMessageAttachment>();
		}

		[Address(RVA="0x25168D4", Offset="0x25168D4", VA="0x25168D4")]
		public static InboxMessageAttachment GetRootAsInboxMessageAttachment(FlatBuffers.ByteBuffer _bb)
		{
			return new InboxMessageAttachment();
		}

		[Address(RVA="0x25168E0", Offset="0x25168E0", VA="0x25168E0")]
		public static InboxMessageAttachment GetRootAsInboxMessageAttachment(FlatBuffers.ByteBuffer _bb, InboxMessageAttachment obj)
		{
			return new InboxMessageAttachment();
		}

		[Address(RVA="0x2516BC4", Offset="0x2516BC4", VA="0x2516BC4")]
		public static void StartInboxMessageAttachment(FlatBufferBuilder builder)
		{
		}
	}
}