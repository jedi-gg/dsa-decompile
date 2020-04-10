using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Zenject;

public abstract class ABattleGameState : AGameState, ILoggable<LogCategory>
{
	[Attribute(Name="InjectAttribute", RVA="0x1052A0C", Offset="0x1052A0C")]
	[FieldOffset(Offset="0x30")]
	private DiContainer _parentContainer;

	[Attribute(Name="InjectAttribute", RVA="0x1052A1C", Offset="0x1052A1C")]
	[FieldOffset(Offset="0x38")]
	private GameStateMachineNavigationTracker _stateHistoryTracker;

	[Attribute(Name="InjectAttribute", RVA="0x1052A2C", Offset="0x1052A2C")]
	[FieldOffset(Offset="0x40")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x1052A3C", Offset="0x1052A3C")]
	[FieldOffset(Offset="0x48")]
	private BattleInviteMessageController _battleInviteMessageController;

	[Attribute(Name="InjectAttribute", RVA="0x1052A4C", Offset="0x1052A4C")]
	[FieldOffset(Offset="0x50")]
	private MultiplayerRecovery _mpRecovery;

	[Attribute(Name="InjectAttribute", RVA="0x1052A5C", Offset="0x1052A5C")]
	[FieldOffset(Offset="0x58")]
	private IAssetDownloader _assetDownloader;

	[FieldOffset(Offset="0x60")]
	private BattleViewController _battleViewController;

	[FieldOffset(Offset="0x68")]
	private BattleHandler _battleHandler;

	public virtual bool AllowEmotes
	{
		[Address(RVA="0x10DF54C", Offset="0x10DF54C", VA="0x10DF54C", Slot="23")]
		get
		{
			return new bool();
		}
	}

	public virtual bool AllowMenu
	{
		[Address(RVA="0x10DF52C", Offset="0x10DF52C", VA="0x10DF52C", Slot="19")]
		get
		{
			return new bool();
		}
	}

	public virtual bool AllowPause
	{
		[Address(RVA="0x10DF53C", Offset="0x10DF53C", VA="0x10DF53C", Slot="21")]
		get
		{
			return new bool();
		}
	}

	public virtual bool AllowQuit
	{
		[Address(RVA="0x10DF534", Offset="0x10DF534", VA="0x10DF534", Slot="20")]
		get
		{
			return new bool();
		}
	}

	public virtual bool AllowReversedPositions
	{
		[Address(RVA="0x10DF564", Offset="0x10DF564", VA="0x10DF564", Slot="26")]
		get
		{
			return new bool();
		}
	}

	public abstract bool AutoBattleEnabled
	{
		get;
	}

	public virtual string AutoBattleSpeedPlayerPrefKey
	{
		[Address(RVA="0x10DF4DC", Offset="0x10DF4DC", VA="0x10DF4DC", Slot="17")]
		get
		{
			return null;
		}
	}

	public virtual string AutoBattleStartsOnPrefKey
	{
		[Address(RVA="0x10DF48C", Offset="0x10DF48C", VA="0x10DF48C", Slot="15")]
		get
		{
			return null;
		}
	}

	public abstract bool BattleSpeedToggleEnabled
	{
		get;
	}

	public override bool CanBeDeepLinkedAwayFrom
	{
		[Address(RVA="0x10DF47C", Offset="0x10DF47C", VA="0x10DF47C", Slot="9")]
		get
		{
			return new bool();
		}
	}

	public override bool CanBeNavigatedBackInto
	{
		[Address(RVA="0x10DF474", Offset="0x10DF474", VA="0x10DF474", Slot="8")]
		get
		{
			return new bool();
		}
	}

	public virtual AutoBattle.Speed DefaultBattleSpeed
	{
		[Address(RVA="0x10DF4D4", Offset="0x10DF4D4", VA="0x10DF4D4", Slot="16")]
		get
		{
			return new AutoBattle.Speed();
		}
	}

	public virtual bool IgnoreAutoBattlePref
	{
		[Address(RVA="0x10DF55C", Offset="0x10DF55C", VA="0x10DF55C", Slot="25")]
		get
		{
			return new bool();
		}
	}

	public override LogCategory LogCategory
	{
		[Address(RVA="0x10DF46C", Offset="0x10DF46C", VA="0x10DF46C", Slot="7")]
		get
		{
			return new LogCategory();
		}
	}

	public virtual bool PlayVictoryOnDefeat
	{
		[Address(RVA="0x10DF554", Offset="0x10DF554", VA="0x10DF554", Slot="24")]
		get
		{
			return new bool();
		}
	}

	public virtual bool ShowCardsImmediately
	{
		[Address(RVA="0x10DF524", Offset="0x10DF524", VA="0x10DF524", Slot="18")]
		get
		{
			return new bool();
		}
	}

	public virtual bool ShowEnvironmentImmediately
	{
		[Address(RVA="0x10DF544", Offset="0x10DF544", VA="0x10DF544", Slot="22")]
		get
		{
			return new bool();
		}
	}

	public override bool ShowGlobalBackdrop
	{
		[Address(RVA="0x10DF484", Offset="0x10DF484", VA="0x10DF484", Slot="10")]
		get
		{
			return new bool();
		}
	}

	public abstract bool ShowRounds
	{
		get;
	}

	[Address(RVA="0x10DFDDC", Offset="0x10DFDDC", VA="0x10DFDDC")]
	protected ABattleGameState()
	{
	}

	[Address(RVA="0x10DF56C", Offset="0x10DF56C", VA="0x10DF56C", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	[Address(RVA="0x10DFC78", Offset="0x10DFC78", VA="0x10DFC78", Slot="5")]
	public override void Exiting()
	{
	}

	protected abstract void Install(DiContainer container, ITransitionContext context, Action finished);

	[Address(RVA="0x10DFD94", Offset="0x10DFD94", VA="0x10DFD94", Slot="11")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AF0C", Offset="0x104AF0C")]
	private sealed class <>c__DisplayClass38_0
	{
		[FieldOffset(Offset="0x10")]
		public ITransitionContext context;

		[FieldOffset(Offset="0x18")]
		public ABattleGameState <>4__this;

		[FieldOffset(Offset="0x20")]
		public DiContainer container;

		[FieldOffset(Offset="0x28")]
		public Action <>9__2;

		[Address(RVA="0x10DFC70", Offset="0x10DFC70", VA="0x10DFC70")]
		public <>c__DisplayClass38_0()
		{
		}

		[Address(RVA="0x10DFDE4", Offset="0x10DFDE4", VA="0x10DFDE4")]
		internal void <Entering>b__0()
		{
		}

		[Address(RVA="0x10DFFA0", Offset="0x10DFFA0", VA="0x10DFFA0")]
		internal void <Entering>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AF1C", Offset="0x104AF1C")]
	private sealed class <>c__DisplayClass38_1
	{
		[FieldOffset(Offset="0x10")]
		public GameStateTransitionContext stateContext;

		[FieldOffset(Offset="0x18")]
		public ABattleGameState.<>c__DisplayClass38_0 CS$<>8__locals1;

		[Address(RVA="0x10DFF98", Offset="0x10DFF98", VA="0x10DFF98")]
		public <>c__DisplayClass38_1()
		{
		}

		[Address(RVA="0x10E0010", Offset="0x10E0010", VA="0x10E0010")]
		internal void <Entering>b__1()
		{
		}
	}

	public abstract class ATransitionContext : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x20")]
		public Stopwatch LoadingTimer;

		[FieldOffset(Offset="0x28")]
		public ABattleGameState.TelemetryInfo TelemetryInfo;

		[Address(RVA="0x10E00FC", Offset="0x10E00FC", VA="0x10E00FC")]
		protected ATransitionContext()
		{
		}
	}

	public class TelemetryInfo
	{
		[FieldOffset(Offset="0x10")]
		public readonly long RefId;

		[FieldOffset(Offset="0x18")]
		public readonly string St3;

		[FieldOffset(Offset="0x20")]
		public readonly string Name;

		[FieldOffset(Offset="0x28")]
		public readonly Dictionary<string, object> BaseData;

		[Address(RVA="0x10E0164", Offset="0x10E0164", VA="0x10E0164")]
		public TelemetryInfo(long refId, string location, string name, Dictionary<string, object> baseData)
		{
		}
	}
}