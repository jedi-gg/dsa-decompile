using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ClubMessage : IMessage<ClubMessage>, IMessage, IEquatable<ClubMessage>, IDeepCloneable<ClubMessage>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ClubMessage> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int TextFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string text_;

		[FieldOffset(Offset="0x0")]
		public const int SenderIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string senderId_;

		[FieldOffset(Offset="0x0")]
		public const int MessageTypeFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ClubMessageType messageType_;

		[FieldOffset(Offset="0x0")]
		public const int TimestampFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong timestamp_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094A50", Offset="0x1094A50")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1FFE6D8", Offset="0x1FFE6D8", VA="0x1FFE6D8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094A90", Offset="0x1094A90")]
		public ClubMessageType MessageType
		{
			[Address(RVA="0x1FFEA7C", Offset="0x1FFEA7C", VA="0x1FFEA7C")]
			get
			{
				return new ClubMessageType();
			}
			[Address(RVA="0x1FFEA84", Offset="0x1FFEA84", VA="0x1FFEA84")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094A40", Offset="0x1094A40")]
		public static MessageParser<ClubMessage> Parser
		{
			[Address(RVA="0x1FFE670", Offset="0x1FFE670", VA="0x1FFE670")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094A60", Offset="0x1094A60")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1FFE7C4", Offset="0x1FFE7C4", VA="0x1FFE7C4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094A80", Offset="0x1094A80")]
		public string SenderId
		{
			[Address(RVA="0x1FFEA04", Offset="0x1FFEA04", VA="0x1FFEA04")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FFEA0C", Offset="0x1FFEA0C", VA="0x1FFEA0C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094A70", Offset="0x1094A70")]
		public string Text
		{
			[Address(RVA="0x1FFE98C", Offset="0x1FFE98C", VA="0x1FFE98C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1FFE994", Offset="0x1FFE994", VA="0x1FFE994")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094AA0", Offset="0x1094AA0")]
		public ulong Timestamp
		{
			[Address(RVA="0x1FFEA8C", Offset="0x1FFEA8C", VA="0x1FFEA8C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1FFEA94", Offset="0x1FFEA94", VA="0x1FFEA94")]
			set
			{
			}
		}

		[Address(RVA="0x1FFF244", Offset="0x1FFF244", VA="0x1FFF244")]
		static ClubMessage()
		{
		}

		[Address(RVA="0x1FFE820", Offset="0x1FFE820", VA="0x1FFE820")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AA4C", Offset="0x107AA4C")]
		public ClubMessage()
		{
		}

		[Address(RVA="0x1FFE878", Offset="0x1FFE878", VA="0x1FFE878")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AA5C", Offset="0x107AA5C")]
		public ClubMessage(ClubMessage other)
		{
		}

		[Address(RVA="0x1FFEEFC", Offset="0x1FFEEFC", VA="0x1FFEEFC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AACC", Offset="0x107AACC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1FFE92C", Offset="0x1FFE92C", VA="0x1FFE92C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AA6C", Offset="0x107AA6C")]
		public ClubMessage Clone()
		{
			return null;
		}

		[Address(RVA="0x1FFEA9C", Offset="0x1FFEA9C", VA="0x1FFEA9C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AA7C", Offset="0x107AA7C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1FFEB10", Offset="0x1FFEB10", VA="0x1FFEB10", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AA8C", Offset="0x107AA8C")]
		public bool Equals(ClubMessage other)
		{
			return new bool();
		}

		[Address(RVA="0x1FFEBA8", Offset="0x1FFEBA8", VA="0x1FFEBA8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AA9C", Offset="0x107AA9C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1FFF088", Offset="0x1FFF088", VA="0x1FFF088", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AADC", Offset="0x107AADC")]
		public void MergeFrom(ClubMessage other)
		{
		}

		[Address(RVA="0x1FFF138", Offset="0x1FFF138", VA="0x1FFF138", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AAEC", Offset="0x107AAEC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1FFECBC", Offset="0x1FFECBC", VA="0x1FFECBC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AAAC", Offset="0x107AAAC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1FFED24", Offset="0x1FFED24", VA="0x1FFED24", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AABC", Offset="0x107AABC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F6B8", Offset="0x104F6B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ClubMessage.<>c <>9;

			[Address(RVA="0x1FFF31C", Offset="0x1FFF31C", VA="0x1FFF31C")]
			static <>c()
			{
			}

			[Address(RVA="0x1FFF380", Offset="0x1FFF380", VA="0x1FFF380")]
			public <>c()
			{
			}

			[Address(RVA="0x1FFF388", Offset="0x1FFF388", VA="0x1FFF388")]
			internal ClubMessage <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}