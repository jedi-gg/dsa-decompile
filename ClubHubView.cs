using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClubHubView : AStandardView
{
	[Attribute(Name="InjectAttribute", RVA="0x1055FE8", Offset="0x1055FE8")]
	[FieldOffset(Offset="0x68")]
	private BadgingController _badgingController;

	[Attribute(Name="InjectAttribute", RVA="0x1055FF8", Offset="0x1055FF8")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x78")]
	private IReadOnlyList<ClubHubController.RosterEntry> _roster;

	[FieldOffset(Offset="0x80")]
	private ClubHubRosterSortMode _sortMode;

	private ClubHubView.SerializedFields Fields
	{
		[Address(RVA="0x11BC920", Offset="0x11BC920", VA="0x11BC920")]
		get
		{
			return null;
		}
	}

	public bool ShouldRequestDungeonAndWarData
	{
		[Address(RVA="0x11B9C60", Offset="0x11B9C60", VA="0x11B9C60")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11BD84C", Offset="0x11BD84C", VA="0x11BD84C")]
	public ClubHubView()
	{
	}

	[Address(RVA="0x11BD854", Offset="0x11BD854", VA="0x11BD854")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106ED94", Offset="0x106ED94")]
	private void <ViewAssetLoaded>b__21_0()
	{
	}

	[Address(RVA="0x11BD8D8", Offset="0x11BD8D8", VA="0x11BD8D8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EDA4", Offset="0x106EDA4")]
	private void <ViewAssetLoaded>b__21_1()
	{
	}

	[Address(RVA="0x11BD95C", Offset="0x11BD95C", VA="0x11BD95C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EDB4", Offset="0x106EDB4")]
	private void <ViewAssetLoaded>b__21_2()
	{
	}

	[Address(RVA="0x11BD9E0", Offset="0x11BD9E0", VA="0x11BD9E0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EDC4", Offset="0x106EDC4")]
	private void <ViewAssetLoaded>b__21_3()
	{
	}

	[Address(RVA="0x11BDA64", Offset="0x11BDA64", VA="0x11BDA64")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EDD4", Offset="0x106EDD4")]
	private void <ViewAssetLoaded>b__21_4()
	{
	}

	[Address(RVA="0x11BDAE8", Offset="0x11BDAE8", VA="0x11BDAE8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EDE4", Offset="0x106EDE4")]
	private void <ViewAssetLoaded>b__21_5()
	{
	}

	[Address(RVA="0x11BDB6C", Offset="0x11BDB6C", VA="0x11BDB6C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EDF4", Offset="0x106EDF4")]
	private void <ViewAssetLoaded>b__21_6()
	{
	}

	[Address(RVA="0x11BDBF0", Offset="0x11BDBF0", VA="0x11BDBF0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EE04", Offset="0x106EE04")]
	private void <ViewAssetLoaded>b__21_7()
	{
	}

	[Address(RVA="0x11BDC74", Offset="0x11BDC74", VA="0x11BDC74")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EE14", Offset="0x106EE14")]
	private void <ViewAssetLoaded>b__21_8()
	{
	}

	[Address(RVA="0x11BDCF8", Offset="0x11BDCF8", VA="0x11BDCF8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EE24", Offset="0x106EE24")]
	private void <ViewAssetLoaded>b__21_9()
	{
	}

	[Address(RVA="0x11BD544", Offset="0x11BD544", VA="0x11BD544")]
	private void BindClubHubRosterListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x11BD468", Offset="0x11BD468", VA="0x11BD468")]
	private void InitializeClubHubRosterListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11B8C74", Offset="0x11B8C74", VA="0x11B8C74")]
	public void SetClubDescriptionLabelText(string description)
	{
	}

	[Address(RVA="0x11B9954", Offset="0x11B9954", VA="0x11B9954")]
	public void SetClubNameLabelText(string name)
	{
	}

	[Address(RVA="0x11B8E60", Offset="0x11B8E60", VA="0x11B8E60")]
	public void SetIcon(Gamedata.InventoryItem? icon)
	{
	}

	[Address(RVA="0x11B8CC0", Offset="0x11B8CC0", VA="0x11B8CC0")]
	public void SetInvitePolicy(ClubInvitePolicy invitePolicy)
	{
	}

	[Address(RVA="0x11B8DD0", Offset="0x11B8DD0", VA="0x11B8DD0")]
	public void SetLevelRequirement(int levelRequirement)
	{
	}

	[Address(RVA="0x11B9148", Offset="0x11B9148", VA="0x11B9148")]
	public void SetRoster(IReadOnlyList<ClubHubController.RosterEntry> roster, ClubHubRosterSortMode sortMode)
	{
	}

	[Address(RVA="0x11B89EC", Offset="0x11B89EC", VA="0x11B89EC")]
	public void SetRosterSortMode(ClubHubRosterSortMode sortMode)
	{
	}

	[Address(RVA="0x11B94E0", Offset="0x11B94E0", VA="0x11B94E0")]
	public void ShowCancelJoinRequestButton(bool showing)
	{
	}

	[Address(RVA="0x11B99A0", Offset="0x11B99A0", VA="0x11B99A0")]
	public void ShowClubDungeonButton(bool showing, bool showAttempts, ulong attemptsRemaining)
	{
	}

	[Address(RVA="0x11B9AC0", Offset="0x11B9AC0", VA="0x11B9AC0")]
	public void ShowClubWarButton(bool showing, ClubWarPhaseType currentPhase)
	{
	}

	[Address(RVA="0x11B8B48", Offset="0x11B8B48", VA="0x11B8B48")]
	public void ShowCustomSortModeLabel(string text)
	{
	}

	[Address(RVA="0x11B8AEC", Offset="0x11B8AEC", VA="0x11B8AEC")]
	public void ShowDefaultSortModeLabel()
	{
	}

	[Address(RVA="0x11B9640", Offset="0x11B9640", VA="0x11B9640")]
	public void ShowInviteFriendsButton(bool showing)
	{
	}

	[Address(RVA="0x11B95E0", Offset="0x11B95E0", VA="0x11B95E0")]
	public void ShowInvitesButton(bool showing)
	{
	}

	[Address(RVA="0x11B9420", Offset="0x11B9420", VA="0x11B9420")]
	public void ShowJoinButton(bool showing)
	{
	}

	[Address(RVA="0x11B9480", Offset="0x11B9480", VA="0x11B9480")]
	public void ShowJoinRequestButton(bool showing)
	{
	}

	[Address(RVA="0x11B96A0", Offset="0x11B96A0", VA="0x11B96A0")]
	public void ShowLeaveClubButton(bool show)
	{
	}

	[Address(RVA="0x11BA7FC", Offset="0x11BA7FC", VA="0x11BA7FC")]
	public void ShowLoadingScrim(bool showing)
	{
	}

	[Address(RVA="0x11B9540", Offset="0x11B9540", VA="0x11B9540")]
	public void ShowSettingsButton(bool showing)
	{
	}

	[Address(RVA="0x11BD404", Offset="0x11BD404", VA="0x11BD404")]
	private void SortClicked()
	{
	}

	[Address(RVA="0x11BCA00", Offset="0x11BCA00", VA="0x11BCA00", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11BD098", Offset="0x11BD098", VA="0x11BD098", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public UiLabel HeadingLabel;

		[FieldOffset(Offset="0x30")]
		public UiLabel DescriptionLabel;

		[FieldOffset(Offset="0x38")]
		public UiLabel InvitePolicyLabel;

		[FieldOffset(Offset="0x40")]
		public UiLabel LevelRequirementLabel;

		[FieldOffset(Offset="0x48")]
		public WrappedScrollRect RosterScrollRect;

		[FieldOffset(Offset="0x50")]
		public UnityEngine.GameObject LeftColumn;

		[FieldOffset(Offset="0x58")]
		public UnityEngine.GameObject RightColumn;

		[FieldOffset(Offset="0x60")]
		public Button FindClubsButton;

		[FieldOffset(Offset="0x68")]
		public Button JoinButton;

		[FieldOffset(Offset="0x70")]
		public Button JoinRequestButton;

		[FieldOffset(Offset="0x78")]
		public Button CancelJoinRequestButton;

		[FieldOffset(Offset="0x80")]
		public Button SettingsButton;

		[FieldOffset(Offset="0x88")]
		public Image SettingsIcon;

		[FieldOffset(Offset="0x90")]
		public RawImage AvatarImage;

		[FieldOffset(Offset="0x98")]
		public Button InvitesButton;

		[FieldOffset(Offset="0xA0")]
		public List<Badge> Badges;

		[FieldOffset(Offset="0xA8")]
		public Button ClubDungeonButton;

		[FieldOffset(Offset="0xB0")]
		public UnityEngine.GameObject ClubDungeonAttemptsContainer;

		[FieldOffset(Offset="0xB8")]
		public UiLabel ClubDungeonAttemptsLabel;

		[FieldOffset(Offset="0xC0")]
		public Button SortRosterButton;

		[FieldOffset(Offset="0xC8")]
		public UiLabel SortModeLabel;

		[FieldOffset(Offset="0xD0")]
		public UnityEngine.Color LocalPlayerRosterColor;

		[FieldOffset(Offset="0xE0")]
		public Button InviteFriendsButton;

		[FieldOffset(Offset="0xE8")]
		public UiLabel MemberCountLabel;

		[FieldOffset(Offset="0xF0")]
		public Button ClubWarButton;

		[FieldOffset(Offset="0xF8")]
		public UiLabel ClubWarPhaseLabel;

		[FieldOffset(Offset="0x100")]
		public UnityEngine.GameObject DungeonAndWarButtonsContainer;

		[FieldOffset(Offset="0x108")]
		public Button LeaveClubButton;

		[Address(RVA="0x11BDD7C", Offset="0x11BDD7C", VA="0x11BDD7C")]
		public SerializedFields()
		{
		}
	}
}