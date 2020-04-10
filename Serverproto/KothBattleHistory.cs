using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class KothBattleHistory : IMessage<KothBattleHistory>, IMessage, IEquatable<KothBattleHistory>, IDeepCloneable<KothBattleHistory>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<KothBattleHistory> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int OpponentFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private KothLobbyOpponent opponent_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerWonFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private bool playerWon_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerRankFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong playerRank_;

		[FieldOffset(Offset="0x0")]
		public const int BattleEndTimeFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong battleEndTime_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B780", Offset="0x109B780")]
		public ulong BattleEndTime
		{
			[Address(RVA="0x1A98394", Offset="0x1A98394", VA="0x1A98394")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A9839C", Offset="0x1A9839C", VA="0x1A9839C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B730", Offset="0x109B730")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A980BC", Offset="0x1A980BC", VA="0x1A980BC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B750", Offset="0x109B750")]
		public KothLobbyOpponent Opponent
		{
			[Address(RVA="0x1A982A0", Offset="0x1A982A0", VA="0x1A982A0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A98308", Offset="0x1A98308", VA="0x1A98308")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B720", Offset="0x109B720")]
		public static MessageParser<KothBattleHistory> Parser
		{
			[Address(RVA="0x1A98054", Offset="0x1A98054", VA="0x1A98054")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B740", Offset="0x109B740")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A981AC", Offset="0x1A981AC", VA="0x1A981AC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B770", Offset="0x109B770")]
		public ulong PlayerRank
		{
			[Address(RVA="0x1A98384", Offset="0x1A98384", VA="0x1A98384")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A9838C", Offset="0x1A9838C", VA="0x1A9838C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B760", Offset="0x109B760")]
		public bool PlayerWon
		{
			[Address(RVA="0x1A98370", Offset="0x1A98370", VA="0x1A98370")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A98378", Offset="0x1A98378", VA="0x1A98378")]
			set
			{
			}
		}

		[Address(RVA="0x1A98CA0", Offset="0x1A98CA0", VA="0x1A98CA0")]
		static KothBattleHistory()
		{
		}

		[Address(RVA="0x1A98208", Offset="0x1A98208", VA="0x1A98208")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108729C", Offset="0x108729C")]
		public KothBattleHistory()
		{
		}

		[Address(RVA="0x1A98210", Offset="0x1A98210", VA="0x1A98210")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10872AC", Offset="0x10872AC")]
		public KothBattleHistory(KothBattleHistory other)
		{
		}

		[Address(RVA="0x1A98790", Offset="0x1A98790", VA="0x1A98790", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108731C", Offset="0x108731C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A98310", Offset="0x1A98310", VA="0x1A98310", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10872BC", Offset="0x10872BC")]
		public KothBattleHistory Clone()
		{
			return null;
		}

		[Address(RVA="0x1A983A4", Offset="0x1A983A4", VA="0x1A983A4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10872CC", Offset="0x10872CC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A98418", Offset="0x1A98418", VA="0x1A98418", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10872DC", Offset="0x10872DC")]
		public bool Equals(KothBattleHistory other)
		{
			return new bool();
		}

		[Address(RVA="0x1A984BC", Offset="0x1A984BC", VA="0x1A984BC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10872EC", Offset="0x10872EC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A988B8", Offset="0x1A988B8", VA="0x1A988B8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108732C", Offset="0x108732C")]
		public void MergeFrom(KothBattleHistory other)
		{
		}

		[Address(RVA="0x1A98B44", Offset="0x1A98B44", VA="0x1A98B44", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108733C", Offset="0x108733C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A9857C", Offset="0x1A9857C", VA="0x1A9857C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10872FC", Offset="0x10872FC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A985E4", Offset="0x1A985E4", VA="0x1A985E4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108730C", Offset="0x108730C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10508F8", Offset="0x10508F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static KothBattleHistory.<>c <>9;

			[Address(RVA="0x1A98D78", Offset="0x1A98D78", VA="0x1A98D78")]
			static <>c()
			{
			}

			[Address(RVA="0x1A98DDC", Offset="0x1A98DDC", VA="0x1A98DDC")]
			public <>c()
			{
			}

			[Address(RVA="0x1A98DE4", Offset="0x1A98DE4", VA="0x1A98DE4")]
			internal KothBattleHistory <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}