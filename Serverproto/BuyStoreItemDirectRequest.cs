using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BuyStoreItemDirectRequest : IMessage<BuyStoreItemDirectRequest>, IMessage, IEquatable<BuyStoreItemDirectRequest>, IDeepCloneable<BuyStoreItemDirectRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BuyStoreItemDirectRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int StoreItemIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong storeItemId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CB68", Offset="0x109CB68")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F88494", Offset="0x1F88494", VA="0x1F88494")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CB58", Offset="0x109CB58")]
		public static MessageParser<BuyStoreItemDirectRequest> Parser
		{
			[Address(RVA="0x1F8842C", Offset="0x1F8842C", VA="0x1F8842C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CB78", Offset="0x109CB78")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F88584", Offset="0x1F88584", VA="0x1F88584", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CB88", Offset="0x109CB88")]
		public ulong StoreItemId
		{
			[Address(RVA="0x1F886AC", Offset="0x1F886AC", VA="0x1F886AC")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F886B4", Offset="0x1F886B4", VA="0x1F886B4")]
			set
			{
			}
		}

		[Address(RVA="0x1F88A28", Offset="0x1F88A28", VA="0x1F88A28")]
		static BuyStoreItemDirectRequest()
		{
		}

		[Address(RVA="0x1F885E0", Offset="0x1F885E0", VA="0x1F885E0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108918C", Offset="0x108918C")]
		public BuyStoreItemDirectRequest()
		{
		}

		[Address(RVA="0x1F885E8", Offset="0x1F885E8", VA="0x1F885E8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108919C", Offset="0x108919C")]
		public BuyStoreItemDirectRequest(BuyStoreItemDirectRequest other)
		{
		}

		[Address(RVA="0x1F888DC", Offset="0x1F888DC", VA="0x1F888DC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108920C", Offset="0x108920C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F8864C", Offset="0x1F8864C", VA="0x1F8864C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10891AC", Offset="0x10891AC")]
		public BuyStoreItemDirectRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1F886BC", Offset="0x1F886BC", VA="0x1F886BC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10891BC", Offset="0x10891BC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F88730", Offset="0x1F88730", VA="0x1F88730", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10891CC", Offset="0x10891CC")]
		public bool Equals(BuyStoreItemDirectRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1F8876C", Offset="0x1F8876C", VA="0x1F8876C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10891DC", Offset="0x10891DC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F8896C", Offset="0x1F8896C", VA="0x1F8896C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108921C", Offset="0x108921C")]
		public void MergeFrom(BuyStoreItemDirectRequest other)
		{
		}

		[Address(RVA="0x1F889AC", Offset="0x1F889AC", VA="0x1F889AC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108922C", Offset="0x108922C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F887D4", Offset="0x1F887D4", VA="0x1F887D4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10891EC", Offset="0x10891EC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F8883C", Offset="0x1F8883C", VA="0x1F8883C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10891FC", Offset="0x10891FC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050BD8", Offset="0x1050BD8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BuyStoreItemDirectRequest.<>c <>9;

			[Address(RVA="0x1F88B00", Offset="0x1F88B00", VA="0x1F88B00")]
			static <>c()
			{
			}

			[Address(RVA="0x1F88B64", Offset="0x1F88B64", VA="0x1F88B64")]
			public <>c()
			{
			}

			[Address(RVA="0x1F88B6C", Offset="0x1F88B6C", VA="0x1F88B6C")]
			internal BuyStoreItemDirectRequest <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}