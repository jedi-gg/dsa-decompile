using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public sealed class HomeRequest : IMessage<HomeRequest>, IMessage, IEquatable<HomeRequest>, IDeepCloneable<HomeRequest>
	{
		[FieldOffset(Offset="0x0")]
		private readonly static MessageParser<HomeRequest> _parser;

		[FieldOffset(Offset="0x10")]
		private UnknownFieldSet _unknownFields;

		[FieldOffset(Offset="0x0")]
		public const int DailyEventsFieldNumber = 1;

		[FieldOffset(Offset="0x18")]
		private GetDailyEventsRequest dailyEvents_;

		[FieldOffset(Offset="0x0")]
		public const int ScheduledEventsFieldNumber = 2;

		[FieldOffset(Offset="0x20")]
		private GetScheduledEventsRequest scheduledEvents_;

		[FieldOffset(Offset="0x0")]
		public const int TowerFieldNumber = 3;

		[FieldOffset(Offset="0x28")]
		private TowerRequest tower_;

		[FieldOffset(Offset="0x0")]
		public const int TowerStatusFieldNumber = 4;

		[FieldOffset(Offset="0x30")]
		private TowerStatusRequest towerStatus_;

		[FieldOffset(Offset="0x0")]
		public const int ClubDungeonStatusFieldNumber = 5;

		[FieldOffset(Offset="0x38")]
		private ClubDungeonStatusRequest clubDungeonStatus_;

		[FieldOffset(Offset="0x0")]
		public const int InboxUnreadCountFieldNumber = 6;

		[FieldOffset(Offset="0x40")]
		private InboxUnreadCountRequest inboxUnreadCount_;

		[FieldOffset(Offset="0x0")]
		public const int HomeDailyEventsFieldNumber = 7;

		[FieldOffset(Offset="0x48")]
		private HomeDailyEventsRequest homeDailyEvents_;

		[FieldOffset(Offset="0x0")]
		public const int HomeScheduledEventsFieldNumber = 8;

		[FieldOffset(Offset="0x50")]
		private HomeScheduledEventsRequest homeScheduledEvents_;

		[FieldOffset(Offset="0x0")]
		public const int HomeTowerStatusFieldNumber = 9;

		[FieldOffset(Offset="0x58")]
		private HomeTowerStatusRequest homeTowerStatus_;

		[FieldOffset(Offset="0x0")]
		public const int HomeClubDungeonStatusFieldNumber = 10;

		[FieldOffset(Offset="0x60")]
		private HomeClubDungeonStatusRequest homeClubDungeonStatus_;

		[FieldOffset(Offset="0x0")]
		public const int HomeClubDonationsFieldNumber = 11;

		[FieldOffset(Offset="0x68")]
		private HomeClubDonationsRequest homeClubDonations_;

		[FieldOffset(Offset="0x0")]
		public const int HomeClubInvitesFieldNumber = 12;

		[FieldOffset(Offset="0x70")]
		private HomeClubInvitesRequest homeClubInvites_;

		[FieldOffset(Offset="0x0")]
		public const int HomeStoreFieldNumber = 13;

		[FieldOffset(Offset="0x78")]
		private HomeStoreRequest homeStore_;

		[FieldOffset(Offset="0x0")]
		public const int HomeInboxFieldNumber = 14;

		[FieldOffset(Offset="0x80")]
		private HomeInboxRequest homeInbox_;

		[FieldOffset(Offset="0x0")]
		public const int HomePlayerActivityFieldNumber = 15;

		[FieldOffset(Offset="0x88")]
		private HomePlayerActivityRequest homePlayerActivity_;

		[FieldOffset(Offset="0x0")]
		public const int HomeShowcaseFieldNumber = 16;

		[FieldOffset(Offset="0x90")]
		private HomeShowcaseRequest homeShowcase_;

		[FieldOffset(Offset="0x0")]
		public const int HomeKothFieldNumber = 17;

		[FieldOffset(Offset="0x98")]
		private HomeKothRequest homeKoth_;

		[FieldOffset(Offset="0x0")]
		public const int HomeClubWarFieldNumber = 18;

		[FieldOffset(Offset="0xA0")]
		private HomeClubWarRequest homeClubWar_;

		[FieldOffset(Offset="0x0")]
		public const int HomePvpFieldNumber = 19;

		[FieldOffset(Offset="0xA8")]
		private HomePvpRequest homePvp_;

		[FieldOffset(Offset="0x0")]
		public const int HomeFriendsFieldNumber = 20;

		[FieldOffset(Offset="0xB0")]
		private HomeFriendsRequest homeFriends_;

		[FieldOffset(Offset="0x0")]
		public const int HomeBattleSelectFieldNumber = 21;

		[FieldOffset(Offset="0xB8")]
		private HomeBattleSelectRequest homeBattleSelect_;

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10977C8", Offset="0x10977C8")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x10977C8", Offset="0x10977C8")]
		public ClubDungeonStatusRequest ClubDungeonStatus
		{
			[Address(RVA="0x1D11140", Offset="0x1D11140", VA="0x1D11140")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D11148", Offset="0x1D11148", VA="0x1D11148")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10976E8", Offset="0x10976E8")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x10976E8", Offset="0x10976E8")]
		public GetDailyEventsRequest DailyEvents
		{
			[Address(RVA="0x1D11100", Offset="0x1D11100", VA="0x1D11100")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D11108", Offset="0x1D11108", VA="0x1D11108")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10976C8", Offset="0x10976C8")]
		public static MessageDescriptor Descriptor
		{
			[Address(RVA="0x1D10DCC", Offset="0x1D10DCC", VA="0x1D10DCC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097918", Offset="0x1097918")]
		public HomeBattleSelectRequest HomeBattleSelect
		{
			[Address(RVA="0x1D11240", Offset="0x1D11240", VA="0x1D11240")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D11248", Offset="0x1D11248", VA="0x1D11248")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097878", Offset="0x1097878")]
		public HomeClubDonationsRequest HomeClubDonations
		{
			[Address(RVA="0x1D111A0", Offset="0x1D111A0", VA="0x1D111A0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D111A8", Offset="0x1D111A8", VA="0x1D111A8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097868", Offset="0x1097868")]
		public HomeClubDungeonStatusRequest HomeClubDungeonStatus
		{
			[Address(RVA="0x1D11190", Offset="0x1D11190", VA="0x1D11190")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D11198", Offset="0x1D11198", VA="0x1D11198")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097888", Offset="0x1097888")]
		public HomeClubInvitesRequest HomeClubInvites
		{
			[Address(RVA="0x1D111B0", Offset="0x1D111B0", VA="0x1D111B0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D111B8", Offset="0x1D111B8", VA="0x1D111B8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10978E8", Offset="0x10978E8")]
		public HomeClubWarRequest HomeClubWar
		{
			[Address(RVA="0x1D11210", Offset="0x1D11210", VA="0x1D11210")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D11218", Offset="0x1D11218", VA="0x1D11218")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097838", Offset="0x1097838")]
		public HomeDailyEventsRequest HomeDailyEvents
		{
			[Address(RVA="0x1D11160", Offset="0x1D11160", VA="0x1D11160")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D11168", Offset="0x1D11168", VA="0x1D11168")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097908", Offset="0x1097908")]
		public HomeFriendsRequest HomeFriends
		{
			[Address(RVA="0x1D11230", Offset="0x1D11230", VA="0x1D11230")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D11238", Offset="0x1D11238", VA="0x1D11238")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10978A8", Offset="0x10978A8")]
		public HomeInboxRequest HomeInbox
		{
			[Address(RVA="0x1D111D0", Offset="0x1D111D0", VA="0x1D111D0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D111D8", Offset="0x1D111D8", VA="0x1D111D8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10978D8", Offset="0x10978D8")]
		public HomeKothRequest HomeKoth
		{
			[Address(RVA="0x1D11200", Offset="0x1D11200", VA="0x1D11200")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D11208", Offset="0x1D11208", VA="0x1D11208")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10978B8", Offset="0x10978B8")]
		public HomePlayerActivityRequest HomePlayerActivity
		{
			[Address(RVA="0x1D111E0", Offset="0x1D111E0", VA="0x1D111E0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D111E8", Offset="0x1D111E8", VA="0x1D111E8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10978F8", Offset="0x10978F8")]
		public HomePvpRequest HomePvp
		{
			[Address(RVA="0x1D11220", Offset="0x1D11220", VA="0x1D11220")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D11228", Offset="0x1D11228", VA="0x1D11228")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097848", Offset="0x1097848")]
		public HomeScheduledEventsRequest HomeScheduledEvents
		{
			[Address(RVA="0x1D11170", Offset="0x1D11170", VA="0x1D11170")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D11178", Offset="0x1D11178", VA="0x1D11178")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10978C8", Offset="0x10978C8")]
		public HomeShowcaseRequest HomeShowcase
		{
			[Address(RVA="0x1D111F0", Offset="0x1D111F0", VA="0x1D111F0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D111F8", Offset="0x1D111F8", VA="0x1D111F8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097898", Offset="0x1097898")]
		public HomeStoreRequest HomeStore
		{
			[Address(RVA="0x1D111C0", Offset="0x1D111C0", VA="0x1D111C0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D111C8", Offset="0x1D111C8", VA="0x1D111C8")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097858", Offset="0x1097858")]
		public HomeTowerStatusRequest HomeTowerStatus
		{
			[Address(RVA="0x1D11180", Offset="0x1D11180", VA="0x1D11180")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D11188", Offset="0x1D11188", VA="0x1D11188")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097800", Offset="0x1097800")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1097800", Offset="0x1097800")]
		public InboxUnreadCountRequest InboxUnreadCount
		{
			[Address(RVA="0x1D11150", Offset="0x1D11150", VA="0x1D11150")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D11158", Offset="0x1D11158", VA="0x1D11158")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10976B8", Offset="0x10976B8")]
		public static MessageParser<HomeRequest> Parser
		{
			[Address(RVA="0x1D10CFC", Offset="0x1D10CFC", VA="0x1D10CFC")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10976D8", Offset="0x10976D8")]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Address(RVA="0x1D10EB8", Offset="0x1D10EB8", VA="0x1D10EB8", Slot="7")]
			get
			{
				return null;
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097720", Offset="0x1097720")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1097720", Offset="0x1097720")]
		public GetScheduledEventsRequest ScheduledEvents
		{
			[Address(RVA="0x1D11110", Offset="0x1D11110", VA="0x1D11110")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D11118", Offset="0x1D11118", VA="0x1D11118")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097758", Offset="0x1097758")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1097758", Offset="0x1097758")]
		public TowerRequest Tower
		{
			[Address(RVA="0x1D11120", Offset="0x1D11120", VA="0x1D11120")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D11128", Offset="0x1D11128", VA="0x1D11128")]
			set
			{
			}
		}

		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x1097790", Offset="0x1097790")]
		[Attribute(Name="ObsoleteAttribute", RVA="0x1097790", Offset="0x1097790")]
		public TowerStatusRequest TowerStatus
		{
			[Address(RVA="0x1D11130", Offset="0x1D11130", VA="0x1D11130")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D11138", Offset="0x1D11138", VA="0x1D11138")]
			set
			{
			}
		}

		[Address(RVA="0x1D13168", Offset="0x1D13168", VA="0x1D13168")]
		static HomeRequest()
		{
		}

		[Address(RVA="0x1D10F14", Offset="0x1D10F14", VA="0x1D10F14")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108003C", Offset="0x108003C")]
		public HomeRequest()
		{
		}

		[Address(RVA="0x1D10F1C", Offset="0x1D10F1C", VA="0x1D10F1C")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108004C", Offset="0x108004C")]
		public HomeRequest(HomeRequest other)
		{
		}

		[Address(RVA="0x1D11F68", Offset="0x1D11F68", VA="0x1D11F68", Slot="6")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10800BC", Offset="0x10800BC")]
		public int CalculateSize()
		{
			return new int();
		}

		[Address(RVA="0x1D11250", Offset="0x1D11250", VA="0x1D11250", Slot="9")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108005C", Offset="0x108005C")]
		public HomeRequest Clone()
		{
			return null;
		}

		[Address(RVA="0x1D112B0", Offset="0x1D112B0", VA="0x1D112B0", Slot="0")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108006C", Offset="0x108006C")]
		public override bool Equals(object other)
		{
			return new bool();
		}

		[Address(RVA="0x1D11324", Offset="0x1D11324", VA="0x1D11324", Slot="8")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108007C", Offset="0x108007C")]
		public bool Equals(HomeRequest other)
		{
			return new bool();
		}

		[Address(RVA="0x1D11518", Offset="0x1D11518", VA="0x1D11518", Slot="2")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108008C", Offset="0x108008C")]
		public override int GetHashCode()
		{
			return new int();
		}

		[Address(RVA="0x1D124B0", Offset="0x1D124B0", VA="0x1D124B0", Slot="10")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10800CC", Offset="0x10800CC")]
		public void MergeFrom(HomeRequest other)
		{
		}

		[Address(RVA="0x1D12BF4", Offset="0x1D12BF4", VA="0x1D12BF4", Slot="4")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10800DC", Offset="0x10800DC")]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[Address(RVA="0x1D11750", Offset="0x1D11750", VA="0x1D11750", Slot="3")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x108009C", Offset="0x108009C")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1D117B8", Offset="0x1D117B8", VA="0x1D117B8", Slot="5")]
		[Attribute(Name="DebuggerNonUserCodeAttribute", RVA="0x10800AC", Offset="0x10800AC")]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104FE98", Offset="0x104FE98")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static HomeRequest.<>c <>9;

			[Address(RVA="0x1D13240", Offset="0x1D13240", VA="0x1D13240")]
			static <>c()
			{
			}

			[Address(RVA="0x1D132A4", Offset="0x1D132A4", VA="0x1D132A4")]
			public <>c()
			{
			}

			[Address(RVA="0x1D132AC", Offset="0x1D132AC", VA="0x1D132AC")]
			internal HomeRequest <.cctor>b__125_0()
			{
				return null;
			}
		}
	}
}