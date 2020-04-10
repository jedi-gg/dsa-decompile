using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ItemCountRange : IMessage<ItemCountRange>, IMessage, IEquatable<ItemCountRange>, IDeepCloneable<ItemCountRange>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ItemCountRange> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ItemIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong itemId_;

		[FieldOffset(Offset="0x0")]
		public const int CountMinFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private uint countMin_;

		[FieldOffset(Offset="0x0")]
		public const int CountMaxFieldNumber = 3;

		[FieldOffset(Offset="0x24")]
		private uint countMax_;

		[FieldOffset(Offset="0x0")]
		public const int LootTagFieldNumber = 4;

		[FieldOffset(Offset="0x28")]
		private Serverproto.LootTag lootTag_;

		[FieldOffset(Offset="0x0")]
		public const int GuaranteedFieldNumber = 5;

		[FieldOffset(Offset="0x2C")]
		private bool guaranteed_;

		[FieldOffset(Offset="0x0")]
		public const int VipExclusiveFieldNumber = 6;

		[FieldOffset(Offset="0x2D")]
		private bool vipExclusive_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10967E0", Offset="0x10967E0")]
		public uint CountMax
		{
			[Address(RVA="0x1A91B14", Offset="0x1A91B14", VA="0x1A91B14")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x1A91B1C", Offset="0x1A91B1C", VA="0x1A91B1C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10967D0", Offset="0x10967D0")]
		public uint CountMin
		{
			[Address(RVA="0x1A91B04", Offset="0x1A91B04", VA="0x1A91B04")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x1A91B0C", Offset="0x1A91B0C", VA="0x1A91B0C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10967A0", Offset="0x10967A0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A91850", Offset="0x1A91850", VA="0x1A91850")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096800", Offset="0x1096800")]
		public bool Guaranteed
		{
			[Address(RVA="0x1A91B34", Offset="0x1A91B34", VA="0x1A91B34")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A91B3C", Offset="0x1A91B3C", VA="0x1A91B3C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10967C0", Offset="0x10967C0")]
		public ulong ItemId
		{
			[Address(RVA="0x1A91AF4", Offset="0x1A91AF4", VA="0x1A91AF4")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A91AFC", Offset="0x1A91AFC", VA="0x1A91AFC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10967F0", Offset="0x10967F0")]
		public Serverproto.LootTag LootTag
		{
			[Address(RVA="0x1A91B24", Offset="0x1A91B24", VA="0x1A91B24")]
			get
			{
				return new Serverproto.LootTag();
			}
			[Address(RVA="0x1A91B2C", Offset="0x1A91B2C", VA="0x1A91B2C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096790", Offset="0x1096790")]
		public static MessageParser<ItemCountRange> Parser
		{
			[Address(RVA="0x1A917E8", Offset="0x1A917E8", VA="0x1A917E8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10967B0", Offset="0x10967B0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A91940", Offset="0x1A91940", VA="0x1A91940", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1096810", Offset="0x1096810")]
		public bool VipExclusive
		{
			[Address(RVA="0x1A91B48", Offset="0x1A91B48", VA="0x1A91B48")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A91B50", Offset="0x1A91B50", VA="0x1A91B50")]
			set
			{
			}
		}

		[Address(RVA="0x1A92388", Offset="0x1A92388", VA="0x1A92388")]
		static ItemCountRange()
		{
		}

		[Address(RVA="0x1A9199C", Offset="0x1A9199C", VA="0x1A9199C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EC4C", Offset="0x107EC4C")]
		public ItemCountRange()
		{
		}

		[Address(RVA="0x1A919A4", Offset="0x1A919A4", VA="0x1A919A4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EC5C", Offset="0x107EC5C")]
		public ItemCountRange(ItemCountRange other)
		{
		}

		[Address(RVA="0x1A92044", Offset="0x1A92044", VA="0x1A92044", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ECCC", Offset="0x107ECCC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A91A94", Offset="0x1A91A94", VA="0x1A91A94", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EC6C", Offset="0x107EC6C")]
		public ItemCountRange Clone()
		{
			return null;
		}

		[Address(RVA="0x1A91B5C", Offset="0x1A91B5C", VA="0x1A91B5C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EC7C", Offset="0x107EC7C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A91BD0", Offset="0x1A91BD0", VA="0x1A91BD0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EC8C", Offset="0x107EC8C")]
		public bool Equals(ItemCountRange other)
		{
			return new bool();
		}

		[Address(RVA="0x1A91C7C", Offset="0x1A91C7C", VA="0x1A91C7C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107EC9C", Offset="0x107EC9C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A921B8", Offset="0x1A921B8", VA="0x1A921B8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ECDC", Offset="0x107ECDC")]
		public void MergeFrom(ItemCountRange other)
		{
		}

		[Address(RVA="0x1A92234", Offset="0x1A92234", VA="0x1A92234", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ECEC", Offset="0x107ECEC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A91D7C", Offset="0x1A91D7C", VA="0x1A91D7C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ECAC", Offset="0x107ECAC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A91DE4", Offset="0x1A91DE4", VA="0x1A91DE4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107ECBC", Offset="0x107ECBC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FCC8", Offset="0x104FCC8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ItemCountRange.<>c <>9;

			[Address(RVA="0x1A92460", Offset="0x1A92460", VA="0x1A92460")]
			static <>c()
			{
			}

			[Address(RVA="0x1A924C4", Offset="0x1A924C4", VA="0x1A924C4")]
			public <>c()
			{
			}

			[Address(RVA="0x1A924CC", Offset="0x1A924CC", VA="0x1A924CC")]
			internal ItemCountRange <.cctor>b__50_0()
			{
				return null;
			}
		}
	}
}