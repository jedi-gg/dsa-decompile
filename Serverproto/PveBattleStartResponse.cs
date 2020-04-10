using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PveBattleStartResponse : IMessage<PveBattleStartResponse>, IMessage, IEquatable<PveBattleStartResponse>, IDeepCloneable<PveBattleStartResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PveBattleStartResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int BootstrapBytesFieldNumber = 5;

		[FieldOffset(Offset="0x18")]
		private ByteString bootstrapBytes_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 7;

		[FieldOffset(Offset="0x20")]
		private ulong playerId_;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 8;

		[FieldOffset(Offset="0x28")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091E98", Offset="0x1091E98")]
		public ByteString BootstrapBytes
		{
			[Address(RVA="0x2015794", Offset="0x2015794", VA="0x2015794")]
			get
			{
				return null;
			}
			[Address(RVA="0x201579C", Offset="0x201579C", VA="0x201579C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091E78", Offset="0x1091E78")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x20154D4", Offset="0x20154D4", VA="0x20154D4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091EB8", Offset="0x1091EB8")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x2015724", Offset="0x2015724", VA="0x2015724")]
			get
			{
				return null;
			}
			[Address(RVA="0x201572C", Offset="0x201572C", VA="0x201572C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091E68", Offset="0x1091E68")]
		public static MessageParser<PveBattleStartResponse> Parser
		{
			[Address(RVA="0x201546C", Offset="0x201546C", VA="0x201546C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091E88", Offset="0x1091E88")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x20155C4", Offset="0x20155C4", VA="0x20155C4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091EA8", Offset="0x1091EA8")]
		public ulong PlayerId
		{
			[Address(RVA="0x201580C", Offset="0x201580C", VA="0x201580C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x2015814", Offset="0x2015814", VA="0x2015814")]
			set
			{
			}
		}

		[Address(RVA="0x2015F60", Offset="0x2015F60", VA="0x2015F60")]
		static PveBattleStartResponse()
		{
		}

		[Address(RVA="0x2015620", Offset="0x2015620", VA="0x2015620")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075FAC", Offset="0x1075FAC")]
		public PveBattleStartResponse()
		{
		}

		[Address(RVA="0x2015694", Offset="0x2015694", VA="0x2015694")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075FBC", Offset="0x1075FBC")]
		public PveBattleStartResponse(PveBattleStartResponse other)
		{
		}

		[Address(RVA="0x2015C04", Offset="0x2015C04", VA="0x2015C04", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107602C", Offset="0x107602C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x2015734", Offset="0x2015734", VA="0x2015734", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075FCC", Offset="0x1075FCC")]
		public PveBattleStartResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x201581C", Offset="0x201581C", VA="0x201581C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075FDC", Offset="0x1075FDC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x2015890", Offset="0x2015890", VA="0x2015890", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075FEC", Offset="0x1075FEC")]
		public bool Equals(PveBattleStartResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x2015970", Offset="0x2015970", VA="0x2015970", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075FFC", Offset="0x1075FFC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2015D38", Offset="0x2015D38", VA="0x2015D38", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107603C", Offset="0x107603C")]
		public void MergeFrom(PveBattleStartResponse other)
		{
		}

		[Address(RVA="0x2015E24", Offset="0x2015E24", VA="0x2015E24", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107604C", Offset="0x107604C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x2015A34", Offset="0x2015A34", VA="0x2015A34", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107600C", Offset="0x107600C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x2015A9C", Offset="0x2015A9C", VA="0x2015A9C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107601C", Offset="0x107601C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EFB8", Offset="0x104EFB8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PveBattleStartResponse.<>c <>9;

			[Address(RVA="0x2016038", Offset="0x2016038", VA="0x2016038")]
			static <>c()
			{
			}

			[Address(RVA="0x201609C", Offset="0x201609C", VA="0x201609C")]
			public <>c()
			{
			}

			[Address(RVA="0x20160A4", Offset="0x20160A4", VA="0x20160A4")]
			internal PveBattleStartResponse <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}