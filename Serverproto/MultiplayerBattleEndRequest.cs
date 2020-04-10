using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class MultiplayerBattleEndRequest : IMessage<MultiplayerBattleEndRequest>, IMessage, IEquatable<MultiplayerBattleEndRequest>, IDeepCloneable<MultiplayerBattleEndRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<MultiplayerBattleEndRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int BattleIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string battleId_;

		[FieldOffset(Offset="0x0")]
		public const int WinningTeamIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private long winningTeamId_;

		[FieldOffset(Offset="0x0")]
		public const int EndBattleAuthTokenFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string endBattleAuthToken_;

		[FieldOffset(Offset="0x0")]
		public const int ActivityResultsFieldNumber = 4;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<MultiplayerBattleActivity> _repeated_activityResults_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<MultiplayerBattleActivity> activityResults_;

		[FieldOffset(Offset="0x0")]
		public const int TeamResultsFieldNumber = 5;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<MultiplayerBattleTeamResult> _repeated_teamResults_codec;

		[FieldOffset(Offset="0x38")]
		private readonly RepeatedField<MultiplayerBattleTeamResult> teamResults_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092A10", Offset="0x1092A10")]
		public RepeatedField<MultiplayerBattleActivity> ActivityResults
		{
			[Address(RVA="0x1A22AC4", Offset="0x1A22AC4", VA="0x1A22AC4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10929E0", Offset="0x10929E0")]
		public string BattleId
		{
			[Address(RVA="0x1A229C4", Offset="0x1A229C4", VA="0x1A229C4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A229CC", Offset="0x1A229CC", VA="0x1A229CC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10929C0", Offset="0x10929C0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A22654", Offset="0x1A22654", VA="0x1A22654")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092A00", Offset="0x1092A00")]
		public string EndBattleAuthToken
		{
			[Address(RVA="0x1A22A4C", Offset="0x1A22A4C", VA="0x1A22A4C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A22A54", Offset="0x1A22A54", VA="0x1A22A54")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10929B0", Offset="0x10929B0")]
		public static MessageParser<MultiplayerBattleEndRequest> Parser
		{
			[Address(RVA="0x1A225EC", Offset="0x1A225EC", VA="0x1A225EC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10929D0", Offset="0x10929D0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A22744", Offset="0x1A22744", VA="0x1A22744", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092A20", Offset="0x1092A20")]
		public RepeatedField<MultiplayerBattleTeamResult> TeamResults
		{
			[Address(RVA="0x1A22ACC", Offset="0x1A22ACC", VA="0x1A22ACC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10929F0", Offset="0x10929F0")]
		public long WinningTeamId
		{
			[Address(RVA="0x1A22A3C", Offset="0x1A22A3C", VA="0x1A22A3C")]
			get
			{
				return new long();
			}
			[Address(RVA="0x1A22A44", Offset="0x1A22A44", VA="0x1A22A44")]
			set
			{
			}
		}

		[Address(RVA="0x1A23514", Offset="0x1A23514", VA="0x1A23514")]
		static MultiplayerBattleEndRequest()
		{
		}

		[Address(RVA="0x1A227A0", Offset="0x1A227A0", VA="0x1A227A0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107723C", Offset="0x107723C")]
		public MultiplayerBattleEndRequest()
		{
		}

		[Address(RVA="0x1A2284C", Offset="0x1A2284C", VA="0x1A2284C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107724C", Offset="0x107724C")]
		public MultiplayerBattleEndRequest(MultiplayerBattleEndRequest other)
		{
		}

		[Address(RVA="0x1A23044", Offset="0x1A23044", VA="0x1A23044", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10772BC", Offset="0x10772BC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A22964", Offset="0x1A22964", VA="0x1A22964", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107725C", Offset="0x107725C")]
		public MultiplayerBattleEndRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A22AD4", Offset="0x1A22AD4", VA="0x1A22AD4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107726C", Offset="0x107726C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A22B48", Offset="0x1A22B48", VA="0x1A22B48", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107727C", Offset="0x107727C")]
		public bool Equals(MultiplayerBattleEndRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A22C60", Offset="0x1A22C60", VA="0x1A22C60", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107728C", Offset="0x107728C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A23230", Offset="0x1A23230", VA="0x1A23230", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10772CC", Offset="0x10772CC")]
		public void MergeFrom(MultiplayerBattleEndRequest other)
		{
		}

		[Address(RVA="0x1A23350", Offset="0x1A23350", VA="0x1A23350", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10772DC", Offset="0x10772DC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A22D9C", Offset="0x1A22D9C", VA="0x1A22D9C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107729C", Offset="0x107729C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A22E04", Offset="0x1A22E04", VA="0x1A22E04", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10772AC", Offset="0x10772AC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F168", Offset="0x104F168")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static MultiplayerBattleEndRequest.<>c <>9;

			[Address(RVA="0x1A236E4", Offset="0x1A236E4", VA="0x1A236E4")]
			static <>c()
			{
			}

			[Address(RVA="0x1A23748", Offset="0x1A23748", VA="0x1A23748")]
			public <>c()
			{
			}

			[Address(RVA="0x1A23750", Offset="0x1A23750", VA="0x1A23750")]
			internal MultiplayerBattleEndRequest <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}