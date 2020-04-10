using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class ChatReportResponse : IMessage<ChatReportResponse>, IMessage, IEquatable<ChatReportResponse>, IDeepCloneable<ChatReportResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<ChatReportResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094520", Offset="0x1094520")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A3D824", Offset="0x1A3D824", VA="0x1A3D824")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094510", Offset="0x1094510")]
		public static MessageParser<ChatReportResponse> Parser
		{
			[Address(RVA="0x1A3C960", Offset="0x1A3C960", VA="0x1A3C960")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094530", Offset="0x1094530")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A3D910", Offset="0x1A3D910", VA="0x1A3D910", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A3DC24", Offset="0x1A3DC24", VA="0x1A3DC24")]
		static ChatReportResponse()
		{
		}

		[Address(RVA="0x1A3D96C", Offset="0x1A3D96C", VA="0x1A3D96C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1079FFC", Offset="0x1079FFC")]
		public ChatReportResponse()
		{
		}

		[Address(RVA="0x1A3D974", Offset="0x1A3D974", VA="0x1A3D974")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A00C", Offset="0x107A00C")]
		public ChatReportResponse(ChatReportResponse other)
		{
		}

		[Address(RVA="0x1A3DB88", Offset="0x1A3DB88", VA="0x1A3DB88", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A07C", Offset="0x107A07C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A3D9B8", Offset="0x1A3D9B8", VA="0x1A3D9B8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A01C", Offset="0x107A01C")]
		public ChatReportResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1A3DA18", Offset="0x1A3DA18", VA="0x1A3DA18", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A02C", Offset="0x107A02C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A3DAB0", Offset="0x1A3DAB0", VA="0x1A3DAB0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A03C", Offset="0x107A03C")]
		public bool Equals(ChatReportResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1A3DADC", Offset="0x1A3DADC", VA="0x1A3DADC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A04C", Offset="0x107A04C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A3DB9C", Offset="0x1A3DB9C", VA="0x1A3DB9C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A08C", Offset="0x107A08C")]
		public void MergeFrom(ChatReportResponse other)
		{
		}

		[Address(RVA="0x1A3DBD0", Offset="0x1A3DBD0", VA="0x1A3DBD0", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A09C", Offset="0x107A09C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A3DB0C", Offset="0x1A3DB0C", VA="0x1A3DB0C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A05C", Offset="0x107A05C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A3DB74", Offset="0x1A3DB74", VA="0x1A3DB74", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A06C", Offset="0x107A06C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F5C8", Offset="0x104F5C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ChatReportResponse.<>c <>9;

			[Address(RVA="0x1A3DCFC", Offset="0x1A3DCFC", VA="0x1A3DCFC")]
			static <>c()
			{
			}

			[Address(RVA="0x1A3DD60", Offset="0x1A3DD60", VA="0x1A3DD60")]
			public <>c()
			{
			}

			[Address(RVA="0x1A3DD68", Offset="0x1A3DD68", VA="0x1A3DD68")]
			internal ChatReportResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}