using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class TutorialEntryGameState : AGameState
{
	[Attribute(Name="InjectAttribute", RVA="0x1054650", Offset="0x1054650")]
	[FieldOffset(Offset="0x30")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x1054660", Offset="0x1054660")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1054670", Offset="0x1054670")]
	[FieldOffset(Offset="0x40")]
	private BattleService _battleService;

	[Attribute(Name="InjectAttribute", RVA="0x1054680", Offset="0x1054680")]
	[FieldOffset(Offset="0x48")]
	private GameStateMachine _gameStateMachine;

	public override bool CanBeDeepLinkedAwayFrom
	{
		[Address(RVA="0x143D3E8", Offset="0x143D3E8", VA="0x143D3E8", Slot="9")]
		get
		{
			return new bool();
		}
	}

	public override bool CanBeNavigatedBackInto
	{
		[Address(RVA="0x143D3E0", Offset="0x143D3E0", VA="0x143D3E0", Slot="8")]
		get
		{
			return new bool();
		}
	}

	public override bool ShowGlobalBackdrop
	{
		[Address(RVA="0x143D3F0", Offset="0x143D3F0", VA="0x143D3F0", Slot="10")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x143D784", Offset="0x143D784", VA="0x143D784")]
	public TutorialEntryGameState()
	{
	}

	[Address(RVA="0x143D3F8", Offset="0x143D3F8", VA="0x143D3F8", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	[Address(RVA="0x143D780", Offset="0x143D780", VA="0x143D780", Slot="5")]
	public override void Exiting()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B31C", Offset="0x104B31C")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset="0x10")]
		public PveBattleStartRequest startReq;

		[FieldOffset(Offset="0x18")]
		public TutorialEntryGameState <>4__this;

		[Address(RVA="0x143D778", Offset="0x143D778", VA="0x143D778")]
		public <>c__DisplayClass6_0()
		{
		}

		[Address(RVA="0x143D78C", Offset="0x143D78C", VA="0x143D78C")]
		internal void <Entering>b__0(PveBattleStartResponse response)
		{
		}

		[Address(RVA="0x143D878", Offset="0x143D878", VA="0x143D878")]
		internal void <Entering>b__1(long errorCode)
		{
		}
	}
}