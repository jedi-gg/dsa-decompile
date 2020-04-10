using BattleLib;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BattleViewController : AFeatureController, IDispatchHandler<DBattleAutoBattleStateChangedAction>, IDispatchHandler, IDispatchHandler<DBattleEncounterAction>, IDispatchHandler<DBattleEndedAction>, IDispatchHandler<DBattleMenuViewAction>, IDispatchHandler<DBattleHudViewAction>, IDispatchHandler<DBattleAbilityCardWidgetAction>, IDispatchHandler<DBattleActivityUpdateAction>, IDispatchHandler<DSendEmoteAction>, IDispatchHandler<DBattlePlayEmoteAction>, IDispatchHandler<DPopupControllerAction>, IDispatchHandler<DViewAction>, IDispatchHandler<DBattleConnectionAction>, IDispatchHandler<DBattleFullscreenInputAction>, IDispatchHandler<DBattleMsgAction<BattleLib_UpdateResult.Types.Aura>>, IDispatchHandler<DBattleMsgAction<BattleLib_UpdateResult.Types.BattleTurnLimit>>
{
	[Attribute(Name="InjectAttribute", RVA="0x1054090", Offset="0x1054090")]
	[FieldOffset(Offset="0x68")]
	private DialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x10540A0", Offset="0x10540A0")]
	[FieldOffset(Offset="0x70")]
	private BattleConfig _battleConfig;

	[Attribute(Name="InjectAttribute", RVA="0x10540B0", Offset="0x10540B0")]
	[FieldOffset(Offset="0x78")]
	private ABattle _battle;

	[Attribute(Name="InjectAttribute", RVA="0x10540C0", Offset="0x10540C0")]
	[FieldOffset(Offset="0x80")]
	private LocalizationManager _locManager;

	[Attribute(Name="InjectAttribute", RVA="0x10540D0", Offset="0x10540D0")]
	[FieldOffset(Offset="0x88")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x10540E0", Offset="0x10540E0")]
	[FieldOffset(Offset="0x90")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x10540F0", Offset="0x10540F0")]
	[FieldOffset(Offset="0x98")]
	private DiContainer _diContainer;

	[Attribute(Name="InjectAttribute", RVA="0x1054100", Offset="0x1054100")]
	[FieldOffset(Offset="0xA0")]
	private BattleUnitsController _unitsController;

	[Attribute(Name="InjectAttribute", RVA="0x1054110", Offset="0x1054110")]
	[FieldOffset(Offset="0xA8")]
	private BattleMessageController _battleMessageController;

	[FieldOffset(Offset="0xB0")]
	private DialogContext _quitDialog;

	[FieldOffset(Offset="0xB8")]
	private BattleBuffIconGlossaryController _battleBuffIconGlossaryController;

	[FieldOffset(Offset="0xC0")]
	private BattleFlyingTextView _flyingTextView;

	[FieldOffset(Offset="0xC8")]
	private BattleFlyingAlertTextView _flyingAlertTextView;

	[FieldOffset(Offset="0xD0")]
	private BattleHealthBarsView _healthBarsView;

	[FieldOffset(Offset="0xD8")]
	private BattlePlayerHandView _handView;

	[FieldOffset(Offset="0xE0")]
	private BattleAutoBattleView _autobattleView;

	[FieldOffset(Offset="0xE8")]
	private BattleMenuView _menuView;

	[FieldOffset(Offset="0xF0")]
	private BattleAbilityTooltipView _tooltipView;

	[FieldOffset(Offset="0xF8")]
	private BattleActivityToastView _activityToastView;

	[FieldOffset(Offset="0x100")]
	private BattleEmoteView _emoteView;

	[FieldOffset(Offset="0x108")]
	private PvpBattleHudView _pvpBattleHudView;

	[FieldOffset(Offset="0x110")]
	private BattleTurnOrderView _turnOrderView;

	[FieldOffset(Offset="0x118")]
	private bool _battleHasEnded;

	[FieldOffset(Offset="0x120")]
	private List<ulong> _silencedActivities;

	public BattlePlayerHandView HandView
	{
		[Address(RVA="0x12A3AD8", Offset="0x12A3AD8", VA="0x12A3AD8")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12A5810", Offset="0x12A5810", VA="0x12A5810")]
	public BattleViewController()
	{
	}

	[Address(RVA="0x12A58F4", Offset="0x12A58F4", VA="0x12A58F4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E6D8", Offset="0x106E6D8")]
	private void <Initialize>g__AsyncViewsLoaded|2_1()
	{
	}

	[Address(RVA="0x12A5880", Offset="0x12A5880", VA="0x12A5880")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E6C8", Offset="0x106E6C8")]
	private void <Initialize>g__SyncViewsLoaded|2_0()
	{
	}

	[Address(RVA="0x12A59B4", Offset="0x12A59B4", VA="0x12A59B4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E6E8", Offset="0x106E6E8")]
	private void <LoadAsyncViews>b__24_0(Action completed)
	{
	}

	[Address(RVA="0x12A5A90", Offset="0x12A5A90", VA="0x12A5A90")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E6F8", Offset="0x106E6F8")]
	private void <LoadAsyncViews>b__24_1(Action completed)
	{
	}

	[Address(RVA="0x12A5B6C", Offset="0x12A5B6C", VA="0x12A5B6C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E708", Offset="0x106E708")]
	private void <LoadAsyncViews>b__24_2(Action completed)
	{
	}

	[Address(RVA="0x12A5C48", Offset="0x12A5C48", VA="0x12A5C48")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E718", Offset="0x106E718")]
	private void <LoadAsyncViews>b__24_3(Action completed)
	{
	}

	[Address(RVA="0x12A5D24", Offset="0x12A5D24", VA="0x12A5D24")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E728", Offset="0x106E728")]
	private void <LoadAsyncViews>b__24_4(Action completed)
	{
	}

	[Address(RVA="0x12A5E00", Offset="0x12A5E00", VA="0x12A5E00")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E738", Offset="0x106E738")]
	private void <LoadAsyncViews>b__24_5(Action completed)
	{
	}

	[Address(RVA="0x12A5EDC", Offset="0x12A5EDC", VA="0x12A5EDC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E748", Offset="0x106E748")]
	private void <LoadAsyncViews>b__24_6(Action completed)
	{
	}

	[Address(RVA="0x12A6008", Offset="0x12A6008", VA="0x12A6008")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E758", Offset="0x106E758")]
	private void <LoadAsyncViews>b__24_7(Action completed)
	{
	}

	[Address(RVA="0x12A4150", Offset="0x12A4150", VA="0x12A4150")]
	public BattleFullscreenInputHandler GetFullScreenInputHandler()
	{
		return null;
	}

	[Address(RVA="0x12A417C", Offset="0x12A417C", VA="0x12A417C")]
	public RectTransform GetTutorialPointAtLookup(string pointAtView, string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x12A44B0", Offset="0x12A44B0", VA="0x12A44B0")]
	private void HandleBattleEnd()
	{
	}

	[Address(RVA="0x12A4284", Offset="0x12A4284", VA="0x12A4284", Slot="13")]
	public void HandleDispatchAction(DBattleAutoBattleStateChangedAction action)
	{
	}

	[Address(RVA="0x12A4338", Offset="0x12A4338", VA="0x12A4338", Slot="14")]
	public void HandleDispatchAction(DBattleEncounterAction action)
	{
	}

	[Address(RVA="0x12A4470", Offset="0x12A4470", VA="0x12A4470", Slot="15")]
	public void HandleDispatchAction(DBattleEndedAction action)
	{
	}

	[Address(RVA="0x12A4634", Offset="0x12A4634", VA="0x12A4634", Slot="16")]
	public void HandleDispatchAction(DBattleMenuViewAction action)
	{
	}

	[Address(RVA="0x12A4760", Offset="0x12A4760", VA="0x12A4760", Slot="17")]
	public void HandleDispatchAction(DBattleHudViewAction action)
	{
	}

	[Address(RVA="0x12A479C", Offset="0x12A479C", VA="0x12A479C", Slot="18")]
	public void HandleDispatchAction(DBattleAbilityCardWidgetAction action)
	{
	}

	[Address(RVA="0x12A480C", Offset="0x12A480C", VA="0x12A480C", Slot="19")]
	public void HandleDispatchAction(DBattleActivityUpdateAction action)
	{
	}

	[Address(RVA="0x12A49C0", Offset="0x12A49C0", VA="0x12A49C0", Slot="20")]
	public void HandleDispatchAction(DSendEmoteAction action)
	{
	}

	[Address(RVA="0x12A49FC", Offset="0x12A49FC", VA="0x12A49FC", Slot="21")]
	public void HandleDispatchAction(DBattlePlayEmoteAction action)
	{
	}

	[Address(RVA="0x12A4A10", Offset="0x12A4A10", VA="0x12A4A10", Slot="22")]
	public void HandleDispatchAction(DPopupControllerAction action)
	{
	}

	[Address(RVA="0x12A4A5C", Offset="0x12A4A5C", VA="0x12A4A5C", Slot="4")]
	public new void HandleDispatchAction(DViewAction action)
	{
	}

	[Address(RVA="0x12A4B3C", Offset="0x12A4B3C", VA="0x12A4B3C", Slot="23")]
	public void HandleDispatchAction(DBattleConnectionAction action)
	{
	}

	[Address(RVA="0x12A4B58", Offset="0x12A4B58", VA="0x12A4B58", Slot="24")]
	public void HandleDispatchAction(DBattleFullscreenInputAction action)
	{
	}

	[Address(RVA="0x12A4D98", Offset="0x12A4D98", VA="0x12A4D98", Slot="26")]
	public void HandleDispatchAction(DBattleMsgAction<BattleLib_UpdateResult.Types.BattleTurnLimit> action)
	{
	}

	[Address(RVA="0x12A4DEC", Offset="0x12A4DEC", VA="0x12A4DEC", Slot="25")]
	public void HandleDispatchAction(DBattleMsgAction<BattleLib_UpdateResult.Types.Aura> action)
	{
	}

	[Address(RVA="0x12A3AE0", Offset="0x12A3AE0", VA="0x12A3AE0", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x12A5020", Offset="0x12A5020", VA="0x12A5020")]
	private void LoadAsyncViews(Action finished)
	{
	}

	[Address(RVA="0x12A5334", Offset="0x12A5334", VA="0x12A5334")]
	private void LoadEmotes(Action finished)
	{
	}

	[Address(RVA="0x12A3CC0", Offset="0x12A3CC0", VA="0x12A3CC0")]
	private void LoadSyncViews(GameStateTransitionContext context, Action finished)
	{
	}

	[Address(RVA="0x12A576C", Offset="0x12A576C", VA="0x12A576C")]
	private void QuitBattle()
	{
	}

	[Address(RVA="0x12A4164", Offset="0x12A4164", VA="0x12A4164")]
	public void ShowCards(bool show)
	{
	}

	[Address(RVA="0x12A3FD8", Offset="0x12A3FD8", VA="0x12A3FD8", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x12A4724", Offset="0x12A4724", VA="0x12A4724")]
	private void StatusEffectsPopUpShown(bool shown)
	{
	}

	[Address(RVA="0x12A408C", Offset="0x12A408C", VA="0x12A408C", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x12A434C", Offset="0x12A434C", VA="0x12A434C")]
	private void UpdateBattleRoundsLabel(int startingEncounterIndex)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B0EC", Offset="0x104B0EC")]
	private sealed class <>c__DisplayClass23_0
	{
		[FieldOffset(Offset="0x10")]
		public BattleViewController <>4__this;

		[FieldOffset(Offset="0x18")]
		public PvpBattleGameState.TransitionContext pvpContext;

		[Address(RVA="0x111B640", Offset="0x111B640", VA="0x111B640")]
		public <>c__DisplayClass23_0()
		{
		}

		[Address(RVA="0x111B648", Offset="0x111B648", VA="0x111B648")]
		internal void <LoadSyncViews>b__0(Action completed)
		{
		}

		[Address(RVA="0x111B73C", Offset="0x111B73C", VA="0x111B73C")]
		internal void <LoadSyncViews>b__1(Action completed)
		{
		}

		[Address(RVA="0x111B830", Offset="0x111B830", VA="0x111B830")]
		internal void <LoadSyncViews>b__2(Action completed)
		{
		}

		[Address(RVA="0x111B924", Offset="0x111B924", VA="0x111B924")]
		internal void <LoadSyncViews>b__3(Action completed)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B0FC", Offset="0x104B0FC")]
	private sealed class <>c__DisplayClass23_1
	{
		[FieldOffset(Offset="0x10")]
		public Action completed;

		[FieldOffset(Offset="0x18")]
		public BattleViewController.<>c__DisplayClass23_0 CS$<>8__locals1;

		[Address(RVA="0x111B734", Offset="0x111B734", VA="0x111B734")]
		public <>c__DisplayClass23_1()
		{
		}

		[Address(RVA="0x111BA18", Offset="0x111BA18", VA="0x111BA18")]
		internal void <LoadSyncViews>b__4(BattlePlayerHandView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B10C", Offset="0x104B10C")]
	private sealed class <>c__DisplayClass23_2
	{
		[FieldOffset(Offset="0x10")]
		public Action completed;

		[FieldOffset(Offset="0x18")]
		public BattleViewController.<>c__DisplayClass23_0 CS$<>8__locals2;

		[Address(RVA="0x111B828", Offset="0x111B828", VA="0x111B828")]
		public <>c__DisplayClass23_2()
		{
		}

		[Address(RVA="0x111BA80", Offset="0x111BA80", VA="0x111BA80")]
		internal void <LoadSyncViews>b__5(BattleAutoBattleView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B11C", Offset="0x104B11C")]
	private sealed class <>c__DisplayClass23_3
	{
		[FieldOffset(Offset="0x10")]
		public Action completed;

		[FieldOffset(Offset="0x18")]
		public BattleViewController.<>c__DisplayClass23_0 CS$<>8__locals3;

		[Address(RVA="0x111B91C", Offset="0x111B91C", VA="0x111B91C")]
		public <>c__DisplayClass23_3()
		{
		}

		[Address(RVA="0x111BB4C", Offset="0x111BB4C", VA="0x111BB4C")]
		internal void <LoadSyncViews>b__6(BattleTurnOrderView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B12C", Offset="0x104B12C")]
	private sealed class <>c__DisplayClass23_4
	{
		[FieldOffset(Offset="0x10")]
		public Action completed;

		[FieldOffset(Offset="0x18")]
		public BattleViewController.<>c__DisplayClass23_0 CS$<>8__locals4;

		[Address(RVA="0x111BA10", Offset="0x111BA10", VA="0x111BA10")]
		public <>c__DisplayClass23_4()
		{
		}

		[Address(RVA="0x111BBB4", Offset="0x111BBB4", VA="0x111BBB4")]
		internal void <LoadSyncViews>b__7(PvpBattleHudView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B13C", Offset="0x104B13C")]
	private sealed class <>c__DisplayClass23_5
	{
		[FieldOffset(Offset="0x10")]
		public KothBattleGameState.TransitionContext kothContext;

		[FieldOffset(Offset="0x18")]
		public BattleViewController.<>c__DisplayClass23_0 CS$<>8__locals5;

		[Address(RVA="0x111BCBC", Offset="0x111BCBC", VA="0x111BCBC")]
		public <>c__DisplayClass23_5()
		{
		}

		[Address(RVA="0x111BCC4", Offset="0x111BCC4", VA="0x111BCC4")]
		internal void <LoadSyncViews>b__8(Action completed)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B14C", Offset="0x104B14C")]
	private sealed class <>c__DisplayClass23_6
	{
		[FieldOffset(Offset="0x10")]
		public Action completed;

		[FieldOffset(Offset="0x18")]
		public BattleViewController.<>c__DisplayClass23_5 CS$<>8__locals6;

		[Address(RVA="0x111BDC0", Offset="0x111BDC0", VA="0x111BDC0")]
		public <>c__DisplayClass23_6()
		{
		}

		[Address(RVA="0x111BDC8", Offset="0x111BDC8", VA="0x111BDC8")]
		internal void <LoadSyncViews>b__9(PvpBattleHudView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B15C", Offset="0x104B15C")]
	private sealed class <>c__DisplayClass23_7
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarBattleGameState.TransitionContext clubWarContext;

		[FieldOffset(Offset="0x18")]
		public BattleViewController.<>c__DisplayClass23_5 CS$<>8__locals7;

		[Address(RVA="0x111BEF0", Offset="0x111BEF0", VA="0x111BEF0")]
		public <>c__DisplayClass23_7()
		{
		}

		[Address(RVA="0x111BEF8", Offset="0x111BEF8", VA="0x111BEF8")]
		internal void <LoadSyncViews>b__10(Action completed)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B16C", Offset="0x104B16C")]
	private sealed class <>c__DisplayClass23_8
	{
		[FieldOffset(Offset="0x10")]
		public Action completed;

		[FieldOffset(Offset="0x18")]
		public BattleViewController.<>c__DisplayClass23_7 CS$<>8__locals8;

		[Address(RVA="0x111C004", Offset="0x111C004", VA="0x111C004")]
		public <>c__DisplayClass23_8()
		{
		}

		[Address(RVA="0x111C00C", Offset="0x111C00C", VA="0x111C00C")]
		internal void <LoadSyncViews>b__11(PvpBattleHudView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B17C", Offset="0x104B17C")]
	private sealed class <>c__DisplayClass24_0
	{
		[FieldOffset(Offset="0x10")]
		public Action completed;

		[FieldOffset(Offset="0x18")]
		public BattleViewController <>4__this;

		[Address(RVA="0x111C154", Offset="0x111C154", VA="0x111C154")]
		public <>c__DisplayClass24_0()
		{
		}

		[Address(RVA="0x111C15C", Offset="0x111C15C", VA="0x111C15C")]
		internal void <LoadAsyncViews>b__8(BattleHealthBarsView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B18C", Offset="0x104B18C")]
	private sealed class <>c__DisplayClass24_1
	{
		[FieldOffset(Offset="0x10")]
		public Action completed;

		[FieldOffset(Offset="0x18")]
		public BattleViewController <>4__this;

		[Address(RVA="0x111C1B4", Offset="0x111C1B4", VA="0x111C1B4")]
		public <>c__DisplayClass24_1()
		{
		}

		[Address(RVA="0x111C1BC", Offset="0x111C1BC", VA="0x111C1BC")]
		internal void <LoadAsyncViews>b__9(BattleFlyingTextView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B19C", Offset="0x104B19C")]
	private sealed class <>c__DisplayClass24_2
	{
		[FieldOffset(Offset="0x10")]
		public Action completed;

		[FieldOffset(Offset="0x18")]
		public BattleViewController <>4__this;

		[Address(RVA="0x111C214", Offset="0x111C214", VA="0x111C214")]
		public <>c__DisplayClass24_2()
		{
		}

		[Address(RVA="0x111C21C", Offset="0x111C21C", VA="0x111C21C")]
		internal void <LoadAsyncViews>b__10(BattleActivityToastView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B1AC", Offset="0x104B1AC")]
	private sealed class <>c__DisplayClass24_3
	{
		[FieldOffset(Offset="0x10")]
		public Action completed;

		[FieldOffset(Offset="0x18")]
		public BattleViewController <>4__this;

		[Address(RVA="0x111C274", Offset="0x111C274", VA="0x111C274")]
		public <>c__DisplayClass24_3()
		{
		}

		[Address(RVA="0x111C27C", Offset="0x111C27C", VA="0x111C27C")]
		internal void <LoadAsyncViews>b__11(BattleEmoteView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B1BC", Offset="0x104B1BC")]
	private sealed class <>c__DisplayClass24_4
	{
		[FieldOffset(Offset="0x10")]
		public Action completed;

		[FieldOffset(Offset="0x18")]
		public BattleViewController <>4__this;

		[Address(RVA="0x111C2D8", Offset="0x111C2D8", VA="0x111C2D8")]
		public <>c__DisplayClass24_4()
		{
		}

		[Address(RVA="0x111C2E0", Offset="0x111C2E0", VA="0x111C2E0")]
		internal void <LoadAsyncViews>b__12(BattleAbilityTooltipView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B1CC", Offset="0x104B1CC")]
	private sealed class <>c__DisplayClass24_5
	{
		[FieldOffset(Offset="0x10")]
		public Action completed;

		[FieldOffset(Offset="0x18")]
		public BattleViewController <>4__this;

		[Address(RVA="0x111C39C", Offset="0x111C39C", VA="0x111C39C")]
		public <>c__DisplayClass24_5()
		{
		}

		[Address(RVA="0x111C3A4", Offset="0x111C3A4", VA="0x111C3A4")]
		internal void <LoadAsyncViews>b__13(BattleFlyingAlertTextView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B1DC", Offset="0x104B1DC")]
	private sealed class <>c__DisplayClass24_6
	{
		[FieldOffset(Offset="0x10")]
		public Action completed;

		[FieldOffset(Offset="0x18")]
		public BattleViewController <>4__this;

		[Address(RVA="0x111C3FC", Offset="0x111C3FC", VA="0x111C3FC")]
		public <>c__DisplayClass24_6()
		{
		}

		[Address(RVA="0x111C404", Offset="0x111C404", VA="0x111C404")]
		internal void <LoadAsyncViews>b__14(BattleMenuView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B1EC", Offset="0x104B1EC")]
	private sealed class <>c__DisplayClass24_7
	{
		[FieldOffset(Offset="0x10")]
		public Action completed;

		[FieldOffset(Offset="0x18")]
		public BattleViewController <>4__this;

		[Address(RVA="0x111C4F4", Offset="0x111C4F4", VA="0x111C4F4")]
		public <>c__DisplayClass24_7()
		{
		}

		[Address(RVA="0x111C4FC", Offset="0x111C4FC", VA="0x111C4FC")]
		internal void <LoadAsyncViews>b__15()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B1FC", Offset="0x104B1FC")]
	private sealed class <>c__DisplayClass25_0
	{
		[FieldOffset(Offset="0x10")]
		public BattleLib_Bootstrap.Types.Player player;

		[FieldOffset(Offset="0x18")]
		public BattleViewController <>4__this;

		[Address(RVA="0x111C560", Offset="0x111C560", VA="0x111C560")]
		public <>c__DisplayClass25_0()
		{
		}

		[Address(RVA="0x111C568", Offset="0x111C568", VA="0x111C568")]
		internal void <LoadEmotes>b__0(Action executed)
		{
		}
	}
}