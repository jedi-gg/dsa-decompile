using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class FriendsListModifyResponse : IMessage<FriendsListModifyResponse>, IMessage, IEquatable<FriendsListModifyResponse>, IDeepCloneable<FriendsListModifyResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<FriendsListModifyResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A7F0", Offset="0x109A7F0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA0880", Offset="0x1BA0880", VA="0x1BA0880")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A7E0", Offset="0x109A7E0")]
		public static MessageParser<FriendsListModifyResponse> Parser
		{
			[Address(RVA="0x1BA0818", Offset="0x1BA0818", VA="0x1BA0818")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A800", Offset="0x109A800")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA0970", Offset="0x1BA0970", VA="0x1BA0970", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BA0C84", Offset="0x1BA0C84", VA="0x1BA0C84")]
		static FriendsListModifyResponse()
		{
		}

		[Address(RVA="0x1BA09CC", Offset="0x1BA09CC", VA="0x1BA09CC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084C1C", Offset="0x1084C1C")]
		public FriendsListModifyResponse()
		{
		}

		[Address(RVA="0x1BA09D4", Offset="0x1BA09D4", VA="0x1BA09D4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084C2C", Offset="0x1084C2C")]
		public FriendsListModifyResponse(FriendsListModifyResponse other)
		{
		}

		[Address(RVA="0x1BA0BE8", Offset="0x1BA0BE8", VA="0x1BA0BE8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084C9C", Offset="0x1084C9C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA0A18", Offset="0x1BA0A18", VA="0x1BA0A18", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084C3C", Offset="0x1084C3C")]
		public FriendsListModifyResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA0A78", Offset="0x1BA0A78", VA="0x1BA0A78", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084C4C", Offset="0x1084C4C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA0B10", Offset="0x1BA0B10", VA="0x1BA0B10", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084C5C", Offset="0x1084C5C")]
		public bool Equals(FriendsListModifyResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA0B3C", Offset="0x1BA0B3C", VA="0x1BA0B3C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084C6C", Offset="0x1084C6C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA0BFC", Offset="0x1BA0BFC", VA="0x1BA0BFC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084CAC", Offset="0x1084CAC")]
		public void MergeFrom(FriendsListModifyResponse other)
		{
		}

		[Address(RVA="0x1BA0C30", Offset="0x1BA0C30", VA="0x1BA0C30", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084CBC", Offset="0x1084CBC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA0B6C", Offset="0x1BA0B6C", VA="0x1BA0B6C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084C7C", Offset="0x1084C7C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA0BD4", Offset="0x1BA0BD4", VA="0x1BA0BD4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084C8C", Offset="0x1084C8C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050578", Offset="0x1050578")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FriendsListModifyResponse.<>c <>9;

			[Address(RVA="0x1BA0D5C", Offset="0x1BA0D5C", VA="0x1BA0D5C")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA0DC0", Offset="0x1BA0DC0", VA="0x1BA0DC0")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA0DC8", Offset="0x1BA0DC8", VA="0x1BA0DC8")]
			internal FriendsListModifyResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}