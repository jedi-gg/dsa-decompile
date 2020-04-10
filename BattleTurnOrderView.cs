using BattleLib;
using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleTurnOrderView : AStandardView, IDispatchHandler<DBattleUnitsControllerAction>, IDispatchHandler, IDispatchHandler<DBattleTurnOrderWidgetAction>, IDispatchHandler<DBattleTurnInfoProcessedAction>, IDispatchHandler<DBattleMsgAction<BattleLib_UpdateResult.Types.UnitTurnStarted>>, IDispatchHandler<DBattleBusyAction>, IDispatchHandler<DBattleAbilityCastResultAction>, IDispatchHandler<DBattleSelectTargetAction>, IDispatchHandler<DBattleCinematicAction>
{
	[FieldOffset(Offset="0x0")]
	private const float CURRENT_UNIT_HIGHLIGHT_APPEAR_DELAY_S = 0.25f;

	[FieldOffset(Offset="0x0")]
	private const float PLAYER_THINKING_HEARTBEAT_FUSE_BURNT_PERCENT = 0.3f;

	[FieldOffset(Offset="0x0")]
	private const float INITIAL_TWEEN_X_OFFSET = -600f;

	[FieldOffset(Offset="0x0")]
	private const float INITIAL_TWEEN_DELAY = 0f;

	[FieldOffset(Offset="0x0")]
	private const float INITIAL_TWEEN_DURATION = 0.33f;

	[FieldOffset(Offset="0x0")]
	private const Ease INITIAL_TWEEN_EASE = Ease.OutSine;

	[Attribute(Name="InjectAttribute", RVA="0x1053F00", Offset="0x1053F00")]
	[FieldOffset(Offset="0x68")]
	private BattleUnitsController _unitsController;

	[Attribute(Name="InjectAttribute", RVA="0x1053F10", Offset="0x1053F10")]
	[FieldOffset(Offset="0x70")]
	private ABattle _battle;

	[Attribute(Name="InjectAttribute", RVA="0x1053F20", Offset="0x1053F20")]
	[FieldOffset(Offset="0x78")]
	private SharedPrefs _sharedPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x1053F30", Offset="0x1053F30")]
	[FieldOffset(Offset="0x80")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x88")]
	private MonoArchetypePool<BattleTurnOrderUnitWidget> _unitWidgetPool;

	[FieldOffset(Offset="0x90")]
	private BattleUnit _currentUnit;

	[FieldOffset(Offset="0x98")]
	private bool _showCurrentUnitHighlight;

	[FieldOffset(Offset="0xA0")]
	private List<BattleLib_UpdateResult.Types.UnitTurnInfo> _turnInfos;

	[FieldOffset(Offset="0xA8")]
	private List<BattleTurnOrderUnitWidget> _cachedWidgetsToRemove;

	[FieldOffset(Offset="0xB0")]
	private float _turnExpireDuration;

	[FieldOffset(Offset="0xB4")]
	private float _turnExpireTimer;

	[FieldOffset(Offset="0xB8")]
	private bool _nextUnitsCollapsed;

	[FieldOffset(Offset="0xC0")]
	private Tweener _nextUnitsCollapseTween;

	[FieldOffset(Offset="0xC8")]
	private Tweener _highlightCurrentUnitTween;

	[FieldOffset(Offset="0xD0")]
	private Sequence _openingTweenSequence;

	private BattleTurnOrderView.SerializedFields Fields
	{
		[Address(RVA="0x1296C0C", Offset="0x1296C0C", VA="0x1296C0C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12995B0", Offset="0x12995B0", VA="0x12995B0")]
	public BattleTurnOrderView()
	{
	}

	[Address(RVA="0x1296D90", Offset="0x1296D90", VA="0x1296D90")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E628", Offset="0x106E628")]
	private float <TickUpdate>g__CalculateFuseBurntPercent|0_0(ref BattleTurnOrderView.<>c__DisplayClass0_0 _)
	{
		return new float();
	}

	[Address(RVA="0x1299650", Offset="0x1299650", VA="0x1299650")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E638", Offset="0x106E638")]
	private void <ViewAssetLoaded>b__9_0()
	{
	}

	[Address(RVA="0x1296E44", Offset="0x1296E44", VA="0x1296E44")]
	private bool ActivateFuses()
	{
		return new bool();
	}

	[Address(RVA="0x12991F4", Offset="0x12991F4", VA="0x12991F4", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x1296FF4", Offset="0x1296FF4", VA="0x1296FF4", Slot="21")]
	public void HandleDispatchAction(DBattleUnitsControllerAction action)
	{
	}

	[Address(RVA="0x1297B0C", Offset="0x1297B0C", VA="0x1297B0C", Slot="23")]
	public void HandleDispatchAction(DBattleTurnInfoProcessedAction action)
	{
	}

	[Address(RVA="0x1298104", Offset="0x1298104", VA="0x1298104", Slot="22")]
	public void HandleDispatchAction(DBattleTurnOrderWidgetAction action)
	{
	}

	[Address(RVA="0x12981A8", Offset="0x12981A8", VA="0x12981A8", Slot="24")]
	public void HandleDispatchAction(DBattleMsgAction<BattleLib_UpdateResult.Types.UnitTurnStarted> action)
	{
	}

	[Address(RVA="0x1298324", Offset="0x1298324", VA="0x1298324", Slot="25")]
	public void HandleDispatchAction(DBattleBusyAction action)
	{
	}

	[Address(RVA="0x1298330", Offset="0x1298330", VA="0x1298330", Slot="26")]
	public void HandleDispatchAction(DBattleAbilityCastResultAction action)
	{
	}

	[Address(RVA="0x12983F4", Offset="0x12983F4", VA="0x12983F4", Slot="27")]
	public void HandleDispatchAction(DBattleSelectTargetAction action)
	{
	}

	[Address(RVA="0x12985CC", Offset="0x12985CC", VA="0x12985CC", Slot="28")]
	public void HandleDispatchAction(DBattleCinematicAction action)
	{
	}

	[Address(RVA="0x12975F0", Offset="0x12975F0", VA="0x12975F0")]
	private void SetActiveUnitTurnInfo(bool restartCurrentTurnTween)
	{
	}

	[Address(RVA="0x12974C0", Offset="0x12974C0", VA="0x12974C0")]
	private void ShowCurrentUnitHighlight(bool show)
	{
	}

	[Address(RVA="0x1296920", Offset="0x1296920", VA="0x1296920")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1299388", Offset="0x1299388", VA="0x1299388")]
	private void ToggleCollapsed()
	{
	}

	[Address(RVA="0x129867C", Offset="0x129867C", VA="0x129867C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x12991B4", Offset="0x12991B4", VA="0x12991B4", Slot="14")]
	protected override void ViewHidden()
	{
	}

	[Address(RVA="0x1299178", Offset="0x1299178", VA="0x1299178", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x1298F80", Offset="0x1298F80", VA="0x1298F80", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B0AC", Offset="0x104B0AC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static BattleTurnOrderView.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Comparison<BattleLib_UpdateResult.Types.UnitTurnInfo> <>9__2_0;

		[Address(RVA="0x1299694", Offset="0x1299694", VA="0x1299694")]
		static <>c()
		{
		}

		[Address(RVA="0x12996F8", Offset="0x12996F8", VA="0x12996F8")]
		public <>c()
		{
		}

		[Address(RVA="0x1299700", Offset="0x1299700", VA="0x1299700")]
		internal int <HandleDispatchAction>b__2_0(BattleLib_UpdateResult.Types.UnitTurnInfo a, BattleLib_UpdateResult.Types.UnitTurnInfo b)
		{
			return new int();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B09C", Offset="0x104B09C")]
	private struct <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x0")]
		public float fuseDuration;
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public BattleTurnOrderUnitWidget UnitWidgetArchetype;

		[FieldOffset(Offset="0x30")]
		public BattleTurnOrderUnitWidget TargetUnit;

		[FieldOffset(Offset="0x38")]
		public int MaxUnitsToShow;

		[FieldOffset(Offset="0x40")]
		public UnityEngine.GameObject CurrentUnitHighlight;

		[FieldOffset(Offset="0x48")]
		public UnityEngine.Color FriendlyBorderColor;

		[FieldOffset(Offset="0x58")]
		public UnityEngine.Color EnemyBorderColor;

		[FieldOffset(Offset="0x68")]
		public UiLabel NextLabel;

		[FieldOffset(Offset="0x70")]
		public Vector2 NextUnitsCollapsedPos;

		[FieldOffset(Offset="0x78")]
		public Vector2 NextUnitsExpandedPos;

		[FieldOffset(Offset="0x80")]
		public RectTransform NextUnitsRoot;

		[FieldOffset(Offset="0x88")]
		public RectTransform NextUnitsCollapsingRoot;

		[FieldOffset(Offset="0x90")]
		public Graphic[] HideWhileCollapsed;

		[FieldOffset(Offset="0x98")]
		public Button CollapseButton;

		[FieldOffset(Offset="0xA0")]
		public Button CollapseButtonSmall;

		[FieldOffset(Offset="0xA8")]
		public float CollapseTweenDuration;

		[Attribute(Name="HeaderAttribute", RVA="0x1069AFC", Offset="0x1069AFC")]
		[FieldOffset(Offset="0xB0")]
		public BattleTurnOrderView.TurnFuse PlayerTurnFuse;

		[FieldOffset(Offset="0xB8")]
		public BattleTurnOrderView.TurnFuse OpponentTurnFuse;

		[FieldOffset(Offset="0xC0")]
		public float TurnFuseActivateSecondsLeft;

		[Attribute(Name="TooltipAttribute", RVA="0x1069B34", Offset="0x1069B34")]
		[FieldOffset(Offset="0xC4")]
		public float TurnFuseDelayShowDurationS;

		[Attribute(Name="RangeAttribute", RVA="0x1069B6C", Offset="0x1069B6C")]
		[FieldOffset(Offset="0xC8")]
		public float TurnFuseMinFill;

		[Attribute(Name="TooltipAttribute", RVA="0x1069B84", Offset="0x1069B84")]
		[FieldOffset(Offset="0xCC")]
		public float TurnExpiredVisualFudgeFactorS;

		[Address(RVA="0x1299770", Offset="0x1299770", VA="0x1299770")]
		public SerializedFields()
		{
		}
	}

	[Serializable]
	public class TurnFuse
	{
		[FieldOffset(Offset="0x10")]
		public UnityEngine.GameObject Root;

		[FieldOffset(Offset="0x18")]
		public RectTransform FuseTransform;

		[FieldOffset(Offset="0x20")]
		private float _fuseWidth;

		[Address(RVA="0x1299810", Offset="0x1299810", VA="0x1299810")]
		public TurnFuse()
		{
		}

		[Address(RVA="0x1298EEC", Offset="0x1298EEC", VA="0x1298EEC")]
		public void Initialize()
		{
		}

		[Address(RVA="0x1296FA0", Offset="0x1296FA0", VA="0x1296FA0")]
		public void SetFuseBurntPercent(float fuseBurntPercent)
		{
		}
	}
}