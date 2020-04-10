using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class MatchMakerInviteToRequest : IMessage<MatchMakerInviteToRequest>, IMessage, IEquatable<MatchMakerInviteToRequest>, IDeepCloneable<MatchMakerInviteToRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<MatchMakerInviteToRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerInfoFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private MatchMakerPlayerInfo playerInfo_;

		[FieldOffset(Offset="0x0")]
		public const int InviteFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private BattleInvite invite_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092620", Offset="0x1092620")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A1B5D8", Offset="0x1A1B5D8", VA="0x1A1B5D8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092650", Offset="0x1092650")]
		public BattleInvite Invite
		{
			[Address(RVA="0x1A1B7C8", Offset="0x1A1B7C8", VA="0x1A1B7C8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A1B7D0", Offset="0x1A1B7D0", VA="0x1A1B7D0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092610", Offset="0x1092610")]
		public static MessageParser<MatchMakerInviteToRequest> Parser
		{
			[Address(RVA="0x1A1B570", Offset="0x1A1B570", VA="0x1A1B570")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092630", Offset="0x1092630")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A1B6C8", Offset="0x1A1B6C8", VA="0x1A1B6C8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092640", Offset="0x1092640")]
		public MatchMakerPlayerInfo PlayerInfo
		{
			[Address(RVA="0x1A1B7B8", Offset="0x1A1B7B8", VA="0x1A1B7B8")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A1B7C0", Offset="0x1A1B7C0", VA="0x1A1B7C0")]
			set
			{
			}
		}

		[Address(RVA="0x1A1BDD4", Offset="0x1A1BDD4", VA="0x1A1BDD4")]
		static MatchMakerInviteToRequest()
		{
		}

		[Address(RVA="0x1A1B724", Offset="0x1A1B724", VA="0x1A1B724")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076B5C", Offset="0x1076B5C")]
		public MatchMakerInviteToRequest()
		{
		}

		[Address(RVA="0x1A1B72C", Offset="0x1A1B72C", VA="0x1A1B72C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076B6C", Offset="0x1076B6C")]
		public MatchMakerInviteToRequest(MatchMakerInviteToRequest other)
		{
		}

		[Address(RVA="0x1A1BAF4", Offset="0x1A1BAF4", VA="0x1A1BAF4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076BDC", Offset="0x1076BDC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A1B7D8", Offset="0x1A1B7D8", VA="0x1A1B7D8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076B7C", Offset="0x1076B7C")]
		public MatchMakerInviteToRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A1B838", Offset="0x1A1B838", VA="0x1A1B838", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076B8C", Offset="0x1076B8C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A1B8AC", Offset="0x1A1B8AC", VA="0x1A1B8AC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076B9C", Offset="0x1076B9C")]
		public bool Equals(MatchMakerInviteToRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A1B924", Offset="0x1A1B924", VA="0x1A1B924", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076BAC", Offset="0x1076BAC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A1BBC8", Offset="0x1A1BBC8", VA="0x1A1BBC8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076BEC", Offset="0x1076BEC")]
		public void MergeFrom(MatchMakerInviteToRequest other)
		{
		}

		[Address(RVA="0x1A1BCC4", Offset="0x1A1BCC4", VA="0x1A1BCC4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076BFC", Offset="0x1076BFC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A1B994", Offset="0x1A1B994", VA="0x1A1B994", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076BBC", Offset="0x1076BBC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A1B9FC", Offset="0x1A1B9FC", VA="0x1A1B9FC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076BCC", Offset="0x1076BCC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F0C8", Offset="0x104F0C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static MatchMakerInviteToRequest.<>c <>9;

			[Address(RVA="0x1A1BEAC", Offset="0x1A1BEAC", VA="0x1A1BEAC")]
			static <>c()
			{
			}

			[Address(RVA="0x1A1BF10", Offset="0x1A1BF10", VA="0x1A1BF10")]
			public <>c()
			{
			}

			[Address(RVA="0x1A1BF18", Offset="0x1A1BF18", VA="0x1A1BF18")]
			internal MatchMakerInviteToRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}