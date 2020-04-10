using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ClubWarPhase : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF44114", Offset="0xF44114", VA="0xF44114", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint DurationS
		{
			[Address(RVA="0xF44148", Offset="0xF44148", VA="0xF44148")]
			get
			{
				return new uint();
			}
		}

		public ClubWarPhaseType PhaseType
		{
			[Address(RVA="0xF44140", Offset="0xF44140", VA="0xF44140")]
			get
			{
				return new ClubWarPhaseType();
			}
		}

		[Address(RVA="0xF44128", Offset="0xF44128", VA="0xF44128")]
		public ClubWarPhase __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ClubWarPhase();
		}

		[Address(RVA="0xF4411C", Offset="0xF4411C", VA="0xF4411C", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x232746C", Offset="0x232746C", VA="0x232746C")]
		public static void AddDurationS(FlatBufferBuilder builder, uint durationS)
		{
		}

		[Address(RVA="0x23274A8", Offset="0x23274A8", VA="0x23274A8")]
		public static void AddPhaseType(FlatBufferBuilder builder, ClubWarPhaseType phaseType)
		{
		}

		[Address(RVA="0x2327404", Offset="0x2327404", VA="0x2327404")]
		public static Offset<ClubWarPhase> CreateClubWarPhase(FlatBufferBuilder builder, ClubWarPhaseType phase_type = 0, uint duration_s = 0)
		{
			return new Offset<ClubWarPhase>();
		}

		[Address(RVA="0x23274E4", Offset="0x23274E4", VA="0x23274E4")]
		public static Offset<ClubWarPhase> EndClubWarPhase(FlatBufferBuilder builder)
		{
			return new Offset<ClubWarPhase>();
		}

		[Address(RVA="0x2327278", Offset="0x2327278", VA="0x2327278")]
		public static ClubWarPhase GetRootAsClubWarPhase(FlatBuffers.ByteBuffer _bb)
		{
			return new ClubWarPhase();
		}

		[Address(RVA="0x2327284", Offset="0x2327284", VA="0x2327284")]
		public static ClubWarPhase GetRootAsClubWarPhase(FlatBuffers.ByteBuffer _bb, ClubWarPhase obj)
		{
			return new ClubWarPhase();
		}

		[Address(RVA="0x2327564", Offset="0x2327564", VA="0x2327564")]
		public static void StartClubWarPhase(FlatBufferBuilder builder)
		{
		}
	}
}