using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClubActivityView : AStandardView, IDispatchHandler<DSelectClubActivityTierAction>, IDispatchHandler, IDispatchHandler<DInventoryItemListItemAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1056818", Offset="0x1056818")]
	[FieldOffset(Offset="0x68")]
	private SingleAssetRegistry _iconAssetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x1056828", Offset="0x1056828")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x78")]
	private List<DClubActivityTierData> _tierData;

	[FieldOffset(Offset="0x80")]
	private List<ClubActivityPlayerData> _sortedPlayers;

	[FieldOffset(Offset="0x88")]
	private UiTimerLabel _resetTimerLabel;

	[FieldOffset(Offset="0x90")]
	private DClubActivityTierData? _selectedActivityTier;

	private ClubActivityView.SerializedFields Fields
	{
		[Address(RVA="0x1465838", Offset="0x1465838", VA="0x1465838")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1467AC8", Offset="0x1467AC8", VA="0x1467AC8")]
	public ClubActivityView()
	{
	}

	[Address(RVA="0x1467408", Offset="0x1467408", VA="0x1467408")]
	private void BindActivityListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x1467564", Offset="0x1467564", VA="0x1467564")]
	private void BindPlayerListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x146775C", Offset="0x146775C", VA="0x146775C")]
	private void BindRewardListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x146791C", Offset="0x146791C", VA="0x146791C")]
	private void DeepLinkClicked()
	{
	}

	[Address(RVA="0x1467A44", Offset="0x1467A44", VA="0x1467A44")]
	private void FindClubClicked()
	{
	}

	[Address(RVA="0x14665CC", Offset="0x14665CC", VA="0x14665CC", Slot="21")]
	public void HandleDispatchAction(DSelectClubActivityTierAction action)
	{
	}

	[Address(RVA="0x1466BE0", Offset="0x1466BE0", VA="0x1466BE0", Slot="22")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x146732C", Offset="0x146732C", VA="0x146732C")]
	private void InitializeActivityListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x1467660", Offset="0x1467660", VA="0x1467660")]
	private void InitializeRewardListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x14665FC", Offset="0x14665FC", VA="0x14665FC")]
	private void SelectActivity(DClubActivityTierData data)
	{
	}

	[Address(RVA="0x1464B80", Offset="0x1464B80", VA="0x1464B80")]
	public void SetData(Club club, IList<ClubActivity> activities, DateTime resetTime)
	{
	}

	[Address(RVA="0x1464B04", Offset="0x1464B04", VA="0x1464B04")]
	public void SetNoClubData()
	{
	}

	[Address(RVA="0x1466DA4", Offset="0x1466DA4", VA="0x1466DA4")]
	private static int SortActivities(ClubActivity a, ClubActivity b)
	{
		return new int();
	}

	[Address(RVA="0x1466E10", Offset="0x1466E10", VA="0x1466E10")]
	private static int SortPlayers(ClubActivityPlayerData a, ClubActivityPlayerData b)
	{
		return new int();
	}

	[Address(RVA="0x1464030", Offset="0x1464030", VA="0x1464030")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1465CA0", Offset="0x1465CA0", VA="0x1465CA0")]
	private void UpdateActivityTiers(IList<ClubActivity> activities)
	{
	}

	[Address(RVA="0x1465918", Offset="0x1465918", VA="0x1465918")]
	private void UpdatePlayers(Club club, DateTime resetTime)
	{
	}

	[Address(RVA="0x1466E58", Offset="0x1466E58", VA="0x1466E58", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x14671A0", Offset="0x14671A0", VA="0x14671A0", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public UnityEngine.GameObject NoClubContainer;

		[FieldOffset(Offset="0x30")]
		public Button FindClubButton;

		[FieldOffset(Offset="0x38")]
		public UnityEngine.GameObject ClubContainer;

		[FieldOffset(Offset="0x40")]
		public RawImage ClubAvatarImage;

		[FieldOffset(Offset="0x48")]
		public UiLabel ClubNameLabel;

		[FieldOffset(Offset="0x50")]
		public UiLabel ClubDescriptionLabel;

		[FieldOffset(Offset="0x58")]
		public UiLabel ResetTimerLabel;

		[FieldOffset(Offset="0x60")]
		public WrappedScrollRect ActivitiesScrollRect;

		[FieldOffset(Offset="0x68")]
		public WrappedScrollRect PlayersScrollRect;

		[FieldOffset(Offset="0x70")]
		public WrappedScrollRect RewardsScrollRect;

		[FieldOffset(Offset="0x78")]
		public Button GoButton;

		[Address(RVA="0x1467B38", Offset="0x1467B38", VA="0x1467B38")]
		public SerializedFields()
		{
		}
	}
}