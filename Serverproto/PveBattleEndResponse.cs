using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class PveBattleEndResponse : IMessage<PveBattleEndResponse>, IMessage, IEquatable<PveBattleEndResponse>, IDeepCloneable<PveBattleEndResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<PveBattleEndResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[FieldOffset(Offset="0x0")]
		public const int UpdatedProgressFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private CampaignProgress updatedProgress_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091F38", Offset="0x1091F38")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x2013B1C", Offset="0x2013B1C", VA="0x2013B1C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091F58", Offset="0x1091F58")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x2013D00", Offset="0x2013D00", VA="0x2013D00")]
			get
			{
				return null;
			}
			[Address(RVA="0x2013D08", Offset="0x2013D08", VA="0x2013D08")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091F28", Offset="0x1091F28")]
		public static MessageParser<PveBattleEndResponse> Parser
		{
			[Address(RVA="0x2013AB4", Offset="0x2013AB4", VA="0x2013AB4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091F48", Offset="0x1091F48")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x2013C0C", Offset="0x2013C0C", VA="0x2013C0C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091F68", Offset="0x1091F68")]
		public CampaignProgress UpdatedProgress
		{
			[Address(RVA="0x2013D10", Offset="0x2013D10", VA="0x2013D10")]
			get
			{
				return null;
			}
			[Address(RVA="0x2013D18", Offset="0x2013D18", VA="0x2013D18")]
			set
			{
			}
		}

		[Address(RVA="0x2014328", Offset="0x2014328", VA="0x2014328")]
		static PveBattleEndResponse()
		{
		}

		[Address(RVA="0x2013C68", Offset="0x2013C68", VA="0x2013C68")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107610C", Offset="0x107610C")]
		public PveBattleEndResponse()
		{
		}

		[Address(RVA="0x2013C70", Offset="0x2013C70", VA="0x2013C70")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107611C", Offset="0x107611C")]
		public PveBattleEndResponse(PveBattleEndResponse other)
		{
		}

		[Address(RVA="0x201403C", Offset="0x201403C", VA="0x201403C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107618C", Offset="0x107618C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x2013D20", Offset="0x2013D20", VA="0x2013D20", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107612C", Offset="0x107612C")]
		public PveBattleEndResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x2013D80", Offset="0x2013D80", VA="0x2013D80", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107613C", Offset="0x107613C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x2013DF4", Offset="0x2013DF4", VA="0x2013DF4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107614C", Offset="0x107614C")]
		public bool Equals(PveBattleEndResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x2013E6C", Offset="0x2013E6C", VA="0x2013E6C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107615C", Offset="0x107615C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x2014110", Offset="0x2014110", VA="0x2014110", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107619C", Offset="0x107619C")]
		public void MergeFrom(PveBattleEndResponse other)
		{
		}

		[Address(RVA="0x2014214", Offset="0x2014214", VA="0x2014214", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10761AC", Offset="0x10761AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x2013EDC", Offset="0x2013EDC", VA="0x2013EDC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107616C", Offset="0x107616C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x2013F44", Offset="0x2013F44", VA="0x2013F44", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107617C", Offset="0x107617C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EFD8", Offset="0x104EFD8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static PveBattleEndResponse.<>c <>9;

			[Address(RVA="0x2014400", Offset="0x2014400", VA="0x2014400")]
			static <>c()
			{
			}

			[Address(RVA="0x2014464", Offset="0x2014464", VA="0x2014464")]
			public <>c()
			{
			}

			[Address(RVA="0x201446C", Offset="0x201446C", VA="0x201446C")]
			internal PveBattleEndResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}