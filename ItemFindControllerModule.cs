using Glunies;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Serverproto;
using System;

public class ItemFindControllerModule : IDispatchHandler<DItemFindCampaignBattleAction>, IDispatchHandler, IDispatchHandler<DItemFindShipmentAction>, IDispatchHandler<DItemFindEventBattleAction>, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler<DCampaignProgressUpdatedAction>, IDispatchHandler<DItemFindClubDungeonAction>, IDispatchHandler<DItemFindArenaAction>, IDispatchHandler<DItemFindKothAction>, IDispatchHandler<DItemFindPlayerActivityAction>, IDispatchHandler<DItemFindPassportSeasonLevelsAction>, IDispatchHandler<DItemFindStoreAction>, IDispatchHandler<DItemFindClubWarAction>, IDispatchHandler<DClubSupportRequestButtonAction>, IDispatchHandler<DItemFindTowerAction>, IDispatchHandler<DDirectBuyAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1059A0C", Offset="0x1059A0C")]
	[FieldOffset(Offset="0x10")]
	private InventoryService _inventoryService;

	[Attribute(Name="InjectAttribute", RVA="0x1059A1C", Offset="0x1059A1C")]
	[FieldOffset(Offset="0x18")]
	private EventService _eventService;

	[Attribute(Name="InjectAttribute", RVA="0x1059A2C", Offset="0x1059A2C")]
	[FieldOffset(Offset="0x20")]
	private CampaignService _campaignService;

	[Attribute(Name="InjectAttribute", RVA="0x1059A3C", Offset="0x1059A3C")]
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1059A4C", Offset="0x1059A4C")]
	[FieldOffset(Offset="0x30")]
	private GameStateMachine _gameStateMachine;

	[Attribute(Name="InjectAttribute", RVA="0x1059A5C", Offset="0x1059A5C")]
	[FieldOffset(Offset="0x38")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1059A6C", Offset="0x1059A6C")]
	[FieldOffset(Offset="0x40")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1059A7C", Offset="0x1059A7C")]
	[FieldOffset(Offset="0x48")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1059A8C", Offset="0x1059A8C")]
	[FieldOffset(Offset="0x50")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x1059A9C", Offset="0x1059A9C")]
	[FieldOffset(Offset="0x58")]
	private CampaignUtility _campaignUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1059AAC", Offset="0x1059AAC")]
	[FieldOffset(Offset="0x60")]
	private ClubUtil _clubUtil;

	[Attribute(Name="InjectAttribute", RVA="0x1059ABC", Offset="0x1059ABC")]
	[FieldOffset(Offset="0x68")]
	private ClubServiceUtility _clubServiceUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1059ACC", Offset="0x1059ACC")]
	[FieldOffset(Offset="0x70")]
	private TelemetryTranslator _telemetryTranslator;

	[Attribute(Name="InjectAttribute", RVA="0x1059ADC", Offset="0x1059ADC")]
	[FieldOffset(Offset="0x78")]
	private StoreService _storeService;

	[FieldOffset(Offset="0x80")]
	private RepeatedField<Event> _dailyEvents;

	[FieldOffset(Offset="0x88")]
	private RepeatedField<Event> _scheduledEvents;

	[FieldOffset(Offset="0x90")]
	private IItemFindListView _view;

	[FieldOffset(Offset="0x98")]
	private bool _isShutdown;

	[FieldOffset(Offset="0xA0")]
	private ulong _itemId;

	[FieldOffset(Offset="0xA8")]
	private ItemFindResponse _findResponse;

	[FieldOffset(Offset="0xB0")]
	private int _campaignCount;

	[FieldOffset(Offset="0xB4")]
	private int _dailyEventCount;

	[FieldOffset(Offset="0xB8")]
	private int _scheduledEventCount;

	[FieldOffset(Offset="0xBC")]
	private int _shipmentCount;

	[FieldOffset(Offset="0xC0")]
	private int _activeShipmentCount;

	[FieldOffset(Offset="0xC4")]
	private int _clubDungeonCount;

	[FieldOffset(Offset="0xC8")]
	private int _arenaCount;

	[FieldOffset(Offset="0xCC")]
	private int _kothCount;

	[FieldOffset(Offset="0xD0")]
	private int _playerActivityCount;

	[FieldOffset(Offset="0xD4")]
	private int _passportLevelCount;

	[FieldOffset(Offset="0xD8")]
	private int _storeCount;

	[FieldOffset(Offset="0xDC")]
	private int _clubWarCount;

	[FieldOffset(Offset="0xE0")]
	private int _pvpPackCount;

	[FieldOffset(Offset="0xE4")]
	private int _towerCount;

	[FieldOffset(Offset="0xE8")]
	private int _campaignMapRewardCount;

	[Address(RVA="0x138427C", Offset="0x138427C", VA="0x138427C")]
	public ItemFindControllerModule()
	{
	}

	[Address(RVA="0x13842C0", Offset="0x13842C0", VA="0x13842C0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10700C4", Offset="0x10700C4")]
	private void <GetDailyEvents>b__31_0(GetDailyEventsResponse response)
	{
	}

	[Address(RVA="0x13842FC", Offset="0x13842FC", VA="0x13842FC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10700D4", Offset="0x10700D4")]
	private void <GetScheduledEvents>b__32_0(GetScheduledEventsResponse response)
	{
	}

	[Address(RVA="0x1384284", Offset="0x1384284", VA="0x1384284")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10700B4", Offset="0x10700B4")]
	private void <Initialize>b__0_0(Action done)
	{
	}

	[Address(RVA="0x1383094", Offset="0x1383094", VA="0x1383094")]
	private void BindItemFindListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x1380E6C", Offset="0x1380E6C", VA="0x1380E6C")]
	private void ClaimFreeClubSupportLimitedAttemptRefresh(ClubSupportRequest supportRequest, CampaignIdentifier campaignIdentifier)
	{
	}

	[Address(RVA="0x13814E8", Offset="0x13814E8", VA="0x13814E8")]
	private int CompareCampaignRewardsPreviews(CampaignRewardsPreview a, CampaignRewardsPreview b)
	{
		return new int();
	}

	[Address(RVA="0x1381E10", Offset="0x1381E10", VA="0x1381E10")]
	private int CompareCampaigns(CampaignRewardsPreview rewardsPreviewA, CampaignRewardsPreview rewardsPreviewB)
	{
		return new int();
	}

	[Address(RVA="0x138222C", Offset="0x138222C", VA="0x138222C")]
	private int CompareDailyEvents(EventIdentifier a, EventIdentifier b)
	{
		return new int();
	}

	[Address(RVA="0x1382234", Offset="0x1382234", VA="0x1382234")]
	private int CompareEvents(EventIdentifier a, EventIdentifier b, RepeatedField<Event> eventList)
	{
		return new int();
	}

	[Address(RVA="0x1381BF4", Offset="0x1381BF4", VA="0x1381BF4")]
	private int CompareLockedCampaigns(CampaignRewardsPreview a, CampaignRewardsPreview b)
	{
		return new int();
	}

	[Address(RVA="0x13825D4", Offset="0x13825D4", VA="0x13825D4")]
	private int CompareScheduledEvents(EventIdentifier a, EventIdentifier b)
	{
		return new int();
	}

	[Address(RVA="0x13825DC", Offset="0x13825DC", VA="0x13825DC")]
	private int CompareShipments(ulong shipmentDefIdA, ulong shipmentDefIdB)
	{
		return new int();
	}

	[Address(RVA="0x13816F0", Offset="0x13816F0", VA="0x13816F0")]
	private int CompareUnlockedCampaigns(CampaignRewardsPreview a, CampaignRewardsPreview b, CampaignProgress aProgress, CampaignProgress bProgress)
	{
		return new int();
	}

	[Address(RVA="0x13890D0", Offset="0x13890D0", VA="0x13890D0")]
	private void EnterState<TState>(GameStateTransitionContext context = // 
	// Current member / type: System.Void ItemFindControllerModule::EnterState(Glunies.GameStateTransitionContext)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void EnterState(Glunies.GameStateTransitionContext)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x137FB78", Offset="0x137FB78", VA="0x137FB78")]
	public void FindItem(ulong itemId, Action completed)
	{
	}

	[Address(RVA="0x13826EC", Offset="0x13826EC", VA="0x13826EC")]
	private Event GetDailyEventData(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x1382C3C", Offset="0x1382C3C", VA="0x1382C3C")]
	private void GetDailyEvents(Action finished)
	{
	}

	[Address(RVA="0x13836FC", Offset="0x13836FC", VA="0x13836FC")]
	private int GetDynamicPointAtObject(string pointAtId)
	{
		return new int();
	}

	[Address(RVA="0x1382990", Offset="0x1382990", VA="0x1382990")]
	private Event GetScheduledEventData(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x1382E64", Offset="0x1382E64", VA="0x1382E64")]
	private void GetScheduledEvents(Action finished)
	{
	}

	[Address(RVA="0x137FF54", Offset="0x137FF54", VA="0x137FF54", Slot="4")]
	public void HandleDispatchAction(DItemFindCampaignBattleAction action)
	{
	}

	[Address(RVA="0x1380468", Offset="0x1380468", VA="0x1380468", Slot="5")]
	public void HandleDispatchAction(DItemFindShipmentAction action)
	{
	}

	[Address(RVA="0x13804F4", Offset="0x13804F4", VA="0x13804F4", Slot="6")]
	public void HandleDispatchAction(DItemFindEventBattleAction action)
	{
	}

	[Address(RVA="0x13806A4", Offset="0x13806A4", VA="0x13806A4", Slot="7")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x13807E4", Offset="0x13807E4", VA="0x13807E4", Slot="8")]
	public void HandleDispatchAction(DCampaignProgressUpdatedAction action)
	{
	}

	[Address(RVA="0x138089C", Offset="0x138089C", VA="0x138089C", Slot="9")]
	public void HandleDispatchAction(DItemFindClubDungeonAction action)
	{
	}

	[Address(RVA="0x138097C", Offset="0x138097C", VA="0x138097C", Slot="10")]
	public void HandleDispatchAction(DItemFindArenaAction action)
	{
	}

	[Address(RVA="0x13809EC", Offset="0x13809EC", VA="0x13809EC", Slot="11")]
	public void HandleDispatchAction(DItemFindKothAction action)
	{
	}

	[Address(RVA="0x1380A40", Offset="0x1380A40", VA="0x1380A40", Slot="15")]
	public void HandleDispatchAction(DItemFindClubWarAction action)
	{
	}

	[Address(RVA="0x1380B20", Offset="0x1380B20", VA="0x1380B20", Slot="12")]
	public void HandleDispatchAction(DItemFindPlayerActivityAction action)
	{
	}

	[Address(RVA="0x1380C4C", Offset="0x1380C4C", VA="0x1380C4C", Slot="13")]
	public void HandleDispatchAction(DItemFindPassportSeasonLevelsAction action)
	{
	}

	[Address(RVA="0x1380CBC", Offset="0x1380CBC", VA="0x1380CBC", Slot="14")]
	public void HandleDispatchAction(DItemFindStoreAction action)
	{
	}

	[Address(RVA="0x1380D10", Offset="0x1380D10", VA="0x1380D10", Slot="16")]
	public void HandleDispatchAction(DClubSupportRequestButtonAction action)
	{
	}

	[Address(RVA="0x138111C", Offset="0x138111C", VA="0x138111C", Slot="17")]
	public void HandleDispatchAction(DItemFindTowerAction action)
	{
	}

	[Address(RVA="0x13811A4", Offset="0x13811A4", VA="0x13811A4", Slot="18")]
	public void HandleDispatchAction(DDirectBuyAction action)
	{
	}

	[Address(RVA="0x137FDC8", Offset="0x137FDC8", VA="0x137FDC8")]
	public void Initialize(Action finished)
	{
	}

	[Address(RVA="0x1382C34", Offset="0x1382C34", VA="0x1382C34")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x13840B8", Offset="0x13840B8", VA="0x13840B8")]
	private void SendItemFindShipmentTelemetry(string itemRequestId, ItemFindShipment shipment, BuyShipmentItemResponse response)
	{
	}

	[Address(RVA="0x137F9E4", Offset="0x137F9E4", VA="0x137F9E4")]
	public void SetItemFindListView(IItemFindListView view)
	{
	}

	[Address(RVA="0x137F678", Offset="0x137F678", VA="0x137F678")]
	public void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C29C", Offset="0x104C29C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static ItemFindControllerModule.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<long> <>9__31_1;

		[FieldOffset(Offset="0x10")]
		public static Action<long> <>9__32_1;

		[FieldOffset(Offset="0x18")]
		public static Action<long> <>9__33_1;

		[Address(RVA="0x1384338", Offset="0x1384338", VA="0x1384338")]
		static <>c()
		{
		}

		[Address(RVA="0x138439C", Offset="0x138439C", VA="0x138439C")]
		public <>c()
		{
		}

		[Address(RVA="0x1384494", Offset="0x1384494", VA="0x1384494")]
		internal void <ClaimFreeClubSupportLimitedAttemptRefresh>b__33_1(long response)
		{
		}

		[Address(RVA="0x13843A4", Offset="0x13843A4", VA="0x13843A4")]
		internal void <GetDailyEvents>b__31_1(long failureCode)
		{
		}

		[Address(RVA="0x138441C", Offset="0x138441C", VA="0x138441C")]
		internal void <GetScheduledEvents>b__32_1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C27C", Offset="0x104C27C")]
	private sealed class <>c__DisplayClass18_0
	{
		[FieldOffset(Offset="0x10")]
		public ItemFindControllerModule <>4__this;

		[FieldOffset(Offset="0x18")]
		public DDirectBuyAction action;

		[Address(RVA="0x13814D8", Offset="0x13814D8", VA="0x13814D8")]
		public <>c__DisplayClass18_0()
		{
		}

		[Address(RVA="0x138450C", Offset="0x138450C", VA="0x138450C")]
		internal void <HandleDispatchAction>b__1(long failureCode)
		{
		}

		[Address(RVA="0x1384604", Offset="0x1384604", VA="0x1384604")]
		internal void <HandleDispatchAction>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C28C", Offset="0x104C28C")]
	private sealed class <>c__DisplayClass18_1
	{
		[FieldOffset(Offset="0x10")]
		public BuyShipmentItemRequest request;

		[FieldOffset(Offset="0x18")]
		public ItemFindControllerModule.<>c__DisplayClass18_0 CS$<>8__locals1;

		[Address(RVA="0x13814E0", Offset="0x13814E0", VA="0x13814E0")]
		public <>c__DisplayClass18_1()
		{
		}

		[Address(RVA="0x1384678", Offset="0x1384678", VA="0x1384678")]
		internal void <HandleDispatchAction>b__0(BuyShipmentItemResponse response)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C26C", Offset="0x104C26C")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public ItemFindControllerModule <>4__this;

		[FieldOffset(Offset="0x18")]
		public ulong itemId;

		[FieldOffset(Offset="0x20")]
		public ItemFindRequest itemFindRequest;

		[Address(RVA="0x137FF4C", Offset="0x137FF4C", VA="0x137FF4C")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x138499C", Offset="0x138499C", VA="0x138499C")]
		internal void <FindItem>b__0(ItemFindResponse response)
		{
		}

		[Address(RVA="0x1386130", Offset="0x1386130", VA="0x1386130")]
		internal void <FindItem>b__1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C2AC", Offset="0x104C2AC")]
	private sealed class <>c__DisplayClass33_0
	{
		[FieldOffset(Offset="0x10")]
		public ItemFindControllerModule <>4__this;

		[FieldOffset(Offset="0x18")]
		public ClubSupportRequest supportRequest;

		[FieldOffset(Offset="0x20")]
		public BuyPveRefreshRequest req;

		[Address(RVA="0x138308C", Offset="0x138308C", VA="0x138308C")]
		public <>c__DisplayClass33_0()
		{
		}

		[Address(RVA="0x138479C", Offset="0x138479C", VA="0x138479C")]
		internal void <ClaimFreeClubSupportLimitedAttemptRefresh>b__0(BuyPveRefreshResponse response)
		{
		}

		[Address(RVA="0x1384928", Offset="0x1384928", VA="0x1384928")]
		internal void <ClaimFreeClubSupportLimitedAttemptRefresh>b__2()
		{
		}
	}
}