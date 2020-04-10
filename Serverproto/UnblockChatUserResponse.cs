using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class UnblockChatUserResponse : IMessage<UnblockChatUserResponse>, IMessage, IEquatable<UnblockChatUserResponse>, IDeepCloneable<UnblockChatUserResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<UnblockChatUserResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10947D0", Offset="0x10947D0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1B7AFB4", Offset="0x1B7AFB4", VA="0x1B7AFB4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10947C0", Offset="0x10947C0")]
		public static MessageParser<UnblockChatUserResponse> Parser
		{
			[Address(RVA="0x1B7AF4C", Offset="0x1B7AF4C", VA="0x1B7AF4C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10947E0", Offset="0x10947E0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1B7B0A4", Offset="0x1B7B0A4", VA="0x1B7B0A4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1B7B3B8", Offset="0x1B7B3B8", VA="0x1B7B3B8")]
		static UnblockChatUserResponse()
		{
		}

		[Address(RVA="0x1B7B100", Offset="0x1B7B100", VA="0x1B7B100")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A57C", Offset="0x107A57C")]
		public UnblockChatUserResponse()
		{
		}

		[Address(RVA="0x1B7B108", Offset="0x1B7B108", VA="0x1B7B108")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A58C", Offset="0x107A58C")]
		public UnblockChatUserResponse(UnblockChatUserResponse other)
		{
		}

		[Address(RVA="0x1B7B31C", Offset="0x1B7B31C", VA="0x1B7B31C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A5FC", Offset="0x107A5FC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1B7B14C", Offset="0x1B7B14C", VA="0x1B7B14C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A59C", Offset="0x107A59C")]
		public UnblockChatUserResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1B7B1AC", Offset="0x1B7B1AC", VA="0x1B7B1AC", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A5AC", Offset="0x107A5AC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1B7B244", Offset="0x1B7B244", VA="0x1B7B244", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A5BC", Offset="0x107A5BC")]
		public bool Equals(UnblockChatUserResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1B7B270", Offset="0x1B7B270", VA="0x1B7B270", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A5CC", Offset="0x107A5CC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1B7B330", Offset="0x1B7B330", VA="0x1B7B330", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A60C", Offset="0x107A60C")]
		public void MergeFrom(UnblockChatUserResponse other)
		{
		}

		[Address(RVA="0x1B7B364", Offset="0x1B7B364", VA="0x1B7B364", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A61C", Offset="0x107A61C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1B7B2A0", Offset="0x1B7B2A0", VA="0x1B7B2A0", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A5DC", Offset="0x107A5DC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1B7B308", Offset="0x1B7B308", VA="0x1B7B308", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A5EC", Offset="0x107A5EC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F648", Offset="0x104F648")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static UnblockChatUserResponse.<>c <>9;

			[Address(RVA="0x14AFAE8", Offset="0x14AFAE8", VA="0x14AFAE8")]
			static <>c()
			{
			}

			[Address(RVA="0x14AFB4C", Offset="0x14AFB4C", VA="0x14AFB4C")]
			public <>c()
			{
			}

			[Address(RVA="0x14AFB54", Offset="0x14AFB54", VA="0x14AFB54")]
			internal UnblockChatUserResponse <.cctor>b__20_0()
			{
				return null;
			}
		}
	}
}