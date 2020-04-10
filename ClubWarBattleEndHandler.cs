using BattleLib;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class ClubWarBattleEndHandler : IBattleEndHandler, ILoggable<LogCategory>
{
	[Attribute(Name="InjectAttribute", RVA="0x10541F0", Offset="0x10541F0")]
	[FieldOffset(Offset="0x10")]
	protected ABattle _battle;

	[Attribute(Name="InjectAttribute", RVA="0x1054200", Offset="0x1054200")]
	[FieldOffset(Offset="0x18")]
	protected BattleHandler _battleHandler;

	[Attribute(Name="InjectAttribute", RVA="0x1054210", Offset="0x1054210")]
	[FieldOffset(Offset="0x20")]
	private BattleService _battleService;

	[Attribute(Name="InjectAttribute", RVA="0x1054220", Offset="0x1054220")]
	[FieldOffset(Offset="0x28")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1054230", Offset="0x1054230")]
	[FieldOffset(Offset="0x30")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1054240", Offset="0x1054240")]
	[FieldOffset(Offset="0x38")]
	private TelemetryTranslator _telemetryTranslator;

	[Attribute(Name="InjectAttribute", RVA="0x1054250", Offset="0x1054250")]
	[FieldOffset(Offset="0x40")]
	private LocalizationManager _locManager;

	[Attribute(Name="InjectAttribute", RVA="0x1054260", Offset="0x1054260")]
	[FieldOffset(Offset="0x48")]
	private BattleAutoBattleController _autoBattleController;

	[FieldOffset(Offset="0x50")]
	private ClubWarBattleGameState.TransitionContext _context;

	public LogCategory LogCategory
	{
		[Address(RVA="0x12682DC", Offset="0x12682DC", VA="0x12682DC", Slot="6")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x12682E4", Offset="0x12682E4", VA="0x12682E4")]
	public ClubWarBattleEndHandler(ClubWarBattleGameState.TransitionContext context)
	{
	}

	[Address(RVA="0x1268310", Offset="0x1268310", VA="0x1268310", Slot="4")]
	public void HandleBattleEnd(BattleLib_UpdateResult.Types.BattleEnded battleEnded)
	{
	}

	[Address(RVA="0x1268698", Offset="0x1268698", VA="0x1268698", Slot="5")]
	public void HandleBattleQuit()
	{
	}

	[Address(RVA="0x1268714", Offset="0x1268714", VA="0x1268714")]
	private void SendBattleCompleteTelemetry(bool win, ClubWarBattleResultResponse response)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B24C", Offset="0x104B24C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static ClubWarBattleEndHandler.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Func<bool> <>9__3_2;

		[Address(RVA="0x1268D9C", Offset="0x1268D9C", VA="0x1268D9C")]
		static <>c()
		{
		}

		[Address(RVA="0x1268E00", Offset="0x1268E00", VA="0x1268E00")]
		public <>c()
		{
		}

		[Address(RVA="0x1268E08", Offset="0x1268E08", VA="0x1268E08")]
		internal bool <HandleBattleEnd>b__3_2()
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B22C", Offset="0x104B22C")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarBattleEndHandler <>4__this;

		[FieldOffset(Offset="0x18")]
		public BattleLib_UpdateResult.Types.BattleEnded battleEnded;

		[Address(RVA="0x1268688", Offset="0x1268688", VA="0x1268688")]
		public <>c__DisplayClass3_0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B23C", Offset="0x104B23C")]
	private sealed class <>c__DisplayClass3_1
	{
		[FieldOffset(Offset="0x10")]
		public bool win;

		[FieldOffset(Offset="0x18")]
		public ClubWarBattleEndHandler.<>c__DisplayClass3_0 CS$<>8__locals1;

		[Address(RVA="0x1268690", Offset="0x1268690", VA="0x1268690")]
		public <>c__DisplayClass3_1()
		{
		}

		[Address(RVA="0x1268E10", Offset="0x1268E10", VA="0x1268E10")]
		internal void <HandleBattleEnd>b__0(ClubWarBattleResultResponse response)
		{
		}

		[Address(RVA="0x12691BC", Offset="0x12691BC", VA="0x12691BC")]
		internal void <HandleBattleEnd>b__1(long errorCode)
		{
		}
	}
}