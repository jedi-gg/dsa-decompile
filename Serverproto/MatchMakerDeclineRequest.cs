using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class MatchMakerDeclineRequest : IMessage<MatchMakerDeclineRequest>, IMessage, IEquatable<MatchMakerDeclineRequest>, IDeepCloneable<MatchMakerDeclineRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<MatchMakerDeclineRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int SenderIdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string senderId_;

		[FieldOffset(Offset="0x0")]
		public const int InviteFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private BattleInvite invite_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092710", Offset="0x1092710")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A1AAF0", Offset="0x1A1AAF0", VA="0x1A1AAF0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092740", Offset="0x1092740")]
		public BattleInvite Invite
		{
			[Address(RVA="0x1A1AD08", Offset="0x1A1AD08", VA="0x1A1AD08")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A1AD10", Offset="0x1A1AD10", VA="0x1A1AD10")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092700", Offset="0x1092700")]
		public static MessageParser<MatchMakerDeclineRequest> Parser
		{
			[Address(RVA="0x1A1AA88", Offset="0x1A1AA88", VA="0x1A1AA88")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092720", Offset="0x1092720")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A1ABE0", Offset="0x1A1ABE0", VA="0x1A1ABE0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092730", Offset="0x1092730")]
		public string SenderId
		{
			[Address(RVA="0x1A1AD78", Offset="0x1A1AD78", VA="0x1A1AD78")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A1AD80", Offset="0x1A1AD80", VA="0x1A1AD80")]
			set
			{
			}
		}

		[Address(RVA="0x1A1B3D4", Offset="0x1A1B3D4", VA="0x1A1B3D4")]
		static MatchMakerDeclineRequest()
		{
		}

		[Address(RVA="0x1A1AC3C", Offset="0x1A1AC3C", VA="0x1A1AC3C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076D6C", Offset="0x1076D6C")]
		public MatchMakerDeclineRequest()
		{
		}

		[Address(RVA="0x1A1AC94", Offset="0x1A1AC94", VA="0x1A1AC94")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076D7C", Offset="0x1076D7C")]
		public MatchMakerDeclineRequest(MatchMakerDeclineRequest other)
		{
		}

		[Address(RVA="0x1A1B0F0", Offset="0x1A1B0F0", VA="0x1A1B0F0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076DEC", Offset="0x1076DEC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A1AD18", Offset="0x1A1AD18", VA="0x1A1AD18", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076D8C", Offset="0x1076D8C")]
		public MatchMakerDeclineRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1A1ADF0", Offset="0x1A1ADF0", VA="0x1A1ADF0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076D9C", Offset="0x1076D9C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A1AE64", Offset="0x1A1AE64", VA="0x1A1AE64", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076DAC", Offset="0x1076DAC")]
		public bool Equals(MatchMakerDeclineRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1A1AEDC", Offset="0x1A1AEDC", VA="0x1A1AEDC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076DBC", Offset="0x1076DBC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A1B1E8", Offset="0x1A1B1E8", VA="0x1A1B1E8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076DFC", Offset="0x1076DFC")]
		public void MergeFrom(MatchMakerDeclineRequest other)
		{
		}

		[Address(RVA="0x1A1B2C8", Offset="0x1A1B2C8", VA="0x1A1B2C8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076E0C", Offset="0x1076E0C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A1AF78", Offset="0x1A1AF78", VA="0x1A1AF78", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076DCC", Offset="0x1076DCC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A1AFE0", Offset="0x1A1AFE0", VA="0x1A1AFE0", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1076DDC", Offset="0x1076DDC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F0F8", Offset="0x104F0F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static MatchMakerDeclineRequest.<>c <>9;

			[Address(RVA="0x1A1B4AC", Offset="0x1A1B4AC", VA="0x1A1B4AC")]
			static <>c()
			{
			}

			[Address(RVA="0x1A1B510", Offset="0x1A1B510", VA="0x1A1B510")]
			public <>c()
			{
			}

			[Address(RVA="0x1A1B518", Offset="0x1A1B518", VA="0x1A1B518")]
			internal MatchMakerDeclineRequest <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}