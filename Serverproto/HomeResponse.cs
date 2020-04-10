using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeResponse : IMessage<HomeResponse>, IMessage, IEquatable<HomeResponse>, IDeepCloneable<HomeResponse>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeResponse> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DailyEventsFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private GetDailyEventsResponse dailyEvents_;

		[FieldOffset(Offset="0x0")]
		public const int DailyEventsCacheSettingsFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private CacheSettings dailyEventsCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int ScheduledEventsFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private GetScheduledEventsResponse scheduledEvents_;

		[FieldOffset(Offset="0x0")]
		public const int ScheduledEventsCacheSettingsFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private CacheSettings scheduledEventsCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int TowerFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private TowerResponse tower_;

		[FieldOffset(Offset="0x0")]
		public const int TowerCacheSettingsFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private CacheSettings towerCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int TowerStatusFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private TowerStatusResponse towerStatus_;

		[FieldOffset(Offset="0x0")]
		public const int TowerStatusCacheSettingsFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private CacheSettings towerStatusCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int ClubDungeonStatusFieldNumber = 9;

		[FieldOffset(Offset="0x58")]
		private ClubDungeonStatusResponse clubDungeonStatus_;

		[FieldOffset(Offset="0x0")]
		public const int ClubDungeonStatusCacheSettingsFieldNumber = 10;

		[FieldOffset(Offset="0x60")]
		private CacheSettings clubDungeonStatusCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int InboxUnreadCountFieldNumber = 11;

		[FieldOffset(Offset="0x68")]
		private InboxUnreadCountResponse inboxUnreadCount_;

		[FieldOffset(Offset="0x0")]
		public const int InboxUnreadCountCacheSettingsFieldNumber = 12;

		[FieldOffset(Offset="0x70")]
		private CacheSettings inboxUnreadCountCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int HomeDailyEventsFieldNumber = 13;

		[FieldOffset(Offset="0x78")]
		private HomeDailyEventsResponse homeDailyEvents_;

		[FieldOffset(Offset="0x0")]
		public const int HomeDailyEventsCacheSettingsFieldNumber = 14;

		[FieldOffset(Offset="0x80")]
		private CacheSettings homeDailyEventsCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int HomeScheduledEventsFieldNumber = 15;

		[FieldOffset(Offset="0x88")]
		private HomeScheduledEventsResponse homeScheduledEvents_;

		[FieldOffset(Offset="0x0")]
		public const int HomeScheduledEventsCacheSettingsFieldNumber = 16;

		[FieldOffset(Offset="0x90")]
		private CacheSettings homeScheduledEventsCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int HomeTowerStatusFieldNumber = 17;

		[FieldOffset(Offset="0x98")]
		private HomeTowerStatusResponse homeTowerStatus_;

		[FieldOffset(Offset="0x0")]
		public const int HomeTowerStatusCacheSettingsFieldNumber = 18;

		[FieldOffset(Offset="0xA0")]
		private CacheSettings homeTowerStatusCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int HomeClubDungeonStatusFieldNumber = 19;

		[FieldOffset(Offset="0xA8")]
		private HomeClubDungeonStatusResponse homeClubDungeonStatus_;

		[FieldOffset(Offset="0x0")]
		public const int HomeClubDungeonStatusCacheSettingsFieldNumber = 20;

		[FieldOffset(Offset="0xB0")]
		private CacheSettings homeClubDungeonStatusCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int HomeClubDonationsFieldNumber = 21;

		[FieldOffset(Offset="0xB8")]
		private HomeClubDonationsResponse homeClubDonations_;

		[FieldOffset(Offset="0x0")]
		public const int HomeClubDonationsCacheSettingsFieldNumber = 22;

		[FieldOffset(Offset="0xC0")]
		private CacheSettings homeClubDonationsCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int HomeClubInvitesFieldNumber = 23;

		[FieldOffset(Offset="0xC8")]
		private HomeClubInvitesResponse homeClubInvites_;

		[FieldOffset(Offset="0x0")]
		public const int HomeClubInvitesCacheSettingsFieldNumber = 24;

		[FieldOffset(Offset="0xD0")]
		private CacheSettings homeClubInvitesCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int HomeStoreFieldNumber = 25;

		[FieldOffset(Offset="0xD8")]
		private HomeStoreResponse homeStore_;

		[FieldOffset(Offset="0x0")]
		public const int HomeStoreCacheSettingsFieldNumber = 26;

		[FieldOffset(Offset="0xE0")]
		private CacheSettings homeStoreCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int HomeInboxFieldNumber = 27;

		[FieldOffset(Offset="0xE8")]
		private HomeInboxResponse homeInbox_;

		[FieldOffset(Offset="0x0")]
		public const int HomeInboxCacheSettingsFieldNumber = 28;

		[FieldOffset(Offset="0xF0")]
		private CacheSettings homeInboxCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int HomePlayerActivityFieldNumber = 29;

		[FieldOffset(Offset="0xF8")]
		private HomePlayerActivityResponse homePlayerActivity_;

		[FieldOffset(Offset="0x0")]
		public const int HomePlayerActivityCacheSettingsFieldNumber = 30;

		[FieldOffset(Offset="0x100")]
		private CacheSettings homePlayerActivityCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int HomeShowcaseFieldNumber = 31;

		[FieldOffset(Offset="0x108")]
		private HomeShowcaseResponse homeShowcase_;

		[FieldOffset(Offset="0x0")]
		public const int HomeShowcaseCacheSettingsFieldNumber = 32;

		[FieldOffset(Offset="0x110")]
		private CacheSettings homeShowcaseCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int HomeKothFieldNumber = 33;

		[FieldOffset(Offset="0x118")]
		private HomeKothResponse homeKoth_;

		[FieldOffset(Offset="0x0")]
		public const int HomeKothCacheSettingsFieldNumber = 34;

		[FieldOffset(Offset="0x120")]
		private CacheSettings homeKothCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int HomeClubWarFieldNumber = 35;

		[FieldOffset(Offset="0x128")]
		private HomeClubWarResponse homeClubWar_;

		[FieldOffset(Offset="0x0")]
		public const int HomeClubWarCacheSettingsFieldNumber = 36;

		[FieldOffset(Offset="0x130")]
		private CacheSettings homeClubWarCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int HomePvpFieldNumber = 37;

		[FieldOffset(Offset="0x138")]
		private HomePvpResponse homePvp_;

		[FieldOffset(Offset="0x0")]
		public const int HomePvpCacheSettingsFieldNumber = 38;

		[FieldOffset(Offset="0x140")]
		private CacheSettings homePvpCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int HomeFriendsFieldNumber = 39;

		[FieldOffset(Offset="0x148")]
		private HomeFriendsResponse homeFriends_;

		[FieldOffset(Offset="0x0")]
		public const int HomeFriendsCacheSettingsFieldNumber = 40;

		[FieldOffset(Offset="0x150")]
		private CacheSettings homeFriendsCacheSettings_;

		[FieldOffset(Offset="0x0")]
		public const int HomeBattleSelectFieldNumber = 41;

		[FieldOffset(Offset="0x158")]
		private HomeBattleSelectResponse homeBattleSelect_;

		[FieldOffset(Offset="0x0")]
		public const int HomeBattleSelectCacheSettingsFieldNumber = 42;

		[FieldOffset(Offset="0x160")]
		private CacheSettings homeBattleSelectCacheSettings_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10984C0", Offset="0x10984C0")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x10984C0", Offset="0x10984C0")]
		public ClubDungeonStatusResponse ClubDungeonStatus
		{
			[Address(RVA="0x1D13860", Offset="0x1D13860", VA="0x1D13860")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13868", Offset="0x1D13868", VA="0x1D13868")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10984F8", Offset="0x10984F8")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x10984F8", Offset="0x10984F8")]
		public CacheSettings ClubDungeonStatusCacheSettings
		{
			[Address(RVA="0x1D13870", Offset="0x1D13870", VA="0x1D13870")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13878", Offset="0x1D13878", VA="0x1D13878")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098300", Offset="0x1098300")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1098300", Offset="0x1098300")]
		public GetDailyEventsResponse DailyEvents
		{
			[Address(RVA="0x1D137E0", Offset="0x1D137E0", VA="0x1D137E0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D137E8", Offset="0x1D137E8", VA="0x1D137E8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098338", Offset="0x1098338")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1098338", Offset="0x1098338")]
		public CacheSettings DailyEventsCacheSettings
		{
			[Address(RVA="0x1D137F0", Offset="0x1D137F0", VA="0x1D137F0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D137F8", Offset="0x1D137F8", VA="0x1D137F8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10982E0", Offset="0x10982E0")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1D13308", Offset="0x1D13308", VA="0x1D13308")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098760", Offset="0x1098760")]
		public HomeBattleSelectResponse HomeBattleSelect
		{
			[Address(RVA="0x1D13A60", Offset="0x1D13A60", VA="0x1D13A60")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13A68", Offset="0x1D13A68", VA="0x1D13A68")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098770", Offset="0x1098770")]
		public CacheSettings HomeBattleSelectCacheSettings
		{
			[Address(RVA="0x1D13A70", Offset="0x1D13A70", VA="0x1D13A70")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13A78", Offset="0x1D13A78", VA="0x1D13A78")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098620", Offset="0x1098620")]
		public HomeClubDonationsResponse HomeClubDonations
		{
			[Address(RVA="0x1D13920", Offset="0x1D13920", VA="0x1D13920")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13928", Offset="0x1D13928", VA="0x1D13928")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098630", Offset="0x1098630")]
		public CacheSettings HomeClubDonationsCacheSettings
		{
			[Address(RVA="0x1D13930", Offset="0x1D13930", VA="0x1D13930")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13938", Offset="0x1D13938", VA="0x1D13938")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098600", Offset="0x1098600")]
		public HomeClubDungeonStatusResponse HomeClubDungeonStatus
		{
			[Address(RVA="0x1D13900", Offset="0x1D13900", VA="0x1D13900")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13908", Offset="0x1D13908", VA="0x1D13908")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098610", Offset="0x1098610")]
		public CacheSettings HomeClubDungeonStatusCacheSettings
		{
			[Address(RVA="0x1D13910", Offset="0x1D13910", VA="0x1D13910")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13918", Offset="0x1D13918", VA="0x1D13918")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098640", Offset="0x1098640")]
		public HomeClubInvitesResponse HomeClubInvites
		{
			[Address(RVA="0x1D13940", Offset="0x1D13940", VA="0x1D13940")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13948", Offset="0x1D13948", VA="0x1D13948")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098650", Offset="0x1098650")]
		public CacheSettings HomeClubInvitesCacheSettings
		{
			[Address(RVA="0x1D13950", Offset="0x1D13950", VA="0x1D13950")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13958", Offset="0x1D13958", VA="0x1D13958")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098700", Offset="0x1098700")]
		public HomeClubWarResponse HomeClubWar
		{
			[Address(RVA="0x1D13A00", Offset="0x1D13A00", VA="0x1D13A00")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13A08", Offset="0x1D13A08", VA="0x1D13A08")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098710", Offset="0x1098710")]
		public CacheSettings HomeClubWarCacheSettings
		{
			[Address(RVA="0x1D13A10", Offset="0x1D13A10", VA="0x1D13A10")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13A18", Offset="0x1D13A18", VA="0x1D13A18")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10985A0", Offset="0x10985A0")]
		public HomeDailyEventsResponse HomeDailyEvents
		{
			[Address(RVA="0x1D138A0", Offset="0x1D138A0", VA="0x1D138A0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D138A8", Offset="0x1D138A8", VA="0x1D138A8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10985B0", Offset="0x10985B0")]
		public CacheSettings HomeDailyEventsCacheSettings
		{
			[Address(RVA="0x1D138B0", Offset="0x1D138B0", VA="0x1D138B0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D138B8", Offset="0x1D138B8", VA="0x1D138B8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098740", Offset="0x1098740")]
		public HomeFriendsResponse HomeFriends
		{
			[Address(RVA="0x1D13A40", Offset="0x1D13A40", VA="0x1D13A40")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13A48", Offset="0x1D13A48", VA="0x1D13A48")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098750", Offset="0x1098750")]
		public CacheSettings HomeFriendsCacheSettings
		{
			[Address(RVA="0x1D13A50", Offset="0x1D13A50", VA="0x1D13A50")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13A58", Offset="0x1D13A58", VA="0x1D13A58")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098680", Offset="0x1098680")]
		public HomeInboxResponse HomeInbox
		{
			[Address(RVA="0x1D13980", Offset="0x1D13980", VA="0x1D13980")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13988", Offset="0x1D13988", VA="0x1D13988")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098690", Offset="0x1098690")]
		public CacheSettings HomeInboxCacheSettings
		{
			[Address(RVA="0x1D13990", Offset="0x1D13990", VA="0x1D13990")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13998", Offset="0x1D13998", VA="0x1D13998")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10986E0", Offset="0x10986E0")]
		public HomeKothResponse HomeKoth
		{
			[Address(RVA="0x1D139E0", Offset="0x1D139E0", VA="0x1D139E0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D139E8", Offset="0x1D139E8", VA="0x1D139E8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10986F0", Offset="0x10986F0")]
		public CacheSettings HomeKothCacheSettings
		{
			[Address(RVA="0x1D139F0", Offset="0x1D139F0", VA="0x1D139F0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D139F8", Offset="0x1D139F8", VA="0x1D139F8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10986A0", Offset="0x10986A0")]
		public HomePlayerActivityResponse HomePlayerActivity
		{
			[Address(RVA="0x1D139A0", Offset="0x1D139A0", VA="0x1D139A0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D139A8", Offset="0x1D139A8", VA="0x1D139A8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10986B0", Offset="0x10986B0")]
		public CacheSettings HomePlayerActivityCacheSettings
		{
			[Address(RVA="0x1D139B0", Offset="0x1D139B0", VA="0x1D139B0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D139B8", Offset="0x1D139B8", VA="0x1D139B8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098720", Offset="0x1098720")]
		public HomePvpResponse HomePvp
		{
			[Address(RVA="0x1D13A20", Offset="0x1D13A20", VA="0x1D13A20")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13A28", Offset="0x1D13A28", VA="0x1D13A28")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098730", Offset="0x1098730")]
		public CacheSettings HomePvpCacheSettings
		{
			[Address(RVA="0x1D13A30", Offset="0x1D13A30", VA="0x1D13A30")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13A38", Offset="0x1D13A38", VA="0x1D13A38")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10985C0", Offset="0x10985C0")]
		public HomeScheduledEventsResponse HomeScheduledEvents
		{
			[Address(RVA="0x1D138C0", Offset="0x1D138C0", VA="0x1D138C0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D138C8", Offset="0x1D138C8", VA="0x1D138C8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10985D0", Offset="0x10985D0")]
		public CacheSettings HomeScheduledEventsCacheSettings
		{
			[Address(RVA="0x1D138D0", Offset="0x1D138D0", VA="0x1D138D0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D138D8", Offset="0x1D138D8", VA="0x1D138D8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10986C0", Offset="0x10986C0")]
		public HomeShowcaseResponse HomeShowcase
		{
			[Address(RVA="0x1D139C0", Offset="0x1D139C0", VA="0x1D139C0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D139C8", Offset="0x1D139C8", VA="0x1D139C8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10986D0", Offset="0x10986D0")]
		public CacheSettings HomeShowcaseCacheSettings
		{
			[Address(RVA="0x1D139D0", Offset="0x1D139D0", VA="0x1D139D0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D139D8", Offset="0x1D139D8", VA="0x1D139D8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098660", Offset="0x1098660")]
		public HomeStoreResponse HomeStore
		{
			[Address(RVA="0x1D13960", Offset="0x1D13960", VA="0x1D13960")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13968", Offset="0x1D13968", VA="0x1D13968")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098670", Offset="0x1098670")]
		public CacheSettings HomeStoreCacheSettings
		{
			[Address(RVA="0x1D13970", Offset="0x1D13970", VA="0x1D13970")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13978", Offset="0x1D13978", VA="0x1D13978")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10985E0", Offset="0x10985E0")]
		public HomeTowerStatusResponse HomeTowerStatus
		{
			[Address(RVA="0x1D138E0", Offset="0x1D138E0", VA="0x1D138E0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D138E8", Offset="0x1D138E8", VA="0x1D138E8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10985F0", Offset="0x10985F0")]
		public CacheSettings HomeTowerStatusCacheSettings
		{
			[Address(RVA="0x1D138F0", Offset="0x1D138F0", VA="0x1D138F0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D138F8", Offset="0x1D138F8", VA="0x1D138F8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098530", Offset="0x1098530")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1098530", Offset="0x1098530")]
		public InboxUnreadCountResponse InboxUnreadCount
		{
			[Address(RVA="0x1D13880", Offset="0x1D13880", VA="0x1D13880")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13888", Offset="0x1D13888", VA="0x1D13888")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098568", Offset="0x1098568")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1098568", Offset="0x1098568")]
		public CacheSettings InboxUnreadCountCacheSettings
		{
			[Address(RVA="0x1D13890", Offset="0x1D13890", VA="0x1D13890")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13898", Offset="0x1D13898", VA="0x1D13898")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10982D0", Offset="0x10982D0")]
		public static MessageParser<HomeResponse> Parser
		{
			[Address(RVA="0x1D10D64", Offset="0x1D10D64", VA="0x1D10D64")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10982F0", Offset="0x10982F0")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1D133F4", Offset="0x1D133F4", VA="0x1D133F4", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098370", Offset="0x1098370")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1098370", Offset="0x1098370")]
		public GetScheduledEventsResponse ScheduledEvents
		{
			[Address(RVA="0x1D13800", Offset="0x1D13800", VA="0x1D13800")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13808", Offset="0x1D13808", VA="0x1D13808")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10983A8", Offset="0x10983A8")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x10983A8", Offset="0x10983A8")]
		public CacheSettings ScheduledEventsCacheSettings
		{
			[Address(RVA="0x1D13810", Offset="0x1D13810", VA="0x1D13810")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13818", Offset="0x1D13818", VA="0x1D13818")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10983E0", Offset="0x10983E0")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x10983E0", Offset="0x10983E0")]
		public TowerResponse Tower
		{
			[Address(RVA="0x1D13820", Offset="0x1D13820", VA="0x1D13820")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13828", Offset="0x1D13828", VA="0x1D13828")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098418", Offset="0x1098418")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1098418", Offset="0x1098418")]
		public CacheSettings TowerCacheSettings
		{
			[Address(RVA="0x1D13830", Offset="0x1D13830", VA="0x1D13830")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13838", Offset="0x1D13838", VA="0x1D13838")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098450", Offset="0x1098450")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1098450", Offset="0x1098450")]
		public TowerStatusResponse TowerStatus
		{
			[Address(RVA="0x1D13840", Offset="0x1D13840", VA="0x1D13840")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13848", Offset="0x1D13848", VA="0x1D13848")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1098488", Offset="0x1098488")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1098488", Offset="0x1098488")]
		public CacheSettings TowerStatusCacheSettings
		{
			[Address(RVA="0x1D13850", Offset="0x1D13850", VA="0x1D13850")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D13858", Offset="0x1D13858", VA="0x1D13858")]
			set
			{
			}
		}

		[Address(RVA="0x1D174D8", Offset="0x1D174D8", VA="0x1D174D8")]
		static HomeResponse()
		{
		}

		[Address(RVA="0x1D13450", Offset="0x1D13450", VA="0x1D13450")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108163C", Offset="0x108163C")]
		public HomeResponse()
		{
		}

		[Address(RVA="0x1D13458", Offset="0x1D13458", VA="0x1D13458")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108164C", Offset="0x108164C")]
		public HomeResponse(HomeResponse other)
		{
		}

		[Address(RVA="0x1D15314", Offset="0x1D15314", VA="0x1D15314", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10816BC", Offset="0x10816BC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1D13A80", Offset="0x1D13A80", VA="0x1D13A80", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108165C", Offset="0x108165C")]
		public HomeResponse Clone()
		{
			return null;
		}

		[Address(RVA="0x1D13AE0", Offset="0x1D13AE0", VA="0x1D13AE0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108166C", Offset="0x108166C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1D13B54", Offset="0x1D13B54", VA="0x1D13B54", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108167C", Offset="0x108167C")]
		public bool Equals(HomeResponse other)
		{
			return new bool();
		}

		[Address(RVA="0x1D13EEC", Offset="0x1D13EEC", VA="0x1D13EEC", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108168C", Offset="0x108168C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1D15D48", Offset="0x1D15D48", VA="0x1D15D48", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10816CC", Offset="0x10816CC")]
		public void MergeFrom(HomeResponse other)
		{
		}

		[Address(RVA="0x1D16AA4", Offset="0x1D16AA4", VA="0x1D16AA4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10816DC", Offset="0x10816DC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1D1431C", Offset="0x1D1431C", VA="0x1D1431C", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108169C", Offset="0x108169C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1D14384", Offset="0x1D14384", VA="0x1D14384", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10816AC", Offset="0x10816AC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050098", Offset="0x1050098")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeResponse.<>c <>9;

			[Address(RVA="0x18D1420", Offset="0x18D1420", VA="0x18D1420")]
			static <>c()
			{
			}

			[Address(RVA="0x18D1484", Offset="0x18D1484", VA="0x18D1484")]
			public <>c()
			{
			}

			[Address(RVA="0x18D148C", Offset="0x18D148C", VA="0x18D148C")]
			internal HomeResponse <.cctor>b__230_0()
			{
				return null;
			}
		}
	}
}