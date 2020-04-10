using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ChatMessage : IMessage<ChatMessage>, IMessage, IEquatable<ChatMessage>, IDeepCloneable<ChatMessage>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ChatMessage> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int MessageTypeFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private ChatMessageType messageType_;

		[FieldOffset(Offset="0x0")]
		public const int MessageFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string message_;

		[FieldOffset(Offset="0x0")]
		public const int ChannelTypeFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ChatChannelType channelType_;

		[FieldOffset(Offset="0x0")]
		public const int ChannelNameFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string channelName_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private string playerId_;

		[FieldOffset(Offset="0x0")]
		public const int PlayerUsernameFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private string playerUsername_;

		[FieldOffset(Offset="0x0")]
		public const int AvatarIdFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private ulong avatarId_;

		[FieldOffset(Offset="0x0")]
		public const int TimestampFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private ulong timestamp_;

		[FieldOffset(Offset="0x0")]
		public const int SystemMessageTypeFieldNumber = 9;

		[FieldOffset(Offset="0x58")]
		private ChatSystemMessageType systemMessageType_;

		[FieldOffset(Offset="0x0")]
		public const int SystemMessagePayloadFieldNumber = 10;

		[FieldOffset(Offset="0x60")]
		private ByteString systemMessagePayload_;

		[FieldOffset(Offset="0x0")]
		public const int DeepLinkLocationFieldNumber = 11;

		[FieldOffset(Offset="0x68")]
		private ulong deepLinkLocation_;

		[FieldOffset(Offset="0x0")]
		public const int DeepLinkSublocationFieldNumber = 12;

		[FieldOffset(Offset="0x70")]
		private string deepLinkSublocation_;

		[FieldOffset(Offset="0x0")]
		public const int MessageIdFieldNumber = 13;

		[FieldOffset(Offset="0x78")]
		private string messageId_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10945D0", Offset="0x10945D0")]
		public ulong AvatarId
		{
			[Address(RVA="0x1F99148", Offset="0x1F99148", VA="0x1F99148")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F99150", Offset="0x1F99150", VA="0x1F99150")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10945A0", Offset="0x10945A0")]
		public string ChannelName
		{
			[Address(RVA="0x1F98FE0", Offset="0x1F98FE0", VA="0x1F98FE0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F98FE8", Offset="0x1F98FE8", VA="0x1F98FE8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094590", Offset="0x1094590")]
		public ChatChannelType ChannelType
		{
			[Address(RVA="0x1F98FD0", Offset="0x1F98FD0", VA="0x1F98FD0")]
			get
			{
				return new ChatChannelType();
			}
			[Address(RVA="0x1F98FD8", Offset="0x1F98FD8", VA="0x1F98FD8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094610", Offset="0x1094610")]
		public ulong DeepLinkLocation
		{
			[Address(RVA="0x1F991F0", Offset="0x1F991F0", VA="0x1F991F0")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F991F8", Offset="0x1F991F8", VA="0x1F991F8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094620", Offset="0x1094620")]
		public string DeepLinkSublocation
		{
			[Address(RVA="0x1F99200", Offset="0x1F99200", VA="0x1F99200")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F99208", Offset="0x1F99208", VA="0x1F99208")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094550", Offset="0x1094550")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F98B58", Offset="0x1F98B58", VA="0x1F98B58")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094580", Offset="0x1094580")]
		public string Message
		{
			[Address(RVA="0x1F98F58", Offset="0x1F98F58", VA="0x1F98F58")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F98F60", Offset="0x1F98F60", VA="0x1F98F60")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094630", Offset="0x1094630")]
		public string MessageId
		{
			[Address(RVA="0x1F99278", Offset="0x1F99278", VA="0x1F99278")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F99280", Offset="0x1F99280", VA="0x1F99280")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094570", Offset="0x1094570")]
		public ChatMessageType MessageType
		{
			[Address(RVA="0x1F98F48", Offset="0x1F98F48", VA="0x1F98F48")]
			get
			{
				return new ChatMessageType();
			}
			[Address(RVA="0x1F98F50", Offset="0x1F98F50", VA="0x1F98F50")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094540", Offset="0x1094540")]
		public static MessageParser<ChatMessage> Parser
		{
			[Address(RVA="0x1F98AF0", Offset="0x1F98AF0", VA="0x1F98AF0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094560", Offset="0x1094560")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F98C48", Offset="0x1F98C48", VA="0x1F98C48", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10945B0", Offset="0x10945B0")]
		public string PlayerId
		{
			[Address(RVA="0x1F99058", Offset="0x1F99058", VA="0x1F99058")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F99060", Offset="0x1F99060", VA="0x1F99060")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10945C0", Offset="0x10945C0")]
		public string PlayerUsername
		{
			[Address(RVA="0x1F990D0", Offset="0x1F990D0", VA="0x1F990D0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F990D8", Offset="0x1F990D8", VA="0x1F990D8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094600", Offset="0x1094600")]
		public ByteString SystemMessagePayload
		{
			[Address(RVA="0x1F99178", Offset="0x1F99178", VA="0x1F99178")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F99180", Offset="0x1F99180", VA="0x1F99180")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10945F0", Offset="0x10945F0")]
		public ChatSystemMessageType SystemMessageType
		{
			[Address(RVA="0x1F99168", Offset="0x1F99168", VA="0x1F99168")]
			get
			{
				return new ChatSystemMessageType();
			}
			[Address(RVA="0x1F99170", Offset="0x1F99170", VA="0x1F99170")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10945E0", Offset="0x10945E0")]
		public ulong Timestamp
		{
			[Address(RVA="0x1F99158", Offset="0x1F99158", VA="0x1F99158")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1F99160", Offset="0x1F99160", VA="0x1F99160")]
			set
			{
			}
		}

		[Address(RVA="0x1F9A650", Offset="0x1F9A650", VA="0x1F9A650")]
		static ChatMessage()
		{
		}

		[Address(RVA="0x1F98CA4", Offset="0x1F98CA4", VA="0x1F98CA4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A0AC", Offset="0x107A0AC")]
		public ChatMessage()
		{
		}

		[Address(RVA="0x1F98D38", Offset="0x1F98D38", VA="0x1F98D38")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A0BC", Offset="0x107A0BC")]
		public ChatMessage(ChatMessage other)
		{
		}

		[Address(RVA="0x1F99DB4", Offset="0x1F99DB4", VA="0x1F99DB4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A12C", Offset="0x107A12C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F98EE8", Offset="0x1F98EE8", VA="0x1F98EE8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A0CC", Offset="0x107A0CC")]
		public ChatMessage Clone()
		{
			return null;
		}

		[Address(RVA="0x1F992F0", Offset="0x1F992F0", VA="0x1F992F0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A0DC", Offset="0x107A0DC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F99364", Offset="0x1F99364", VA="0x1F99364", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A0EC", Offset="0x107A0EC")]
		public bool Equals(ChatMessage other)
		{
			return new bool();
		}

		[Address(RVA="0x1F99504", Offset="0x1F99504", VA="0x1F99504", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A0FC", Offset="0x107A0FC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F9A1E0", Offset="0x1F9A1E0", VA="0x1F9A1E0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A13C", Offset="0x107A13C")]
		public void MergeFrom(ChatMessage other)
		{
		}

		[Address(RVA="0x1F9A39C", Offset="0x1F9A39C", VA="0x1F9A39C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A14C", Offset="0x107A14C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F997E4", Offset="0x1F997E4", VA="0x1F997E4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A10C", Offset="0x107A10C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F9984C", Offset="0x1F9984C", VA="0x1F9984C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A11C", Offset="0x107A11C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F5D8", Offset="0x104F5D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ChatMessage.<>c <>9;

			[Address(RVA="0x1A39570", Offset="0x1A39570", VA="0x1A39570")]
			static <>c()
			{
			}

			[Address(RVA="0x1A395D4", Offset="0x1A395D4", VA="0x1A395D4")]
			public <>c()
			{
			}

			[Address(RVA="0x1A395DC", Offset="0x1A395DC", VA="0x1A395DC")]
			internal ChatMessage <.cctor>b__85_0()
			{
				return null;
			}
		}
	}
}