using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CancelBattleInviteMsg : IMessage<CancelBattleInviteMsg>, IMessage, IEquatable<CancelBattleInviteMsg>, IDeepCloneable<CancelBattleInviteMsg>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CancelBattleInviteMsg> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InviteFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private BattleInvite invite_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091CA0", Offset="0x1091CA0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1F96574", Offset="0x1F96574", VA="0x1F96574")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091CC0", Offset="0x1091CC0")]
		public BattleInvite Invite
		{
			[Address(RVA="0x1F96744", Offset="0x1F96744", VA="0x1F96744")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F9674C", Offset="0x1F9674C", VA="0x1F9674C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091C90", Offset="0x1091C90")]
		public static MessageParser<CancelBattleInviteMsg> Parser
		{
			[Address(RVA="0x1F9650C", Offset="0x1F9650C", VA="0x1F9650C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1091CB0", Offset="0x1091CB0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1F96664", Offset="0x1F96664", VA="0x1F96664", Slot="7")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1F96C0C", Offset="0x1F96C0C", VA="0x1F96C0C")]
		static CancelBattleInviteMsg()
		{
		}

		[Address(RVA="0x1F966C0", Offset="0x1F966C0", VA="0x1F966C0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075CEC", Offset="0x1075CEC")]
		public CancelBattleInviteMsg()
		{
		}

		[Address(RVA="0x1F966C8", Offset="0x1F966C8", VA="0x1F966C8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075CFC", Offset="0x1075CFC")]
		public CancelBattleInviteMsg(CancelBattleInviteMsg other)
		{
		}

		[Address(RVA="0x1F969EC", Offset="0x1F969EC", VA="0x1F969EC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075D6C", Offset="0x1075D6C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1F96754", Offset="0x1F96754", VA="0x1F96754", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075D0C", Offset="0x1075D0C")]
		public CancelBattleInviteMsg Clone()
		{
			return null;
		}

		[Address(RVA="0x1F967B4", Offset="0x1F967B4", VA="0x1F967B4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075D1C", Offset="0x1075D1C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1F96828", Offset="0x1F96828", VA="0x1F96828", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075D2C", Offset="0x1075D2C")]
		public bool Equals(CancelBattleInviteMsg other)
		{
			return new bool();
		}

		[Address(RVA="0x1F9688C", Offset="0x1F9688C", VA="0x1F9688C", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075D3C", Offset="0x1075D3C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1F96A7C", Offset="0x1F96A7C", VA="0x1F96A7C", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075D7C", Offset="0x1075D7C")]
		public void MergeFrom(CancelBattleInviteMsg other)
		{
		}

		[Address(RVA="0x1F96B30", Offset="0x1F96B30", VA="0x1F96B30", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075D8C", Offset="0x1075D8C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1F968E4", Offset="0x1F968E4", VA="0x1F968E4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075D4C", Offset="0x1075D4C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1F9694C", Offset="0x1F9694C", VA="0x1F9694C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1075D5C", Offset="0x1075D5C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104EF78", Offset="0x104EF78")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CancelBattleInviteMsg.<>c <>9;

			[Address(RVA="0x1F96CE4", Offset="0x1F96CE4", VA="0x1F96CE4")]
			static <>c()
			{
			}

			[Address(RVA="0x1F96D48", Offset="0x1F96D48", VA="0x1F96D48")]
			public <>c()
			{
			}

			[Address(RVA="0x1F96D50", Offset="0x1F96D50", VA="0x1F96D50")]
			internal CancelBattleInviteMsg <.cctor>b__25_0()
			{
				return null;
			}
		}
	}
}