using BattleLib;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class TowerBattleEndHandler : IBattleEndHandler, ILoggable<LogCategory>
{
	[Attribute(Name="InjectAttribute", RVA="0x1054540", Offset="0x1054540")]
	[FieldOffset(Offset="0x10")]
	private ABattle _battle;

	[Attribute(Name="InjectAttribute", RVA="0x1054550", Offset="0x1054550")]
	[FieldOffset(Offset="0x18")]
	private BattleHandler _battleHandler;

	[Attribute(Name="InjectAttribute", RVA="0x1054560", Offset="0x1054560")]
	[FieldOffset(Offset="0x20")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1054570", Offset="0x1054570")]
	[FieldOffset(Offset="0x28")]
	private BattleService _battleService;

	[Attribute(Name="InjectAttribute", RVA="0x1054580", Offset="0x1054580")]
	[FieldOffset(Offset="0x30")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1054590", Offset="0x1054590")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x10545A0", Offset="0x10545A0")]
	[FieldOffset(Offset="0x40")]
	private TelemetryTranslator _telemetryTranslator;

	[Attribute(Name="InjectAttribute", RVA="0x10545B0", Offset="0x10545B0")]
	[FieldOffset(Offset="0x48")]
	private BattleAutoBattleController _autoBattleController;

	[Attribute(Name="InjectAttribute", RVA="0x10545C0", Offset="0x10545C0")]
	[FieldOffset(Offset="0x50")]
	private RevSdkController _revSdk;

	[FieldOffset(Offset="0x58")]
	private TowerBattleGameState.TransitionContext _context;

	public LogCategory LogCategory
	{
		[Address(RVA="0x13298AC", Offset="0x13298AC", VA="0x13298AC", Slot="6")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x13298B4", Offset="0x13298B4", VA="0x13298B4")]
	public TowerBattleEndHandler(TowerBattleGameState.TransitionContext context)
	{
	}

	[Address(RVA="0x13298E0", Offset="0x13298E0", VA="0x13298E0", Slot="4")]
	public void HandleBattleEnd(BattleLib_UpdateResult.Types.BattleEnded battleEnded)
	{
	}

	[Address(RVA="0x1329F8C", Offset="0x1329F8C", VA="0x1329F8C", Slot="5")]
	public void HandleBattleQuit()
	{
	}

	[Address(RVA="0x132A014", Offset="0x132A014", VA="0x132A014")]
	private void SendBattleCompleteTelemetry(bool quit, TowerBattleEndRequest request, TowerBattleEndResponse response)
	{
	}

	[Address(RVA="0x1329D48", Offset="0x1329D48", VA="0x1329D48")]
	private void SendBattleEnd(TowerBattleEndRequest request, BattleLib_UpdateResult.Types.BattleEnded.Types.Reason reason, bool quit)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B2FC", Offset="0x104B2FC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static TowerBattleEndHandler.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Func<bool> <>9__5_2;

		[Address(RVA="0x142FFC8", Offset="0x142FFC8", VA="0x142FFC8")]
		static <>c()
		{
		}

		[Address(RVA="0x143002C", Offset="0x143002C", VA="0x143002C")]
		public <>c()
		{
		}

		[Address(RVA="0x1430034", Offset="0x1430034", VA="0x1430034")]
		internal bool <SendBattleEnd>b__5_2()
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B2EC", Offset="0x104B2EC")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset="0x10")]
		public TowerBattleEndHandler <>4__this;

		[FieldOffset(Offset="0x18")]
		public bool quit;

		[FieldOffset(Offset="0x20")]
		public TowerBattleEndRequest request;

		[FieldOffset(Offset="0x28")]
		public bool delayExit;

		[FieldOffset(Offset="0x2C")]
		public BattleLib_UpdateResult.Types.BattleEnded.Types.Reason reason;

		[Address(RVA="0x143003C", Offset="0x143003C", VA="0x143003C")]
		public <>c__DisplayClass5_0()
		{
		}

		[Address(RVA="0x1430044", Offset="0x1430044", VA="0x1430044")]
		internal void <SendBattleEnd>b__0(TowerBattleEndResponse response)
		{
		}

		[Address(RVA="0x14302B8", Offset="0x14302B8", VA="0x14302B8")]
		internal void <SendBattleEnd>b__1(long errorCode)
		{
		}
	}
}