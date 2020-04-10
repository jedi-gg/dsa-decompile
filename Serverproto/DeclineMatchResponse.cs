using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class DeclineMatchResponse : IMessage<DeclineMatchResponse>, IMessage, IEquatable<DeclineMatchResponse>, IDeepCloneable<DeclineMatchResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<DeclineMatchResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10923D8", Offset="0x10923D8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EF9820", Offset="0x1EF9820", VA="0x1EF9820")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10923C8", Offset="0x10923C8")]
		public static MessageParser<DeclineMatchResponse> Parser
		{
			[Address(RVA="0x1EF97B8", Offset="0x1EF97B8", VA="0x1EF97B8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10923E8", Offset="0x10923E8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EF9910", Offset="0x1EF9910", VA="0x1EF9910", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EF9C24", Offset="0x1EF9C24", VA="0x1EF9C24")]
		static DeclineMatchResponse()
		{
		}

		[Address(RVA="0x1EF996C", Offset="0x1EF996C", VA="0x1EF996C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10767EC", Offset="0x10767EC")]
		public DeclineMatchResponse()
		{
		}

		[Address(RVA="0x1EF9974", Offset="0x1EF9974", VA="0x1EF9974")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10767FC", Offset="0x10767FC")]
		public DeclineMatchResponse(DeclineMatchResponse other)
		{
		}

		[Address(RVA="0x1EF9B88", Offset="0x1EF9B88", VA="0x1EF9B88", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107686C", Offset="0x107686C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EF99B8", Offset="0x1EF99B8", VA="0x1EF99B8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107680C", Offset="0x107680C")]
		public DeclineMatchResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1EF9A18", Offset="0x1EF9A18", VA="0x1EF9A18", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107681C", Offset="0x107681C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF9AB0", Offset="0x1EF9AB0", VA="0x1EF9AB0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107682C", Offset="0x107682C")]
		public bool Equals(DeclineMatchResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF9ADC", Offset="0x1EF9ADC", VA="0x1EF9ADC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107683C", Offset="0x107683C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EF9B9C", Offset="0x1EF9B9C", VA="0x1EF9B9C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107687C", Offset="0x107687C")]
		public void MergeFrom(DeclineMatchResponse other)
		{
		}

		[Address(RVA="0x1EF9BD0", Offset="0x1EF9BD0", VA="0x1EF9BD0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107688C", Offset="0x107688C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EF9B0C", Offset="0x1EF9B0C", VA="0x1EF9B0C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107684C", Offset="0x107684C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EF9B74", Offset="0x1EF9B74", VA="0x1EF9B74", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107685C", Offset="0x107685C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F078", Offset="0x104F078")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DeclineMatchResponse.<>c <>9;

			[Address(RVA="0x1EF9CFC", Offset="0x1EF9CFC", VA="0x1EF9CFC")]
			static <>c()
			{
			}

			[Address(RVA="0x1EF9D60", Offset="0x1EF9D60", VA="0x1EF9D60")]
			public <>c()
			{
			}

			[Address(RVA="0x1EF9D68", Offset="0x1EF9D68", VA="0x1EF9D68")]
			internal DeclineMatchResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}