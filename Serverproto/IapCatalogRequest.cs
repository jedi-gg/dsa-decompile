using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class IapCatalogRequest : IMessage<IapCatalogRequest>, IMessage, IEquatable<IapCatalogRequest>, IDeepCloneable<IapCatalogRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<IapCatalogRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CA18", Offset="0x109CA18")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18D95CC", Offset="0x18D95CC", VA="0x18D95CC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CA08", Offset="0x109CA08")]
		public static MessageParser<IapCatalogRequest> Parser
		{
			[Address(RVA="0x18D9564", Offset="0x18D9564", VA="0x18D9564")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109CA28", Offset="0x109CA28")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18D96BC", Offset="0x18D96BC", VA="0x18D96BC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18D99D0", Offset="0x18D99D0", VA="0x18D99D0")]
		static IapCatalogRequest()
		{
		}

		[Address(RVA="0x18D9718", Offset="0x18D9718", VA="0x18D9718")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088E1C", Offset="0x1088E1C")]
		public IapCatalogRequest()
		{
		}

		[Address(RVA="0x18D9720", Offset="0x18D9720", VA="0x18D9720")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088E2C", Offset="0x1088E2C")]
		public IapCatalogRequest(IapCatalogRequest other)
		{
		}

		[Address(RVA="0x18D9934", Offset="0x18D9934", VA="0x18D9934", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088E9C", Offset="0x1088E9C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18D9764", Offset="0x18D9764", VA="0x18D9764", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088E3C", Offset="0x1088E3C")]
		public IapCatalogRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x18D97C4", Offset="0x18D97C4", VA="0x18D97C4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088E4C", Offset="0x1088E4C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18D985C", Offset="0x18D985C", VA="0x18D985C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088E5C", Offset="0x1088E5C")]
		public bool Equals(IapCatalogRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x18D9888", Offset="0x18D9888", VA="0x18D9888", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088E6C", Offset="0x1088E6C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18D9948", Offset="0x18D9948", VA="0x18D9948", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088EAC", Offset="0x1088EAC")]
		public void MergeFrom(IapCatalogRequest other)
		{
		}

		[Address(RVA="0x18D997C", Offset="0x18D997C", VA="0x18D997C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088EBC", Offset="0x1088EBC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18D98B8", Offset="0x18D98B8", VA="0x18D98B8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088E7C", Offset="0x1088E7C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18D9920", Offset="0x18D9920", VA="0x18D9920", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1088E8C", Offset="0x1088E8C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050B88", Offset="0x1050B88")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static IapCatalogRequest.<>c <>9;

			[Address(RVA="0x18D9AA8", Offset="0x18D9AA8", VA="0x18D9AA8")]
			static <>c()
			{
			}

			[Address(RVA="0x18D9B0C", Offset="0x18D9B0C", VA="0x18D9B0C")]
			public <>c()
			{
			}

			[Address(RVA="0x18D9B14", Offset="0x18D9B14", VA="0x18D9B14")]
			internal IapCatalogRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}