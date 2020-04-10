using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class StoreItemGrantOption : IMessage<StoreItemGrantOption>, IMessage, IEquatable<StoreItemGrantOption>, IDeepCloneable<StoreItemGrantOption>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<StoreItemGrantOption> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ItemFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ItemCountRange item_;

		[FieldOffset(Offset="0x0")]
		public const int PercentChanceFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private float percentChance_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C8E8", Offset="0x109C8E8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BDF764", Offset="0x1BDF764", VA="0x1BDF764")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C908", Offset="0x109C908")]
		public ItemCountRange Item
		{
			[Address(RVA="0x1BDF93C", Offset="0x1BDF93C", VA="0x1BDF93C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1BDF944", Offset="0x1BDF944", VA="0x1BDF944")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C8D8", Offset="0x109C8D8")]
		public static MessageParser<StoreItemGrantOption> Parser
		{
			[Address(RVA="0x1BDF638", Offset="0x1BDF638", VA="0x1BDF638")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C8F8", Offset="0x109C8F8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BDF854", Offset="0x1BDF854", VA="0x1BDF854", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109C918", Offset="0x109C918")]
		public float PercentChance
		{
			[Address(RVA="0x1BDF9AC", Offset="0x1BDF9AC", VA="0x1BDF9AC")]
			get
			{
				return new float();
			}
			[Address(RVA="0x1BDF9B4", Offset="0x1BDF9B4", VA="0x1BDF9B4")]
			set
			{
			}
		}

		[Address(RVA="0x1BDFFF0", Offset="0x1BDFFF0", VA="0x1BDFFF0")]
		static StoreItemGrantOption()
		{
		}

		[Address(RVA="0x1BDF8B0", Offset="0x1BDF8B0", VA="0x1BDF8B0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088C0C", Offset="0x1088C0C")]
		public StoreItemGrantOption()
		{
		}

		[Address(RVA="0x1BDF8B8", Offset="0x1BDF8B8", VA="0x1BDF8B8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088C1C", Offset="0x1088C1C")]
		public StoreItemGrantOption(StoreItemGrantOption other)
		{
		}

		[Address(RVA="0x1BDFD80", Offset="0x1BDFD80", VA="0x1BDFD80", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088C8C", Offset="0x1088C8C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BDF94C", Offset="0x1BDF94C", VA="0x1BDF94C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088C2C", Offset="0x1088C2C")]
		public StoreItemGrantOption Clone()
		{
			return null;
		}

		[Address(RVA="0x1BDF9BC", Offset="0x1BDF9BC", VA="0x1BDF9BC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088C3C", Offset="0x1088C3C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BDFA30", Offset="0x1BDFA30", VA="0x1BDFA30", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088C4C", Offset="0x1088C4C")]
		public bool Equals(StoreItemGrantOption other)
		{
			return new bool();
		}

		[Address(RVA="0x1BDFB28", Offset="0x1BDFB28", VA="0x1BDFB28", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088C5C", Offset="0x1088C5C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BDFE28", Offset="0x1BDFE28", VA="0x1BDFE28", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088C9C", Offset="0x1088C9C")]
		public void MergeFrom(StoreItemGrantOption other)
		{
		}

		[Address(RVA="0x1BDFEEC", Offset="0x1BDFEEC", VA="0x1BDFEEC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088CAC", Offset="0x1088CAC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BDFC10", Offset="0x1BDFC10", VA="0x1BDFC10", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088C6C", Offset="0x1088C6C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BDFC78", Offset="0x1BDFC78", VA="0x1BDFC78", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088C7C", Offset="0x1088C7C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050B58", Offset="0x1050B58")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static StoreItemGrantOption.<>c <>9;

			[Address(RVA="0x1BE00C8", Offset="0x1BE00C8", VA="0x1BE00C8")]
			static <>c()
			{
			}

			[Address(RVA="0x1BE012C", Offset="0x1BE012C", VA="0x1BE012C")]
			public <>c()
			{
			}

			[Address(RVA="0x1BE0134", Offset="0x1BE0134", VA="0x1BE0134")]
			internal StoreItemGrantOption <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}