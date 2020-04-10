using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class IapCatalogEntry : IMessage<IapCatalogEntry>, IMessage, IEquatable<IapCatalogEntry>, IDeepCloneable<IapCatalogEntry>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<IapCatalogEntry> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ProductIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string productId_;

		[FieldOffset(Offset="0x0")]
		public const int PriceUsdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private float priceUsd_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CA88", Offset="0x109CA88")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18D8ACC", Offset="0x18D8ACC", VA="0x18D8ACC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CA78", Offset="0x109CA78")]
		public static MessageParser<IapCatalogEntry> Parser
		{
			[Address(RVA="0x18D8A64", Offset="0x18D8A64", VA="0x18D8A64")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CA98", Offset="0x109CA98")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18D8BBC", Offset="0x18D8BBC", VA="0x18D8BBC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CAB8", Offset="0x109CAB8")]
		public float PriceUsd
		{
			[Address(RVA="0x18D8DC4", Offset="0x18D8DC4", VA="0x18D8DC4")]
			get
			{
				return new float();
			}
			[Address(RVA="0x18D8DCC", Offset="0x18D8DCC", VA="0x18D8DCC")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CAA8", Offset="0x109CAA8")]
		public string ProductId
		{
			[Address(RVA="0x18D8D4C", Offset="0x18D8D4C", VA="0x18D8D4C")]
			get
			{
				return null;
			}
			[Address(RVA="0x18D8D54", Offset="0x18D8D54", VA="0x18D8D54")]
			set
			{
			}
		}

		[Address(RVA="0x18D93C8", Offset="0x18D93C8", VA="0x18D93C8")]
		static IapCatalogEntry()
		{
		}

		[Address(RVA="0x18D8C18", Offset="0x18D8C18", VA="0x18D8C18")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088F7C", Offset="0x1088F7C")]
		public IapCatalogEntry()
		{
		}

		[Address(RVA="0x18D8C70", Offset="0x18D8C70", VA="0x18D8C70")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088F8C", Offset="0x1088F8C")]
		public IapCatalogEntry(IapCatalogEntry other)
		{
		}

		[Address(RVA="0x18D91DC", Offset="0x18D91DC", VA="0x18D91DC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088FFC", Offset="0x1088FFC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18D8CEC", Offset="0x18D8CEC", VA="0x18D8CEC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088F9C", Offset="0x1088F9C")]
		public IapCatalogEntry Clone()
		{
			return null;
		}

		[Address(RVA="0x18D8DD4", Offset="0x18D8DD4", VA="0x18D8DD4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088FAC", Offset="0x1088FAC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18D8E48", Offset="0x18D8E48", VA="0x18D8E48", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088FBC", Offset="0x1088FBC")]
		public bool Equals(IapCatalogEntry other)
		{
			return new bool();
		}

		[Address(RVA="0x18D8F40", Offset="0x18D8F40", VA="0x18D8F40", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088FCC", Offset="0x1088FCC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18D92A0", Offset="0x18D92A0", VA="0x18D92A0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108900C", Offset="0x108900C")]
		public void MergeFrom(IapCatalogEntry other)
		{
		}

		[Address(RVA="0x18D931C", Offset="0x18D931C", VA="0x18D931C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108901C", Offset="0x108901C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18D9054", Offset="0x18D9054", VA="0x18D9054", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088FDC", Offset="0x1088FDC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18D90BC", Offset="0x18D90BC", VA="0x18D90BC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088FEC", Offset="0x1088FEC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050BA8", Offset="0x1050BA8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static IapCatalogEntry.<>c <>9;

			[Address(RVA="0x18D94A0", Offset="0x18D94A0", VA="0x18D94A0")]
			static <>c()
			{
			}

			[Address(RVA="0x18D9504", Offset="0x18D9504", VA="0x18D9504")]
			public <>c()
			{
			}

			[Address(RVA="0x18D950C", Offset="0x18D950C", VA="0x18D950C")]
			internal IapCatalogEntry <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}