using BattleLib;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class PveBattleEndHandler : IBattleEndHandler, ILoggable<LogCategory>
{
	[Attribute(Name="InjectAttribute", RVA="0x1054410", Offset="0x1054410")]
	[FieldOffset(Offset="0x10")]
	private ABattle _battle;

	[Attribute(Name="InjectAttribute", RVA="0x1054420", Offset="0x1054420")]
	[FieldOffset(Offset="0x18")]
	private BattleHandler _battleHandler;

	[Attribute(Name="InjectAttribute", RVA="0x1054430", Offset="0x1054430")]
	[FieldOffset(Offset="0x20")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1054440", Offset="0x1054440")]
	[FieldOffset(Offset="0x28")]
	private BattleService _battleService;

	[Attribute(Name="InjectAttribute", RVA="0x1054450", Offset="0x1054450")]
	[FieldOffset(Offset="0x30")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1054460", Offset="0x1054460")]
	[FieldOffset(Offset="0x38")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1054470", Offset="0x1054470")]
	[FieldOffset(Offset="0x40")]
	private TelemetryTranslator _telemetryTranslator;

	[Attribute(Name="InjectAttribute", RVA="0x1054480", Offset="0x1054480")]
	[FieldOffset(Offset="0x48")]
	private AccountPrefs _accountPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x1054490", Offset="0x1054490")]
	[FieldOffset(Offset="0x50")]
	private BattleAutoBattleController _autoBattleController;

	[Attribute(Name="InjectAttribute", RVA="0x10544A0", Offset="0x10544A0")]
	[FieldOffset(Offset="0x58")]
	private RevSdkController _revSdk;

	[FieldOffset(Offset="0x60")]
	private PveBattleGameState.TransitionContext _context;

	public LogCategory LogCategory
	{
		[Address(RVA="0x127F730", Offset="0x127F730", VA="0x127F730", Slot="6")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x127F738", Offset="0x127F738", VA="0x127F738")]
	public PveBattleEndHandler(PveBattleGameState.TransitionContext context)
	{
	}

	[Address(RVA="0x127F764", Offset="0x127F764", VA="0x127F764", Slot="4")]
	public void HandleBattleEnd(BattleLib_UpdateResult.Types.BattleEnded battleEnded)
	{
	}

	[Address(RVA="0x127FE64", Offset="0x127FE64", VA="0x127FE64", Slot="5")]
	public void HandleBattleQuit()
	{
	}

	[Address(RVA="0x127FF20", Offset="0x127FF20", VA="0x127FF20")]
	private void SendBattleCompleteTelemetry(bool quit, CampaignProgress previousProgress, PveBattleEndRequest request, PveBattleEndResponse response)
	{
	}

	[Address(RVA="0x127FBB8", Offset="0x127FBB8", VA="0x127FBB8")]
	private void SendBattleEnd(PveBattleEndRequest request, BattleLib_UpdateResult.Types.BattleEnded.Types.Reason reason, bool quit)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B2CC", Offset="0x104B2CC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static PveBattleEndHandler.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Func<bool> <>9__5_2;

		[Address(RVA="0x12807E4", Offset="0x12807E4", VA="0x12807E4")]
		static <>c()
		{
		}

		[Address(RVA="0x1280848", Offset="0x1280848", VA="0x1280848")]
		public <>c()
		{
		}

		[Address(RVA="0x1280850", Offset="0x1280850", VA="0x1280850")]
		internal bool <SendBattleEnd>b__5_2()
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B2BC", Offset="0x104B2BC")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset="0x10")]
		public PveBattleEndHandler <>4__this;

		[FieldOffset(Offset="0x18")]
		public bool quit;

		[FieldOffset(Offset="0x20")]
		public CampaignProgress previousProgress;

		[FieldOffset(Offset="0x28")]
		public PveBattleEndRequest request;

		[FieldOffset(Offset="0x30")]
		public bool delayExit;

		[FieldOffset(Offset="0x34")]
		public BattleLib_UpdateResult.Types.BattleEnded.Types.Reason reason;

		[Address(RVA="0x127FF18", Offset="0x127FF18", VA="0x127FF18")]
		public <>c__DisplayClass5_0()
		{
		}

		[Address(RVA="0x1280858", Offset="0x1280858", VA="0x1280858")]
		internal void <SendBattleEnd>b__0(PveBattleEndResponse response)
		{
		}

		[Address(RVA="0x1281084", Offset="0x1281084", VA="0x1281084")]
		internal void <SendBattleEnd>b__1(long errorCode)
		{
		}
	}
}