using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class CoopInviteToMatchRequest : IMessage<CoopInviteToMatchRequest>, IMessage, IEquatable<CoopInviteToMatchRequest>, IDeepCloneable<CoopInviteToMatchRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<CoopInviteToMatchRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int CampaignIdentifierFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private Serverproto.CampaignIdentifier campaignIdentifier_;

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
		public const int FriendIdFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private string friendId_;

		[FieldOffset(Offset="0x0")]
		public const int SquadSaveFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private BattleSquadSaveInfo squadSave_;

		[FieldOffset(Offset="0x0")]
		public const int EventIdFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private EventIdentifier eventId_;

		[FieldOffset(Offset="0x0")]
		public const int LeaderUnitFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private ulong leaderUnit_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092280", Offset="0x1092280")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1092280", Offset="0x1092280")]
		public Serverproto.CampaignIdentifier CampaignIdentifier
		{
			[Address(RVA="0x1EF1ED0", Offset="0x1EF1ED0", VA="0x1EF1ED0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EF1ED8", Offset="0x1EF1ED8", VA="0x1EF1ED8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092260", Offset="0x1092260")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1EF1BC4", Offset="0x1EF1BC4", VA="0x1EF1BC4")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10922F8", Offset="0x10922F8")]
		public EventIdentifier EventId
		{
			[Address(RVA="0x1EF1EF0", Offset="0x1EF1EF0", VA="0x1EF1EF0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EF1EF8", Offset="0x1EF1EF8", VA="0x1EF1EF8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10922D8", Offset="0x10922D8")]
		public string FriendId
		{
			[Address(RVA="0x1EF1F70", Offset="0x1EF1F70", VA="0x1EF1F70")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EF1F78", Offset="0x1EF1F78", VA="0x1EF1F78")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092308", Offset="0x1092308")]
		public ulong LeaderUnit
		{
			[Address(RVA="0x1EF1FE8", Offset="0x1EF1FE8", VA="0x1EF1FE8")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1EF1FF0", Offset="0x1EF1FF0", VA="0x1EF1FF0")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092250", Offset="0x1092250")]
		public static MessageParser<CoopInviteToMatchRequest> Parser
		{
			[Address(RVA="0x1EF1B5C", Offset="0x1EF1B5C", VA="0x1EF1B5C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1092270", Offset="0x1092270")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1EF1CB4", Offset="0x1EF1CB4", VA="0x1EF1CB4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10922C8", Offset="0x10922C8")]
		public RepeatedField<ulong> Spells
		{
			[Address(RVA="0x1EF1F68", Offset="0x1EF1F68", VA="0x1EF1F68")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10922E8", Offset="0x10922E8")]
		public BattleSquadSaveInfo SquadSave
		{
			[Address(RVA="0x1EF1EE0", Offset="0x1EF1EE0", VA="0x1EF1EE0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1EF1EE8", Offset="0x1EF1EE8", VA="0x1EF1EE8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10922B8", Offset="0x10922B8")]
		public RepeatedField<ulong> Units
		{
			[Address(RVA="0x1EF1F60", Offset="0x1EF1F60", VA="0x1EF1F60")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EF2CD0", Offset="0x1EF2CD0", VA="0x1EF2CD0")]
		static CoopInviteToMatchRequest()
		{
		}

		[Address(RVA="0x1EF1D10", Offset="0x1EF1D10", VA="0x1EF1D10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10765DC", Offset="0x10765DC")]
		public CoopInviteToMatchRequest()
		{
		}

		[Address(RVA="0x1EF1DB0", Offset="0x1EF1DB0", VA="0x1EF1DB0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10765EC", Offset="0x10765EC")]
		public CoopInviteToMatchRequest(CoopInviteToMatchRequest other)
		{
		}

		[Address(RVA="0x1EF2634", Offset="0x1EF2634", VA="0x1EF2634", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107665C", Offset="0x107665C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1EF1F00", Offset="0x1EF1F00", VA="0x1EF1F00", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10765FC", Offset="0x10765FC")]
		public CoopInviteToMatchRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1EF1FF8", Offset="0x1EF1FF8", VA="0x1EF1FF8", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107660C", Offset="0x107660C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF206C", Offset="0x1EF206C", VA="0x1EF206C", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107661C", Offset="0x107661C")]
		public bool Equals(CoopInviteToMatchRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1EF21B0", Offset="0x1EF21B0", VA="0x1EF21B0", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107662C", Offset="0x107662C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1EF2878", Offset="0x1EF2878", VA="0x1EF2878", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107666C", Offset="0x107666C")]
		public void MergeFrom(CoopInviteToMatchRequest other)
		{
		}

		[Address(RVA="0x1EF2A5C", Offset="0x1EF2A5C", VA="0x1EF2A5C", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107667C", Offset="0x107667C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1EF22FC", Offset="0x1EF22FC", VA="0x1EF22FC", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107663C", Offset="0x107663C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1EF2364", Offset="0x1EF2364", VA="0x1EF2364", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x107664C", Offset="0x107664C")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104F048", Offset="0x104F048")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static CoopInviteToMatchRequest.<>c <>9;

			[Address(RVA="0x1EF2DD8", Offset="0x1EF2DD8", VA="0x1EF2DD8")]
			static <>c()
			{
			}

			[Address(RVA="0x1EF2E3C", Offset="0x1EF2E3C", VA="0x1EF2E3C")]
			public <>c()
			{
			}

			[Address(RVA="0x1EF2E44", Offset="0x1EF2E44", VA="0x1EF2E44")]
			internal CoopInviteToMatchRequest <.cctor>b__55_0()
			{
				return null;
			}
		}
	}
}