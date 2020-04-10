using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BuyStoreItemRequest : IMessage<BuyStoreItemRequest>, IMessage, IEquatable<BuyStoreItemRequest>, IDeepCloneable<BuyStoreItemRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BuyStoreItemRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int StoreItemIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong storeItemId_;

		[FieldOffset(Offset="0x0")]
		public const int IapProductIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string iapProductId_;

		[FieldOffset(Offset="0x0")]
		public const int IapTransactionIdFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private string iapTransactionId_;

		[FieldOffset(Offset="0x0")]
		public const int IapValidationRequestBodyFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string iapValidationRequestBody_;

		[FieldOffset(Offset="0x0")]
		public const int DeferGrantingItemsFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private bool deferGrantingItems_;

		[FieldOffset(Offset="0x0")]
		public const int StoreShelfIdFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private ulong storeShelfId_;

		[FieldOffset(Offset="0x0")]
		public const int ClubGiftAnonFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private bool clubGiftAnon_;

		[FieldOffset(Offset="0x0")]
		public const int GiftIdFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private string giftId_;

		[FieldOffset(Offset="0x0")]
		public const int CostItemIdFieldNumber = 9;

		[FieldOffset(Offset="0x58")]
		private ulong costItemId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C5D0", Offset="0x109C5D0")]
		public bool ClubGiftAnon
		{
			[Address(RVA="0x1F899B8", Offset="0x1F899B8", VA="0x1F899B8")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1F899C0", Offset="0x1F899C0", VA="0x1F899C0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C5F0", Offset="0x109C5F0")]
		public ulong CostItemId
		{
			[Address(RVA="0x1F89A44", Offset="0x1F89A44", VA="0x1F89A44")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F89A4C", Offset="0x1F89A4C", VA="0x1F89A4C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C588", Offset="0x109C588")]
		public bool DeferGrantingItems
		{
			[Address(RVA="0x1F89994", Offset="0x1F89994", VA="0x1F89994")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1F8999C", Offset="0x1F8999C", VA="0x1F8999C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C528", Offset="0x109C528")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F894D0", Offset="0x1F894D0", VA="0x1F894D0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C5E0", Offset="0x109C5E0")]
		public string GiftId
		{
			[Address(RVA="0x1F899CC", Offset="0x1F899CC", VA="0x1F899CC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F899D4", Offset="0x1F899D4", VA="0x1F899D4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C558", Offset="0x109C558")]
		public string IapProductId
		{
			[Address(RVA="0x1F8982C", Offset="0x1F8982C", VA="0x1F8982C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F89834", Offset="0x1F89834", VA="0x1F89834")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C568", Offset="0x109C568")]
		public string IapTransactionId
		{
			[Address(RVA="0x1F898A4", Offset="0x1F898A4", VA="0x1F898A4")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F898AC", Offset="0x1F898AC", VA="0x1F898AC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C578", Offset="0x109C578")]
		public string IapValidationRequestBody
		{
			[Address(RVA="0x1F8991C", Offset="0x1F8991C", VA="0x1F8991C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F89924", Offset="0x1F89924", VA="0x1F89924")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C518", Offset="0x109C518")]
		public static MessageParser<BuyStoreItemRequest> Parser
		{
			[Address(RVA="0x1F89468", Offset="0x1F89468", VA="0x1F89468")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C538", Offset="0x109C538")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F895C0", Offset="0x1F895C0", VA="0x1F895C0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C548", Offset="0x109C548")]
		public ulong StoreItemId
		{
			[Address(RVA="0x1F8981C", Offset="0x1F8981C", VA="0x1F8981C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F89824", Offset="0x1F89824", VA="0x1F89824")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C598", Offset="0x109C598")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x109C598", Offset="0x109C598")]
		public ulong StoreShelfId
		{
			[Address(RVA="0x1F899A8", Offset="0x1F899A8", VA="0x1F899A8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F899B0", Offset="0x1F899B0", VA="0x1F899B0")]
			set
			{
			}
		}

		[Address(RVA="0x1F8A7C0", Offset="0x1F8A7C0", VA="0x1F8A7C0")]
		static BuyStoreItemRequest()
		{
		}

		[Address(RVA="0x1F8961C", Offset="0x1F8961C", VA="0x1F8961C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10885DC", Offset="0x10885DC")]
		public BuyStoreItemRequest()
		{
		}

		[Address(RVA="0x1F8967C", Offset="0x1F8967C", VA="0x1F8967C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10885EC", Offset="0x10885EC")]
		public BuyStoreItemRequest(BuyStoreItemRequest other)
		{
		}

		[Address(RVA="0x1F8A200", Offset="0x1F8A200", VA="0x1F8A200", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108865C", Offset="0x108865C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F897BC", Offset="0x1F897BC", VA="0x1F897BC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10885FC", Offset="0x10885FC")]
		public BuyStoreItemRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1F89A54", Offset="0x1F89A54", VA="0x1F89A54", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108860C", Offset="0x108860C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F89AC8", Offset="0x1F89AC8", VA="0x1F89AC8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108861C", Offset="0x108861C")]
		public bool Equals(BuyStoreItemRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1F89BD8", Offset="0x1F89BD8", VA="0x1F89BD8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108862C", Offset="0x108862C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F8A498", Offset="0x1F8A498", VA="0x1F8A498", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108866C", Offset="0x108866C")]
		public void MergeFrom(BuyStoreItemRequest other)
		{
		}

		[Address(RVA="0x1F8A5C4", Offset="0x1F8A5C4", VA="0x1F8A5C4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108867C", Offset="0x108867C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F89DD0", Offset="0x1F89DD0", VA="0x1F89DD0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108863C", Offset="0x108863C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F89E38", Offset="0x1F89E38", VA="0x1F89E38", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108864C", Offset="0x108864C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050AC8", Offset="0x1050AC8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BuyStoreItemRequest.<>c <>9;

			[Address(RVA="0x1F8A898", Offset="0x1F8A898", VA="0x1F8A898")]
			static <>c()
			{
			}

			[Address(RVA="0x1F8A8FC", Offset="0x1F8A8FC", VA="0x1F8A8FC")]
			public <>c()
			{
			}

			[Address(RVA="0x1F8A904", Offset="0x1F8A904", VA="0x1F8A904")]
			internal BuyStoreItemRequest <.cctor>b__65_0()
			{
				return null;
			}
		}
	}
}