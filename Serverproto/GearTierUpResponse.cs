using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class GearTierUpResponse : IMessage<GearTierUpResponse>, IMessage, IEquatable<GearTierUpResponse>, IDeepCloneable<GearTierUpResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<GearTierUpResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098C50", Offset="0x1098C50")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA4344", Offset="0x1BA4344", VA="0x1BA4344")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098C70", Offset="0x1098C70")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1BA4514", Offset="0x1BA4514", VA="0x1BA4514")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BA451C", Offset="0x1BA451C", VA="0x1BA451C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098C40", Offset="0x1098C40")]
		public static MessageParser<GearTierUpResponse> Parser
		{
			[Address(RVA="0x1BA42DC", Offset="0x1BA42DC", VA="0x1BA42DC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098C60", Offset="0x1098C60")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA4434", Offset="0x1BA4434", VA="0x1BA4434", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BA49DC", Offset="0x1BA49DC", VA="0x1BA49DC")]
		static GearTierUpResponse()
		{
		}

		[Address(RVA="0x1BA4490", Offset="0x1BA4490", VA="0x1BA4490")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10821EC", Offset="0x10821EC")]
		public GearTierUpResponse()
		{
		}

		[Address(RVA="0x1BA4498", Offset="0x1BA4498", VA="0x1BA4498")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10821FC", Offset="0x10821FC")]
		public GearTierUpResponse(GearTierUpResponse other)
		{
		}

		[Address(RVA="0x1BA47BC", Offset="0x1BA47BC", VA="0x1BA47BC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108226C", Offset="0x108226C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA4524", Offset="0x1BA4524", VA="0x1BA4524", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108220C", Offset="0x108220C")]
		public GearTierUpResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA4584", Offset="0x1BA4584", VA="0x1BA4584", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108221C", Offset="0x108221C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA45F8", Offset="0x1BA45F8", VA="0x1BA45F8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108222C", Offset="0x108222C")]
		public bool Equals(GearTierUpResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA465C", Offset="0x1BA465C", VA="0x1BA465C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108223C", Offset="0x108223C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA484C", Offset="0x1BA484C", VA="0x1BA484C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108227C", Offset="0x108227C")]
		public void MergeFrom(GearTierUpResponse other)
		{
		}

		[Address(RVA="0x1BA4900", Offset="0x1BA4900", VA="0x1BA4900", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108228C", Offset="0x108228C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA46B4", Offset="0x1BA46B4", VA="0x1BA46B4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108224C", Offset="0x108224C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA471C", Offset="0x1BA471C", VA="0x1BA471C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108225C", Offset="0x108225C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10501A8", Offset="0x10501A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GearTierUpResponse.<>c <>9;

			[Address(RVA="0x1BA4AB4", Offset="0x1BA4AB4", VA="0x1BA4AB4")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA4B18", Offset="0x1BA4B18", VA="0x1BA4B18")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA4B20", Offset="0x1BA4B20", VA="0x1BA4B20")]
			internal GearTierUpResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}