using DG.Tweening;
using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeView : AStandardView
{
	[FieldOffset(Offset="0x0")]
	private const ulong HIDE_REFRESH_UNDER_S = 1L;

	[FieldOffset(Offset="0x0")]
	private static ulong s_dailyEventAvailableCount;

	[FieldOffset(Offset="0x8")]
	private static ulong s_dailyEventMaxCount;

	[FieldOffset(Offset="0x10")]
	private static ulong s_towerNodesCompletedCount;

	[FieldOffset(Offset="0x18")]
	private static ulong s_towerNodesMaxCount;

	[Attribute(Name="InjectAttribute", RVA="0x1058EB8", Offset="0x1058EB8")]
	[FieldOffset(Offset="0x68")]
	private BadgingController _badgingController;

	[Attribute(Name="InjectAttribute", RVA="0x1058EC8", Offset="0x1058EC8")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1058ED8", Offset="0x1058ED8")]
	[FieldOffset(Offset="0x78")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1058EE8", Offset="0x1058EE8")]
	[FieldOffset(Offset="0x80")]
	private EventDomainController _eventDc;

	[Attribute(Name="InjectAttribute", RVA="0x1058EF8", Offset="0x1058EF8")]
	[FieldOffset(Offset="0x88")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x1058F08", Offset="0x1058F08")]
	[FieldOffset(Offset="0x90")]
	private HudController _hudController;

	[FieldOffset(Offset="0x98")]
	private Camera _mainCamera;

	[FieldOffset(Offset="0xA0")]
	private HomeScene _homeScene;

	[FieldOffset(Offset="0xA8")]
	private UiTimerLabel _eventTimerLabel;

	[FieldOffset(Offset="0xB0")]
	private UiTimerLabel _clubDungeonTimerLabel;

	[FieldOffset(Offset="0xB8")]
	private List<Serverproto.PlayerActivity> _dailyActivities;

	[FieldOffset(Offset="0xC0")]
	private UiTimerLabel _kothAttackCooldownTimer;

	[FieldOffset(Offset="0xC8")]
	private UiTimerLabel _specialOfferTimerLabel;

	[FieldOffset(Offset="0xD0")]
	private UiTimerLabel _vipTimerLabel;

	[FieldOffset(Offset="0xD8")]
	private UiTimerLabel _battleButtonBonusLootTimerLabel;

	private HomeView.SerializedFields Fields
	{
		[Address(RVA="0x1172674", Offset="0x1172674", VA="0x1172674")]
		get
		{
			return null;
		}
	}

	public float InitializationDelayFromTitle
	{
		[Address(RVA="0x1172648", Offset="0x1172648", VA="0x1172648")]
		get
		{
			return new float();
		}
	}

	[Address(RVA="0x11766F4", Offset="0x11766F4", VA="0x11766F4")]
	static HomeView()
	{
	}

	[Address(RVA="0x11766EC", Offset="0x11766EC", VA="0x11766EC")]
	public HomeView()
	{
	}

	[Address(RVA="0x11766F8", Offset="0x11766F8", VA="0x11766F8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FCA4", Offset="0x106FCA4")]
	private void <ViewAssetLoaded>b__26_0(UiLockableFeature l)
	{
	}

	[Address(RVA="0x1176778", Offset="0x1176778", VA="0x1176778")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FCB4", Offset="0x106FCB4")]
	private void <ViewAssetLoaded>b__26_1()
	{
	}

	[Address(RVA="0x11767C0", Offset="0x11767C0", VA="0x11767C0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FD44", Offset="0x106FD44")]
	private void <ViewAssetLoaded>b__26_10()
	{
	}

	[Address(RVA="0x11767C8", Offset="0x11767C8", VA="0x11767C8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FD54", Offset="0x106FD54")]
	private void <ViewAssetLoaded>b__26_11()
	{
	}

	[Address(RVA="0x11767D0", Offset="0x11767D0", VA="0x11767D0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FD64", Offset="0x106FD64")]
	private void <ViewAssetLoaded>b__26_12()
	{
	}

	[Address(RVA="0x11767D8", Offset="0x11767D8", VA="0x11767D8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FD74", Offset="0x106FD74")]
	private void <ViewAssetLoaded>b__26_13()
	{
	}

	[Address(RVA="0x11767E0", Offset="0x11767E0", VA="0x11767E0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FD84", Offset="0x106FD84")]
	private void <ViewAssetLoaded>b__26_14()
	{
	}

	[Address(RVA="0x11767E8", Offset="0x11767E8", VA="0x11767E8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FD94", Offset="0x106FD94")]
	private void <ViewAssetLoaded>b__26_15()
	{
	}

	[Address(RVA="0x11767F0", Offset="0x11767F0", VA="0x11767F0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FDA4", Offset="0x106FDA4")]
	private void <ViewAssetLoaded>b__26_16()
	{
	}

	[Address(RVA="0x11767F8", Offset="0x11767F8", VA="0x11767F8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FDB4", Offset="0x106FDB4")]
	private void <ViewAssetLoaded>b__26_17()
	{
	}

	[Address(RVA="0x1176780", Offset="0x1176780", VA="0x1176780")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FCC4", Offset="0x106FCC4")]
	private void <ViewAssetLoaded>b__26_2()
	{
	}

	[Address(RVA="0x1176788", Offset="0x1176788", VA="0x1176788")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FCD4", Offset="0x106FCD4")]
	private void <ViewAssetLoaded>b__26_3()
	{
	}

	[Address(RVA="0x1176790", Offset="0x1176790", VA="0x1176790")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FCE4", Offset="0x106FCE4")]
	private void <ViewAssetLoaded>b__26_4()
	{
	}

	[Address(RVA="0x1176798", Offset="0x1176798", VA="0x1176798")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FCF4", Offset="0x106FCF4")]
	private void <ViewAssetLoaded>b__26_5()
	{
	}

	[Address(RVA="0x11767A0", Offset="0x11767A0", VA="0x11767A0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FD04", Offset="0x106FD04")]
	private void <ViewAssetLoaded>b__26_6()
	{
	}

	[Address(RVA="0x11767A8", Offset="0x11767A8", VA="0x11767A8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FD14", Offset="0x106FD14")]
	private void <ViewAssetLoaded>b__26_7()
	{
	}

	[Address(RVA="0x11767B0", Offset="0x11767B0", VA="0x11767B0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FD24", Offset="0x106FD24")]
	private void <ViewAssetLoaded>b__26_8()
	{
	}

	[Address(RVA="0x11767B8", Offset="0x11767B8", VA="0x11767B8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FD34", Offset="0x106FD34")]
	private void <ViewAssetLoaded>b__26_9()
	{
	}

	[Address(RVA="0x116DA3C", Offset="0x116DA3C", VA="0x116DA3C")]
	public void ClaimDailyActivity(HomeDailyActivityButton clickedButton, InventoryDelta inventoryDelta)
	{
	}

	[Address(RVA="0x1176260", Offset="0x1176260", VA="0x1176260")]
	private void DispatchViewAction(DHomeViewAction.Type actionType)
	{
	}

	[Address(RVA="0x1176438", Offset="0x1176438", VA="0x1176438", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x1173A04", Offset="0x1173A04", VA="0x1173A04")]
	public void PlayRecentlyUnlockedAnimations()
	{
	}

	[Address(RVA="0x1172E3C", Offset="0x1172E3C", VA="0x1172E3C")]
	public float PlayTitleAnimations()
	{
		return new float();
	}

	[Address(RVA="0x116D1E8", Offset="0x116D1E8", VA="0x116D1E8")]
	public void QueueRecentlyUnlockedAnimations()
	{
	}

	[Address(RVA="0x1174080", Offset="0x1174080", VA="0x1174080")]
	private void RefreshDailyActivityCountLabel()
	{
	}

	[Address(RVA="0x1174820", Offset="0x1174820", VA="0x1174820")]
	public void SetBonusLootStatus(ulong bonusLootExpireTimestamp)
	{
	}

	[Address(RVA="0x1174370", Offset="0x1174370", VA="0x1174370")]
	public void SetCardProgressTracker(ACardProgressTracker tracker)
	{
	}

	[Address(RVA="0x1173DE8", Offset="0x1173DE8", VA="0x1173DE8")]
	public void SetClubDungeonStatus(ulong endTimestamp, ulong completedAttemptsToday, ulong maxAttemptsToday)
	{
	}

	[Address(RVA="0x1174758", Offset="0x1174758", VA="0x1174758")]
	public void SetClubSupportCount(int count)
	{
	}

	[Address(RVA="0x1174644", Offset="0x1174644", VA="0x1174644")]
	public void SetClubWarStatus(ClubWarPhaseType currentPhase)
	{
	}

	[Address(RVA="0x1173F78", Offset="0x1173F78", VA="0x1173F78")]
	public void SetDailyActivities(List<Serverproto.PlayerActivity> dailyActivities)
	{
	}

	[Address(RVA="0x11736BC", Offset="0x11736BC", VA="0x11736BC")]
	public void SetDailyEventBattleCount(ulong available, ulong max)
	{
	}

	[Address(RVA="0x1174410", Offset="0x1174410", VA="0x1174410")]
	public void SetKothStatus(uint currentRank, uint attemptsRemaining, ulong attackCooldownEndTime)
	{
	}

	[Address(RVA="0x117327C", Offset="0x117327C", VA="0x117327C")]
	public void SetMarqueeEventGroup(EventGroup marqueeEventGroup)
	{
	}

	[Address(RVA="0x1173928", Offset="0x1173928", VA="0x1173928")]
	public void SetPassportActivityPreview(string activityNameKey, ulong currentValue, ulong requiredValue)
	{
	}

	[Address(RVA="0x1173984", Offset="0x1173984", VA="0x1173984")]
	public void SetPassportSeason(PassportSeason? season, bool showActivityPreviews)
	{
	}

	[Address(RVA="0x11742B8", Offset="0x11742B8", VA="0x11742B8")]
	public void SetPlayerLevel(ulong level)
	{
	}

	[Address(RVA="0x1173B88", Offset="0x1173B88", VA="0x1173B88")]
	public void SetSpecialOffer(StoreItem specialOffer)
	{
	}

	[Address(RVA="0x1172B6C", Offset="0x1172B6C", VA="0x1172B6C")]
	private void SetSpecialOfferTimeRemainingVisual()
	{
	}

	[Address(RVA="0x11737F4", Offset="0x11737F4", VA="0x11737F4")]
	public void SetTowerStatus(ulong completedBattles, ulong maxBattles)
	{
	}

	[Address(RVA="0x116C47C", Offset="0x116C47C", VA="0x116C47C")]
	public void SetupWorldScene(HomeScene homeScene)
	{
	}

	[Address(RVA="0x116D4B8", Offset="0x116D4B8", VA="0x116D4B8")]
	public void SetVipStatus()
	{
	}

	[Address(RVA="0x1174020", Offset="0x1174020", VA="0x1174020")]
	public void ShowDailyActivityButton(bool showing)
	{
	}

	[Address(RVA="0x1174710", Offset="0x1174710", VA="0x1174710")]
	public void ShowFreeStoreItemIndicator(bool show)
	{
	}

	[Address(RVA="0x116D89C", Offset="0x116D89C", VA="0x116D89C")]
	public void ShowOfferWallSpecialIndicator(bool show, string textKey = // 
	// Current member / type: System.Void HomeView::ShowOfferWallSpecialIndicator(System.Boolean,System.String)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void ShowOfferWallSpecialIndicator(System.Boolean,System.String)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1172754", Offset="0x1172754", VA="0x1172754")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1174984", Offset="0x1174984", VA="0x1174984", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1175A0C", Offset="0x1175A0C", VA="0x1175A0C", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Address(RVA="0x11762E8", Offset="0x11762E8", VA="0x11762E8")]
	private void WorldScrollRectValueChanged(Vector2 normalizedPos)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C05C", Offset="0x104C05C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static HomeView.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<UiLockableFeature> <>9__27_0;

		[Address(RVA="0x1176900", Offset="0x1176900", VA="0x1176900")]
		static <>c()
		{
		}

		[Address(RVA="0x1176964", Offset="0x1176964", VA="0x1176964")]
		public <>c()
		{
		}

		[Address(RVA="0x117696C", Offset="0x117696C", VA="0x117696C")]
		internal void <ViewShuttingDown>b__27_0(UiLockableFeature l)
		{
		}
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106A67C", Offset="0x106A67C")]
		[FieldOffset(Offset="0x28")]
		public List<Badge> Badges;

		[FieldOffset(Offset="0x30")]
		public List<UiLockableFeature> UiLockableFeatures;

		[FieldOffset(Offset="0x38")]
		public PlayerXpContainer PlayerXpContainer;

		[FieldOffset(Offset="0x40")]
		public UiLabel PlayerLevelLabel;

		[FieldOffset(Offset="0x48")]
		public Button BattleButton;

		[FieldOffset(Offset="0x50")]
		public Button InventoryButton;

		[FieldOffset(Offset="0x58")]
		public Button SocialButton;

		[FieldOffset(Offset="0x60")]
		public Button StoreButton;

		[FieldOffset(Offset="0x68")]
		public UnityEngine.GameObject FreeStoreItemIndicator;

		[FieldOffset(Offset="0x70")]
		public UnityEngine.GameObject OfferWallSpecialIndicator;

		[FieldOffset(Offset="0x78")]
		public UiLabel OfferWallSpecialLabel;

		[FieldOffset(Offset="0x80")]
		public Button InboxButton;

		[FieldOffset(Offset="0x88")]
		public Button ShipmentsButton;

		[FieldOffset(Offset="0x90")]
		public Button TowerButton;

		[FieldOffset(Offset="0x98")]
		public Button ClubWarButton;

		[FieldOffset(Offset="0xA0")]
		public UiLabel TowerStatusLabel;

		[FieldOffset(Offset="0xA8")]
		public HomeCardPromotionButton CardPromotionButton;

		[FieldOffset(Offset="0xB0")]
		public UnityEngine.GameObject BattleButtonBonusLootContainer;

		[FieldOffset(Offset="0xB8")]
		public UiLabel BattleButtonBonusLootLabel;

		[FieldOffset(Offset="0xC0")]
		public UiLabel BattleButtonBonusLootTimerLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106A6B4", Offset="0x106A6B4")]
		[FieldOffset(Offset="0xC8")]
		public List<HomeViewWorldIcon> WorldIcons;

		[FieldOffset(Offset="0xD0")]
		public ScrollRect WorldScrollRect;

		[FieldOffset(Offset="0xD8")]
		public Vector2 WorldScrollFactor;

		[Attribute(Name="HeaderAttribute", RVA="0x106A6EC", Offset="0x106A6EC")]
		[FieldOffset(Offset="0xE0")]
		public Button SpecialOfferButton;

		[FieldOffset(Offset="0xE8")]
		public RawImage SpecialOfferImage;

		[FieldOffset(Offset="0xF0")]
		public Texture2D DefaultSpecialOfferTexture;

		[FieldOffset(Offset="0xF8")]
		public UiLabel SpecialOfferTimerLabel;

		[FieldOffset(Offset="0x100")]
		public HomeView.SpecialOfferTimeRemainingVisual[] SpecialOfferTimeRemainingVisuals;

		[Attribute(Name="HeaderAttribute", RVA="0x106A724", Offset="0x106A724")]
		[FieldOffset(Offset="0x108")]
		public Button ClubDungeonButton;

		[FieldOffset(Offset="0x110")]
		public UiLabel ClubDungeonTimer;

		[FieldOffset(Offset="0x118")]
		public UnityEngine.GameObject ClubUnlockedNotInClub;

		[FieldOffset(Offset="0x120")]
		public UnityEngine.GameObject ClubDungeonActiveContainer;

		[FieldOffset(Offset="0x128")]
		public UiLabel ClubDungeonAttemptsLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106A75C", Offset="0x106A75C")]
		[FieldOffset(Offset="0x130")]
		public Button DailyEventsButton;

		[FieldOffset(Offset="0x138")]
		public UiLabel AvailableDailyEventsBattlesLabel;

		[FieldOffset(Offset="0x140")]
		public Button ScheduledEventsButton;

		[FieldOffset(Offset="0x148")]
		public UiLabel EventTimeLabel;

		[FieldOffset(Offset="0x150")]
		public UiLabel EventTimerPrefixLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106A794", Offset="0x106A794")]
		[FieldOffset(Offset="0x158")]
		public Button KothButton;

		[FieldOffset(Offset="0x160")]
		public UiLabel KothRankLabel;

		[FieldOffset(Offset="0x168")]
		public UiLabel KothAttemptsLabel;

		[FieldOffset(Offset="0x170")]
		public UiLabel KothAttackCooldownLabel;

		[FieldOffset(Offset="0x178")]
		public UiLabel KothLockedLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106A7CC", Offset="0x106A7CC")]
		[FieldOffset(Offset="0x180")]
		public HomePassportSeasonWidget PassportSeasonWidget;

		[FieldOffset(Offset="0x188")]
		public Button PassportActivityButton;

		[Attribute(Name="HeaderAttribute", RVA="0x106A804", Offset="0x106A804")]
		[FieldOffset(Offset="0x190")]
		public Button DailyActivityButton;

		[FieldOffset(Offset="0x198")]
		public UiLabel DailyActivityCountLabel;

		[FieldOffset(Offset="0x1A0")]
		public HomeDailyActivityButton HomeDailyActivityButton;

		[Attribute(Name="HeaderAttribute", RVA="0x106A83C", Offset="0x106A83C")]
		[FieldOffset(Offset="0x1A8")]
		public float InitializationDelayFromTitle;

		[FieldOffset(Offset="0x1B0")]
		public List<HomeView.TitleTween> TitleTweens;

		[Attribute(Name="HeaderAttribute", RVA="0x106A874", Offset="0x106A874")]
		[FieldOffset(Offset="0x1B8")]
		public UiLabel ClubWarPhaseLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106A8AC", Offset="0x106A8AC")]
		[FieldOffset(Offset="0x1C0")]
		public UnityEngine.GameObject ClubSupportContainer;

		[FieldOffset(Offset="0x1C8")]
		public Button ClubSupportButton;

		[FieldOffset(Offset="0x1D0")]
		public UiLabel ClubSupportLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106A8E4", Offset="0x106A8E4")]
		[FieldOffset(Offset="0x1D8")]
		public CanvasGroup VipContainer;

		[FieldOffset(Offset="0x1E0")]
		public Button VipButton;

		[FieldOffset(Offset="0x1E8")]
		public UiLabel VipTimerLabel;

		[FieldOffset(Offset="0x1F0")]
		public UiLabel VipGetLabel;

		[Address(RVA="0x117699C", Offset="0x117699C", VA="0x117699C")]
		public SerializedFields()
		{
		}
	}

	[Serializable]
	public class SpecialOfferTimeRemainingVisual
	{
		[FieldOffset(Offset="0x10")]
		public float MaxTimeRemainingMinutes;

		[FieldOffset(Offset="0x14")]
		public UnityEngine.Color LabelColor;

		[FieldOffset(Offset="0x24")]
		public float PulseAmplitude;

		[FieldOffset(Offset="0x28")]
		public float PulseFrequency;

		[Address(RVA="0x11769A4", Offset="0x11769A4", VA="0x11769A4")]
		public SpecialOfferTimeRemainingVisual()
		{
		}
	}

	[Serializable]
	public class TitleTween
	{
		[FieldOffset(Offset="0x10")]
		public float Duration;

		[FieldOffset(Offset="0x14")]
		public float StartAlpha;

		[FieldOffset(Offset="0x18")]
		public float StartScale;

		[FieldOffset(Offset="0x1C")]
		public float Delay;

		[FieldOffset(Offset="0x20")]
		public float ExtraRandomDelay;

		[FieldOffset(Offset="0x24")]
		public Ease Ease;

		[FieldOffset(Offset="0x28")]
		public List<CanvasGroup> UiElements;

		[Address(RVA="0x11769AC", Offset="0x11769AC", VA="0x11769AC")]
		public TitleTween()
		{
		}
	}
}