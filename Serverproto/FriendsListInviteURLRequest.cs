using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class FriendsListInviteURLRequest : IMessage<FriendsListInviteURLRequest>, IMessage, IEquatable<FriendsListInviteURLRequest>, IDeepCloneable<FriendsListInviteURLRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<FriendsListInviteURLRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A820", Offset="0x109A820")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B9EC08", Offset="0x1B9EC08", VA="0x1B9EC08")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A810", Offset="0x109A810")]
		public static MessageParser<FriendsListInviteURLRequest> Parser
		{
			[Address(RVA="0x1B9EBA0", Offset="0x1B9EBA0", VA="0x1B9EBA0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A830", Offset="0x109A830")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B9ECF8", Offset="0x1B9ECF8", VA="0x1B9ECF8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B9F00C", Offset="0x1B9F00C", VA="0x1B9F00C")]
		static FriendsListInviteURLRequest()
		{
		}

		[Address(RVA="0x1B9ED54", Offset="0x1B9ED54", VA="0x1B9ED54")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084CCC", Offset="0x1084CCC")]
		public FriendsListInviteURLRequest()
		{
		}

		[Address(RVA="0x1B9ED5C", Offset="0x1B9ED5C", VA="0x1B9ED5C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084CDC", Offset="0x1084CDC")]
		public FriendsListInviteURLRequest(FriendsListInviteURLRequest other)
		{
		}

		[Address(RVA="0x1B9EF70", Offset="0x1B9EF70", VA="0x1B9EF70", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084D4C", Offset="0x1084D4C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B9EDA0", Offset="0x1B9EDA0", VA="0x1B9EDA0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084CEC", Offset="0x1084CEC")]
		public FriendsListInviteURLRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1B9EE00", Offset="0x1B9EE00", VA="0x1B9EE00", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084CFC", Offset="0x1084CFC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9EE98", Offset="0x1B9EE98", VA="0x1B9EE98", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084D0C", Offset="0x1084D0C")]
		public bool Equals(FriendsListInviteURLRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9EEC4", Offset="0x1B9EEC4", VA="0x1B9EEC4", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084D1C", Offset="0x1084D1C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B9EF84", Offset="0x1B9EF84", VA="0x1B9EF84", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084D5C", Offset="0x1084D5C")]
		public void MergeFrom(FriendsListInviteURLRequest other)
		{
		}

		[Address(RVA="0x1B9EFB8", Offset="0x1B9EFB8", VA="0x1B9EFB8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084D6C", Offset="0x1084D6C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B9EEF4", Offset="0x1B9EEF4", VA="0x1B9EEF4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084D2C", Offset="0x1084D2C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B9EF5C", Offset="0x1B9EF5C", VA="0x1B9EF5C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084D3C", Offset="0x1084D3C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050588", Offset="0x1050588")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FriendsListInviteURLRequest.<>c <>9;

			[Address(RVA="0x1B9F0E4", Offset="0x1B9F0E4", VA="0x1B9F0E4")]
			static <>c()
			{
			}

			[Address(RVA="0x1B9F148", Offset="0x1B9F148", VA="0x1B9F148")]
			public <>c()
			{
			}

			[Address(RVA="0x1B9F150", Offset="0x1B9F150", VA="0x1B9F150")]
			internal FriendsListInviteURLRequest <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}