using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClubDungeonView : AStandardView, IDispatchHandler<DClubDungeonNodeAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1056A68", Offset="0x1056A68")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1056A78", Offset="0x1056A78")]
	[FieldOffset(Offset="0x70")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x1056A88", Offset="0x1056A88")]
	[FieldOffset(Offset="0x78")]
	private GamedataDomainController _gamedataDomainController;

	[FieldOffset(Offset="0x80")]
	private UiTimerLabel _stateEndTimerLabel;

	[FieldOffset(Offset="0x88")]
	private UiTimerLabel _attemptResetTimerLabel;

	[FieldOffset(Offset="0x90")]
	private ClubDungeonContext _dungeonContext;

	[FieldOffset(Offset="0x98")]
	private Action _currentMapLoadedCallback;

	private ClubDungeonView.SerializedFields Fields
	{
		[Address(RVA="0x11B4CA4", Offset="0x11B4CA4", VA="0x11B4CA4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11B5E90", Offset="0x11B5E90", VA="0x11B5E90")]
	public ClubDungeonView()
	{
	}

	[Address(RVA="0x11B5E98", Offset="0x11B5E98", VA="0x11B5E98")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F064", Offset="0x106F064")]
	private void <ViewAssetLoaded>b__5_0(UiLockableFeature l)
	{
	}

	[Address(RVA="0x11B5F18", Offset="0x11B5F18", VA="0x11B5F18")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F074", Offset="0x106F074")]
	private void <ViewAssetLoaded>b__5_1()
	{
	}

	[Address(RVA="0x11B6020", Offset="0x11B6020", VA="0x11B6020")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F084", Offset="0x106F084")]
	private void <ViewAssetLoaded>b__5_2()
	{
	}

	[Address(RVA="0x11B5B6C", Offset="0x11B5B6C", VA="0x11B5B6C")]
	private void BackgroundClicked()
	{
	}

	[Address(RVA="0x11B58F0", Offset="0x11B58F0", VA="0x11B58F0")]
	private void BindMap(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x11B5AE8", Offset="0x11B5AE8", VA="0x11B5AE8")]
	private void BonusAttemptVideoClicked()
	{
	}

	[Address(RVA="0x11B4D84", Offset="0x11B4D84", VA="0x11B4D84")]
	private int CurrentMap()
	{
		return new int();
	}

	[Address(RVA="0x11B5E0C", Offset="0x11B5E0C", VA="0x11B5E0C")]
	private void EventDetailsClicked()
	{
	}

	[Address(RVA="0x11B4E7C", Offset="0x11B4E7C", VA="0x11B4E7C", Slot="21")]
	public void HandleDispatchAction(DClubDungeonNodeAction action)
	{
	}

	[Address(RVA="0x11B5814", Offset="0x11B5814", VA="0x11B5814")]
	private void InitializeMap(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11B5D34", Offset="0x11B5D34", VA="0x11B5D34")]
	private void LeaderboardClicked()
	{
	}

	[Address(RVA="0x11B5C1C", Offset="0x11B5C1C", VA="0x11B5C1C")]
	private void RewardsClicked()
	{
	}

	[Address(RVA="0x11AB25C", Offset="0x11AB25C", VA="0x11AB25C")]
	public void SetAttemptsStatus(ClubDungeonContext dungeonContext)
	{
	}

	[Address(RVA="0x11ABCC0", Offset="0x11ABCC0", VA="0x11ABCC0")]
	public void SetDungeonData(ClubDungeonContext dungeonContext, Action currentMapLoaded)
	{
	}

	[Address(RVA="0x11B4960", Offset="0x11B4960", VA="0x11B4960")]
	public void SetState(ClubDungeonState state)
	{
	}

	[Address(RVA="0x11B5A64", Offset="0x11B5A64", VA="0x11B5A64")]
	private void ShipmentsClicked()
	{
	}

	[Address(RVA="0x11AC144", Offset="0x11AC144", VA="0x11AC144")]
	public void ShowActiveBonusIndicator(bool hasActiveBonus)
	{
	}

	[Address(RVA="0x11A9A5C", Offset="0x11A9A5C", VA="0x11A9A5C")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x11B4EC0", Offset="0x11B4EC0", VA="0x11B4EC0", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11B5520", Offset="0x11B5520", VA="0x11B5520", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public Button ShipmentButton;

		[FieldOffset(Offset="0x30")]
		public Button LeaderboardButton;

		[FieldOffset(Offset="0x38")]
		public List<UiLockableFeature> UiLockableFeatures;

		[Attribute(Name="HeaderAttribute", RVA="0x1069ECC", Offset="0x1069ECC")]
		[FieldOffset(Offset="0x40")]
		public WrappedScrollRect MapsScrollList;

		[FieldOffset(Offset="0x48")]
		public Camera WorldCamera;

		[FieldOffset(Offset="0x50")]
		public Button BackgroundButton;

		[Attribute(Name="HeaderAttribute", RVA="0x1069F04", Offset="0x1069F04")]
		[FieldOffset(Offset="0x58")]
		public UiLabel StateLabel;

		[FieldOffset(Offset="0x60")]
		public UiLabel StateEndTimerLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x1069F3C", Offset="0x1069F3C")]
		[FieldOffset(Offset="0x68")]
		public UnityEngine.GameObject AttemptContainer;

		[FieldOffset(Offset="0x70")]
		public UnityEngine.GameObject[] Attempts;

		[FieldOffset(Offset="0x78")]
		public UnityEngine.GameObject[] VipAttempts;

		[FieldOffset(Offset="0x80")]
		public UiLabel AttemptResetTimerLabel;

		[FieldOffset(Offset="0x88")]
		public Button BonusAttemptVideoButton;

		[FieldOffset(Offset="0x90")]
		public UnityEngine.GameObject AttemptsRemainingContainer;

		[FieldOffset(Offset="0x98")]
		public UnityEngine.GameObject NoAttemptsRemainingContainer;

		[FieldOffset(Offset="0xA0")]
		public Button VIPBonusAttemptButton;

		[FieldOffset(Offset="0xA8")]
		public Button VIPButton;

		[FieldOffset(Offset="0xB0")]
		public UnityEngine.GameObject[] VIPBonusLockIcons;

		[Attribute(Name="HeaderAttribute", RVA="0x1069F74", Offset="0x1069F74")]
		[FieldOffset(Offset="0xB8")]
		public Button RewardsButton;

		[FieldOffset(Offset="0xC0")]
		public ClubDungeonRewardsWidget RewardsWidget;

		[Attribute(Name="HeaderAttribute", RVA="0x1069FAC", Offset="0x1069FAC")]
		[FieldOffset(Offset="0xC8")]
		public DClubDungeonNodeVisuals NodeVisuals;

		[Attribute(Name="HeaderAttribute", RVA="0x1069FE4", Offset="0x1069FE4")]
		[FieldOffset(Offset="0xF8")]
		public UnityEngine.GameObject EventDetailsContainer;

		[FieldOffset(Offset="0x100")]
		public Button EventDetailsButton;

		[Address(RVA="0x11B6128", Offset="0x11B6128", VA="0x11B6128")]
		public SerializedFields()
		{
		}
	}
}