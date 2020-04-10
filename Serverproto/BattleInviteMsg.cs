using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class BattleInviteMsg : IMessage<BattleInviteMsg>, IMessage, IEquatable<BattleInviteMsg>, IDeepCloneable<BattleInviteMsg>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<BattleInviteMsg> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InviteFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private BattleInvite invite_;

		[FieldOffset(Offset="0x0")]
		public const int SenderProfileFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private PlayerProfileSimple senderProfile_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091C50", Offset="0x1091C50")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1E72CDC", Offset="0x1E72CDC", VA="0x1E72CDC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091C70", Offset="0x1091C70")]
		public BattleInvite Invite
		{
			[Address(RVA="0x1E72EBC", Offset="0x1E72EBC", VA="0x1E72EBC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1E72EC4", Offset="0x1E72EC4", VA="0x1E72EC4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091C40", Offset="0x1091C40")]
		public static MessageParser<BattleInviteMsg> Parser
		{
			[Address(RVA="0x1E72C74", Offset="0x1E72C74", VA="0x1E72C74")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091C60", Offset="0x1091C60")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1E72DCC", Offset="0x1E72DCC", VA="0x1E72DCC", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091C80", Offset="0x1091C80")]
		public PlayerProfileSimple SenderProfile
		{
			[Address(RVA="0x1E72ECC", Offset="0x1E72ECC", VA="0x1E72ECC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1E72ED4", Offset="0x1E72ED4", VA="0x1E72ED4")]
			set
			{
			}
		}

		[Address(RVA="0x1E734D8", Offset="0x1E734D8", VA="0x1E734D8")]
		static BattleInviteMsg()
		{
		}

		[Address(RVA="0x1E72E28", Offset="0x1E72E28", VA="0x1E72E28")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075C3C", Offset="0x1075C3C")]
		public BattleInviteMsg()
		{
		}

		[Address(RVA="0x1E72E30", Offset="0x1E72E30", VA="0x1E72E30")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075C4C", Offset="0x1075C4C")]
		public BattleInviteMsg(BattleInviteMsg other)
		{
		}

		[Address(RVA="0x1E731F8", Offset="0x1E731F8", VA="0x1E731F8", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075CBC", Offset="0x1075CBC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1E72EDC", Offset="0x1E72EDC", VA="0x1E72EDC", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075C5C", Offset="0x1075C5C")]
		public BattleInviteMsg Clone()
		{
			return null;
		}

		[Address(RVA="0x1E72F3C", Offset="0x1E72F3C", VA="0x1E72F3C", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075C6C", Offset="0x1075C6C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1E72FB0", Offset="0x1E72FB0", VA="0x1E72FB0", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075C7C", Offset="0x1075C7C")]
		public bool Equals(BattleInviteMsg other)
		{
			return new bool();
		}

		[Address(RVA="0x1E73028", Offset="0x1E73028", VA="0x1E73028", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075C8C", Offset="0x1075C8C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1E732CC", Offset="0x1E732CC", VA="0x1E732CC", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075CCC", Offset="0x1075CCC")]
		public void MergeFrom(BattleInviteMsg other)
		{
		}

		[Address(RVA="0x1E733C8", Offset="0x1E733C8", VA="0x1E733C8", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075CDC", Offset="0x1075CDC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1E73098", Offset="0x1E73098", VA="0x1E73098", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075C9C", Offset="0x1075C9C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1E73100", Offset="0x1E73100", VA="0x1E73100", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075CAC", Offset="0x1075CAC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EF68", Offset="0x104EF68")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static BattleInviteMsg.<>c <>9;

			[Address(RVA="0x1E735B0", Offset="0x1E735B0", VA="0x1E735B0")]
			static <>c()
			{
			}

			[Address(RVA="0x1E73614", Offset="0x1E73614", VA="0x1E73614")]
			public <>c()
			{
			}

			[Address(RVA="0x1E7361C", Offset="0x1E7361C", VA="0x1E7361C")]
			internal BattleInviteMsg <.cctor>b__30_0()
			{
				return null;
			}
		}
	}
}