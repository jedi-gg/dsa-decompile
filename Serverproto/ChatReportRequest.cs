using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ChatReportRequest : IMessage<ChatReportRequest>, IMessage, IEquatable<ChatReportRequest>, IDeepCloneable<ChatReportRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ChatReportRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string playerId_;

		[FieldOffset(Offset="0x0")]
		public const int MessageIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string messageId_;

		[FieldOffset(Offset="0x0")]
		public const int MessageTimestampFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ulong messageTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int ChannelNameFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string channelName_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094500", Offset="0x1094500")]
		public string ChannelName
		{
			[Address(RVA="0x1A3CDE8", Offset="0x1A3CDE8", VA="0x1A3CDE8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A3CDF0", Offset="0x1A3CDF0", VA="0x1A3CDF0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10944B0", Offset="0x10944B0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A3CA30", Offset="0x1A3CA30", VA="0x1A3CA30")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10944E0", Offset="0x10944E0")]
		public string MessageId
		{
			[Address(RVA="0x1A3CD60", Offset="0x1A3CD60", VA="0x1A3CD60")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A3CD68", Offset="0x1A3CD68", VA="0x1A3CD68")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10944F0", Offset="0x10944F0")]
		public ulong MessageTimestamp
		{
			[Address(RVA="0x1A3CDD8", Offset="0x1A3CDD8", VA="0x1A3CDD8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A3CDE0", Offset="0x1A3CDE0", VA="0x1A3CDE0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10944A0", Offset="0x10944A0")]
		public static MessageParser<ChatReportRequest> Parser
		{
			[Address(RVA="0x1A3C8F8", Offset="0x1A3C8F8", VA="0x1A3C8F8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10944C0", Offset="0x10944C0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A3CB1C", Offset="0x1A3CB1C", VA="0x1A3CB1C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10944D0", Offset="0x10944D0")]
		public string PlayerId
		{
			[Address(RVA="0x1A3CCE8", Offset="0x1A3CCE8", VA="0x1A3CCE8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A3CCF0", Offset="0x1A3CCF0", VA="0x1A3CCF0")]
			set
			{
			}
		}

		[Address(RVA="0x1A3D688", Offset="0x1A3D688", VA="0x1A3D688")]
		static ChatReportRequest()
		{
		}

		[Address(RVA="0x1A3CB78", Offset="0x1A3CB78", VA="0x1A3CB78")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079F4C", Offset="0x1079F4C")]
		public ChatReportRequest()
		{
		}

		[Address(RVA="0x1A3CBD4", Offset="0x1A3CBD4", VA="0x1A3CBD4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079F5C", Offset="0x1079F5C")]
		public ChatReportRequest(ChatReportRequest other)
		{
		}

		[Address(RVA="0x1A3D2FC", Offset="0x1A3D2FC", VA="0x1A3D2FC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079FCC", Offset="0x1079FCC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A3CC88", Offset="0x1A3CC88", VA="0x1A3CC88", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079F6C", Offset="0x1079F6C")]
		public ChatReportRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A3CE60", Offset="0x1A3CE60", VA="0x1A3CE60", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079F7C", Offset="0x1079F7C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A3CED4", Offset="0x1A3CED4", VA="0x1A3CED4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079F8C", Offset="0x1079F8C")]
		public bool Equals(ChatReportRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A3CF70", Offset="0x1A3CF70", VA="0x1A3CF70", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079F9C", Offset="0x1079F9C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A3D4A4", Offset="0x1A3D4A4", VA="0x1A3D4A4", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079FDC", Offset="0x1079FDC")]
		public void MergeFrom(ChatReportRequest other)
		{
		}

		[Address(RVA="0x1A3D574", Offset="0x1A3D574", VA="0x1A3D574", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079FEC", Offset="0x1079FEC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A3D0A4", Offset="0x1A3D0A4", VA="0x1A3D0A4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079FAC", Offset="0x1079FAC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A3D10C", Offset="0x1A3D10C", VA="0x1A3D10C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079FBC", Offset="0x1079FBC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F5B8", Offset="0x104F5B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ChatReportRequest.<>c <>9;

			[Address(RVA="0x1A3D760", Offset="0x1A3D760", VA="0x1A3D760")]
			static <>c()
			{
			}

			[Address(RVA="0x1A3D7C4", Offset="0x1A3D7C4", VA="0x1A3D7C4")]
			public <>c()
			{
			}

			[Address(RVA="0x1A3D7CC", Offset="0x1A3D7CC", VA="0x1A3D7CC")]
			internal ChatReportRequest <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}