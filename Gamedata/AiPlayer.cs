using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct AiPlayer : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF09CF0", Offset="0xF09CF0", VA="0xF09CF0", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF09D1C", Offset="0xF09D1C", VA="0xF09D1C")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF09D04", Offset="0xF09D04", VA="0xF09D04")]
		public AiPlayer __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new AiPlayer();
		}

		[Address(RVA="0xF09CF8", Offset="0xF09CF8", VA="0xF09CF8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15EE090", Offset="0x15EE090", VA="0x15EE090")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x15EE040", Offset="0x15EE040", VA="0x15EE040")]
		public static Offset<AiPlayer> CreateAiPlayer(FlatBufferBuilder builder, ulong id = 0L)
		{
			return new Offset<AiPlayer>();
		}

		[Address(RVA="0x15EE0CC", Offset="0x15EE0CC", VA="0x15EE0CC")]
		public static Offset<AiPlayer> EndAiPlayer(FlatBufferBuilder builder)
		{
			return new Offset<AiPlayer>();
		}

		[Address(RVA="0x15EE17C", Offset="0x15EE17C", VA="0x15EE17C")]
		public static void FinishAiPlayerBuffer(FlatBufferBuilder builder, Offset<AiPlayer> offset)
		{
		}

		[Address(RVA="0x15EDF00", Offset="0x15EDF00", VA="0x15EDF00")]
		public static AiPlayer GetRootAsAiPlayer(FlatBuffers.ByteBuffer _bb)
		{
			return new AiPlayer();
		}

		[Address(RVA="0x15EDF0C", Offset="0x15EDF0C", VA="0x15EDF0C")]
		public static AiPlayer GetRootAsAiPlayer(FlatBuffers.ByteBuffer _bb, AiPlayer obj)
		{
			return new AiPlayer();
		}

		[Address(RVA="0x15EE14C", Offset="0x15EE14C", VA="0x15EE14C")]
		public static void StartAiPlayer(FlatBufferBuilder builder)
		{
		}
	}
}