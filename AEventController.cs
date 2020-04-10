using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public abstract class AEventController : AFeatureController, IDispatchHandler<DEventViewAction>, IDispatchHandler, IDispatchHandler<DSelectEventGroupListItemAction>, IDispatchHandler<DEventListItemAction>, IDispatchHandler<DEventTierListItemAction>, IDispatchHandler<DEventRefreshAttemptAction>, IDispatchHandler<DEventViewClearSelectedEventGroupAction>, IDispatchHandler<DEventViewClearSelectedEventAction>, IDispatchHandler<DEventStatusProcessedAction>, IDispatchHandler<DUnitListItemAction>, IDispatchHandler<DClubSupportRequestButtonAction>
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1057DC4", Offset="0x1057DC4")]
	[FieldOffset(Offset="0x68")]
	private readonly string <RevSdkVgpActionName>k__BackingField;

	[Attribute(Name="InjectAttribute", RVA="0x1057DD4", Offset="0x1057DD4")]
	[FieldOffset(Offset="0x70")]
	protected EventService _eventService;

	[Attribute(Name="InjectAttribute", RVA="0x1057DE4", Offset="0x1057DE4")]
	[FieldOffset(Offset="0x78")]
	private BattleService _battleService;

	[Attribute(Name="InjectAttribute", RVA="0x1057DF4", Offset="0x1057DF4")]
	[FieldOffset(Offset="0x80")]
	private DialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x1057E04", Offset="0x1057E04")]
	[FieldOffset(Offset="0x88")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1057E14", Offset="0x1057E14")]
	[FieldOffset(Offset="0x90")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1057E24", Offset="0x1057E24")]
	[FieldOffset(Offset="0x98")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x1057E34", Offset="0x1057E34")]
	[FieldOffset(Offset="0xA0")]
	private TelemetryTranslator _telemetryTranslator;

	[Attribute(Name="InjectAttribute", RVA="0x1057E44", Offset="0x1057E44")]
	[FieldOffset(Offset="0xA8")]
	private ClubServiceUtility _clubServiceUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1057E54", Offset="0x1057E54")]
	[FieldOffset(Offset="0xB0")]
	private ClubUtil _clubUtil;

	[Attribute(Name="InjectAttribute", RVA="0x1057E64", Offset="0x1057E64")]
	[FieldOffset(Offset="0xB8")]
	private EventUtility _eventUtility;

	[FieldOffset(Offset="0xC0")]
	private List<EventGroupModel> _eventGroupData;

	[FieldOffset(Offset="0xC8")]
	protected AEventView _view;

	[FieldOffset(Offset="0xD0")]
	private List<EventStatus> _activeEventStatuses;

	[FieldOffset(Offset="0xD8")]
	private List<ulong> _expiredEventStatusEventIds;

	[FieldOffset(Offset="0xE0")]
	private bool _refreshingEventOrStatus;

	[FieldOffset(Offset="0xE8")]
	protected Dictionary<ulong, HudItemComponent.Data> _customHudData;

	protected abstract string EventExpiredLocKey
	{
		get;
	}

	protected abstract string EventRpcName
	{
		get;
	}

	protected abstract string EventStatusExpiredLocKey
	{
		get;
	}

	protected abstract EventGameStateContext.EventType EventType
	{
		get;
	}

	protected abstract string HudTitleKey
	{
		get;
	}

	protected virtual string RevSdkVgpActionName
	{
		[Address(RVA="0x10E7D84", Offset="0x10E7D84", VA="0x10E7D84", Slot="30")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F644", Offset="0x106F644")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x10E7D8C", Offset="0x10E7D8C", VA="0x10E7D8C")]
	protected AEventController()
	{
	}

	[Address(RVA="0x10E7E74", Offset="0x10E7E74", VA="0x10E7E74")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F654", Offset="0x106F654")]
	private void <ReloadEvents>b__24_0()
	{
	}

	[Address(RVA="0x10E7F08", Offset="0x10E7F08", VA="0x10E7F08")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F664", Offset="0x106F664")]
	private void <UpdateEventStatuses>b__25_0(GetEventStatusResponse response)
	{
	}

	[Address(RVA="0x10E7F0C", Offset="0x10E7F0C", VA="0x10E7F0C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F674", Offset="0x106F674")]
	private void <UpdateEventStatuses>b__25_1(long failureCode)
	{
	}

	[Address(RVA="0x10E7F88", Offset="0x10E7F88", VA="0x10E7F88")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F684", Offset="0x106F684")]
	private void <UpdateEventStatuses>b__25_2()
	{
	}

	[Address(RVA="0x10E5B64", Offset="0x10E5B64", VA="0x10E5B64")]
	private void CacheActiveEventStatuses()
	{
	}

	[Address(RVA="0x10E409C", Offset="0x10E409C", VA="0x10E409C")]
	private void CacheActiveEventStatusesAndUpdateView()
	{
	}

	[Address(RVA="0x10E214C", Offset="0x10E214C", VA="0x10E214C")]
	private void CheckForExpiredEventOrStatus()
	{
	}

	[Address(RVA="0x10E3BD8", Offset="0x10E3BD8", VA="0x10E3BD8")]
	private void ConfirmBattleLimitRefresh(Event evt)
	{
	}

	[Address(RVA="0x10E468C", Offset="0x10E468C", VA="0x10E468C", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x10E3354", Offset="0x10E3354", VA="0x10E3354")]
	private void EnterBattle(EventIdentifier eventId)
	{
	}

	[Address(RVA="0x10E58B8", Offset="0x10E58B8", VA="0x10E58B8")]
	private void FinishInitialization(GameStateTransitionContext context)
	{
	}

	protected abstract void GetEvents(Action finished);

	[Address(RVA="0x10E25EC", Offset="0x10E25EC", VA="0x10E25EC", Slot="13")]
	public void HandleDispatchAction(DEventViewAction action)
	{
	}

	[Address(RVA="0x10E288C", Offset="0x10E288C", VA="0x10E288C", Slot="14")]
	public void HandleDispatchAction(DSelectEventGroupListItemAction action)
	{
	}

	[Address(RVA="0x10E2DE4", Offset="0x10E2DE4", VA="0x10E2DE4", Slot="15")]
	public void HandleDispatchAction(DEventListItemAction action)
	{
	}

	[Address(RVA="0x10E3334", Offset="0x10E3334", VA="0x10E3334", Slot="16")]
	public void HandleDispatchAction(DEventTierListItemAction action)
	{
	}

	[Address(RVA="0x10E3BD4", Offset="0x10E3BD4", VA="0x10E3BD4", Slot="17")]
	public void HandleDispatchAction(DEventRefreshAttemptAction action)
	{
	}

	[Address(RVA="0x10E3E64", Offset="0x10E3E64", VA="0x10E3E64", Slot="18")]
	public void HandleDispatchAction(DEventViewClearSelectedEventGroupAction action)
	{
	}

	[Address(RVA="0x10E3FF0", Offset="0x10E3FF0", VA="0x10E3FF0", Slot="19")]
	public void HandleDispatchAction(DEventViewClearSelectedEventAction action)
	{
	}

	[Address(RVA="0x10E4098", Offset="0x10E4098", VA="0x10E4098", Slot="20")]
	public void HandleDispatchAction(DEventStatusProcessedAction action)
	{
	}

	[Address(RVA="0x10E40F8", Offset="0x10E40F8", VA="0x10E40F8", Slot="21")]
	public void HandleDispatchAction(DUnitListItemAction action)
	{
	}

	[Address(RVA="0x10E41E0", Offset="0x10E41E0", VA="0x10E41E0", Slot="22")]
	public void HandleDispatchAction(DClubSupportRequestButtonAction action)
	{
	}

	[Address(RVA="0x10E1CA4", Offset="0x10E1CA4", VA="0x10E1CA4", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x10E3914", Offset="0x10E3914", VA="0x10E3914")]
	private void InstantBattle(EventIdentifier eventId)
	{
	}

	[Address(RVA="0x10E25F8", Offset="0x10E25F8", VA="0x10E25F8")]
	private void InstantWinAll()
	{
	}

	protected abstract void LoadView(Action finished);

	[Address(RVA="0x10E442C", Offset="0x10E442C", VA="0x10E442C")]
	private void RefreshBattleLimit(ulong eventContentId, bool useFreeClubSupport, Action success = // 
	// Current member / type: System.Void AEventController::RefreshBattleLimit(System.UInt64,System.Boolean,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void RefreshBattleLimit(System.UInt64,System.Boolean,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x10E6DDC", Offset="0x10E6DDC", VA="0x10E6DDC")]
	private void ReloadEvents()
	{
	}

	[Address(RVA="0x10E2DF4", Offset="0x10E2DF4", VA="0x10E2DF4")]
	private void SelectEvent(ulong eventContentId)
	{
	}

	[Address(RVA="0x10E2890", Offset="0x10E2890", VA="0x10E2890")]
	private void SelectEventGroup(ulong eventGroupContentId)
	{
	}

	[Address(RVA="0x10E78F0", Offset="0x10E78F0", VA="0x10E78F0")]
	private void SendInstantBattleTelemetry(InstantBattleEventRequest request, InstantBattleEventResponse response)
	{
	}

	[Address(RVA="0x10E7AF8", Offset="0x10E7AF8", VA="0x10E7AF8")]
	private void SendInstantWinAllTelemetry(long previousBattlesRemaining, InstantBattleAllDailyEventsResponse response)
	{
	}

	[Address(RVA="0x10E47F8", Offset="0x10E47F8", VA="0x10E47F8")]
	protected void SetEvents(IList<Event> events, IList<EventGroup> eventGroups, IList<InfoEvent> infoEvents)
	{
	}

	[Address(RVA="0x10E3F14", Offset="0x10E3F14", VA="0x10E3F14")]
	private void ShowDefaultHud()
	{
	}

	[Address(RVA="0x10E1EA8", Offset="0x10E1EA8", VA="0x10E1EA8", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x10E1F14", Offset="0x10E1F14", VA="0x10E1F14", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x10E73CC", Offset="0x10E73CC", VA="0x10E73CC")]
	private bool TryShowMultiInstantBattle(EventIdentifier eventId)
	{
		return new bool();
	}

	[Address(RVA="0x10E6F88", Offset="0x10E6F88", VA="0x10E6F88")]
	private void UpdateEventStatuses()
	{
	}

	[Address(RVA="0x10E6194", Offset="0x10E6194", VA="0x10E6194")]
	private void UpdateInstantWinAllEnabled()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BDCC", Offset="0x104BDCC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static AEventController.<>c <>9;

		[Address(RVA="0x10E7FF0", Offset="0x10E7FF0", VA="0x10E7FF0")]
		static <>c()
		{
		}

		[Address(RVA="0x10E8054", Offset="0x10E8054", VA="0x10E8054")]
		public <>c()
		{
		}

		[Address(RVA="0x10E805C", Offset="0x10E805C", VA="0x10E805C")]
		internal int <SetEvents>g__CompareEventGroups|16_0(EventGroupModel a, EventGroupModel b)
		{
			return new int();
		}

		[Address(RVA="0x10E80EC", Offset="0x10E80EC", VA="0x10E80EC")]
		internal int <SetEvents>g__CompareEvents|16_1(IEventModel a, IEventModel b)
		{
			return new int();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BDAC", Offset="0x104BDAC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public AEventController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x10E1EA0", Offset="0x10E1EA0", VA="0x10E1EA0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x10E85F0", Offset="0x10E85F0", VA="0x10E85F0")]
		internal void <Initialize>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BDBC", Offset="0x104BDBC")]
	private sealed class <>c__DisplayClass12_0
	{
		[FieldOffset(Offset="0x10")]
		public AEventController <>4__this;

		[FieldOffset(Offset="0x18")]
		public ClubSupportRequest supportRequest;

		[Address(RVA="0x10E441C", Offset="0x10E441C", VA="0x10E441C")]
		public <>c__DisplayClass12_0()
		{
		}

		[Address(RVA="0x10E8620", Offset="0x10E8620", VA="0x10E8620")]
		internal void <HandleDispatchAction>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BDDC", Offset="0x104BDDC")]
	private sealed class <>c__DisplayClass27_0
	{
		[FieldOffset(Offset="0x10")]
		public AEventController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Event evt;

		[Address(RVA="0x10E73B4", Offset="0x10E73B4", VA="0x10E73B4")]
		public <>c__DisplayClass27_0()
		{
		}

		[Address(RVA="0x10E866C", Offset="0x10E866C", VA="0x10E866C")]
		internal void <ConfirmBattleLimitRefresh>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BDEC", Offset="0x104BDEC")]
	private sealed class <>c__DisplayClass28_0
	{
		[FieldOffset(Offset="0x10")]
		public Action success;

		[FieldOffset(Offset="0x18")]
		public AEventController <>4__this;

		[FieldOffset(Offset="0x20")]
		public ulong eventContentId;

		[Address(RVA="0x10E73BC", Offset="0x10E73BC", VA="0x10E73BC")]
		public <>c__DisplayClass28_0()
		{
		}

		[Address(RVA="0x10E86C0", Offset="0x10E86C0", VA="0x10E86C0")]
		internal void <RefreshBattleLimit>b__0(RefreshEventBattleLimitResponse response)
		{
		}

		[Address(RVA="0x10E87FC", Offset="0x10E87FC", VA="0x10E87FC")]
		internal void <RefreshBattleLimit>b__1(long failureCode)
		{
		}

		[Address(RVA="0x10E88BC", Offset="0x10E88BC", VA="0x10E88BC")]
		internal void <RefreshBattleLimit>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BDFC", Offset="0x104BDFC")]
	private sealed class <>c__DisplayClass30_0
	{
		[FieldOffset(Offset="0x10")]
		public AEventController <>4__this;

		[FieldOffset(Offset="0x18")]
		public EventIdentifier eventId;

		[Address(RVA="0x10E73C4", Offset="0x10E73C4", VA="0x10E73C4")]
		public <>c__DisplayClass30_0()
		{
		}

		[Address(RVA="0x10E8930", Offset="0x10E8930", VA="0x10E8930")]
		internal void <InstantBattle>b__1(long failureCode)
		{
		}

		[Address(RVA="0x10E8A4C", Offset="0x10E8A4C", VA="0x10E8A4C")]
		internal void <InstantBattle>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BE0C", Offset="0x104BE0C")]
	private sealed class <>c__DisplayClass30_1
	{
		[FieldOffset(Offset="0x10")]
		public InstantBattleEventRequest request;

		[FieldOffset(Offset="0x18")]
		public AEventController.<>c__DisplayClass30_0 CS$<>8__locals1;

		[Address(RVA="0x10E78E8", Offset="0x10E78E8", VA="0x10E78E8")]
		public <>c__DisplayClass30_1()
		{
		}

		[Address(RVA="0x10E8AC0", Offset="0x10E8AC0", VA="0x10E8AC0")]
		internal void <InstantBattle>b__0(InstantBattleEventResponse response)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BE1C", Offset="0x104BE1C")]
	private sealed class <>c__DisplayClass33_0
	{
		[FieldOffset(Offset="0x10")]
		public AEventController <>4__this;

		[FieldOffset(Offset="0x18")]
		public long previousBattlesRemaining;

		[Address(RVA="0x10E7AF0", Offset="0x10E7AF0", VA="0x10E7AF0")]
		public <>c__DisplayClass33_0()
		{
		}

		[Address(RVA="0x10E8C38", Offset="0x10E8C38", VA="0x10E8C38")]
		internal void <InstantWinAll>b__0(InstantBattleAllDailyEventsResponse response)
		{
		}

		[Address(RVA="0x10E8D8C", Offset="0x10E8D8C", VA="0x10E8D8C")]
		internal void <InstantWinAll>b__1(long failureCode)
		{
		}

		[Address(RVA="0x10E8E0C", Offset="0x10E8E0C", VA="0x10E8E0C")]
		internal void <InstantWinAll>b__2()
		{
		}
	}
}