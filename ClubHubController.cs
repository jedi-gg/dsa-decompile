using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ClubHubController : AFeatureController, IDispatchHandler<DClubHubViewAction>, IDispatchHandler, IDispatchHandler<DClubHubRosterListItemClickedAction>, IDispatchHandler<DClubJoinRequestAction>, IDispatchHandler<DPlayerClubChangedAction>, IDispatchHandler<DPopupControllerAction>, IDispatchHandler<DClubInviteAcceptedAction>, IDispatchHandler<DClubSettingsChangedAction>, IDispatchHandler<DClubRosterChangedAction>, IDispatchHandler<DClubHubRosterSortedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1055EC8", Offset="0x1055EC8")]
	[FieldOffset(Offset="0x68")]
	private ClubServiceUtility _clubServiceUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1055ED8", Offset="0x1055ED8")]
	[FieldOffset(Offset="0x70")]
	private ClubService _clubService;

	[Attribute(Name="InjectAttribute", RVA="0x1055EE8", Offset="0x1055EE8")]
	[FieldOffset(Offset="0x78")]
	private DiContainer _diContainer;

	[Attribute(Name="InjectAttribute", RVA="0x1055EF8", Offset="0x1055EF8")]
	[FieldOffset(Offset="0x80")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1055F08", Offset="0x1055F08")]
	[FieldOffset(Offset="0x88")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1055F18", Offset="0x1055F18")]
	[FieldOffset(Offset="0x90")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1055F28", Offset="0x1055F28")]
	[FieldOffset(Offset="0x98")]
	private ClubDomainController _clubDC;

	[FieldOffset(Offset="0xA0")]
	private string _clubId;

	[FieldOffset(Offset="0xA8")]
	private Club _club;

	[FieldOffset(Offset="0xB0")]
	private ClubDungeonStatus _dungeonStatus;

	[FieldOffset(Offset="0xB8")]
	private Serverproto.ClubWar _clubWarStatus;

	[FieldOffset(Offset="0xC0")]
	private ClubHubView _view;

	[FieldOffset(Offset="0xC8")]
	private bool _isLocalPlayersClub;

	[FieldOffset(Offset="0xD0")]
	private List<ClubHubController.RosterEntry> _roster;

	[FieldOffset(Offset="0xD8")]
	private ClubHubRosterFilterSortController _filterSortController;

	[FieldOffset(Offset="0xE0")]
	private ClubHubController.RosterEntry _localPlayer;

	[Address(RVA="0x11B9D34", Offset="0x11B9D34", VA="0x11B9D34")]
	public ClubHubController()
	{
	}

	[Address(RVA="0x11B9D3C", Offset="0x11B9D3C", VA="0x11B9D3C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106ED34", Offset="0x106ED34")]
	private void <HandleDispatchAction>b__5_0()
	{
	}

	[Address(RVA="0x11B9D40", Offset="0x11B9D40", VA="0x11B9D40")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106ED44", Offset="0x106ED44")]
	private void <HandleDispatchAction>b__5_1()
	{
	}

	[Address(RVA="0x11B9D44", Offset="0x11B9D44", VA="0x11B9D44")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106ED54", Offset="0x106ED54")]
	private void <RequestClubWarStatus>b__17_0(ClubWarResponse response)
	{
	}

	[Address(RVA="0x11B9D80", Offset="0x11B9D80", VA="0x11B9D80")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106ED64", Offset="0x106ED64")]
	private void <RequestClubWarStatus>b__17_1(long errorCode)
	{
	}

	[Address(RVA="0x11B8BEC", Offset="0x11B8BEC", VA="0x11B8BEC", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x11B6C50", Offset="0x11B6C50", VA="0x11B6C50", Slot="13")]
	public void HandleDispatchAction(DClubHubViewAction action)
	{
	}

	[Address(RVA="0x11B70B0", Offset="0x11B70B0", VA="0x11B70B0", Slot="14")]
	public void HandleDispatchAction(DClubHubRosterListItemClickedAction action)
	{
	}

	[Address(RVA="0x11B7734", Offset="0x11B7734", VA="0x11B7734", Slot="15")]
	public void HandleDispatchAction(DClubJoinRequestAction action)
	{
	}

	[Address(RVA="0x11B8350", Offset="0x11B8350", VA="0x11B8350", Slot="16")]
	public void HandleDispatchAction(DPlayerClubChangedAction action)
	{
	}

	[Address(RVA="0x11B8868", Offset="0x11B8868", VA="0x11B8868", Slot="17")]
	public void HandleDispatchAction(DPopupControllerAction action)
	{
	}

	[Address(RVA="0x11B890C", Offset="0x11B890C", VA="0x11B890C", Slot="18")]
	public void HandleDispatchAction(DClubInviteAcceptedAction action)
	{
	}

	[Address(RVA="0x11B891C", Offset="0x11B891C", VA="0x11B891C", Slot="19")]
	public void HandleDispatchAction(DClubSettingsChangedAction action)
	{
	}

	[Address(RVA="0x11B892C", Offset="0x11B892C", VA="0x11B892C", Slot="20")]
	public void HandleDispatchAction(DClubRosterChangedAction action)
	{
	}

	[Address(RVA="0x11B893C", Offset="0x11B893C", VA="0x11B893C", Slot="21")]
	public void HandleDispatchAction(DClubHubRosterSortedAction action)
	{
	}

	[Address(RVA="0x11B688C", Offset="0x11B688C", VA="0x11B688C", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x11B77A4", Offset="0x11B77A4", VA="0x11B77A4")]
	private void InitializeView(ClubHubController.ViewInitFlags initFlags = 7)
	{
	}

	[Address(RVA="0x11B86DC", Offset="0x11B86DC", VA="0x11B86DC")]
	private void RequestClubWarStatus(Action finished)
	{
	}

	[Address(RVA="0x11B8518", Offset="0x11B8518", VA="0x11B8518")]
	private void RequestDungeonStatus(Action finished)
	{
	}

	[Address(RVA="0x11B70B4", Offset="0x11B70B4", VA="0x11B70B4")]
	private void ShowRosterEntryActionPopup(ClubHubController.RosterEntry clickedPlayer, RectTransform clickedTransform)
	{
	}

	[Address(RVA="0x11B6B98", Offset="0x11B6B98", VA="0x11B6B98", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x11B9700", Offset="0x11B9700", VA="0x11B9700")]
	private void UpdateClubDungeonButton()
	{
	}

	[Address(RVA="0x11B97AC", Offset="0x11B97AC", VA="0x11B97AC")]
	private void UpdateClubWarButton()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B63C", Offset="0x104B63C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubHubController <>4__this;

		[FieldOffset(Offset="0x18")]
		public SocialGameState.ClubHubContext clubContext;

		[FieldOffset(Offset="0x20")]
		public GameStateTransitionContext context;

		[FieldOffset(Offset="0x28")]
		public Action<ClubResponse> <>9__5;

		[FieldOffset(Offset="0x30")]
		public Action <>9__7;

		[FieldOffset(Offset="0x38")]
		public Action <>9__8;

		[Address(RVA="0x11B6B90", Offset="0x11B6B90", VA="0x11B6B90")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11B9E04", Offset="0x11B9E04", VA="0x11B9E04")]
		internal void <Initialize>b__0(Action finished)
		{
		}

		[Address(RVA="0x11B9EF8", Offset="0x11B9EF8", VA="0x11B9EF8")]
		internal void <Initialize>b__1(Action finished)
		{
		}

		[Address(RVA="0x11BA390", Offset="0x11BA390", VA="0x11BA390")]
		internal void <Initialize>b__2(Action finished)
		{
		}

		[Address(RVA="0x11BA5DC", Offset="0x11BA5DC", VA="0x11BA5DC")]
		internal void <Initialize>b__3()
		{
		}

		[Address(RVA="0x11BA590", Offset="0x11BA590", VA="0x11BA590")]
		internal void <Initialize>b__5(ClubResponse response)
		{
		}

		[Address(RVA="0x11BAB1C", Offset="0x11BAB1C", VA="0x11BAB1C")]
		internal void <Initialize>b__7()
		{
		}

		[Address(RVA="0x11BAB48", Offset="0x11BAB48", VA="0x11BAB48")]
		internal void <Initialize>b__8()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B64C", Offset="0x104B64C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action finished;

		[FieldOffset(Offset="0x18")]
		public ClubHubController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x11B9EF0", Offset="0x11B9EF0", VA="0x11B9EF0")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x11BAB74", Offset="0x11BAB74", VA="0x11BAB74")]
		internal void <Initialize>b__4(ClubHubView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B65C", Offset="0x104B65C")]
	private sealed class <>c__DisplayClass0_2
	{
		[FieldOffset(Offset="0x10")]
		public ClubRequest clubRequest;

		[FieldOffset(Offset="0x18")]
		public ClubHubController.<>c__DisplayClass0_0 CS$<>8__locals2;

		[Address(RVA="0x11BA588", Offset="0x11BA588", VA="0x11BA588")]
		public <>c__DisplayClass0_2()
		{
		}

		[Address(RVA="0x11BAD48", Offset="0x11BAD48", VA="0x11BAD48")]
		internal void <Initialize>b__6(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B66C", Offset="0x104B66C")]
	private sealed class <>c__DisplayClass15_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubHubController <>4__this;

		[FieldOffset(Offset="0x18")]
		public ClubHubController.RosterEntry clickedPlayer;

		[FieldOffset(Offset="0x20")]
		public bool clickedPlayerIsLocalPlayer;

		[Address(RVA="0x11B9BF0", Offset="0x11B9BF0", VA="0x11B9BF0")]
		public <>c__DisplayClass15_0()
		{
		}

		[Address(RVA="0x11BAE48", Offset="0x11BAE48", VA="0x11BAE48")]
		internal void <ShowRosterEntryActionPopup>b__0()
		{
		}

		[Address(RVA="0x11BAEFC", Offset="0x11BAEFC", VA="0x11BAEFC")]
		internal void <ShowRosterEntryActionPopup>b__1()
		{
		}

		[Address(RVA="0x11BB000", Offset="0x11BB000", VA="0x11BB000")]
		internal void <ShowRosterEntryActionPopup>b__2()
		{
		}

		[Address(RVA="0x11BB0D4", Offset="0x11BB0D4", VA="0x11BB0D4")]
		internal void <ShowRosterEntryActionPopup>b__3()
		{
		}

		[Address(RVA="0x11BB1A8", Offset="0x11BB1A8", VA="0x11BB1A8")]
		internal void <ShowRosterEntryActionPopup>b__4()
		{
		}

		[Address(RVA="0x11BB2EC", Offset="0x11BB2EC", VA="0x11BB2EC")]
		internal void <ShowRosterEntryActionPopup>b__5()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B67C", Offset="0x104B67C")]
	private sealed class <>c__DisplayClass16_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubHubController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x11B9C58", Offset="0x11B9C58", VA="0x11B9C58")]
		public <>c__DisplayClass16_0()
		{
		}

		[Address(RVA="0x11BB3A8", Offset="0x11BB3A8", VA="0x11BB3A8")]
		internal void <RequestDungeonStatus>b__0(ClubDungeonStatusResponse response)
		{
		}

		[Address(RVA="0x11BB41C", Offset="0x11BB41C", VA="0x11BB41C")]
		internal void <RequestDungeonStatus>b__1(long failureCode)
		{
		}
	}

	public class RosterEntry
	{
		[FieldOffset(Offset="0x10")]
		public readonly ClubRosterEntry ClubRosterEntry;

		[FieldOffset(Offset="0x18")]
		public readonly Gamedata.InventoryItem? AvatarPin;

		[FieldOffset(Offset="0x30")]
		public readonly bool IsLocalPlayer;

		public ulong CollectionScore
		{
			[Address(RVA="0x11BB6A8", Offset="0x11BB6A8", VA="0x11BB6A8")]
			get
			{
				return new ulong();
			}
		}

		public ulong DonationCount
		{
			[Address(RVA="0x11BB560", Offset="0x11BB560", VA="0x11BB560")]
			get
			{
				return new ulong();
			}
		}

		public string Id
		{
			[Address(RVA="0x11B9BF8", Offset="0x11B9BF8", VA="0x11B9BF8")]
			get
			{
				return null;
			}
		}

		public DateTime JoinDate
		{
			[Address(RVA="0x11BB590", Offset="0x11BB590", VA="0x11BB590")]
			get
			{
				return new DateTime();
			}
		}

		public DateTime LastLogin
		{
			[Address(RVA="0x11BB61C", Offset="0x11BB61C", VA="0x11BB61C")]
			get
			{
				return new DateTime();
			}
		}

		public string Name
		{
			[Address(RVA="0x11BB500", Offset="0x11BB500", VA="0x11BB500")]
			get
			{
				return null;
			}
		}

		public PlayerProfileSimple PlayerProfile
		{
			[Address(RVA="0x11BAFD0", Offset="0x11BAFD0", VA="0x11BAFD0")]
			get
			{
				return null;
			}
		}

		public ClubRole Role
		{
			[Address(RVA="0x11B9C28", Offset="0x11B9C28", VA="0x11B9C28")]
			get
			{
				return new ClubRole();
			}
		}

		public bool ShowVipBg
		{
			[Address(RVA="0x11BB530", Offset="0x11BB530", VA="0x11BB530")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x11B90F4", Offset="0x11B90F4", VA="0x11B90F4")]
		public RosterEntry(ClubRosterEntry clubRosterEntry, Gamedata.InventoryItem? avatarPin, bool isLocalPlayer)
		{
		}
	}

	[Flags]
	private enum ViewInitFlags
	{
		[FieldOffset(Offset="0x0")]
		Settings = 1,
		[FieldOffset(Offset="0x0")]
		Roster = 2,
		[FieldOffset(Offset="0x0")]
		Misc = 4,
		[FieldOffset(Offset="0x0")]
		All = 7
	}
}