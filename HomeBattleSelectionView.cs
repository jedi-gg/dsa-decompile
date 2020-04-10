using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeBattleSelectionView : APopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x1058F88", Offset="0x1058F88")]
	[FieldOffset(Offset="0x68")]
	private BadgingController _badgingController;

	[Attribute(Name="InjectAttribute", RVA="0x1058F98", Offset="0x1058F98")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1058FA8", Offset="0x1058FA8")]
	[FieldOffset(Offset="0x78")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1058FB8", Offset="0x1058FB8")]
	[FieldOffset(Offset="0x80")]
	private FeatureLockController _featureLockController;

	private HomeBattleSelectionView.SerializedFields Fields
	{
		[Address(RVA="0x12E9860", Offset="0x12E9860", VA="0x12E9860")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12EA718", Offset="0x12EA718", VA="0x12EA718")]
	public HomeBattleSelectionView()
	{
	}

	[Address(RVA="0x12EA720", Offset="0x12EA720", VA="0x12EA720")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FDC4", Offset="0x106FDC4")]
	private void <ViewAssetLoaded>b__3_0(UiLockableFeature l)
	{
	}

	[Address(RVA="0x12EA7A0", Offset="0x12EA7A0", VA="0x12EA7A0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FDD4", Offset="0x106FDD4")]
	private void <ViewAssetLoaded>b__3_1()
	{
	}

	[Address(RVA="0x12EA824", Offset="0x12EA824", VA="0x12EA824")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FDE4", Offset="0x106FDE4")]
	private void <ViewAssetLoaded>b__3_2()
	{
	}

	[Address(RVA="0x12EA8A8", Offset="0x12EA8A8", VA="0x12EA8A8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FDF4", Offset="0x106FDF4")]
	private void <ViewAssetLoaded>b__3_3()
	{
	}

	[Address(RVA="0x12EA92C", Offset="0x12EA92C", VA="0x12EA92C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FE04", Offset="0x106FE04")]
	private void <ViewAssetLoaded>b__3_4()
	{
	}

	[Address(RVA="0x12EA0A0", Offset="0x12EA0A0", VA="0x12EA0A0")]
	private void SetArenaStatus()
	{
	}

	[Address(RVA="0x12E90F4", Offset="0x12E90F4", VA="0x12E90F4")]
	public void SetBonusLootLabel(HomeBattleSelectResponse homeBattleSelectResponse)
	{
	}

	[Address(RVA="0x12E9C74", Offset="0x12E9C74", VA="0x12E9C74")]
	private void SetCampaignStars()
	{
	}

	[Address(RVA="0x12E96A0", Offset="0x12E96A0", VA="0x12E96A0")]
	public void SetPvpResponse(HomePvpResponse homePvpResponse)
	{
	}

	[Address(RVA="0x12E8840", Offset="0x12E8840", VA="0x12E8840")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x12E9940", Offset="0x12E9940", VA="0x12E9940", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x12EA458", Offset="0x12EA458", VA="0x12EA458", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C07C", Offset="0x104C07C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static HomeBattleSelectionView.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<UiLockableFeature> <>9__4_0;

		[Address(RVA="0x12EA9B0", Offset="0x12EA9B0", VA="0x12EA9B0")]
		static <>c()
		{
		}

		[Address(RVA="0x12EAA14", Offset="0x12EAA14", VA="0x12EAA14")]
		public <>c()
		{
		}

		[Address(RVA="0x12EAA1C", Offset="0x12EAA1C", VA="0x12EAA1C")]
		internal void <ViewShuttingDown>b__4_0(UiLockableFeature l)
		{
		}
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106A91C", Offset="0x106A91C")]
		[FieldOffset(Offset="0x30")]
		public List<Badge> Badges;

		[FieldOffset(Offset="0x38")]
		public List<UiLockableFeature> UiLockableFeatures;

		[Attribute(Name="HeaderAttribute", RVA="0x106A954", Offset="0x106A954")]
		[FieldOffset(Offset="0x40")]
		public Button HeroButton;

		[FieldOffset(Offset="0x48")]
		public UiLabel HeroStarLabel;

		[FieldOffset(Offset="0x50")]
		public UnityEngine.GameObject HeroBonusLootContainer;

		[FieldOffset(Offset="0x58")]
		public UiLabel HeroBonusLootLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106A98C", Offset="0x106A98C")]
		[FieldOffset(Offset="0x60")]
		public Button VillainButton;

		[FieldOffset(Offset="0x68")]
		public UiLabel VillainStarLabel;

		[FieldOffset(Offset="0x70")]
		public UnityEngine.GameObject VillainBonusLootContainer;

		[FieldOffset(Offset="0x78")]
		public UiLabel VillainBonusLootLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106A9C4", Offset="0x106A9C4")]
		[FieldOffset(Offset="0x80")]
		public Button GrandButton;

		[FieldOffset(Offset="0x88")]
		public UiLabel GrandStarLabel;

		[FieldOffset(Offset="0x90")]
		public UnityEngine.GameObject GrandBonusLootContainer;

		[FieldOffset(Offset="0x98")]
		public UiLabel GrandBonusLootLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106A9FC", Offset="0x106A9FC")]
		[FieldOffset(Offset="0xA0")]
		public Button PvpButton;

		[FieldOffset(Offset="0xA8")]
		public RawImage PvpRankIcon;

		[FieldOffset(Offset="0xB0")]
		public UnityEngine.GameObject PvpRankPlaceholder;

		[FieldOffset(Offset="0xB8")]
		public DailyPvpRewardWidget DailyPvpRewardWidget;

		[FieldOffset(Offset="0xC0")]
		public UiLabel PvpLockedLabel;

		[FieldOffset(Offset="0xC8")]
		public RawImage PvpPanelView;

		[FieldOffset(Offset="0xD0")]
		public UnityEngine.GameObject PvpBonusLootContainer;

		[FieldOffset(Offset="0xD8")]
		public UiLabel PvpBonusLootLabel;

		[Address(RVA="0x12EAA4C", Offset="0x12EAA4C", VA="0x12EAA4C")]
		public SerializedFields()
		{
		}
	}
}