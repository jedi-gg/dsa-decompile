using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PvpLobbyView : AStandardView
{
	[Attribute(Name="InjectAttribute", RVA="0x105BE00", Offset="0x105BE00")]
	[FieldOffset(Offset="0x68")]
	private BadgingController _badgingController;

	[Attribute(Name="InjectAttribute", RVA="0x105BE10", Offset="0x105BE10")]
	[FieldOffset(Offset="0x70")]
	private PassportSeasonUtility _passportSeasonUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105BE20", Offset="0x105BE20")]
	[FieldOffset(Offset="0x78")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x105BE30", Offset="0x105BE30")]
	[FieldOffset(Offset="0x80")]
	private PlayerDomainController _playerDc;

	[FieldOffset(Offset="0x88")]
	private UiTimerLabel _timerLabel;

	public DailyPvpRewardWidget DailyPvpRewardWidget
	{
		[Address(RVA="0x128737C", Offset="0x128737C", VA="0x128737C")]
		get
		{
			return null;
		}
	}

	private PvpLobbyView.SerializedFields Fields
	{
		[Address(RVA="0x12878B4", Offset="0x12878B4", VA="0x12878B4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x128857C", Offset="0x128857C", VA="0x128857C")]
	public PvpLobbyView()
	{
	}

	[Address(RVA="0x1288584", Offset="0x1288584", VA="0x1288584")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070744", Offset="0x1070744")]
	private void <ViewAssetLoaded>b__5_0()
	{
	}

	[Address(RVA="0x1288608", Offset="0x1288608", VA="0x1288608")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070754", Offset="0x1070754")]
	private void <ViewAssetLoaded>b__5_1()
	{
	}

	[Address(RVA="0x128868C", Offset="0x128868C", VA="0x128868C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070764", Offset="0x1070764")]
	private void <ViewAssetLoaded>b__5_2()
	{
	}

	[Address(RVA="0x1288710", Offset="0x1288710", VA="0x1288710")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070774", Offset="0x1070774")]
	private void <ViewAssetLoaded>b__5_3()
	{
	}

	[Address(RVA="0x1288794", Offset="0x1288794", VA="0x1288794")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070784", Offset="0x1070784")]
	private void <ViewAssetLoaded>b__5_4()
	{
	}

	[Address(RVA="0x1288818", Offset="0x1288818", VA="0x1288818")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070794", Offset="0x1070794")]
	private void <ViewAssetLoaded>b__5_5()
	{
	}

	[Address(RVA="0x128889C", Offset="0x128889C", VA="0x128889C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10707A4", Offset="0x10707A4")]
	private void <ViewAssetLoaded>b__5_6(UiLockableFeature l)
	{
	}

	[Address(RVA="0x1286B90", Offset="0x1286B90", VA="0x1286B90")]
	public void SetPvpEvent(PvpLobbyResponse response)
	{
	}

	[Address(RVA="0x1287594", Offset="0x1287594", VA="0x1287594")]
	public void SetPvpRank(PvpRank? pvpRank, ulong playerScore)
	{
	}

	[Address(RVA="0x1286A10", Offset="0x1286A10", VA="0x1286A10")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1287994", Offset="0x1287994", VA="0x1287994", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1288318", Offset="0x1288318", VA="0x1288318", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106B77C", Offset="0x106B77C")]
		[FieldOffset(Offset="0x28")]
		public List<UiLockableFeature> UiLockableFeatures;

		[FieldOffset(Offset="0x30")]
		public List<Badge> Badges;

		[FieldOffset(Offset="0x38")]
		public Button InventoryButton;

		[FieldOffset(Offset="0x40")]
		public Button ShipmentsButton;

		[FieldOffset(Offset="0x48")]
		public DailyPvpRewardWidget DailyPvpReward;

		[FieldOffset(Offset="0x50")]
		public UnityEngine.GameObject TimerParent;

		[FieldOffset(Offset="0x58")]
		public UiLabel TimerLabel;

		[FieldOffset(Offset="0x60")]
		public UiLabel TimerPrefixLabel;

		[FieldOffset(Offset="0x68")]
		public Button PassportButton;

		[FieldOffset(Offset="0x70")]
		public RawImage LeftBanner;

		[FieldOffset(Offset="0x78")]
		public UiLabel LeftBannerText;

		[FieldOffset(Offset="0x80")]
		public RawImage RightBanner;

		[FieldOffset(Offset="0x88")]
		public UiLabel RightBannerText;

		[Attribute(Name="HeaderAttribute", RVA="0x106B7B4", Offset="0x106B7B4")]
		[FieldOffset(Offset="0x90")]
		public Button WeeklyRewardsButton;

		[FieldOffset(Offset="0x98")]
		public UiLabel WeeklyRewardsLabel;

		[FieldOffset(Offset="0xA0")]
		public Button SeasonRewardsButton;

		[FieldOffset(Offset="0xA8")]
		public UiLabel SeasonRewardsLabel;

		[FieldOffset(Offset="0xB0")]
		public RawImage WeeklyPvpRankIcon;

		[FieldOffset(Offset="0xB8")]
		public UiLabel WeeklyPvpScoreLabel;

		[FieldOffset(Offset="0xC0")]
		public RawImage SeasonPvpRankIcon;

		[FieldOffset(Offset="0xC8")]
		public UiLabel SeasonPvpScoreLabel;

		[Address(RVA="0x128891C", Offset="0x128891C", VA="0x128891C")]
		public SerializedFields()
		{
		}
	}
}