using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class Player : IMessage<Player>, IMessage, IEquatable<Player>, IDeepCloneable<Player>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<Player> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int IdFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private string id_;

		[FieldOffset(Offset="0x0")]
		public const int UnitInventoryFieldNumber = 2;

		[FieldOffset(Offset="0x8")]
		private readonly static FieldCodec<Unit> _repeated_unitInventory_codec;

		[FieldOffset(Offset="0x20")]
		private readonly RepeatedField<Unit> unitInventory_;

		[FieldOffset(Offset="0x0")]
		public const int ItemInventoryFieldNumber = 3;

		[FieldOffset(Offset="0x10")]
		private readonly static FieldCodec<InventoryItem> _repeated_itemInventory_codec;

		[FieldOffset(Offset="0x28")]
		private readonly RepeatedField<InventoryItem> itemInventory_;

		[FieldOffset(Offset="0x0")]
		public const int LevelFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private ulong level_;

		[FieldOffset(Offset="0x0")]
		public const int ActivitiesFieldNumber = 5;

		[FieldOffset(Offset="0x18")]
		private readonly static FieldCodec<PlayerActivity> _repeated_activities_codec;

		[FieldOffset(Offset="0x38")]
		private readonly RepeatedField<PlayerActivity> activities_;

		[FieldOffset(Offset="0x0")]
		public const int CampaignProgressFieldNumber = 6;

		[FieldOffset(Offset="0x20")]
		private readonly static FieldCodec<Serverproto.CampaignProgress> _repeated_campaignProgress_codec;

		[FieldOffset(Offset="0x40")]
		private readonly RepeatedField<Serverproto.CampaignProgress> campaignProgress_;

		[FieldOffset(Offset="0x0")]
		public const int DayEndTimestampFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private ulong dayEndTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int EnergyTrackersFieldNumber = 8;

		[FieldOffset(Offset="0x28")]
		private readonly static FieldCodec<PlayerEnergyTracker> _repeated_energyTrackers_codec;

		[FieldOffset(Offset="0x50")]
		private readonly RepeatedField<PlayerEnergyTracker> energyTrackers_;

		[FieldOffset(Offset="0x0")]
		public const int SpellInventoryFieldNumber = 9;

		[FieldOffset(Offset="0x30")]
		private readonly static FieldCodec<Spell> _repeated_spellInventory_codec;

		[FieldOffset(Offset="0x58")]
		private readonly RepeatedField<Spell> spellInventory_;

		[FieldOffset(Offset="0x0")]
		public const int UsernameFieldNumber = 10;

		[FieldOffset(Offset="0x60")]
		private string username_;

		[FieldOffset(Offset="0x0")]
		public const int SquadSelectionsFieldNumber = 11;

		[FieldOffset(Offset="0x38")]
		private readonly static FieldCodec<PlayerSquadSelection> _repeated_squadSelections_codec;

		[FieldOffset(Offset="0x68")]
		private readonly RepeatedField<PlayerSquadSelection> squadSelections_;

		[FieldOffset(Offset="0x0")]
		public const int AvatarIdFieldNumber = 12;

		[FieldOffset(Offset="0x70")]
		private ulong avatarId_;

		[FieldOffset(Offset="0x0")]
		public const int ClubIdFieldNumber = 13;

		[FieldOffset(Offset="0x78")]
		private string clubId_;

		[FieldOffset(Offset="0x0")]
		public const int ClubNameFieldNumber = 14;

		[FieldOffset(Offset="0x80")]
		private string clubName_;

		[FieldOffset(Offset="0x0")]
		public const int ClubAvatarIdFieldNumber = 15;

		[FieldOffset(Offset="0x88")]
		private ulong clubAvatarId_;

		[FieldOffset(Offset="0x0")]
		public const int ClubRoleFieldNumber = 16;

		[FieldOffset(Offset="0x90")]
		private Serverproto.ClubRole clubRole_;

		[FieldOffset(Offset="0x0")]
		public const int ClubInvitesFieldNumber = 17;

		[FieldOffset(Offset="0x40")]
		private readonly static FieldCodec<ClubInvite> _repeated_clubInvites_codec;

		[FieldOffset(Offset="0x98")]
		private readonly RepeatedField<ClubInvite> clubInvites_;

		[FieldOffset(Offset="0x0")]
		public const int ClubItemRequestsFieldNumber = 18;

		[FieldOffset(Offset="0x48")]
		private readonly static FieldCodec<ClubItemRequest> _repeated_clubItemRequests_codec;

		[FieldOffset(Offset="0xA0")]
		private readonly RepeatedField<ClubItemRequest> clubItemRequests_;

		[FieldOffset(Offset="0x0")]
		public const int ClubRequestableItemsFieldNumber = 19;

		[FieldOffset(Offset="0x50")]
		private readonly static FieldCodec<ulong> _repeated_clubRequestableItems_codec;

		[FieldOffset(Offset="0xA8")]
		private readonly RepeatedField<ulong> clubRequestableItems_;

		[FieldOffset(Offset="0x0")]
		public const int NextClubItemRequestTimestampFieldNumber = 20;

		[FieldOffset(Offset="0xB0")]
		private ulong nextClubItemRequestTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int ClubItemDonationsRemainingFieldNumber = 21;

		[FieldOffset(Offset="0xB8")]
		private ulong clubItemDonationsRemaining_;

		[FieldOffset(Offset="0x0")]
		public const int ClubItemDonationsResetTimestampFieldNumber = 22;

		[FieldOffset(Offset="0xC0")]
		private ulong clubItemDonationsResetTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int DailyLoginStatusFieldNumber = 23;

		[FieldOffset(Offset="0xC8")]
		private Serverproto.DailyLoginStatus dailyLoginStatus_;

		[FieldOffset(Offset="0x0")]
		public const int CurrentCalendarDateFieldNumber = 24;

		[FieldOffset(Offset="0xD0")]
		private CalendarDate currentCalendarDate_;

		[FieldOffset(Offset="0x0")]
		public const int ShipmentResetTimestampFieldNumber = 25;

		[FieldOffset(Offset="0xD8")]
		private ulong shipmentResetTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int ShowVipProfileBgFieldNumber = 26;

		[FieldOffset(Offset="0xE0")]
		private bool showVipProfileBg_;

		[FieldOffset(Offset="0x0")]
		public const int CollectionPowerFieldNumber = 27;

		[FieldOffset(Offset="0xE8")]
		private ulong collectionPower_;

		[FieldOffset(Offset="0x0")]
		public const int UnlockedFeaturesFieldNumber = 28;

		[FieldOffset(Offset="0x58")]
		private readonly static FieldCodec<ulong> _repeated_unlockedFeatures_codec;

		[FieldOffset(Offset="0xF0")]
		private readonly RepeatedField<ulong> unlockedFeatures_;

		[FieldOffset(Offset="0x0")]
		public const int DisabledFeaturesFieldNumber = 29;

		[FieldOffset(Offset="0x60")]
		private readonly static FieldCodec<ulong> _repeated_disabledFeatures_codec;

		[FieldOffset(Offset="0xF8")]
		private readonly RepeatedField<ulong> disabledFeatures_;

		[FieldOffset(Offset="0x0")]
		public const int EventProgressFieldNumber = 30;

		[FieldOffset(Offset="0x68")]
		private readonly static FieldCodec<Serverproto.EventProgress> _repeated_eventProgress_codec;

		[FieldOffset(Offset="0x100")]
		private readonly RepeatedField<Serverproto.EventProgress> eventProgress_;

		[FieldOffset(Offset="0x0")]
		public const int EventStatusFieldNumber = 31;

		[FieldOffset(Offset="0x70")]
		private readonly static FieldCodec<Serverproto.EventStatus> _repeated_eventStatus_codec;

		[FieldOffset(Offset="0x108")]
		private readonly RepeatedField<Serverproto.EventStatus> eventStatus_;

		[FieldOffset(Offset="0x0")]
		public const int ChatAccessTokenFieldNumber = 32;

		[FieldOffset(Offset="0x110")]
		private string chatAccessToken_;

		[FieldOffset(Offset="0x0")]
		public const int NextFreeStoreItemTimestampFieldNumber = 33;

		[FieldOffset(Offset="0x118")]
		private ulong nextFreeStoreItemTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int PvpScoreFieldNumber = 34;

		[FieldOffset(Offset="0x120")]
		private Serverproto.PvpScore pvpScore_;

		[FieldOffset(Offset="0x0")]
		public const int AgeGateStatusFieldNumber = 35;

		[FieldOffset(Offset="0x128")]
		private Serverproto.AgeGateStatus ageGateStatus_;

		[FieldOffset(Offset="0x0")]
		public const int UnlockedContextualMessageGroupIdsFieldNumber = 36;

		[FieldOffset(Offset="0x78")]
		private readonly static FieldCodec<ulong> _repeated_unlockedContextualMessageGroupIds_codec;

		[FieldOffset(Offset="0x130")]
		private readonly RepeatedField<ulong> unlockedContextualMessageGroupIds_;

		[FieldOffset(Offset="0x0")]
		public const int VariantIdsFieldNumber = 37;

		[FieldOffset(Offset="0x80")]
		private readonly static FieldCodec<ulong> _repeated_variantIds_codec;

		[FieldOffset(Offset="0x138")]
		private readonly RepeatedField<ulong> variantIds_;

		[FieldOffset(Offset="0x0")]
		public const int DailyStoreAdRewardsClaimedFieldNumber = 38;

		[FieldOffset(Offset="0x140")]
		private ulong dailyStoreAdRewardsClaimed_;

		[FieldOffset(Offset="0x0")]
		public const int IsSpenderFieldNumber = 39;

		[FieldOffset(Offset="0x148")]
		private bool isSpender_;

		[FieldOffset(Offset="0x0")]
		public const int ChatServerAppIdFieldNumber = 40;

		[FieldOffset(Offset="0x150")]
		private string chatServerAppId_;

		[FieldOffset(Offset="0x0")]
		public const int LeftClubTimestampFieldNumber = 41;

		[FieldOffset(Offset="0x158")]
		private ulong leftClubTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int JoinClubLockLevelFieldNumber = 42;

		[FieldOffset(Offset="0x160")]
		private ulong joinClubLockLevel_;

		[FieldOffset(Offset="0x0")]
		public const int CreationTimestampFieldNumber = 43;

		[FieldOffset(Offset="0x168")]
		private ulong creationTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int EmoteDeckFieldNumber = 44;

		[FieldOffset(Offset="0x88")]
		private readonly static FieldCodec<ulong> _repeated_emoteDeck_codec;

		[FieldOffset(Offset="0x170")]
		private readonly RepeatedField<ulong> emoteDeck_;

		[FieldOffset(Offset="0x0")]
		public const int KothPayoutTimestampFieldNumber = 45;

		[FieldOffset(Offset="0x178")]
		private ulong kothPayoutTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int ClubSupportFulfillCooldownExpireTimestampFieldNumber = 46;

		[FieldOffset(Offset="0x180")]
		private long clubSupportFulfillCooldownExpireTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int DailyRewardFieldNumber = 47;

		[FieldOffset(Offset="0x188")]
		private Serverproto.DailyReward dailyReward_;

		[FieldOffset(Offset="0x0")]
		public const int VipExpireTimestampFieldNumber = 48;

		[FieldOffset(Offset="0x190")]
		private ulong vipExpireTimestamp_;

		[FieldOffset(Offset="0x0")]
		public const int KothRankFieldNumber = 49;

		[FieldOffset(Offset="0x198")]
		private ulong kothRank_;

		[FieldOffset(Offset="0x0")]
		public const int GlobalChatChannelNameFieldNumber = 50;

		[FieldOffset(Offset="0x1A0")]
		private string globalChatChannelName_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099A48", Offset="0x1099A48")]
		public RepeatedField<PlayerActivity> Activities
		{
			[Address(RVA="0x1A27854", Offset="0x1A27854", VA="0x1A27854")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099D40", Offset="0x1099D40")]
		public Serverproto.AgeGateStatus AgeGateStatus
		{
			[Address(RVA="0x1A27B48", Offset="0x1A27B48", VA="0x1A27B48")]
			get
			{
				return new Serverproto.AgeGateStatus();
			}
			[Address(RVA="0x1A27B50", Offset="0x1A27B50", VA="0x1A27B50")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099AB8", Offset="0x1099AB8")]
		public ulong AvatarId
		{
			[Address(RVA="0x1A27904", Offset="0x1A27904", VA="0x1A27904")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A2790C", Offset="0x1A2790C", VA="0x1A2790C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099A58", Offset="0x1099A58")]
		public RepeatedField<Serverproto.CampaignProgress> CampaignProgress
		{
			[Address(RVA="0x1A2785C", Offset="0x1A2785C", VA="0x1A2785C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099CE8", Offset="0x1099CE8")]
		public string ChatAccessToken
		{
			[Address(RVA="0x1A27AC0", Offset="0x1A27AC0", VA="0x1A27AC0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A27AC8", Offset="0x1A27AC8", VA="0x1A27AC8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099D90", Offset="0x1099D90")]
		public string ChatServerAppId
		{
			[Address(RVA="0x1A27B8C", Offset="0x1A27B8C", VA="0x1A27B8C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A27B94", Offset="0x1A27B94", VA="0x1A27B94")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099AE8", Offset="0x1099AE8")]
		public ulong ClubAvatarId
		{
			[Address(RVA="0x1A27A04", Offset="0x1A27A04", VA="0x1A27A04")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A27A0C", Offset="0x1A27A0C", VA="0x1A27A0C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099AC8", Offset="0x1099AC8")]
		public string ClubId
		{
			[Address(RVA="0x1A27914", Offset="0x1A27914", VA="0x1A27914")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A2791C", Offset="0x1A2791C", VA="0x1A2791C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099B08", Offset="0x1099B08")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1099B08", Offset="0x1099B08")]
		public RepeatedField<ClubInvite> ClubInvites
		{
			[Address(RVA="0x1A27A24", Offset="0x1A27A24", VA="0x1A27A24")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099BE8", Offset="0x1099BE8")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1099BE8", Offset="0x1099BE8")]
		public ulong ClubItemDonationsRemaining
		{
			[Address(RVA="0x1A27A4C", Offset="0x1A27A4C", VA="0x1A27A4C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A27A54", Offset="0x1A27A54", VA="0x1A27A54")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099C20", Offset="0x1099C20")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1099C20", Offset="0x1099C20")]
		public ulong ClubItemDonationsResetTimestamp
		{
			[Address(RVA="0x1A27A5C", Offset="0x1A27A5C", VA="0x1A27A5C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A27A64", Offset="0x1A27A64", VA="0x1A27A64")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099B40", Offset="0x1099B40")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1099B40", Offset="0x1099B40")]
		public RepeatedField<ClubItemRequest> ClubItemRequests
		{
			[Address(RVA="0x1A27A2C", Offset="0x1A27A2C", VA="0x1A27A2C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099AD8", Offset="0x1099AD8")]
		public string ClubName
		{
			[Address(RVA="0x1A2798C", Offset="0x1A2798C", VA="0x1A2798C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A27994", Offset="0x1A27994", VA="0x1A27994")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099B78", Offset="0x1099B78")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1099B78", Offset="0x1099B78")]
		public RepeatedField<ulong> ClubRequestableItems
		{
			[Address(RVA="0x1A27A34", Offset="0x1A27A34", VA="0x1A27A34")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099AF8", Offset="0x1099AF8")]
		public Serverproto.ClubRole ClubRole
		{
			[Address(RVA="0x1A27A14", Offset="0x1A27A14", VA="0x1A27A14")]
			get
			{
				return new Serverproto.ClubRole();
			}
			[Address(RVA="0x1A27A1C", Offset="0x1A27A1C", VA="0x1A27A1C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099DF0", Offset="0x1099DF0")]
		public long ClubSupportFulfillCooldownExpireTimestamp
		{
			[Address(RVA="0x1A27C4C", Offset="0x1A27C4C", VA="0x1A27C4C")]
			get
			{
				return new long();
			}
			[Address(RVA="0x1A27C54", Offset="0x1A27C54", VA="0x1A27C54")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099C98", Offset="0x1099C98")]
		public ulong CollectionPower
		{
			[Address(RVA="0x1A27A90", Offset="0x1A27A90", VA="0x1A27A90")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A27A98", Offset="0x1A27A98", VA="0x1A27A98")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099DC0", Offset="0x1099DC0")]
		public ulong CreationTimestamp
		{
			[Address(RVA="0x1A27C24", Offset="0x1A27C24", VA="0x1A27C24")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A27C2C", Offset="0x1A27C2C", VA="0x1A27C2C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099C68", Offset="0x1099C68")]
		public CalendarDate CurrentCalendarDate
		{
			[Address(RVA="0x1A2772C", Offset="0x1A2772C", VA="0x1A2772C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A27734", Offset="0x1A27734", VA="0x1A27734")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099C58", Offset="0x1099C58")]
		public Serverproto.DailyLoginStatus DailyLoginStatus
		{
			[Address(RVA="0x1A2771C", Offset="0x1A2771C", VA="0x1A2771C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A27724", Offset="0x1A27724", VA="0x1A27724")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099E00", Offset="0x1099E00")]
		public Serverproto.DailyReward DailyReward
		{
			[Address(RVA="0x1A2774C", Offset="0x1A2774C", VA="0x1A2774C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A27754", Offset="0x1A27754", VA="0x1A27754")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099D70", Offset="0x1099D70")]
		public ulong DailyStoreAdRewardsClaimed
		{
			[Address(RVA="0x1A27B68", Offset="0x1A27B68", VA="0x1A27B68")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A27B70", Offset="0x1A27B70", VA="0x1A27B70")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099A68", Offset="0x1099A68")]
		public ulong DayEndTimestamp
		{
			[Address(RVA="0x1A27864", Offset="0x1A27864", VA="0x1A27864")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A2786C", Offset="0x1A2786C", VA="0x1A2786C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10999E8", Offset="0x10999E8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1A26EB0", Offset="0x1A26EB0", VA="0x1A26EB0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099CB8", Offset="0x1099CB8")]
		public RepeatedField<ulong> DisabledFeatures
		{
			[Address(RVA="0x1A27AA8", Offset="0x1A27AA8", VA="0x1A27AA8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099DD0", Offset="0x1099DD0")]
		public RepeatedField<ulong> EmoteDeck
		{
			[Address(RVA="0x1A27C34", Offset="0x1A27C34", VA="0x1A27C34")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099A78", Offset="0x1099A78")]
		public RepeatedField<PlayerEnergyTracker> EnergyTrackers
		{
			[Address(RVA="0x1A27874", Offset="0x1A27874", VA="0x1A27874")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099CC8", Offset="0x1099CC8")]
		public RepeatedField<Serverproto.EventProgress> EventProgress
		{
			[Address(RVA="0x1A27AB0", Offset="0x1A27AB0", VA="0x1A27AB0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099CD8", Offset="0x1099CD8")]
		public RepeatedField<Serverproto.EventStatus> EventStatus
		{
			[Address(RVA="0x1A27AB8", Offset="0x1A27AB8", VA="0x1A27AB8")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099E30", Offset="0x1099E30")]
		public string GlobalChatChannelName
		{
			[Address(RVA="0x1A27C7C", Offset="0x1A27C7C", VA="0x1A27C7C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A27C84", Offset="0x1A27C84", VA="0x1A27C84")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099A08", Offset="0x1099A08")]
		public string Id
		{
			[Address(RVA="0x1A277BC", Offset="0x1A277BC", VA="0x1A277BC")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A277C4", Offset="0x1A277C4", VA="0x1A277C4")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099D80", Offset="0x1099D80")]
		public bool IsSpender
		{
			[Address(RVA="0x1A27B78", Offset="0x1A27B78", VA="0x1A27B78")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A27B80", Offset="0x1A27B80", VA="0x1A27B80")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099A28", Offset="0x1099A28")]
		public RepeatedField<InventoryItem> ItemInventory
		{
			[Address(RVA="0x1A2783C", Offset="0x1A2783C", VA="0x1A2783C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099DB0", Offset="0x1099DB0")]
		public ulong JoinClubLockLevel
		{
			[Address(RVA="0x1A27C14", Offset="0x1A27C14", VA="0x1A27C14")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A27C1C", Offset="0x1A27C1C", VA="0x1A27C1C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099DE0", Offset="0x1099DE0")]
		public ulong KothPayoutTimestamp
		{
			[Address(RVA="0x1A27C3C", Offset="0x1A27C3C", VA="0x1A27C3C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A27C44", Offset="0x1A27C44", VA="0x1A27C44")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099E20", Offset="0x1099E20")]
		public ulong KothRank
		{
			[Address(RVA="0x1A27C6C", Offset="0x1A27C6C", VA="0x1A27C6C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A27C74", Offset="0x1A27C74", VA="0x1A27C74")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099DA0", Offset="0x1099DA0")]
		public ulong LeftClubTimestamp
		{
			[Address(RVA="0x1A27C04", Offset="0x1A27C04", VA="0x1A27C04")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A27C0C", Offset="0x1A27C0C", VA="0x1A27C0C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099A38", Offset="0x1099A38")]
		public ulong Level
		{
			[Address(RVA="0x1A27844", Offset="0x1A27844", VA="0x1A27844")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A2784C", Offset="0x1A2784C", VA="0x1A2784C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099BB0", Offset="0x1099BB0")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1099BB0", Offset="0x1099BB0")]
		public ulong NextClubItemRequestTimestamp
		{
			[Address(RVA="0x1A27A3C", Offset="0x1A27A3C", VA="0x1A27A3C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A27A44", Offset="0x1A27A44", VA="0x1A27A44")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099CF8", Offset="0x1099CF8")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1099CF8", Offset="0x1099CF8")]
		public ulong NextFreeStoreItemTimestamp
		{
			[Address(RVA="0x1A27B38", Offset="0x1A27B38", VA="0x1A27B38")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A27B40", Offset="0x1A27B40", VA="0x1A27B40")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10999D8", Offset="0x10999D8")]
		public static MessageParser<Player> Parser
		{
			[Address(RVA="0x1A26E48", Offset="0x1A26E48", VA="0x1A26E48")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10999F8", Offset="0x10999F8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1A26FA0", Offset="0x1A26FA0", VA="0x1A26FA0", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099D30", Offset="0x1099D30")]
		public Serverproto.PvpScore PvpScore
		{
			[Address(RVA="0x1A2773C", Offset="0x1A2773C", VA="0x1A2773C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A27744", Offset="0x1A27744", VA="0x1A27744")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099C78", Offset="0x1099C78")]
		public ulong ShipmentResetTimestamp
		{
			[Address(RVA="0x1A27A6C", Offset="0x1A27A6C", VA="0x1A27A6C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A27A74", Offset="0x1A27A74", VA="0x1A27A74")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099C88", Offset="0x1099C88")]
		public bool ShowVipProfileBg
		{
			[Address(RVA="0x1A27A7C", Offset="0x1A27A7C", VA="0x1A27A7C")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1A27A84", Offset="0x1A27A84", VA="0x1A27A84")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099A88", Offset="0x1099A88")]
		public RepeatedField<Spell> SpellInventory
		{
			[Address(RVA="0x1A2787C", Offset="0x1A2787C", VA="0x1A2787C")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099AA8", Offset="0x1099AA8")]
		public RepeatedField<PlayerSquadSelection> SquadSelections
		{
			[Address(RVA="0x1A278FC", Offset="0x1A278FC", VA="0x1A278FC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099A18", Offset="0x1099A18")]
		public RepeatedField<Unit> UnitInventory
		{
			[Address(RVA="0x1A27834", Offset="0x1A27834", VA="0x1A27834")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099D50", Offset="0x1099D50")]
		public RepeatedField<ulong> UnlockedContextualMessageGroupIds
		{
			[Address(RVA="0x1A27B58", Offset="0x1A27B58", VA="0x1A27B58")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099CA8", Offset="0x1099CA8")]
		public RepeatedField<ulong> UnlockedFeatures
		{
			[Address(RVA="0x1A27AA0", Offset="0x1A27AA0", VA="0x1A27AA0")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099A98", Offset="0x1099A98")]
		public string Username
		{
			[Address(RVA="0x1A27884", Offset="0x1A27884", VA="0x1A27884")]
			get
			{
				return null;
			}
			[Address(RVA="0x1A2788C", Offset="0x1A2788C", VA="0x1A2788C")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099D60", Offset="0x1099D60")]
		public RepeatedField<ulong> VariantIds
		{
			[Address(RVA="0x1A27B60", Offset="0x1A27B60", VA="0x1A27B60")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1099E10", Offset="0x1099E10")]
		public ulong VipExpireTimestamp
		{
			[Address(RVA="0x1A27C5C", Offset="0x1A27C5C", VA="0x1A27C5C")]
			get
			{
				return new ulong();
			}
			[Address(RVA="0x1A27C64", Offset="0x1A27C64", VA="0x1A27C64")]
			set
			{
			}
		}

		[Address(RVA="0x1A2BCFC", Offset="0x1A2BCFC", VA="0x1A2BCFC")]
		static Player()
		{
		}

		[Address(RVA="0x1A26FFC", Offset="0x1A26FFC", VA="0x1A26FFC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108398C", Offset="0x108398C")]
		public Player()
		{
		}

		[Address(RVA="0x1A272DC", Offset="0x1A272DC", VA="0x1A272DC")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108399C", Offset="0x108399C")]
		public Player(Player other)
		{
		}

		[Address(RVA="0x1A29CEC", Offset="0x1A29CEC", VA="0x1A29CEC", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083A0C", Offset="0x1083A0C")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1A2775C", Offset="0x1A2775C", VA="0x1A2775C", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10839AC", Offset="0x10839AC")]
		public Player Clone()
		{
			return null;
		}

		[Address(RVA="0x1A27CF4", Offset="0x1A27CF4", VA="0x1A27CF4", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10839BC", Offset="0x10839BC")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1A27D68", Offset="0x1A27D68", VA="0x1A27D68", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10839CC", Offset="0x10839CC")]
		public bool Equals(Player other)
		{
			return new bool();
		}

		[Address(RVA="0x1A28358", Offset="0x1A28358", VA="0x1A28358", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10839DC", Offset="0x10839DC")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1A2A9F8", Offset="0x1A2A9F8", VA="0x1A2A9F8", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083A1C", Offset="0x1083A1C")]
		public void MergeFrom(Player other)
		{
		}

		[Address(RVA="0x1A2B0A4", Offset="0x1A2B0A4", VA="0x1A2B0A4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1083A2C", Offset="0x1083A2C")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1A28AE4", Offset="0x1A28AE4", VA="0x1A28AE4", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10839EC", Offset="0x10839EC")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1A28B4C", Offset="0x1A28B4C", VA="0x1A28B4C", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10839FC", Offset="0x10839FC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10503C8", Offset="0x10503C8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static Player.<>c <>9;

			[Address(RVA="0x1AF4900", Offset="0x1AF4900", VA="0x1AF4900")]
			static <>c()
			{
			}

			[Address(RVA="0x1AF4964", Offset="0x1AF4964", VA="0x1AF4964")]
			public <>c()
			{
			}

			[Address(RVA="0x1AF496C", Offset="0x1AF496C", VA="0x1AF496C")]
			internal Player <.cctor>b__270_0()
			{
				return null;
			}
		}
	}
}