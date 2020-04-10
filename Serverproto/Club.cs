using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class Club : IMessage<Club>, IMessage, IEquatable<Club>, IDeepCloneable<Club>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<Club> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string id_;

		[FieldOffset(Offset="0x0")]
		public const int NameFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private string name_;

		[FieldOffset(Offset="0x0")]
		public const int SettingsFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private ClubSettings settings_;

		[FieldOffset(Offset="0x0")]
		public const int RosterFieldNumber = 4;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<ClubRosterEntry> _repeated_roster_codec;

		[FieldOffset(Offset="0x30")]
		private readonly RepeatedField<ClubRosterEntry> roster_;

		[FieldOffset(Offset="0x0")]
		public const int MessagesFieldNumber = 5;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<ClubMessage> _repeated_messages_codec;

		[FieldOffset(Offset="0x38")]
		private readonly RepeatedField<ClubMessage> messages_;

		[FieldOffset(Offset="0x0")]
		public const int CreatedTimestampFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private ulong createdTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int InvitesFieldNumber = 7;

		[FieldOffset(Offset="0x18")]
		private readonly static FieldCodec<ClubInvite> _repeated_invites_codec;

		[FieldOffset(Offset="0x48")]
		private readonly RepeatedField<ClubInvite> invites_;

		[FieldOffset(Offset="0x0")]
		public const int ItemRequestsFieldNumber = 8;

		[FieldOffset(Offset="0x20")]
		private readonly static FieldCodec<ClubItemRequest> _repeated_itemRequests_codec;

		[FieldOffset(Offset="0x50")]
		private readonly RepeatedField<ClubItemRequest> itemRequests_;

		[FieldOffset(Offset="0x0")]
		public const int SupportRequestsFieldNumber = 9;

		[FieldOffset(Offset="0x28")]
		private readonly static FieldCodec<ClubSupportRequest> _repeated_supportRequests_codec;

		[FieldOffset(Offset="0x58")]
		private readonly RepeatedField<ClubSupportRequest> supportRequests_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094A00", Offset="0x1094A00")]
		public ulong CreatedTimestamp
		{
			[Address(RVA="0x1A46008", Offset="0x1A46008", VA="0x1A46008")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A46010", Offset="0x1A46010", VA="0x1A46010")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094990", Offset="0x1094990")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A45A9C", Offset="0x1A45A9C", VA="0x1A45A9C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10949B0", Offset="0x10949B0")]
		public string Id
		{
			[Address(RVA="0x1A45F08", Offset="0x1A45F08", VA="0x1A45F08")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A45F10", Offset="0x1A45F10", VA="0x1A45F10")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094A10", Offset="0x1094A10")]
		public RepeatedField<ClubInvite> Invites
		{
			[Address(RVA="0x1A46018", Offset="0x1A46018", VA="0x1A46018")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094A20", Offset="0x1094A20")]
		public RepeatedField<ClubItemRequest> ItemRequests
		{
			[Address(RVA="0x1A46020", Offset="0x1A46020", VA="0x1A46020")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10949F0", Offset="0x10949F0")]
		public RepeatedField<ClubMessage> Messages
		{
			[Address(RVA="0x1A46000", Offset="0x1A46000", VA="0x1A46000")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10949C0", Offset="0x10949C0")]
		public string Name
		{
			[Address(RVA="0x1A45F80", Offset="0x1A45F80", VA="0x1A45F80")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A45F88", Offset="0x1A45F88", VA="0x1A45F88")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094980", Offset="0x1094980")]
		public static MessageParser<Club> Parser
		{
			[Address(RVA="0x1A45A34", Offset="0x1A45A34", VA="0x1A45A34")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10949A0", Offset="0x10949A0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A45B8C", Offset="0x1A45B8C", VA="0x1A45B8C", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10949E0", Offset="0x10949E0")]
		public RepeatedField<ClubRosterEntry> Roster
		{
			[Address(RVA="0x1A45FF8", Offset="0x1A45FF8", VA="0x1A45FF8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10949D0", Offset="0x10949D0")]
		public ClubSettings Settings
		{
			[Address(RVA="0x1A45E98", Offset="0x1A45E98", VA="0x1A45E98")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A45EA0", Offset="0x1A45EA0", VA="0x1A45EA0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1094A30", Offset="0x1094A30")]
		public RepeatedField<ClubSupportRequest> SupportRequests
		{
			[Address(RVA="0x1A46028", Offset="0x1A46028", VA="0x1A46028")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1A46FDC", Offset="0x1A46FDC", VA="0x1A46FDC")]
		static Club()
		{
		}

		[Address(RVA="0x1A45BE8", Offset="0x1A45BE8", VA="0x1A45BE8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A99C", Offset="0x107A99C")]
		public Club()
		{
		}

		[Address(RVA="0x1A45D08", Offset="0x1A45D08", VA="0x1A45D08")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A9AC", Offset="0x107A9AC")]
		public Club(Club other)
		{
		}

		[Address(RVA="0x1A467E0", Offset="0x1A467E0", VA="0x1A467E0", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AA1C", Offset="0x107AA1C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A45EA8", Offset="0x1A45EA8", VA="0x1A45EA8", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A9BC", Offset="0x107A9BC")]
		public Club Clone()
		{
			return null;
		}

		[Address(RVA="0x1A46030", Offset="0x1A46030", VA="0x1A46030", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A9CC", Offset="0x107A9CC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A460A4", Offset="0x1A460A4", VA="0x1A460A4", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A9DC", Offset="0x107A9DC")]
		public bool Equals(Club other)
		{
			return new bool();
		}

		[Address(RVA="0x1A46260", Offset="0x1A46260", VA="0x1A46260", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A9EC", Offset="0x107A9EC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A46AC8", Offset="0x1A46AC8", VA="0x1A46AC8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AA2C", Offset="0x107AA2C")]
		public void MergeFrom(Club other)
		{
		}

		[Address(RVA="0x1A46CBC", Offset="0x1A46CBC", VA="0x1A46CBC", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AA3C", Offset="0x107AA3C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A46420", Offset="0x1A46420", VA="0x1A46420", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107A9FC", Offset="0x107A9FC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A46488", Offset="0x1A46488", VA="0x1A46488", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107AA0C", Offset="0x107AA0C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F6A8", Offset="0x104F6A8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static Club.<>c <>9;

			[Address(RVA="0x1A47230", Offset="0x1A47230", VA="0x1A47230")]
			static <>c()
			{
			}

			[Address(RVA="0x1A47294", Offset="0x1A47294", VA="0x1A47294")]
			public <>c()
			{
			}

			[Address(RVA="0x1A4729C", Offset="0x1A4729C", VA="0x1A4729C")]
			internal Club <.cctor>b__65_0()
			{
				return null;
			}
		}
	}
}