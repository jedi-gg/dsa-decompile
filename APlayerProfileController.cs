using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public abstract class APlayerProfileController : AFeatureController, IDispatchHandler<DPlayerProfileAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105B980", Offset="0x105B980")]
	[FieldOffset(Offset="0x68")]
	protected PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x105B990", Offset="0x105B990")]
	[FieldOffset(Offset="0x70")]
	protected GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x78")]
	private Player _player;

	[FieldOffset(Offset="0x80")]
	private List<PlayerStat> _playerStats;

	[FieldOffset(Offset="0x88")]
	protected PlayerProfileView _view;

	[Address(RVA="0x10F1488", Offset="0x10F1488", VA="0x10F1488")]
	protected APlayerProfileController()
	{
	}

	[Address(RVA="0x10F1390", Offset="0x10F1390", VA="0x10F1390")]
	private void FinishInitialization(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x10F0EC4", Offset="0x10F0EC4", VA="0x10F0EC4", Slot="14")]
	public virtual void HandleDispatchAction(DPlayerProfileAction action)
	{
	}

	[Address(RVA="0x10F0CCC", Offset="0x10F0CCC", VA="0x10F0CCC", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x10F137C", Offset="0x10F137C", VA="0x10F137C", Slot="17")]
	protected virtual void InitializeAsync(Action finished)
	{
	}

	[Address(RVA="0x10F0FA8", Offset="0x10F0FA8", VA="0x10F0FA8", Slot="16")]
	protected virtual void InitializeView()
	{
	}

	protected abstract void LoadProfileInfo(Action<Player, List<PlayerStat>> success, Action<long> failure);

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C74C", Offset="0x104C74C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public APlayerProfileController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x10F0EBC", Offset="0x10F0EBC", VA="0x10F0EBC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x10F1490", Offset="0x10F1490", VA="0x10F1490")]
		internal void <Initialize>b__0(Action jobDone)
		{
		}

		[Address(RVA="0x10F15B8", Offset="0x10F15B8", VA="0x10F15B8")]
		internal void <Initialize>b__1(Action jobDone)
		{
		}

		[Address(RVA="0x10F16AC", Offset="0x10F16AC", VA="0x10F16AC")]
		internal void <Initialize>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C75C", Offset="0x104C75C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action jobDone;

		[FieldOffset(Offset="0x18")]
		public APlayerProfileController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x10F15B0", Offset="0x10F15B0", VA="0x10F15B0")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x10F16DC", Offset="0x10F16DC", VA="0x10F16DC")]
		internal void <Initialize>b__3(Player player, List<PlayerStat> stats)
		{
		}

		[Address(RVA="0x10F176C", Offset="0x10F176C", VA="0x10F176C")]
		internal void <Initialize>b__4(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C76C", Offset="0x104C76C")]
	private sealed class <>c__DisplayClass0_2
	{
		[FieldOffset(Offset="0x10")]
		public Action jobDone;

		[FieldOffset(Offset="0x18")]
		public APlayerProfileController.<>c__DisplayClass0_0 CS$<>8__locals2;

		[Address(RVA="0x10F16A4", Offset="0x10F16A4", VA="0x10F16A4")]
		public <>c__DisplayClass0_2()
		{
		}

		[Address(RVA="0x10F1780", Offset="0x10F1780", VA="0x10F1780")]
		internal void <Initialize>b__5(PlayerProfileView view)
		{
		}
	}
}