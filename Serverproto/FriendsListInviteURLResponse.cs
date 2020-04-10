using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class FriendsListInviteURLResponse : IMessage<FriendsListInviteURLResponse>, IMessage, IEquatable<FriendsListInviteURLResponse>, IDeepCloneable<FriendsListInviteURLResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<FriendsListInviteURLResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int UrlFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string url_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A850", Offset="0x109A850")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B9F214", Offset="0x1B9F214", VA="0x1B9F214")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A840", Offset="0x109A840")]
		public static MessageParser<FriendsListInviteURLResponse> Parser
		{
			[Address(RVA="0x1B9F1AC", Offset="0x1B9F1AC", VA="0x1B9F1AC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A860", Offset="0x109A860")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B9F304", Offset="0x1B9F304", VA="0x1B9F304", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x109A870", Offset="0x109A870")]
		public string Url
		{
			[Address(RVA="0x1B9F478", Offset="0x1B9F478", VA="0x1B9F478")]
			get
			{
				return null;
			}
			[Address(RVA="0x1B9F480", Offset="0x1B9F480", VA="0x1B9F480")]
			set
			{
			}
		}

		[Address(RVA="0x1B9F910", Offset="0x1B9F910", VA="0x1B9F910")]
		static FriendsListInviteURLResponse()
		{
		}

		[Address(RVA="0x1B9F360", Offset="0x1B9F360", VA="0x1B9F360")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084D7C", Offset="0x1084D7C")]
		public FriendsListInviteURLResponse()
		{
		}

		[Address(RVA="0x1B9F3B8", Offset="0x1B9F3B8", VA="0x1B9F3B8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084D8C", Offset="0x1084D8C")]
		public FriendsListInviteURLResponse(FriendsListInviteURLResponse other)
		{
		}

		[Address(RVA="0x1B9F76C", Offset="0x1B9F76C", VA="0x1B9F76C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084DFC", Offset="0x1084DFC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B9F418", Offset="0x1B9F418", VA="0x1B9F418", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084D9C", Offset="0x1084D9C")]
		public FriendsListInviteURLResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B9F4F0", Offset="0x1B9F4F0", VA="0x1B9F4F0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084DAC", Offset="0x1084DAC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9F564", Offset="0x1B9F564", VA="0x1B9F564", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084DBC", Offset="0x1084DBC")]
		public bool Equals(FriendsListInviteURLResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B9F5C8", Offset="0x1B9F5C8", VA="0x1B9F5C8", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084DCC", Offset="0x1084DCC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B9F820", Offset="0x1B9F820", VA="0x1B9F820", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084E0C", Offset="0x1084E0C")]
		public void MergeFrom(FriendsListInviteURLResponse other)
		{
		}

		[Address(RVA="0x1B9F88C", Offset="0x1B9F88C", VA="0x1B9F88C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084E1C", Offset="0x1084E1C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B9F64C", Offset="0x1B9F64C", VA="0x1B9F64C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084DDC", Offset="0x1084DDC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B9F6B4", Offset="0x1B9F6B4", VA="0x1B9F6B4", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1084DEC", Offset="0x1084DEC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050598", Offset="0x1050598")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FriendsListInviteURLResponse.<>c <>9;

			[Address(RVA="0x1B9F9E8", Offset="0x1B9F9E8", VA="0x1B9F9E8")]
			static <>c()
			{
			}

			[Address(RVA="0x1B9FA4C", Offset="0x1B9FA4C", VA="0x1B9FA4C")]
			public <>c()
			{
			}

			[Address(RVA="0x1B9FA54", Offset="0x1B9FA54", VA="0x1B9FA54")]
			internal FriendsListInviteURLResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}