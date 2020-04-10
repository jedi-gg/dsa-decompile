using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubWarBattleResultResponse : IMessage<ClubWarBattleResultResponse>, IMessage, IEquatable<ClubWarBattleResultResponse>, IDeepCloneable<ClubWarBattleResultResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubWarBattleResultResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[FieldOffset(Offset="0x0")]
		public const int ScoreDeltasFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ClubWarClubScoreDelta> _repeated_scoreDeltas_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<ClubWarClubScoreDelta> scoreDeltas_;

		[FieldOffset(Offset="0x0")]
		public const int CapturedNodeFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private bool capturedNode_;

		[FieldOffset(Offset="0x0")]
		public const int NumDefensesRemainingFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong numDefensesRemaining_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10935F0", Offset="0x10935F0")]
		public bool CapturedNode
		{
			[Address(RVA="0x1B1ABB4", Offset="0x1B1ABB4", VA="0x1B1ABB4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1B1ABBC", Offset="0x1B1ABBC", VA="0x1B1ABBC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10935B0", Offset="0x10935B0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B1A8A8", Offset="0x1B1A8A8", VA="0x1B1A8A8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10935D0", Offset="0x10935D0")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1B1AB3C", Offset="0x1B1AB3C", VA="0x1B1AB3C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B1AB44", Offset="0x1B1AB44", VA="0x1B1AB44")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1093600", Offset="0x1093600")]
		public ulong NumDefensesRemaining
		{
			[Address(RVA="0x1B1ABC8", Offset="0x1B1ABC8", VA="0x1B1ABC8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1B1ABD0", Offset="0x1B1ABD0", VA="0x1B1ABD0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10935A0", Offset="0x10935A0")]
		public static MessageParser<ClubWarBattleResultResponse> Parser
		{
			[Address(RVA="0x1B1A840", Offset="0x1B1A840", VA="0x1B1A840")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10935C0", Offset="0x10935C0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B1A998", Offset="0x1B1A998", VA="0x1B1A998", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10935E0", Offset="0x10935E0")]
		public RepeatedField<ClubWarClubScoreDelta> ScoreDeltas
		{
			[Address(RVA="0x1B1ABAC", Offset="0x1B1ABAC", VA="0x1B1ABAC")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B1B41C", Offset="0x1B1B41C", VA="0x1B1B41C")]
		static ClubWarBattleResultResponse()
		{
		}

		[Address(RVA="0x1B1A9F4", Offset="0x1B1A9F4", VA="0x1B1A9F4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10788EC", Offset="0x10788EC")]
		public ClubWarBattleResultResponse()
		{
		}

		[Address(RVA="0x1B1AA64", Offset="0x1B1AA64", VA="0x1B1AA64")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10788FC", Offset="0x10788FC")]
		public ClubWarBattleResultResponse(ClubWarBattleResultResponse other)
		{
		}

		[Address(RVA="0x1B1B044", Offset="0x1B1B044", VA="0x1B1B044", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107896C", Offset="0x107896C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B1AB4C", Offset="0x1B1AB4C", VA="0x1B1AB4C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107890C", Offset="0x107890C")]
		public ClubWarBattleResultResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B1ABD8", Offset="0x1B1ABD8", VA="0x1B1ABD8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107891C", Offset="0x107891C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B1AC4C", Offset="0x1B1AC4C", VA="0x1B1AC4C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107892C", Offset="0x107892C")]
		public bool Equals(ClubWarBattleResultResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B1AD40", Offset="0x1B1AD40", VA="0x1B1AD40", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107893C", Offset="0x107893C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B1B188", Offset="0x1B1B188", VA="0x1B1B188", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107897C", Offset="0x107897C")]
		public void MergeFrom(ClubWarBattleResultResponse other)
		{
		}

		[Address(RVA="0x1B1B280", Offset="0x1B1B280", VA="0x1B1B280", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107898C", Offset="0x107898C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B1AE0C", Offset="0x1B1AE0C", VA="0x1B1AE0C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107894C", Offset="0x107894C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B1AE74", Offset="0x1B1AE74", VA="0x1B1AE74", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107895C", Offset="0x107895C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F378", Offset="0x104F378")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubWarBattleResultResponse.<>c <>9;

			[Address(RVA="0x1B1B5A4", Offset="0x1B1B5A4", VA="0x1B1B5A4")]
			static <>c()
			{
			}

			[Address(RVA="0x1B1B608", Offset="0x1B1B608", VA="0x1B1B608")]
			public <>c()
			{
			}

			[Address(RVA="0x1B1B610", Offset="0x1B1B610", VA="0x1B1B610")]
			internal ClubWarBattleResultResponse <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}