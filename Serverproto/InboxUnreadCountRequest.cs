using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InboxUnreadCountRequest : IMessage<InboxUnreadCountRequest>, IMessage, IEquatable<InboxUnreadCountRequest>, IDeepCloneable<InboxUnreadCountRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InboxUnreadCountRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A980", Offset="0x109A980")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18E1068", Offset="0x18E1068", VA="0x18E1068")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A970", Offset="0x109A970")]
		public static MessageParser<InboxUnreadCountRequest> Parser
		{
			[Address(RVA="0x18E1000", Offset="0x18E1000", VA="0x18E1000")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A990", Offset="0x109A990")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18E1158", Offset="0x18E1158", VA="0x18E1158", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18E146C", Offset="0x18E146C", VA="0x18E146C")]
		static InboxUnreadCountRequest()
		{
		}

		[Address(RVA="0x18E11B4", Offset="0x18E11B4", VA="0x18E11B4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084EDC", Offset="0x1084EDC")]
		public InboxUnreadCountRequest()
		{
		}

		[Address(RVA="0x18E11BC", Offset="0x18E11BC", VA="0x18E11BC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084EEC", Offset="0x1084EEC")]
		public InboxUnreadCountRequest(InboxUnreadCountRequest other)
		{
		}

		[Address(RVA="0x18E13D0", Offset="0x18E13D0", VA="0x18E13D0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084F5C", Offset="0x1084F5C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18E1200", Offset="0x18E1200", VA="0x18E1200", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084EFC", Offset="0x1084EFC")]
		public InboxUnreadCountRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x18E1260", Offset="0x18E1260", VA="0x18E1260", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084F0C", Offset="0x1084F0C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18E12F8", Offset="0x18E12F8", VA="0x18E12F8", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084F1C", Offset="0x1084F1C")]
		public bool Equals(InboxUnreadCountRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x18E1324", Offset="0x18E1324", VA="0x18E1324", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084F2C", Offset="0x1084F2C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18E13E4", Offset="0x18E13E4", VA="0x18E13E4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084F6C", Offset="0x1084F6C")]
		public void MergeFrom(InboxUnreadCountRequest other)
		{
		}

		[Address(RVA="0x18E1418", Offset="0x18E1418", VA="0x18E1418", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084F7C", Offset="0x1084F7C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18E1354", Offset="0x18E1354", VA="0x18E1354", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084F3C", Offset="0x1084F3C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18E13BC", Offset="0x18E13BC", VA="0x18E13BC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084F4C", Offset="0x1084F4C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10505B8", Offset="0x10505B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InboxUnreadCountRequest.<>c <>9;

			[Address(RVA="0x18E1544", Offset="0x18E1544", VA="0x18E1544")]
			static <>c()
			{
			}

			[Address(RVA="0x18E15A8", Offset="0x18E15A8", VA="0x18E15A8")]
			public <>c()
			{
			}

			[Address(RVA="0x18E15B0", Offset="0x18E15B0", VA="0x18E15B0")]
			internal InboxUnreadCountRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}