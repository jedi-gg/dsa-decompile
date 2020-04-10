using BattleLib;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class ClubDungeonBattleEndHandler : IBattleEndHandler, ILoggable<LogCategory>
{
	[Attribute(Name="InjectAttribute", RVA="0x1054180", Offset="0x1054180")]
	[FieldOffset(Offset="0x10")]
	private ABattle _battle;

	[Attribute(Name="InjectAttribute", RVA="0x1054190", Offset="0x1054190")]
	[FieldOffset(Offset="0x18")]
	private BattleHandler _battleHandler;

	[Attribute(Name="InjectAttribute", RVA="0x10541A0", Offset="0x10541A0")]
	[FieldOffset(Offset="0x20")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x10541B0", Offset="0x10541B0")]
	[FieldOffset(Offset="0x28")]
	private BattleService _battleService;

	[Attribute(Name="InjectAttribute", RVA="0x10541C0", Offset="0x10541C0")]
	[FieldOffset(Offset="0x30")]
	private TelemetryTranslator _telemetryTranslator;

	[Attribute(Name="InjectAttribute", RVA="0x10541D0", Offset="0x10541D0")]
	[FieldOffset(Offset="0x38")]
	private BattleAutoBattleController _autoBattleController;

	[Attribute(Name="InjectAttribute", RVA="0x10541E0", Offset="0x10541E0")]
	[FieldOffset(Offset="0x40")]
	private RevSdkController _revSdk;

	[FieldOffset(Offset="0x48")]
	private ClubDungeonBattleGameState.TransitionContext _context;

	public LogCategory LogCategory
	{
		[Address(RVA="0x11A6ED8", Offset="0x11A6ED8", VA="0x11A6ED8", Slot="6")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x11A6EE0", Offset="0x11A6EE0", VA="0x11A6EE0")]
	public ClubDungeonBattleEndHandler(ClubDungeonBattleGameState.TransitionContext context)
	{
	}

	[Address(RVA="0x11A6F0C", Offset="0x11A6F0C", VA="0x11A6F0C", Slot="4")]
	public void HandleBattleEnd(BattleLib_UpdateResult.Types.BattleEnded battleEnded)
	{
	}

	[Address(RVA="0x11A7240", Offset="0x11A7240", VA="0x11A7240", Slot="5")]
	public void HandleBattleQuit()
	{
	}

	[Address(RVA="0x11A72D0", Offset="0x11A72D0", VA="0x11A72D0")]
	private void SendBattleCompleteTelemetry(bool quit, ClubDungeonBattleEndRequest request, ClubDungeonBattleEndResponse response)
	{
	}

	[Address(RVA="0x11A7064", Offset="0x11A7064", VA="0x11A7064")]
	private void SendBattleEnd(ClubDungeonBattleEndRequest request, BattleLib_UpdateResult.Types.BattleEnded.Types.Reason reason, bool quit)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B21C", Offset="0x104B21C")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubDungeonBattleEndHandler <>4__this;

		[FieldOffset(Offset="0x18")]
		public bool quit;

		[FieldOffset(Offset="0x20")]
		public ClubDungeonBattleEndRequest request;

		[FieldOffset(Offset="0x28")]
		public bool delayExit;

		[FieldOffset(Offset="0x2C")]
		public BattleLib_UpdateResult.Types.BattleEnded.Types.Reason reason;

		[Address(RVA="0x11A72C8", Offset="0x11A72C8", VA="0x11A72C8")]
		public <>c__DisplayClass5_0()
		{
		}

		[Address(RVA="0x11A7808", Offset="0x11A7808", VA="0x11A7808")]
		internal void <SendBattleEnd>b__0(ClubDungeonBattleEndResponse response)
		{
		}

		[Address(RVA="0x11A7A04", Offset="0x11A7A04", VA="0x11A7A04")]
		internal void <SendBattleEnd>b__1(long errorCode)
		{
		}
	}
}