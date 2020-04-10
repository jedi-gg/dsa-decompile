using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CoopAcceptMatchRequest : IMessage<CoopAcceptMatchRequest>, IMessage, IEquatable<CoopAcceptMatchRequest>, IDeepCloneable<CoopAcceptMatchRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CoopAcceptMatchRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int InviteFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private BattleInvite invite_;

		[FieldOffset(Offset="0x0")]
		public const int UnitsFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ulong> _repeated_units_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<ulong> units_;

		[FieldOffset(Offset="0x0")]
		public const int SpellsFieldNumber = 3;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ulong> _repeated_spells_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<ulong> spells_;

		[FieldOffset(Offset="0x0")]
		public const int LeaderUnitFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong leaderUnit_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092328", Offset="0x1092328")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EEE8D4", Offset="0x1EEE8D4", VA="0x1EEE8D4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092348", Offset="0x1092348")]
		public BattleInvite Invite
		{
			[Address(RVA="0x1EEEBA0", Offset="0x1EEEBA0", VA="0x1EEEBA0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EEEBA8", Offset="0x1EEEBA8", VA="0x1EEEBA8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092378", Offset="0x1092378")]
		public ulong LeaderUnit
		{
			[Address(RVA="0x1EEEC20", Offset="0x1EEEC20", VA="0x1EEEC20")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EEEC28", Offset="0x1EEEC28", VA="0x1EEEC28")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092318", Offset="0x1092318")]
		public static MessageParser<CoopAcceptMatchRequest> Parser
		{
			[Address(RVA="0x1EEE86C", Offset="0x1EEE86C", VA="0x1EEE86C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092338", Offset="0x1092338")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EEE9C4", Offset="0x1EEE9C4", VA="0x1EEE9C4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092368", Offset="0x1092368")]
		public RepeatedField<ulong> Spells
		{
			[Address(RVA="0x1EEEC18", Offset="0x1EEEC18", VA="0x1EEEC18")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092358", Offset="0x1092358")]
		public RepeatedField<ulong> Units
		{
			[Address(RVA="0x1EEEC10", Offset="0x1EEEC10", VA="0x1EEEC10")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EEF4D0", Offset="0x1EEF4D0", VA="0x1EEF4D0")]
		static CoopAcceptMatchRequest()
		{
		}

		[Address(RVA="0x1EEEA20", Offset="0x1EEEA20", VA="0x1EEEA20")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107668C", Offset="0x107668C")]
		public CoopAcceptMatchRequest()
		{
		}

		[Address(RVA="0x1EEEAB0", Offset="0x1EEEAB0", VA="0x1EEEAB0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107669C", Offset="0x107669C")]
		public CoopAcceptMatchRequest(CoopAcceptMatchRequest other)
		{
		}

		[Address(RVA="0x1EEF08C", Offset="0x1EEF08C", VA="0x1EEF08C", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107670C", Offset="0x107670C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EEEBB0", Offset="0x1EEEBB0", VA="0x1EEEBB0", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10766AC", Offset="0x10766AC")]
		public CoopAcceptMatchRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1EEEC30", Offset="0x1EEEC30", VA="0x1EEEC30", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10766BC", Offset="0x10766BC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EEECA4", Offset="0x1EEECA4", VA="0x1EEECA4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10766CC", Offset="0x10766CC")]
		public bool Equals(CoopAcceptMatchRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1EEEDAC", Offset="0x1EEEDAC", VA="0x1EEEDAC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10766DC", Offset="0x10766DC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EEF1F8", Offset="0x1EEF1F8", VA="0x1EEF1F8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107671C", Offset="0x107671C")]
		public void MergeFrom(CoopAcceptMatchRequest other)
		{
		}

		[Address(RVA="0x1EEF310", Offset="0x1EEF310", VA="0x1EEF310", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107672C", Offset="0x107672C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EEEE74", Offset="0x1EEEE74", VA="0x1EEEE74", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10766EC", Offset="0x10766EC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EEEEDC", Offset="0x1EEEEDC", VA="0x1EEEEDC", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10766FC", Offset="0x10766FC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F058", Offset="0x104F058")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CoopAcceptMatchRequest.<>c <>9;

			[Address(RVA="0x1EEF5D8", Offset="0x1EEF5D8", VA="0x1EEF5D8")]
			static <>c()
			{
			}

			[Address(RVA="0x1EEF63C", Offset="0x1EEF63C", VA="0x1EEF63C")]
			public <>c()
			{
			}

			[Address(RVA="0x1EEF644", Offset="0x1EEF644", VA="0x1EEF644")]
			internal CoopAcceptMatchRequest <.cctor>b__40_0()
			{
				return null;
			}
		}
	}
}