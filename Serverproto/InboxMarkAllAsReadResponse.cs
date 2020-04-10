using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InboxMarkAllAsReadResponse : IMessage<InboxMarkAllAsReadResponse>, IMessage, IEquatable<InboxMarkAllAsReadResponse>, IDeepCloneable<InboxMarkAllAsReadResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InboxMarkAllAsReadResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109ABF0", Offset="0x109ABF0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18DABCC", Offset="0x18DABCC", VA="0x18DABCC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109ABE0", Offset="0x109ABE0")]
		public static MessageParser<InboxMarkAllAsReadResponse> Parser
		{
			[Address(RVA="0x18DAB64", Offset="0x18DAB64", VA="0x18DAB64")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109AC00", Offset="0x109AC00")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18DACBC", Offset="0x18DACBC", VA="0x18DACBC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18DAFD0", Offset="0x18DAFD0", VA="0x18DAFD0")]
		static InboxMarkAllAsReadResponse()
		{
		}

		[Address(RVA="0x18DAD18", Offset="0x18DAD18", VA="0x18DAD18")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108566C", Offset="0x108566C")]
		public InboxMarkAllAsReadResponse()
		{
		}

		[Address(RVA="0x18DAD20", Offset="0x18DAD20", VA="0x18DAD20")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108567C", Offset="0x108567C")]
		public InboxMarkAllAsReadResponse(InboxMarkAllAsReadResponse other)
		{
		}

		[Address(RVA="0x18DAF34", Offset="0x18DAF34", VA="0x18DAF34", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10856EC", Offset="0x10856EC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18DAD64", Offset="0x18DAD64", VA="0x18DAD64", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108568C", Offset="0x108568C")]
		public InboxMarkAllAsReadResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x18DADC4", Offset="0x18DADC4", VA="0x18DADC4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108569C", Offset="0x108569C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18DAE5C", Offset="0x18DAE5C", VA="0x18DAE5C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10856AC", Offset="0x10856AC")]
		public bool Equals(InboxMarkAllAsReadResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x18DAE88", Offset="0x18DAE88", VA="0x18DAE88", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10856BC", Offset="0x10856BC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18DAF48", Offset="0x18DAF48", VA="0x18DAF48", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10856FC", Offset="0x10856FC")]
		public void MergeFrom(InboxMarkAllAsReadResponse other)
		{
		}

		[Address(RVA="0x18DAF7C", Offset="0x18DAF7C", VA="0x18DAF7C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108570C", Offset="0x108570C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18DAEB8", Offset="0x18DAEB8", VA="0x18DAEB8", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10856CC", Offset="0x10856CC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18DAF20", Offset="0x18DAF20", VA="0x18DAF20", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10856DC", Offset="0x10856DC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050668", Offset="0x1050668")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InboxMarkAllAsReadResponse.<>c <>9;

			[Address(RVA="0x18DB0A8", Offset="0x18DB0A8", VA="0x18DB0A8")]
			static <>c()
			{
			}

			[Address(RVA="0x18DB10C", Offset="0x18DB10C", VA="0x18DB10C")]
			public <>c()
			{
			}

			[Address(RVA="0x18DB114", Offset="0x18DB114", VA="0x18DB114")]
			internal InboxMarkAllAsReadResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}