using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class GetBlockedChatUsersResponse : IMessage<GetBlockedChatUsersResponse>, IMessage, IEquatable<GetBlockedChatUsersResponse>, IDeepCloneable<GetBlockedChatUsersResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<GetBlockedChatUsersResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayersFieldNumber = 1;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<PlayerProfileSimple> _repeated_players_codec;

		[FieldOffset(Offset="0x18")]
		private readonly RepeatedField<PlayerProfileSimple> players_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094870", Offset="0x1094870")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1BA6248", Offset="0x1BA6248", VA="0x1BA6248")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094860", Offset="0x1094860")]
		public static MessageParser<GetBlockedChatUsersResponse> Parser
		{
			[Address(RVA="0x1BA61E0", Offset="0x1BA61E0", VA="0x1BA61E0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094880", Offset="0x1094880")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1BA6338", Offset="0x1BA6338", VA="0x1BA6338", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094890", Offset="0x1094890")]
		public RepeatedField<PlayerProfileSimple> Players
		{
			[Address(RVA="0x1BA64FC", Offset="0x1BA64FC", VA="0x1BA64FC")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BA69E4", Offset="0x1BA69E4", VA="0x1BA69E4")]
		static GetBlockedChatUsersResponse()
		{
		}

		[Address(RVA="0x1BA6394", Offset="0x1BA6394", VA="0x1BA6394")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A78C", Offset="0x107A78C")]
		public GetBlockedChatUsersResponse()
		{
		}

		[Address(RVA="0x1BA6404", Offset="0x1BA6404", VA="0x1BA6404")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A79C", Offset="0x107A79C")]
		public GetBlockedChatUsersResponse(GetBlockedChatUsersResponse other)
		{
		}

		[Address(RVA="0x1BA67B4", Offset="0x1BA67B4", VA="0x1BA67B4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A80C", Offset="0x107A80C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1BA649C", Offset="0x1BA649C", VA="0x1BA649C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A7AC", Offset="0x107A7AC")]
		public GetBlockedChatUsersResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1BA6504", Offset="0x1BA6504", VA="0x1BA6504", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A7BC", Offset="0x107A7BC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA6578", Offset="0x1BA6578", VA="0x1BA6578", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A7CC", Offset="0x107A7CC")]
		public bool Equals(GetBlockedChatUsersResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1BA6628", Offset="0x1BA6628", VA="0x1BA6628", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A7DC", Offset="0x107A7DC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1BA6870", Offset="0x1BA6870", VA="0x1BA6870", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A81C", Offset="0x107A81C")]
		public void MergeFrom(GetBlockedChatUsersResponse other)
		{
		}

		[Address(RVA="0x1BA6900", Offset="0x1BA6900", VA="0x1BA6900", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A82C", Offset="0x107A82C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1BA6688", Offset="0x1BA6688", VA="0x1BA6688", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A7EC", Offset="0x107A7EC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1BA66F0", Offset="0x1BA66F0", VA="0x1BA66F0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A7FC", Offset="0x107A7FC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F678", Offset="0x104F678")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GetBlockedChatUsersResponse.<>c <>9;

			[Address(RVA="0x1BA6B08", Offset="0x1BA6B08", VA="0x1BA6B08")]
			static <>c()
			{
			}

			[Address(RVA="0x1BA6B6C", Offset="0x1BA6B6C", VA="0x1BA6B6C")]
			public <>c()
			{
			}

			[Address(RVA="0x1BA6B74", Offset="0x1BA6B74", VA="0x1BA6B74")]
			internal GetBlockedChatUsersResponse <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}