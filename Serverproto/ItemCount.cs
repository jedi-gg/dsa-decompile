using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ItemCount : IMessage<ItemCount>, IMessage, IEquatable<ItemCount>, IDeepCloneable<ItemCount>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ItemCount> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ItemIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong itemId_;

		[FieldOffset(Offset="0x0")]
		public const int CountFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private ulong count_;

		[FieldOffset(Offset="0x0")]
		public const int LootTagFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private Serverproto.LootTag lootTag_;

		[FieldOffset(Offset="0x0")]
		public const int GuaranteedFieldNumber = 4;

		[FieldOffset(Offset="0x2C")]
		private bool guaranteed_;

		[FieldOffset(Offset="0x0")]
		public const int VipExclusiveFieldNumber = 5;

		[FieldOffset(Offset="0x2D")]
		private bool vipExclusive_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096750", Offset="0x1096750")]
		public ulong Count
		{
			[Address(RVA="0x1A90EC4", Offset="0x1A90EC4", VA="0x1A90EC4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A90ECC", Offset="0x1A90ECC", VA="0x1A90ECC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096720", Offset="0x1096720")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A90C2C", Offset="0x1A90C2C", VA="0x1A90C2C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096770", Offset="0x1096770")]
		public bool Guaranteed
		{
			[Address(RVA="0x1A90EE4", Offset="0x1A90EE4", VA="0x1A90EE4")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A90EEC", Offset="0x1A90EEC", VA="0x1A90EEC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096740", Offset="0x1096740")]
		public ulong ItemId
		{
			[Address(RVA="0x1A90EB4", Offset="0x1A90EB4", VA="0x1A90EB4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A90EBC", Offset="0x1A90EBC", VA="0x1A90EBC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096760", Offset="0x1096760")]
		public Serverproto.LootTag LootTag
		{
			[Address(RVA="0x1A90ED4", Offset="0x1A90ED4", VA="0x1A90ED4")]
			get
			{
				return new Serverproto.LootTag();
			}
			[Address(RVA="0x1A90EDC", Offset="0x1A90EDC", VA="0x1A90EDC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096710", Offset="0x1096710")]
		public static MessageParser<ItemCount> Parser
		{
			[Address(RVA="0x1A90BC4", Offset="0x1A90BC4", VA="0x1A90BC4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096730", Offset="0x1096730")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A90D1C", Offset="0x1A90D1C", VA="0x1A90D1C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096780", Offset="0x1096780")]
		public bool VipExclusive
		{
			[Address(RVA="0x1A90EF8", Offset="0x1A90EF8", VA="0x1A90EF8")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A90F00", Offset="0x1A90F00", VA="0x1A90F00")]
			set
			{
			}
		}

		[Address(RVA="0x1A91648", Offset="0x1A91648", VA="0x1A91648")]
		static ItemCount()
		{
		}

		[Address(RVA="0x1A90D78", Offset="0x1A90D78", VA="0x1A90D78")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EB9C", Offset="0x107EB9C")]
		public ItemCount()
		{
		}

		[Address(RVA="0x1A90D80", Offset="0x1A90D80", VA="0x1A90D80")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EBAC", Offset="0x107EBAC")]
		public ItemCount(ItemCount other)
		{
		}

		[Address(RVA="0x1A91374", Offset="0x1A91374", VA="0x1A91374", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EC1C", Offset="0x107EC1C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A90E54", Offset="0x1A90E54", VA="0x1A90E54", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EBBC", Offset="0x107EBBC")]
		public ItemCount Clone()
		{
			return null;
		}

		[Address(RVA="0x1A90F0C", Offset="0x1A90F0C", VA="0x1A90F0C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EBCC", Offset="0x107EBCC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A90F80", Offset="0x1A90F80", VA="0x1A90F80", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EBDC", Offset="0x107EBDC")]
		public bool Equals(ItemCount other)
		{
			return new bool();
		}

		[Address(RVA="0x1A9101C", Offset="0x1A9101C", VA="0x1A9101C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EBEC", Offset="0x107EBEC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A914AC", Offset="0x1A914AC", VA="0x1A914AC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EC2C", Offset="0x107EC2C")]
		public void MergeFrom(ItemCount other)
		{
		}

		[Address(RVA="0x1A9151C", Offset="0x1A9151C", VA="0x1A9151C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EC3C", Offset="0x107EC3C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A91104", Offset="0x1A91104", VA="0x1A91104", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EBFC", Offset="0x107EBFC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A9116C", Offset="0x1A9116C", VA="0x1A9116C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EC0C", Offset="0x107EC0C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FCB8", Offset="0x104FCB8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ItemCount.<>c <>9;

			[Address(RVA="0x1A91720", Offset="0x1A91720", VA="0x1A91720")]
			static <>c()
			{
			}

			[Address(RVA="0x1A91784", Offset="0x1A91784", VA="0x1A91784")]
			public <>c()
			{
			}

			[Address(RVA="0x1A9178C", Offset="0x1A9178C", VA="0x1A9178C")]
			internal ItemCount <.cctor>b__45_0()
			{
				return null;
			}
		}
	}
}