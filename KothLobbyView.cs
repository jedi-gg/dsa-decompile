using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KothLobbyView : AStandardView
{
	[FieldOffset(Offset="0x0")]
	private const float REFRESH_OPPONENT_COOLDOWN_S = 2f;

	[FieldOffset(Offset="0x0")]
	private const ulong HIDE_REFRESH_UNDER_S = 1L;

	[Attribute(Name="InjectAttribute", RVA="0x105A574", Offset="0x105A574")]
	[FieldOffset(Offset="0x68")]
	private BadgingController _badgingController;

	[Attribute(Name="InjectAttribute", RVA="0x105A584", Offset="0x105A584")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105A594", Offset="0x105A594")]
	[FieldOffset(Offset="0x78")]
	private PlayerDomainController _playerDC;

	[FieldOffset(Offset="0x80")]
	private UiTimerLabel _cooldownTimer;

	[FieldOffset(Offset="0x88")]
	private float _refreshOpponentsCooldownS;

	[FieldOffset(Offset="0x90")]
	private UiTimerLabel _payoutCountdownTimer;

	private KothLobbyView.SerializedFields Fields
	{
		[Address(RVA="0x11D3F34", Offset="0x11D3F34", VA="0x11D3F34")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11D5360", Offset="0x11D5360", VA="0x11D5360")]
	public KothLobbyView()
	{
	}

	[Address(RVA="0x11D5368", Offset="0x11D5368", VA="0x11D5368")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070184", Offset="0x1070184")]
	private void <ViewAssetLoaded>b__2_0()
	{
	}

	[Address(RVA="0x11D53EC", Offset="0x11D53EC", VA="0x11D53EC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070194", Offset="0x1070194")]
	private void <ViewAssetLoaded>b__2_1()
	{
	}

	[Address(RVA="0x11D5470", Offset="0x11D5470", VA="0x11D5470")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10701A4", Offset="0x10701A4")]
	private void <ViewAssetLoaded>b__2_2()
	{
	}

	[Address(RVA="0x11D54F4", Offset="0x11D54F4", VA="0x11D54F4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10701B4", Offset="0x10701B4")]
	private void <ViewAssetLoaded>b__2_3()
	{
	}

	[Address(RVA="0x11D5578", Offset="0x11D5578", VA="0x11D5578")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10701C4", Offset="0x10701C4")]
	private void <ViewAssetLoaded>b__2_4()
	{
	}

	[Address(RVA="0x11D55FC", Offset="0x11D55FC", VA="0x11D55FC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10701D4", Offset="0x10701D4")]
	private void <ViewAssetLoaded>b__2_5()
	{
	}

	[Address(RVA="0x11D5680", Offset="0x11D5680", VA="0x11D5680")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10701E4", Offset="0x10701E4")]
	private void <ViewAssetLoaded>b__2_6()
	{
	}

	[Address(RVA="0x11D5704", Offset="0x11D5704", VA="0x11D5704")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10701F4", Offset="0x10701F4")]
	private void <ViewAssetLoaded>b__2_7()
	{
	}

	[Address(RVA="0x11D5788", Offset="0x11D5788", VA="0x11D5788")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070204", Offset="0x1070204")]
	private void <ViewAssetLoaded>b__2_8(Button b)
	{
	}

	[Address(RVA="0x11D4014", Offset="0x11D4014", VA="0x11D4014")]
	private void EnableCooldown(bool cooldownEnabled)
	{
	}

	[Address(RVA="0x11D4FF8", Offset="0x11D4FF8", VA="0x11D4FF8", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x11D4DA0", Offset="0x11D4DA0", VA="0x11D4DA0", Slot="18")]
	protected override void ProcessBackButton()
	{
	}

	[Address(RVA="0x11D4F38", Offset="0x11D4F38", VA="0x11D4F38")]
	private void RefreshOpponents()
	{
	}

	[Address(RVA="0x11D08B4", Offset="0x11D08B4", VA="0x11D08B4")]
	public void SetData(KothLobbyResponse data, ulong defensePowerRating, IList<ItemCount> dailyPayout)
	{
	}

	[Address(RVA="0x11CE9C8", Offset="0x11CE9C8", VA="0x11CE9C8")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x11D4E10", Offset="0x11D4E10", VA="0x11D4E10")]
	private void ToggleInfo()
	{
	}

	[Address(RVA="0x11D40EC", Offset="0x11D40EC", VA="0x11D40EC", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11D48B8", Offset="0x11D48B8", VA="0x11D48B8", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C36C", Offset="0x104C36C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static KothLobbyView.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<Button> <>9__3_0;

		[Address(RVA="0x11D5838", Offset="0x11D5838", VA="0x11D5838")]
		static <>c()
		{
		}

		[Address(RVA="0x11D589C", Offset="0x11D589C", VA="0x11D589C")]
		public <>c()
		{
		}

		[Address(RVA="0x11D58A4", Offset="0x11D58A4", VA="0x11D58A4")]
		internal void <ViewShuttingDown>b__3_0(Button b)
		{
		}
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public List<Badge> Badges;

		[FieldOffset(Offset="0x30")]
		public Button InventoryButton;

		[FieldOffset(Offset="0x38")]
		public Button ShipmentButton;

		[FieldOffset(Offset="0x40")]
		public Button LeaderboardButton;

		[FieldOffset(Offset="0x48")]
		public Button RewardsButton;

		[FieldOffset(Offset="0x50")]
		public Button RefreshOpponentsButton;

		[FieldOffset(Offset="0x58")]
		public ClubSupportRequestButton ClubSupportRequestButton;

		[FieldOffset(Offset="0x60")]
		public Button BattleHistoryButton;

		[FieldOffset(Offset="0x68")]
		public Button InfoButton;

		[FieldOffset(Offset="0x70")]
		public UnityEngine.GameObject InfoContainer;

		[FieldOffset(Offset="0x78")]
		public List<Button> InfoCloseButtons;

		[FieldOffset(Offset="0x80")]
		public KothLobbyOpponentWidget[] OpponentWidgets;

		[Attribute(Name="HeaderAttribute", RVA="0x106AD7C", Offset="0x106AD7C")]
		[FieldOffset(Offset="0x88")]
		public UiLabel PlayerRankLabel;

		[FieldOffset(Offset="0x90")]
		public UiLabel PlayerDefensePower;

		[FieldOffset(Offset="0x98")]
		public Button SetDefenseButton;

		[FieldOffset(Offset="0xA0")]
		public Image RankIcon;

		[FieldOffset(Offset="0xA8")]
		public PlayerRankSpriteLookup RankSpriteLookup;

		[Attribute(Name="HeaderAttribute", RVA="0x106ADB4", Offset="0x106ADB4")]
		[FieldOffset(Offset="0xB0")]
		public UiLabel AttemptsLabel;

		[FieldOffset(Offset="0xB8")]
		public UnityEngine.GameObject CooldownContainer;

		[FieldOffset(Offset="0xC0")]
		public UiLabel CooldownTimerLabel;

		[FieldOffset(Offset="0xC8")]
		public UnityEngine.GameObject RefreshCooldownContainer;

		[FieldOffset(Offset="0xD0")]
		public CostButton RefreshCooldownButton;

		[FieldOffset(Offset="0xD8")]
		public Button RefreshCooldownForAdButton;

		[Attribute(Name="HeaderAttribute", RVA="0x106ADEC", Offset="0x106ADEC")]
		[FieldOffset(Offset="0xE0")]
		public UiLabel[] RewardAmount;

		[FieldOffset(Offset="0xE8")]
		public RawImage[] RewardIcon;

		[FieldOffset(Offset="0xF0")]
		public UiLabel RewardPayoutTime;

		[Address(RVA="0x11D58EC", Offset="0x11D58EC", VA="0x11D58EC")]
		public SerializedFields()
		{
		}
	}
}