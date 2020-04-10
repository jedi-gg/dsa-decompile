using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class GetBlockedChatUsersRequest : IMessage<GetBlockedChatUsersRequest>, IMessage, IEquatable<GetBlockedChatUsersRequest>, IDeepCloneable<GetBlockedChatUsersRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<GetBlockedChatUsersRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094840", Offset="0x1094840")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA5C3C", Offset="0x1BA5C3C", VA="0x1BA5C3C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094830", Offset="0x1094830")]
		public static MessageParser<GetBlockedChatUsersRequest> Parser
		{
			[Address(RVA="0x1BA5BD4", Offset="0x1BA5BD4", VA="0x1BA5BD4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094850", Offset="0x1094850")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA5D2C", Offset="0x1BA5D2C", VA="0x1BA5D2C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BA6040", Offset="0x1BA6040", VA="0x1BA6040")]
		static GetBlockedChatUsersRequest()
		{
		}

		[Address(RVA="0x1BA5D88", Offset="0x1BA5D88", VA="0x1BA5D88")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A6DC", Offset="0x107A6DC")]
		public GetBlockedChatUsersRequest()
		{
		}

		[Address(RVA="0x1BA5D90", Offset="0x1BA5D90", VA="0x1BA5D90")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A6EC", Offset="0x107A6EC")]
		public GetBlockedChatUsersRequest(GetBlockedChatUsersRequest other)
		{
		}

		[Address(RVA="0x1BA5FA4", Offset="0x1BA5FA4", VA="0x1BA5FA4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A75C", Offset="0x107A75C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA5DD4", Offset="0x1BA5DD4", VA="0x1BA5DD4", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A6FC", Offset="0x107A6FC")]
		public GetBlockedChatUsersRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA5E34", Offset="0x1BA5E34", VA="0x1BA5E34", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A70C", Offset="0x107A70C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA5ECC", Offset="0x1BA5ECC", VA="0x1BA5ECC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A71C", Offset="0x107A71C")]
		public bool Equals(GetBlockedChatUsersRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA5EF8", Offset="0x1BA5EF8", VA="0x1BA5EF8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A72C", Offset="0x107A72C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA5FB8", Offset="0x1BA5FB8", VA="0x1BA5FB8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A76C", Offset="0x107A76C")]
		public void MergeFrom(GetBlockedChatUsersRequest other)
		{
		}

		[Address(RVA="0x1BA5FEC", Offset="0x1BA5FEC", VA="0x1BA5FEC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A77C", Offset="0x107A77C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA5F28", Offset="0x1BA5F28", VA="0x1BA5F28", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A73C", Offset="0x107A73C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA5F90", Offset="0x1BA5F90", VA="0x1BA5F90", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A74C", Offset="0x107A74C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F668", Offset="0x104F668")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GetBlockedChatUsersRequest.<>c <>9;

			[Address(RVA="0x1BA6118", Offset="0x1BA6118", VA="0x1BA6118")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA617C", Offset="0x1BA617C", VA="0x1BA617C")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA6184", Offset="0x1BA6184", VA="0x1BA6184")]
			internal GetBlockedChatUsersRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}