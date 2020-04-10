using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BuyExpiredDailyLoginResponse : IMessage<BuyExpiredDailyLoginResponse>, IMessage, IEquatable<BuyExpiredDailyLoginResponse>, IDeepCloneable<BuyExpiredDailyLoginResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BuyExpiredDailyLoginResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AD80", Offset="0x109AD80")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F8457C", Offset="0x1F8457C", VA="0x1F8457C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109ADA0", Offset="0x109ADA0")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1F8474C", Offset="0x1F8474C", VA="0x1F8474C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F84754", Offset="0x1F84754", VA="0x1F84754")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AD70", Offset="0x109AD70")]
		public static MessageParser<BuyExpiredDailyLoginResponse> Parser
		{
			[Address(RVA="0x1F84514", Offset="0x1F84514", VA="0x1F84514")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AD90", Offset="0x109AD90")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F8466C", Offset="0x1F8466C", VA="0x1F8466C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1F84C14", Offset="0x1F84C14", VA="0x1F84C14")]
		static BuyExpiredDailyLoginResponse()
		{
		}

		[Address(RVA="0x1F846C8", Offset="0x1F846C8", VA="0x1F846C8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085B3C", Offset="0x1085B3C")]
		public BuyExpiredDailyLoginResponse()
		{
		}

		[Address(RVA="0x1F846D0", Offset="0x1F846D0", VA="0x1F846D0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085B4C", Offset="0x1085B4C")]
		public BuyExpiredDailyLoginResponse(BuyExpiredDailyLoginResponse other)
		{
		}

		[Address(RVA="0x1F849F4", Offset="0x1F849F4", VA="0x1F849F4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085BBC", Offset="0x1085BBC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F8475C", Offset="0x1F8475C", VA="0x1F8475C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085B5C", Offset="0x1085B5C")]
		public BuyExpiredDailyLoginResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1F847BC", Offset="0x1F847BC", VA="0x1F847BC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085B6C", Offset="0x1085B6C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F84830", Offset="0x1F84830", VA="0x1F84830", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085B7C", Offset="0x1085B7C")]
		public bool Equals(BuyExpiredDailyLoginResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1F84894", Offset="0x1F84894", VA="0x1F84894", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085B8C", Offset="0x1085B8C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F84A84", Offset="0x1F84A84", VA="0x1F84A84", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085BCC", Offset="0x1085BCC")]
		public void MergeFrom(BuyExpiredDailyLoginResponse other)
		{
		}

		[Address(RVA="0x1F84B38", Offset="0x1F84B38", VA="0x1F84B38", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085BDC", Offset="0x1085BDC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F848EC", Offset="0x1F848EC", VA="0x1F848EC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085B9C", Offset="0x1085B9C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F84954", Offset="0x1F84954", VA="0x1F84954", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1085BAC", Offset="0x1085BAC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10506D8", Offset="0x10506D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BuyExpiredDailyLoginResponse.<>c <>9;

			[Address(RVA="0x1F84CEC", Offset="0x1F84CEC", VA="0x1F84CEC")]
			static <>c()
			{
			}

			[Address(RVA="0x1F84D50", Offset="0x1F84D50", VA="0x1F84D50")]
			public <>c()
			{
			}

			[Address(RVA="0x1F84D58", Offset="0x1F84D58", VA="0x1F84D58")]
			internal BuyExpiredDailyLoginResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}