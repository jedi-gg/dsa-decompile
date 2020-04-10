using BattleLib;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class TutorialBattleEndHandler : IBattleEndHandler, ILoggable<LogCategory>
{
	[Attribute(Name="InjectAttribute", RVA="0x1054600", Offset="0x1054600")]
	[FieldOffset(Offset="0x10")]
	private ABattle _battle;

	[Attribute(Name="InjectAttribute", RVA="0x1054610", Offset="0x1054610")]
	[FieldOffset(Offset="0x18")]
	private BattleHandler _battleHandler;

	[Attribute(Name="InjectAttribute", RVA="0x1054620", Offset="0x1054620")]
	[FieldOffset(Offset="0x20")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1054630", Offset="0x1054630")]
	[FieldOffset(Offset="0x28")]
	private BattleService _battleService;

	public LogCategory LogCategory
	{
		[Address(RVA="0x143C2BC", Offset="0x143C2BC", VA="0x143C2BC", Slot="6")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x143C2C4", Offset="0x143C2C4", VA="0x143C2C4")]
	public TutorialBattleEndHandler(TutorialBattleGameState.TransitionContext context)
	{
	}

	[Address(RVA="0x143C2CC", Offset="0x143C2CC", VA="0x143C2CC", Slot="4")]
	public void HandleBattleEnd(BattleLib_UpdateResult.Types.BattleEnded battleEnded)
	{
	}

	[Address(RVA="0x143C4D8", Offset="0x143C4D8", VA="0x143C4D8", Slot="5")]
	public void HandleBattleQuit()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B30C", Offset="0x104B30C")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public TutorialBattleEndHandler <>4__this;

		[FieldOffset(Offset="0x18")]
		public PveBattleEndRequest request;

		[FieldOffset(Offset="0x20")]
		public BattleLib_UpdateResult.Types.BattleEnded battleEnded;

		[Address(RVA="0x143C4D0", Offset="0x143C4D0", VA="0x143C4D0")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x143C554", Offset="0x143C554", VA="0x143C554")]
		internal void <HandleBattleEnd>b__0(PveBattleEndResponse response)
		{
		}

		[Address(RVA="0x143C6A0", Offset="0x143C6A0", VA="0x143C6A0")]
		internal void <HandleBattleEnd>b__1(long errorCode)
		{
		}
	}
}