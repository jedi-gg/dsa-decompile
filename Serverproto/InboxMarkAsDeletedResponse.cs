using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InboxMarkAsDeletedResponse : IMessage<InboxMarkAsDeletedResponse>, IMessage, IEquatable<InboxMarkAsDeletedResponse>, IDeepCloneable<InboxMarkAsDeletedResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InboxMarkAsDeletedResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AB90", Offset="0x109AB90")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18DCF64", Offset="0x18DCF64", VA="0x18DCF64")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AB80", Offset="0x109AB80")]
		public static MessageParser<InboxMarkAsDeletedResponse> Parser
		{
			[Address(RVA="0x18DCEFC", Offset="0x18DCEFC", VA="0x18DCEFC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109ABA0", Offset="0x109ABA0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18DD054", Offset="0x18DD054", VA="0x18DD054", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18DD368", Offset="0x18DD368", VA="0x18DD368")]
		static InboxMarkAsDeletedResponse()
		{
		}

		[Address(RVA="0x18DD0B0", Offset="0x18DD0B0", VA="0x18DD0B0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108550C", Offset="0x108550C")]
		public InboxMarkAsDeletedResponse()
		{
		}

		[Address(RVA="0x18DD0B8", Offset="0x18DD0B8", VA="0x18DD0B8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108551C", Offset="0x108551C")]
		public InboxMarkAsDeletedResponse(InboxMarkAsDeletedResponse other)
		{
		}

		[Address(RVA="0x18DD2CC", Offset="0x18DD2CC", VA="0x18DD2CC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108558C", Offset="0x108558C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18DD0FC", Offset="0x18DD0FC", VA="0x18DD0FC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108552C", Offset="0x108552C")]
		public InboxMarkAsDeletedResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x18DD15C", Offset="0x18DD15C", VA="0x18DD15C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108553C", Offset="0x108553C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18DD1F4", Offset="0x18DD1F4", VA="0x18DD1F4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108554C", Offset="0x108554C")]
		public bool Equals(InboxMarkAsDeletedResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x18DD220", Offset="0x18DD220", VA="0x18DD220", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108555C", Offset="0x108555C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18DD2E0", Offset="0x18DD2E0", VA="0x18DD2E0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108559C", Offset="0x108559C")]
		public void MergeFrom(InboxMarkAsDeletedResponse other)
		{
		}

		[Address(RVA="0x18DD314", Offset="0x18DD314", VA="0x18DD314", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10855AC", Offset="0x10855AC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18DD250", Offset="0x18DD250", VA="0x18DD250", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108556C", Offset="0x108556C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18DD2B8", Offset="0x18DD2B8", VA="0x18DD2B8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108557C", Offset="0x108557C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050648", Offset="0x1050648")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InboxMarkAsDeletedResponse.<>c <>9;

			[Address(RVA="0x18DD440", Offset="0x18DD440", VA="0x18DD440")]
			static <>c()
			{
			}

			[Address(RVA="0x18DD4A4", Offset="0x18DD4A4", VA="0x18DD4A4")]
			public <>c()
			{
			}

			[Address(RVA="0x18DD4AC", Offset="0x18DD4AC", VA="0x18DD4AC")]
			internal InboxMarkAsDeletedResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}