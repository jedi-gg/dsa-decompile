using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeInboxResponse : IMessage<HomeInboxResponse>, IMessage, IEquatable<HomeInboxResponse>, IDeepCloneable<HomeInboxResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeInboxResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UnreadCountFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private uint unreadCount_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097E10", Offset="0x1097E10")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1D053C4", Offset="0x1D053C4", VA="0x1D053C4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097E00", Offset="0x1097E00")]
		public static MessageParser<HomeInboxResponse> Parser
		{
			[Address(RVA="0x1D0535C", Offset="0x1D0535C", VA="0x1D0535C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097E20", Offset="0x1097E20")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1D054B0", Offset="0x1D054B0", VA="0x1D054B0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097E30", Offset="0x1097E30")]
		public uint UnreadCount
		{
			[Address(RVA="0x1D055D8", Offset="0x1D055D8", VA="0x1D055D8")]
			get
			{
				return new uint();
			}
			[Address(RVA="0x1D055E0", Offset="0x1D055E0", VA="0x1D055E0")]
			set
			{
			}
		}

		[Address(RVA="0x1D05954", Offset="0x1D05954", VA="0x1D05954")]
		static HomeInboxResponse()
		{
		}

		[Address(RVA="0x1D0550C", Offset="0x1D0550C", VA="0x1D0550C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080B3C", Offset="0x1080B3C")]
		public HomeInboxResponse()
		{
		}

		[Address(RVA="0x1D05514", Offset="0x1D05514", VA="0x1D05514")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080B4C", Offset="0x1080B4C")]
		public HomeInboxResponse(HomeInboxResponse other)
		{
		}

		[Address(RVA="0x1D05808", Offset="0x1D05808", VA="0x1D05808", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080BBC", Offset="0x1080BBC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1D05578", Offset="0x1D05578", VA="0x1D05578", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080B5C", Offset="0x1080B5C")]
		public HomeInboxResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1D055E8", Offset="0x1D055E8", VA="0x1D055E8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080B6C", Offset="0x1080B6C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1D0565C", Offset="0x1D0565C", VA="0x1D0565C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080B7C", Offset="0x1080B7C")]
		public bool Equals(HomeInboxResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1D05698", Offset="0x1D05698", VA="0x1D05698", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080B8C", Offset="0x1080B8C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1D05898", Offset="0x1D05898", VA="0x1D05898", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080BCC", Offset="0x1080BCC")]
		public void MergeFrom(HomeInboxResponse other)
		{
		}

		[Address(RVA="0x1D058D8", Offset="0x1D058D8", VA="0x1D058D8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080BDC", Offset="0x1080BDC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1D05700", Offset="0x1D05700", VA="0x1D05700", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080B9C", Offset="0x1080B9C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1D05768", Offset="0x1D05768", VA="0x1D05768", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1080BAC", Offset="0x1080BAC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FF98", Offset="0x104FF98")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeInboxResponse.<>c <>9;

			[Address(RVA="0x1D05A2C", Offset="0x1D05A2C", VA="0x1D05A2C")]
			static <>c()
			{
			}

			[Address(RVA="0x1D05A90", Offset="0x1D05A90", VA="0x1D05A90")]
			public <>c()
			{
			}

			[Address(RVA="0x1D05A98", Offset="0x1D05A98", VA="0x1D05A98")]
			internal HomeInboxResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}