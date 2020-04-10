using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class PackOpeningController : AFeatureController, IDispatchHandler<DPackOpeningViewAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x0")]
	private const double EXIT_SAFETY_FALLBACK_DURATION_S = 10;

	[Attribute(Name="InjectAttribute", RVA="0x105AAD8", Offset="0x105AAD8")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x105AAE8", Offset="0x105AAE8")]
	[FieldOffset(Offset="0x70")]
	private GameStateMachineNavigationTracker _navigationTracker;

	[FieldOffset(Offset="0x78")]
	private InventoryDelta _inventoryDelta;

	[FieldOffset(Offset="0x80")]
	private long? _passportSeasonPurchaseTelemetryRefId;

	[FieldOffset(Offset="0x90")]
	private PackOpeningView _packOpeningView;

	[FieldOffset(Offset="0x98")]
	private DateTime? _exitSafetyFallbackTime;

	[FieldOffset(Offset="0xA8")]
	private StoreItemData _buyAgainItem;

	[Address(RVA="0x1303F98", Offset="0x1303F98", VA="0x1303F98")]
	public PackOpeningController()
	{
	}

	[Address(RVA="0x1303EC8", Offset="0x1303EC8", VA="0x1303EC8", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x1303B40", Offset="0x1303B40", VA="0x1303B40")]
	private void Exit()
	{
	}

	[Address(RVA="0x1303B70", Offset="0x1303B70", VA="0x1303B70", Slot="13")]
	public void HandleDispatchAction(DPackOpeningViewAction action)
	{
	}

	[Address(RVA="0x1303348", Offset="0x1303348", VA="0x1303348", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x13035B8", Offset="0x13035B8", VA="0x13035B8", Slot="7")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x13035E0", Offset="0x13035E0", VA="0x13035E0", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C43C", Offset="0x104C43C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public PackOpeningController <>4__this;

		[FieldOffset(Offset="0x18")]
		public PackOpeningGameState.Context revealContext;

		[FieldOffset(Offset="0x20")]
		public GameStateTransitionContext context;

		[Address(RVA="0x13035B0", Offset="0x13035B0", VA="0x13035B0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1303FA0", Offset="0x1303FA0", VA="0x1303FA0")]
		internal void <Initialize>b__0(Action jobFinished)
		{
		}

		[Address(RVA="0x130408C", Offset="0x130408C", VA="0x130408C")]
		internal void <Initialize>b__1(Action jobFinished)
		{
		}

		[Address(RVA="0x1304180", Offset="0x1304180", VA="0x1304180")]
		internal void <Initialize>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C44C", Offset="0x104C44C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[Address(RVA="0x1304084", Offset="0x1304084", VA="0x1304084")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x13041BC", Offset="0x13041BC", VA="0x13041BC")]
		internal void <Initialize>b__3(PackOpeningScene _)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C45C", Offset="0x104C45C")]
	private sealed class <>c__DisplayClass0_2
	{
		[FieldOffset(Offset="0x10")]
		public Action jobFinished;

		[FieldOffset(Offset="0x18")]
		public PackOpeningController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x1304178", Offset="0x1304178", VA="0x1304178")]
		public <>c__DisplayClass0_2()
		{
		}

		[Address(RVA="0x13041D0", Offset="0x13041D0", VA="0x13041D0")]
		internal void <Initialize>b__4(PackOpeningView view)
		{
		}
	}
}