using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class IapCatalogResponse : IMessage<IapCatalogResponse>, IMessage, IEquatable<IapCatalogResponse>, IDeepCloneable<IapCatalogResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<IapCatalogResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int ProductsFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<IapCatalogEntry> _repeated_products_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<IapCatalogEntry> products_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CA48", Offset="0x109CA48")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18D9BD8", Offset="0x18D9BD8", VA="0x18D9BD8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CA38", Offset="0x109CA38")]
		public static MessageParser<IapCatalogResponse> Parser
		{
			[Address(RVA="0x18D9B70", Offset="0x18D9B70", VA="0x18D9B70")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CA58", Offset="0x109CA58")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18D9CC8", Offset="0x18D9CC8", VA="0x18D9CC8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CA68", Offset="0x109CA68")]
		public RepeatedField<IapCatalogEntry> Products
		{
			[Address(RVA="0x18D9E8C", Offset="0x18D9E8C", VA="0x18D9E8C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18DA374", Offset="0x18DA374", VA="0x18DA374")]
		static IapCatalogResponse()
		{
		}

		[Address(RVA="0x18D9D24", Offset="0x18D9D24", VA="0x18D9D24")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088ECC", Offset="0x1088ECC")]
		public IapCatalogResponse()
		{
		}

		[Address(RVA="0x18D9D94", Offset="0x18D9D94", VA="0x18D9D94")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088EDC", Offset="0x1088EDC")]
		public IapCatalogResponse(IapCatalogResponse other)
		{
		}

		[Address(RVA="0x18DA144", Offset="0x18DA144", VA="0x18DA144", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088F4C", Offset="0x1088F4C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18D9E2C", Offset="0x18D9E2C", VA="0x18D9E2C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088EEC", Offset="0x1088EEC")]
		public IapCatalogResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x18D9E94", Offset="0x18D9E94", VA="0x18D9E94", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088EFC", Offset="0x1088EFC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18D9F08", Offset="0x18D9F08", VA="0x18D9F08", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088F0C", Offset="0x1088F0C")]
		public bool Equals(IapCatalogResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x18D9FB8", Offset="0x18D9FB8", VA="0x18D9FB8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088F1C", Offset="0x1088F1C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18DA200", Offset="0x18DA200", VA="0x18DA200", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088F5C", Offset="0x1088F5C")]
		public void MergeFrom(IapCatalogResponse other)
		{
		}

		[Address(RVA="0x18DA290", Offset="0x18DA290", VA="0x18DA290", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088F6C", Offset="0x1088F6C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18DA018", Offset="0x18DA018", VA="0x18DA018", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088F2C", Offset="0x1088F2C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18DA080", Offset="0x18DA080", VA="0x18DA080", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088F3C", Offset="0x1088F3C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050B98", Offset="0x1050B98")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static IapCatalogResponse.<>c <>9;

			[Address(RVA="0x18DA494", Offset="0x18DA494", VA="0x18DA494")]
			static <>c()
			{
			}

			[Address(RVA="0x18DA4F8", Offset="0x18DA4F8", VA="0x18DA4F8")]
			public <>c()
			{
			}

			[Address(RVA="0x18DA500", Offset="0x18DA500", VA="0x18DA500")]
			internal IapCatalogResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}