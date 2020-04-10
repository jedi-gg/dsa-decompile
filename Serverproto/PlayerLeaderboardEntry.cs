using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PlayerLeaderboardEntry : IMessage<PlayerLeaderboardEntry>, IMessage, IEquatable<PlayerLeaderboardEntry>, IDeepCloneable<PlayerLeaderboardEntry>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PlayerLeaderboardEntry> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private PlayerProfileSimple player_;

		[FieldOffset(Offset="0x0")]
		public const int CurrentScoreFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong currentScore_;

		[FieldOffset(Offset="0x0")]
		public const int RankDeltaFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private int rankDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099480", Offset="0x1099480")]
		public ulong CurrentScore
		{
			[Address(RVA="0x1AF9D1C", Offset="0x1AF9D1C", VA="0x1AF9D1C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1AF9D24", Offset="0x1AF9D24", VA="0x1AF9D24")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099450", Offset="0x1099450")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1AF9A70", Offset="0x1AF9A70", VA="0x1AF9A70")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099440", Offset="0x1099440")]
		public static MessageParser<PlayerLeaderboardEntry> Parser
		{
			[Address(RVA="0x1AF9A08", Offset="0x1AF9A08", VA="0x1AF9A08")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099460", Offset="0x1099460")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1AF9B60", Offset="0x1AF9B60", VA="0x1AF9B60", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099470", Offset="0x1099470")]
		public PlayerProfileSimple Player
		{
			[Address(RVA="0x1AF9C4C", Offset="0x1AF9C4C", VA="0x1AF9C4C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1AF9CB4", Offset="0x1AF9CB4", VA="0x1AF9CB4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099490", Offset="0x1099490")]
		public int RankDelta
		{
			[Address(RVA="0x1AF9D2C", Offset="0x1AF9D2C", VA="0x1AF9D2C")]
			get
			{
				return new int();
			}
			[Address(RVA="0x1AF9D34", Offset="0x1AF9D34", VA="0x1AF9D34")]
			set
			{
			}
		}

		[Address(RVA="0x1AFA524", Offset="0x1AFA524", VA="0x1AFA524")]
		static PlayerLeaderboardEntry()
		{
		}

		[Address(RVA="0x1AF9BBC", Offset="0x1AF9BBC", VA="0x1AF9BBC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10831BC", Offset="0x10831BC")]
		public PlayerLeaderboardEntry()
		{
		}

		[Address(RVA="0x1AF9BC4", Offset="0x1AF9BC4", VA="0x1AF9BC4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10831CC", Offset="0x10831CC")]
		public PlayerLeaderboardEntry(PlayerLeaderboardEntry other)
		{
		}

		[Address(RVA="0x1AFA08C", Offset="0x1AFA08C", VA="0x1AFA08C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108323C", Offset="0x108323C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1AF9CBC", Offset="0x1AF9CBC", VA="0x1AF9CBC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10831DC", Offset="0x10831DC")]
		public PlayerLeaderboardEntry Clone()
		{
			return null;
		}

		[Address(RVA="0x1AF9D3C", Offset="0x1AF9D3C", VA="0x1AF9D3C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10831EC", Offset="0x10831EC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1AF9DB0", Offset="0x1AF9DB0", VA="0x1AF9DB0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10831FC", Offset="0x10831FC")]
		public bool Equals(PlayerLeaderboardEntry other)
		{
			return new bool();
		}

		[Address(RVA="0x1AF9E34", Offset="0x1AF9E34", VA="0x1AF9E34", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108320C", Offset="0x108320C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1AFA19C", Offset="0x1AFA19C", VA="0x1AFA19C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108324C", Offset="0x108324C")]
		public void MergeFrom(PlayerLeaderboardEntry other)
		{
		}

		[Address(RVA="0x1AFA3F4", Offset="0x1AFA3F4", VA="0x1AFA3F4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108325C", Offset="0x108325C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1AF9ED4", Offset="0x1AF9ED4", VA="0x1AF9ED4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108321C", Offset="0x108321C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1AF9F3C", Offset="0x1AF9F3C", VA="0x1AF9F3C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108322C", Offset="0x108322C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050318", Offset="0x1050318")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PlayerLeaderboardEntry.<>c <>9;

			[Address(RVA="0x1AFA5FC", Offset="0x1AFA5FC", VA="0x1AFA5FC")]
			static <>c()
			{
			}

			[Address(RVA="0x1AFA660", Offset="0x1AFA660", VA="0x1AFA660")]
			public <>c()
			{
			}

			[Address(RVA="0x1AFA668", Offset="0x1AFA668", VA="0x1AFA668")]
			internal PlayerLeaderboardEntry <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}