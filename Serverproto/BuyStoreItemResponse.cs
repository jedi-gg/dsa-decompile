using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BuyStoreItemResponse : IMessage<BuyStoreItemResponse>, IMessage, IEquatable<BuyStoreItemResponse>, IDeepCloneable<BuyStoreItemResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BuyStoreItemResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InventoryDeltaFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.InventoryDelta inventoryDelta_;

		[FieldOffset(Offset="0x0")]
		public const int PurchaseLimitsFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private Serverproto.PurchaseLimits purchaseLimits_;

		[FieldOffset(Offset="0x0")]
		public const int NextFreeStoreItemTimestampFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong nextFreeStoreItemTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int ConversionsFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private Serverproto.InventoryDelta conversions_;

		[FieldOffset(Offset="0x0")]
		public const int TotalSpendFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private float totalSpend_;

		[FieldOffset(Offset="0x0")]
		public const int RefreshedStoreFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private StoreResponse refreshedStore_;

		[FieldOffset(Offset="0x0")]
		public const int IsSandboxEnvironmentFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private bool isSandboxEnvironment_;

		[FieldOffset(Offset="0x0")]
		public const int IsAFriendGiftFieldNumber = 8;

		[FieldOffset(Offset="0x49")]
		private bool isAFriendGift_;

		[FieldOffset(Offset="0x0")]
		public const int GiftedFriendIdFieldNumber = 9;

		[FieldOffset(Offset="0x50")]
		private string giftedFriendId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C660", Offset="0x109C660")]
		public Serverproto.InventoryDelta Conversions
		{
			[Address(RVA="0x1F8AC64", Offset="0x1F8AC64", VA="0x1F8AC64")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F8AC6C", Offset="0x1F8AC6C", VA="0x1F8AC6C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C610", Offset="0x109C610")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F8A9C4", Offset="0x1F8A9C4", VA="0x1F8A9C4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C6B0", Offset="0x109C6B0")]
		public string GiftedFriendId
		{
			[Address(RVA="0x1F8AD2C", Offset="0x1F8AD2C", VA="0x1F8AD2C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F8AD34", Offset="0x1F8AD34", VA="0x1F8AD34")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C630", Offset="0x109C630")]
		public Serverproto.InventoryDelta InventoryDelta
		{
			[Address(RVA="0x1F8AC44", Offset="0x1F8AC44", VA="0x1F8AC44")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F8AC4C", Offset="0x1F8AC4C", VA="0x1F8AC4C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C6A0", Offset="0x109C6A0")]
		public bool IsAFriendGift
		{
			[Address(RVA="0x1F8AD18", Offset="0x1F8AD18", VA="0x1F8AD18")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1F8AD20", Offset="0x1F8AD20", VA="0x1F8AD20")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C690", Offset="0x109C690")]
		public bool IsSandboxEnvironment
		{
			[Address(RVA="0x1F8AD04", Offset="0x1F8AD04", VA="0x1F8AD04")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1F8AD0C", Offset="0x1F8AD0C", VA="0x1F8AD0C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C650", Offset="0x109C650")]
		public ulong NextFreeStoreItemTimestamp
		{
			[Address(RVA="0x1F8ACE4", Offset="0x1F8ACE4", VA="0x1F8ACE4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F8ACEC", Offset="0x1F8ACEC", VA="0x1F8ACEC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C600", Offset="0x109C600")]
		public static MessageParser<BuyStoreItemResponse> Parser
		{
			[Address(RVA="0x1F8A95C", Offset="0x1F8A95C", VA="0x1F8A95C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C620", Offset="0x109C620")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F8AAB4", Offset="0x1F8AAB4", VA="0x1F8AAB4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C640", Offset="0x109C640")]
		public Serverproto.PurchaseLimits PurchaseLimits
		{
			[Address(RVA="0x1F8AC54", Offset="0x1F8AC54", VA="0x1F8AC54")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F8AC5C", Offset="0x1F8AC5C", VA="0x1F8AC5C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C680", Offset="0x109C680")]
		public StoreResponse RefreshedStore
		{
			[Address(RVA="0x1F8AC74", Offset="0x1F8AC74", VA="0x1F8AC74")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F8AC7C", Offset="0x1F8AC7C", VA="0x1F8AC7C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C670", Offset="0x109C670")]
		public float TotalSpend
		{
			[Address(RVA="0x1F8ACF4", Offset="0x1F8ACF4", VA="0x1F8ACF4")]
			get
			{
				return new float();
			}
			[Address(RVA="0x1F8ACFC", Offset="0x1F8ACFC", VA="0x1F8ACFC")]
			set
			{
			}
		}

		[Address(RVA="0x1F8BC18", Offset="0x1F8BC18", VA="0x1F8BC18")]
		static BuyStoreItemResponse()
		{
		}

		[Address(RVA="0x1F8AB10", Offset="0x1F8AB10", VA="0x1F8AB10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108868C", Offset="0x108868C")]
		public BuyStoreItemResponse()
		{
		}

		[Address(RVA="0x1F8AB68", Offset="0x1F8AB68", VA="0x1F8AB68")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108869C", Offset="0x108869C")]
		public BuyStoreItemResponse(BuyStoreItemResponse other)
		{
		}

		[Address(RVA="0x1F8B588", Offset="0x1F8B588", VA="0x1F8B588", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108870C", Offset="0x108870C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F8AC84", Offset="0x1F8AC84", VA="0x1F8AC84", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10886AC", Offset="0x10886AC")]
		public BuyStoreItemResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1F8ADA4", Offset="0x1F8ADA4", VA="0x1F8ADA4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10886BC", Offset="0x10886BC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F8AE18", Offset="0x1F8AE18", VA="0x1F8AE18", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10886CC", Offset="0x10886CC")]
		public bool Equals(BuyStoreItemResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1F8AFB0", Offset="0x1F8AFB0", VA="0x1F8AFB0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10886DC", Offset="0x10886DC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F8B7A0", Offset="0x1F8B7A0", VA="0x1F8B7A0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108871C", Offset="0x108871C")]
		public void MergeFrom(BuyStoreItemResponse other)
		{
		}

		[Address(RVA="0x1F8B9A4", Offset="0x1F8B9A4", VA="0x1F8B9A4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108872C", Offset="0x108872C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F8B190", Offset="0x1F8B190", VA="0x1F8B190", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10886EC", Offset="0x10886EC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F8B1F8", Offset="0x1F8B1F8", VA="0x1F8B1F8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10886FC", Offset="0x10886FC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050AD8", Offset="0x1050AD8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BuyStoreItemResponse.<>c <>9;

			[Address(RVA="0x1F8BCF0", Offset="0x1F8BCF0", VA="0x1F8BCF0")]
			static <>c()
			{
			}

			[Address(RVA="0x1F8BD54", Offset="0x1F8BD54", VA="0x1F8BD54")]
			public <>c()
			{
			}

			[Address(RVA="0x1F8BD5C", Offset="0x1F8BD5C", VA="0x1F8BD5C")]
			internal BuyStoreItemResponse <.cctor>b__65_0()
			{
				return null;
			}
		}
	}
}