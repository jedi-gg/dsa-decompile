using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ItemFindTower : IMessage<ItemFindTower>, IMessage, IEquatable<ItemFindTower>, IDeepCloneable<ItemFindTower>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ItemFindTower> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int TowerIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private TowerIdentifier towerId_;

		[FieldOffset(Offset="0x0")]
		public const int TowerNameFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string towerName_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098F40", Offset="0x1098F40")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A962B8", Offset="0x1A962B8", VA="0x1A962B8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098F30", Offset="0x1098F30")]
		public static MessageParser<ItemFindTower> Parser
		{
			[Address(RVA="0x1A906EC", Offset="0x1A906EC", VA="0x1A906EC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098F50", Offset="0x1098F50")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A963A4", Offset="0x1A963A4", VA="0x1A963A4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098F60", Offset="0x1098F60")]
		public TowerIdentifier TowerId
		{
			[Address(RVA="0x1A964D8", Offset="0x1A964D8", VA="0x1A964D8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A964E0", Offset="0x1A964E0", VA="0x1A964E0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098F70", Offset="0x1098F70")]
		public string TowerName
		{
			[Address(RVA="0x1A96548", Offset="0x1A96548", VA="0x1A96548")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A96550", Offset="0x1A96550", VA="0x1A96550")]
			set
			{
			}
		}

		[Address(RVA="0x1A96BA4", Offset="0x1A96BA4", VA="0x1A96BA4")]
		static ItemFindTower()
		{
		}

		[Address(RVA="0x1A96400", Offset="0x1A96400", VA="0x1A96400")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10824AC", Offset="0x10824AC")]
		public ItemFindTower()
		{
		}

		[Address(RVA="0x1A96458", Offset="0x1A96458", VA="0x1A96458")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10824BC", Offset="0x10824BC")]
		public ItemFindTower(ItemFindTower other)
		{
		}

		[Address(RVA="0x1A968C8", Offset="0x1A968C8", VA="0x1A968C8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108252C", Offset="0x108252C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A964E8", Offset="0x1A964E8", VA="0x1A964E8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10824CC", Offset="0x10824CC")]
		public ItemFindTower Clone()
		{
			return null;
		}

		[Address(RVA="0x1A965C0", Offset="0x1A965C0", VA="0x1A965C0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10824DC", Offset="0x10824DC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A96634", Offset="0x1A96634", VA="0x1A96634", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10824EC", Offset="0x10824EC")]
		public bool Equals(ItemFindTower other)
		{
			return new bool();
		}

		[Address(RVA="0x1A966AC", Offset="0x1A966AC", VA="0x1A966AC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10824FC", Offset="0x10824FC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A969B8", Offset="0x1A969B8", VA="0x1A969B8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108253C", Offset="0x108253C")]
		public void MergeFrom(ItemFindTower other)
		{
		}

		[Address(RVA="0x1A96A98", Offset="0x1A96A98", VA="0x1A96A98", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108254C", Offset="0x108254C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A96750", Offset="0x1A96750", VA="0x1A96750", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108250C", Offset="0x108250C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A967B8", Offset="0x1A967B8", VA="0x1A967B8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108251C", Offset="0x108251C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10501E8", Offset="0x10501E8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ItemFindTower.<>c <>9;

			[Address(RVA="0x1A96C7C", Offset="0x1A96C7C", VA="0x1A96C7C")]
			static <>c()
			{
			}

			[Address(RVA="0x1A96CE0", Offset="0x1A96CE0", VA="0x1A96CE0")]
			public <>c()
			{
			}

			[Address(RVA="0x1A96CE8", Offset="0x1A96CE8", VA="0x1A96CE8")]
			internal ItemFindTower <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}