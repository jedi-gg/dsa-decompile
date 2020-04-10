using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InboxMarkAllAsReadRequest : IMessage<InboxMarkAllAsReadRequest>, IMessage, IEquatable<InboxMarkAllAsReadRequest>, IDeepCloneable<InboxMarkAllAsReadRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InboxMarkAllAsReadRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109ABC0", Offset="0x109ABC0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18DA5C0", Offset="0x18DA5C0", VA="0x18DA5C0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109ABB0", Offset="0x109ABB0")]
		public static MessageParser<InboxMarkAllAsReadRequest> Parser
		{
			[Address(RVA="0x18DA558", Offset="0x18DA558", VA="0x18DA558")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109ABD0", Offset="0x109ABD0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18DA6B0", Offset="0x18DA6B0", VA="0x18DA6B0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18DA9C4", Offset="0x18DA9C4", VA="0x18DA9C4")]
		static InboxMarkAllAsReadRequest()
		{
		}

		[Address(RVA="0x18DA70C", Offset="0x18DA70C", VA="0x18DA70C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10855BC", Offset="0x10855BC")]
		public InboxMarkAllAsReadRequest()
		{
		}

		[Address(RVA="0x18DA714", Offset="0x18DA714", VA="0x18DA714")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10855CC", Offset="0x10855CC")]
		public InboxMarkAllAsReadRequest(InboxMarkAllAsReadRequest other)
		{
		}

		[Address(RVA="0x18DA928", Offset="0x18DA928", VA="0x18DA928", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108563C", Offset="0x108563C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18DA758", Offset="0x18DA758", VA="0x18DA758", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10855DC", Offset="0x10855DC")]
		public InboxMarkAllAsReadRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x18DA7B8", Offset="0x18DA7B8", VA="0x18DA7B8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10855EC", Offset="0x10855EC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18DA850", Offset="0x18DA850", VA="0x18DA850", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10855FC", Offset="0x10855FC")]
		public bool Equals(InboxMarkAllAsReadRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x18DA87C", Offset="0x18DA87C", VA="0x18DA87C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108560C", Offset="0x108560C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18DA93C", Offset="0x18DA93C", VA="0x18DA93C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108564C", Offset="0x108564C")]
		public void MergeFrom(InboxMarkAllAsReadRequest other)
		{
		}

		[Address(RVA="0x18DA970", Offset="0x18DA970", VA="0x18DA970", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108565C", Offset="0x108565C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18DA8AC", Offset="0x18DA8AC", VA="0x18DA8AC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108561C", Offset="0x108561C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18DA914", Offset="0x18DA914", VA="0x18DA914", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108562C", Offset="0x108562C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050658", Offset="0x1050658")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InboxMarkAllAsReadRequest.<>c <>9;

			[Address(RVA="0x18DAA9C", Offset="0x18DAA9C", VA="0x18DAA9C")]
			static <>c()
			{
			}

			[Address(RVA="0x18DAB00", Offset="0x18DAB00", VA="0x18DAB00")]
			public <>c()
			{
			}

			[Address(RVA="0x18DAB08", Offset="0x18DAB08", VA="0x18DAB08")]
			internal InboxMarkAllAsReadRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}