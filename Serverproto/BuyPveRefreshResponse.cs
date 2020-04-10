using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BuyPveRefreshResponse : IMessage<BuyPveRefreshResponse>, IMessage, IEquatable<BuyPveRefreshResponse>, IDeepCloneable<BuyPveRefreshResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BuyPveRefreshResponse> _parser;

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

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094400", Offset="0x1094400")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F867A4", Offset="0x1F867A4", VA="0x1F867A4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094420", Offset="0x1094420")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1F86980", Offset="0x1F86980", VA="0x1F86980")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F86988", Offset="0x1F86988", VA="0x1F86988")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10943F0", Offset="0x10943F0")]
		public static MessageParser<BuyPveRefreshResponse> Parser
		{
			[Address(RVA="0x1F8673C", Offset="0x1F8673C", VA="0x1F8673C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094410", Offset="0x1094410")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F86890", Offset="0x1F86890", VA="0x1F86890", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094430", Offset="0x1094430")]
		public CampaignProgress UpdatedProgress
		{
			[Address(RVA="0x1F86990", Offset="0x1F86990", VA="0x1F86990")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F869F8", Offset="0x1F869F8", VA="0x1F869F8")]
			set
			{
			}
		}

		[Address(RVA="0x1F870EC", Offset="0x1F870EC", VA="0x1F870EC")]
		static BuyPveRefreshResponse()
		{
		}

		[Address(RVA="0x1F868EC", Offset="0x1F868EC", VA="0x1F868EC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079DEC", Offset="0x1079DEC")]
		public BuyPveRefreshResponse()
		{
		}

		[Address(RVA="0x1F868F4", Offset="0x1F868F4", VA="0x1F868F4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079DFC", Offset="0x1079DFC")]
		public BuyPveRefreshResponse(BuyPveRefreshResponse other)
		{
		}

		[Address(RVA="0x1F86D1C", Offset="0x1F86D1C", VA="0x1F86D1C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079E6C", Offset="0x1079E6C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F86A00", Offset="0x1F86A00", VA="0x1F86A00", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079E0C", Offset="0x1079E0C")]
		public BuyPveRefreshResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1F86A60", Offset="0x1F86A60", VA="0x1F86A60", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079E1C", Offset="0x1079E1C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F86AD4", Offset="0x1F86AD4", VA="0x1F86AD4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079E2C", Offset="0x1079E2C")]
		public bool Equals(BuyPveRefreshResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1F86B4C", Offset="0x1F86B4C", VA="0x1F86B4C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079E3C", Offset="0x1079E3C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F86DF0", Offset="0x1F86DF0", VA="0x1F86DF0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079E7C", Offset="0x1079E7C")]
		public void MergeFrom(BuyPveRefreshResponse other)
		{
		}

		[Address(RVA="0x1F86FD8", Offset="0x1F86FD8", VA="0x1F86FD8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079E8C", Offset="0x1079E8C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F86BBC", Offset="0x1F86BBC", VA="0x1F86BBC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079E4C", Offset="0x1079E4C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F86C24", Offset="0x1F86C24", VA="0x1F86C24", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079E5C", Offset="0x1079E5C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F598", Offset="0x104F598")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BuyPveRefreshResponse.<>c <>9;

			[Address(RVA="0x1F871C4", Offset="0x1F871C4", VA="0x1F871C4")]
			static <>c()
			{
			}

			[Address(RVA="0x1F87228", Offset="0x1F87228", VA="0x1F87228")]
			public <>c()
			{
			}

			[Address(RVA="0x1F87230", Offset="0x1F87230", VA="0x1F87230")]
			internal BuyPveRefreshResponse <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}