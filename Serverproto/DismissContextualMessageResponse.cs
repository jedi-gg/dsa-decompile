using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class DismissContextualMessageResponse : IMessage<DismissContextualMessageResponse>, IMessage, IEquatable<DismissContextualMessageResponse>, IDeepCloneable<DismissContextualMessageResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<DismissContextualMessageResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B090", Offset="0x109B090")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FBC30C", Offset="0x1FBC30C", VA="0x1FBC30C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B080", Offset="0x109B080")]
		public static MessageParser<DismissContextualMessageResponse> Parser
		{
			[Address(RVA="0x1FBC2A4", Offset="0x1FBC2A4", VA="0x1FBC2A4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109B0A0", Offset="0x109B0A0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FBC3FC", Offset="0x1FBC3FC", VA="0x1FBC3FC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1FBC710", Offset="0x1FBC710", VA="0x1FBC710")]
		static DismissContextualMessageResponse()
		{
		}

		[Address(RVA="0x1FBC458", Offset="0x1FBC458", VA="0x1FBC458")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108637C", Offset="0x108637C")]
		public DismissContextualMessageResponse()
		{
		}

		[Address(RVA="0x1FBC460", Offset="0x1FBC460", VA="0x1FBC460")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108638C", Offset="0x108638C")]
		public DismissContextualMessageResponse(DismissContextualMessageResponse other)
		{
		}

		[Address(RVA="0x1FBC674", Offset="0x1FBC674", VA="0x1FBC674", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10863FC", Offset="0x10863FC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FBC4A4", Offset="0x1FBC4A4", VA="0x1FBC4A4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108639C", Offset="0x108639C")]
		public DismissContextualMessageResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1FBC504", Offset="0x1FBC504", VA="0x1FBC504", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10863AC", Offset="0x10863AC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBC59C", Offset="0x1FBC59C", VA="0x1FBC59C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10863BC", Offset="0x10863BC")]
		public bool Equals(DismissContextualMessageResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1FBC5C8", Offset="0x1FBC5C8", VA="0x1FBC5C8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10863CC", Offset="0x10863CC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FBC688", Offset="0x1FBC688", VA="0x1FBC688", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108640C", Offset="0x108640C")]
		public void MergeFrom(DismissContextualMessageResponse other)
		{
		}

		[Address(RVA="0x1FBC6BC", Offset="0x1FBC6BC", VA="0x1FBC6BC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108641C", Offset="0x108641C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FBC5F8", Offset="0x1FBC5F8", VA="0x1FBC5F8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10863DC", Offset="0x10863DC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FBC660", Offset="0x1FBC660", VA="0x1FBC660", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10863EC", Offset="0x10863EC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050798", Offset="0x1050798")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DismissContextualMessageResponse.<>c <>9;

			[Address(RVA="0x1FBC7E8", Offset="0x1FBC7E8", VA="0x1FBC7E8")]
			static <>c()
			{
			}

			[Address(RVA="0x1FBC84C", Offset="0x1FBC84C", VA="0x1FBC84C")]
			public <>c()
			{
			}

			[Address(RVA="0x1FBC854", Offset="0x1FBC854", VA="0x1FBC854")]
			internal DismissContextualMessageResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}