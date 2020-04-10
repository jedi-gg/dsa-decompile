using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubLeaderboardResponse : IMessage<ClubLeaderboardResponse>, IMessage, IEquatable<ClubLeaderboardResponse>, IDeepCloneable<ClubLeaderboardResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubLeaderboardResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int TypeFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ClubLeaderboardType type_;

		[FieldOffset(Offset="0x0")]
		public const int EntriesFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ClubLeaderboardEntry> _repeated_entries_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<ClubLeaderboardEntry> entries_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099600", Offset="0x1099600")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FFC8F0", Offset="0x1FFC8F0", VA="0x1FFC8F0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099630", Offset="0x1099630")]
		public RepeatedField<ClubLeaderboardEntry> Entries
		{
			[Address(RVA="0x1FFCBD4", Offset="0x1FFCBD4", VA="0x1FFCBD4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10995F0", Offset="0x10995F0")]
		public static MessageParser<ClubLeaderboardResponse> Parser
		{
			[Address(RVA="0x1FFC888", Offset="0x1FFC888", VA="0x1FFC888")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099610", Offset="0x1099610")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FFC9E0", Offset="0x1FFC9E0", VA="0x1FFC9E0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099620", Offset="0x1099620")]
		public ClubLeaderboardType Type
		{
			[Address(RVA="0x1FFCBC4", Offset="0x1FFCBC4", VA="0x1FFCBC4")]
			get
			{
				return new ClubLeaderboardType();
			}
			[Address(RVA="0x1FFCBCC", Offset="0x1FFCBCC", VA="0x1FFCBCC")]
			set
			{
			}
		}

		[Address(RVA="0x1FFD1C8", Offset="0x1FFD1C8", VA="0x1FFD1C8")]
		static ClubLeaderboardResponse()
		{
		}

		[Address(RVA="0x1FFCA3C", Offset="0x1FFCA3C", VA="0x1FFCA3C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108352C", Offset="0x108352C")]
		public ClubLeaderboardResponse()
		{
		}

		[Address(RVA="0x1FFCAAC", Offset="0x1FFCAAC", VA="0x1FFCAAC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108353C", Offset="0x108353C")]
		public ClubLeaderboardResponse(ClubLeaderboardResponse other)
		{
		}

		[Address(RVA="0x1FFCF24", Offset="0x1FFCF24", VA="0x1FFCF24", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10835AC", Offset="0x10835AC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FFCB64", Offset="0x1FFCB64", VA="0x1FFCB64", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108354C", Offset="0x108354C")]
		public ClubLeaderboardResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1FFCBDC", Offset="0x1FFCBDC", VA="0x1FFCBDC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108355C", Offset="0x108355C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FFCC50", Offset="0x1FFCC50", VA="0x1FFCC50", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108356C", Offset="0x108356C")]
		public bool Equals(ClubLeaderboardResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1FFCD10", Offset="0x1FFCD10", VA="0x1FFCD10", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108357C", Offset="0x108357C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FFD020", Offset="0x1FFD020", VA="0x1FFD020", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10835BC", Offset="0x10835BC")]
		public void MergeFrom(ClubLeaderboardResponse other)
		{
		}

		[Address(RVA="0x1FFD0BC", Offset="0x1FFD0BC", VA="0x1FFD0BC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10835CC", Offset="0x10835CC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FFCDA0", Offset="0x1FFCDA0", VA="0x1FFCDA0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108358C", Offset="0x108358C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FFCE08", Offset="0x1FFCE08", VA="0x1FFCE08", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108359C", Offset="0x108359C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050368", Offset="0x1050368")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubLeaderboardResponse.<>c <>9;

			[Address(RVA="0x1FFD2E8", Offset="0x1FFD2E8", VA="0x1FFD2E8")]
			static <>c()
			{
			}

			[Address(RVA="0x1FFD34C", Offset="0x1FFD34C", VA="0x1FFD34C")]
			public <>c()
			{
			}

			[Address(RVA="0x1FFD354", Offset="0x1FFD354", VA="0x1FFD354")]
			internal ClubLeaderboardResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}