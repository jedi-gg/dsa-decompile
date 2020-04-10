using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class MatchMakerAcceptRequest : IMessage<MatchMakerAcceptRequest>, IMessage, IEquatable<MatchMakerAcceptRequest>, IDeepCloneable<MatchMakerAcceptRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<MatchMakerAcceptRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int PlayerInfoFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private MatchMakerPlayerInfo playerInfo_;

		[FieldOffset(Offset="0x0")]
		public const int SenderIdFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string senderId_;

		[FieldOffset(Offset="0x0")]
		public const int InviteFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private BattleInvite invite_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092670", Offset="0x1092670")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A192BC", Offset="0x1A192BC", VA="0x1A192BC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10926B0", Offset="0x10926B0")]
		public BattleInvite Invite
		{
			[Address(RVA="0x1A19560", Offset="0x1A19560", VA="0x1A19560")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A19568", Offset="0x1A19568", VA="0x1A19568")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092660", Offset="0x1092660")]
		public static MessageParser<MatchMakerAcceptRequest> Parser
		{
			[Address(RVA="0x1A19254", Offset="0x1A19254", VA="0x1A19254")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092680", Offset="0x1092680")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A193AC", Offset="0x1A193AC", VA="0x1A193AC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092690", Offset="0x1092690")]
		public MatchMakerPlayerInfo PlayerInfo
		{
			[Address(RVA="0x1A194F0", Offset="0x1A194F0", VA="0x1A194F0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A19558", Offset="0x1A19558", VA="0x1A19558")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10926A0", Offset="0x10926A0")]
		public string SenderId
		{
			[Address(RVA="0x1A195D0", Offset="0x1A195D0", VA="0x1A195D0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A195D8", Offset="0x1A195D8", VA="0x1A195D8")]
			set
			{
			}
		}

		[Address(RVA="0x1A19FEC", Offset="0x1A19FEC", VA="0x1A19FEC")]
		static MatchMakerAcceptRequest()
		{
		}

		[Address(RVA="0x1A19408", Offset="0x1A19408", VA="0x1A19408")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076C0C", Offset="0x1076C0C")]
		public MatchMakerAcceptRequest()
		{
		}

		[Address(RVA="0x1A19460", Offset="0x1A19460", VA="0x1A19460")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076C1C", Offset="0x1076C1C")]
		public MatchMakerAcceptRequest(MatchMakerAcceptRequest other)
		{
		}

		[Address(RVA="0x1A199D4", Offset="0x1A199D4", VA="0x1A199D4", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076C8C", Offset="0x1076C8C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A19570", Offset="0x1A19570", VA="0x1A19570", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076C2C", Offset="0x1076C2C")]
		public MatchMakerAcceptRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A19648", Offset="0x1A19648", VA="0x1A19648", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076C3C", Offset="0x1076C3C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A196BC", Offset="0x1A196BC", VA="0x1A196BC", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076C4C", Offset="0x1076C4C")]
		public bool Equals(MatchMakerAcceptRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A19748", Offset="0x1A19748", VA="0x1A19748", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076C5C", Offset="0x1076C5C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A19B00", Offset="0x1A19B00", VA="0x1A19B00", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076C9C", Offset="0x1076C9C")]
		public void MergeFrom(MatchMakerAcceptRequest other)
		{
		}

		[Address(RVA="0x1A19EA4", Offset="0x1A19EA4", VA="0x1A19EA4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076CAC", Offset="0x1076CAC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A19804", Offset="0x1A19804", VA="0x1A19804", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076C6C", Offset="0x1076C6C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A1986C", Offset="0x1A1986C", VA="0x1A1986C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076C7C", Offset="0x1076C7C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F0D8", Offset="0x104F0D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static MatchMakerAcceptRequest.<>c <>9;

			[Address(RVA="0x1A1A0C4", Offset="0x1A1A0C4", VA="0x1A1A0C4")]
			static <>c()
			{
			}

			[Address(RVA="0x1A1A128", Offset="0x1A1A128", VA="0x1A1A128")]
			public <>c()
			{
			}

			[Address(RVA="0x1A1A130", Offset="0x1A1A130", VA="0x1A1A130")]
			internal MatchMakerAcceptRequest <.cctor>b__35_0()
			{
				return null;
			}
		}
	}
}