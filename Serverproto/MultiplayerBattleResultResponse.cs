using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class MultiplayerBattleResultResponse : IMessage<MultiplayerBattleResultResponse>, IMessage, IEquatable<MultiplayerBattleResultResponse>, IDeepCloneable<MultiplayerBattleResultResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<MultiplayerBattleResultResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[FieldOffset(Offset="0x0")]
		public const int PvpScoreFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private Serverproto.PvpScore pvpScore_;

		[FieldOffset(Offset="0x0")]
		public const int PvpTakeoverResponseFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private PvpTakeoverResultResponse pvpTakeoverResponse_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092AB0", Offset="0x1092AB0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A2471C", Offset="0x1A2471C", VA="0x1A2471C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092AD0", Offset="0x1092AD0")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1A24914", Offset="0x1A24914", VA="0x1A24914")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A2491C", Offset="0x1A2491C", VA="0x1A2491C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092AA0", Offset="0x1092AA0")]
		public static MessageParser<MultiplayerBattleResultResponse> Parser
		{
			[Address(RVA="0x1A246B4", Offset="0x1A246B4", VA="0x1A246B4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092AC0", Offset="0x1092AC0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A2480C", Offset="0x1A2480C", VA="0x1A2480C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092AE0", Offset="0x1092AE0")]
		public Serverproto.PvpScore PvpScore
		{
			[Address(RVA="0x1A24924", Offset="0x1A24924", VA="0x1A24924")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A2492C", Offset="0x1A2492C", VA="0x1A2492C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092AF0", Offset="0x1092AF0")]
		public PvpTakeoverResultResponse PvpTakeoverResponse
		{
			[Address(RVA="0x1A24934", Offset="0x1A24934", VA="0x1A24934")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A2493C", Offset="0x1A2493C", VA="0x1A2493C")]
			set
			{
			}
		}

		[Address(RVA="0x1A2509C", Offset="0x1A2509C", VA="0x1A2509C")]
		static MultiplayerBattleResultResponse()
		{
		}

		[Address(RVA="0x1A24868", Offset="0x1A24868", VA="0x1A24868")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107744C", Offset="0x107744C")]
		public MultiplayerBattleResultResponse()
		{
		}

		[Address(RVA="0x1A24870", Offset="0x1A24870", VA="0x1A24870")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107745C", Offset="0x107745C")]
		public MultiplayerBattleResultResponse(MultiplayerBattleResultResponse other)
		{
		}

		[Address(RVA="0x1A24CE4", Offset="0x1A24CE4", VA="0x1A24CE4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10774CC", Offset="0x10774CC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A24944", Offset="0x1A24944", VA="0x1A24944", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107746C", Offset="0x107746C")]
		public MultiplayerBattleResultResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A249A4", Offset="0x1A249A4", VA="0x1A249A4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107747C", Offset="0x107747C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A24A18", Offset="0x1A24A18", VA="0x1A24A18", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107748C", Offset="0x107748C")]
		public bool Equals(MultiplayerBattleResultResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A24AA4", Offset="0x1A24AA4", VA="0x1A24AA4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107749C", Offset="0x107749C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A24DF4", Offset="0x1A24DF4", VA="0x1A24DF4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10774DC", Offset="0x10774DC")]
		public void MergeFrom(MultiplayerBattleResultResponse other)
		{
		}

		[Address(RVA="0x1A24F48", Offset="0x1A24F48", VA="0x1A24F48", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10774EC", Offset="0x10774EC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A24B2C", Offset="0x1A24B2C", VA="0x1A24B2C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10774AC", Offset="0x10774AC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A24B94", Offset="0x1A24B94", VA="0x1A24B94", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10774BC", Offset="0x10774BC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F198", Offset="0x104F198")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static MultiplayerBattleResultResponse.<>c <>9;

			[Address(RVA="0x1A25174", Offset="0x1A25174", VA="0x1A25174")]
			static <>c()
			{
			}

			[Address(RVA="0x1A251D8", Offset="0x1A251D8", VA="0x1A251D8")]
			public <>c()
			{
			}

			[Address(RVA="0x1A251E0", Offset="0x1A251E0", VA="0x1A251E0")]
			internal MultiplayerBattleResultResponse <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}