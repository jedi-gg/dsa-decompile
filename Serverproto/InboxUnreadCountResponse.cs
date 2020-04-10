using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class InboxUnreadCountResponse : IMessage<InboxUnreadCountResponse>, IMessage, IEquatable<InboxUnreadCountResponse>, IDeepCloneable<InboxUnreadCountResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<InboxUnreadCountResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int CountFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ulong count_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A9D0", Offset="0x109A9D0")]
		public ulong Count
		{
			[Address(RVA="0x18E188C", Offset="0x18E188C", VA="0x18E188C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x18E1894", Offset="0x18E1894", VA="0x18E1894")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A9B0", Offset="0x109A9B0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x18E1674", Offset="0x18E1674", VA="0x18E1674")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A9A0", Offset="0x109A9A0")]
		public static MessageParser<InboxUnreadCountResponse> Parser
		{
			[Address(RVA="0x18E160C", Offset="0x18E160C", VA="0x18E160C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A9C0", Offset="0x109A9C0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x18E1764", Offset="0x18E1764", VA="0x18E1764", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x18E1C08", Offset="0x18E1C08", VA="0x18E1C08")]
		static InboxUnreadCountResponse()
		{
		}

		[Address(RVA="0x18E17C0", Offset="0x18E17C0", VA="0x18E17C0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084F8C", Offset="0x1084F8C")]
		public InboxUnreadCountResponse()
		{
		}

		[Address(RVA="0x18E17C8", Offset="0x18E17C8", VA="0x18E17C8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084F9C", Offset="0x1084F9C")]
		public InboxUnreadCountResponse(InboxUnreadCountResponse other)
		{
		}

		[Address(RVA="0x18E1ABC", Offset="0x18E1ABC", VA="0x18E1ABC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108500C", Offset="0x108500C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x18E182C", Offset="0x18E182C", VA="0x18E182C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084FAC", Offset="0x1084FAC")]
		public InboxUnreadCountResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x18E189C", Offset="0x18E189C", VA="0x18E189C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084FBC", Offset="0x1084FBC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x18E1910", Offset="0x18E1910", VA="0x18E1910", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084FCC", Offset="0x1084FCC")]
		public bool Equals(InboxUnreadCountResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x18E194C", Offset="0x18E194C", VA="0x18E194C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084FDC", Offset="0x1084FDC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x18E1B4C", Offset="0x18E1B4C", VA="0x18E1B4C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108501C", Offset="0x108501C")]
		public void MergeFrom(InboxUnreadCountResponse other)
		{
		}

		[Address(RVA="0x18E1B8C", Offset="0x18E1B8C", VA="0x18E1B8C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108502C", Offset="0x108502C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x18E19B4", Offset="0x18E19B4", VA="0x18E19B4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084FEC", Offset="0x1084FEC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x18E1A1C", Offset="0x18E1A1C", VA="0x18E1A1C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084FFC", Offset="0x1084FFC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10505C8", Offset="0x10505C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InboxUnreadCountResponse.<>c <>9;

			[Address(RVA="0x18E1CE0", Offset="0x18E1CE0", VA="0x18E1CE0")]
			static <>c()
			{
			}

			[Address(RVA="0x18E1D44", Offset="0x18E1D44", VA="0x18E1D44")]
			public <>c()
			{
			}

			[Address(RVA="0x18E1D4C", Offset="0x18E1D4C", VA="0x18E1D4C")]
			internal InboxUnreadCountResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}