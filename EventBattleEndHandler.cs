using BattleLib;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class EventBattleEndHandler : IBattleEndHandler, ILoggable<LogCategory>
{
	[Attribute(Name="InjectAttribute", RVA="0x1054280", Offset="0x1054280")]
	[FieldOffset(Offset="0x10")]
	private ABattle _battle;

	[Attribute(Name="InjectAttribute", RVA="0x1054290", Offset="0x1054290")]
	[FieldOffset(Offset="0x18")]
	private BattleHandler _battleHandler;

	[Attribute(Name="InjectAttribute", RVA="0x10542A0", Offset="0x10542A0")]
	[FieldOffset(Offset="0x20")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x10542B0", Offset="0x10542B0")]
	[FieldOffset(Offset="0x28")]
	private BattleService _battleService;

	[Attribute(Name="InjectAttribute", RVA="0x10542C0", Offset="0x10542C0")]
	[FieldOffset(Offset="0x30")]
	private TelemetryTranslator _telemetryTranslator;

	[Attribute(Name="InjectAttribute", RVA="0x10542D0", Offset="0x10542D0")]
	[FieldOffset(Offset="0x38")]
	private BattleAutoBattleController _autoBattleController;

	[Attribute(Name="InjectAttribute", RVA="0x10542E0", Offset="0x10542E0")]
	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x10542F0", Offset="0x10542F0")]
	[FieldOffset(Offset="0x48")]
	private RevSdkController _revSdk;

	[FieldOffset(Offset="0x50")]
	private EventBattleGameState.TransitionContext _context;

	public LogCategory LogCategory
	{
		[Address(RVA="0x12123E0", Offset="0x12123E0", VA="0x12123E0", Slot="6")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x12123E8", Offset="0x12123E8", VA="0x12123E8")]
	public EventBattleEndHandler(EventBattleGameState.TransitionContext context)
	{
	}

	[Address(RVA="0x1212414", Offset="0x1212414", VA="0x1212414", Slot="4")]
	public void HandleBattleEnd(BattleLib_UpdateResult.Types.BattleEnded battleEnded)
	{
	}

	[Address(RVA="0x1212AAC", Offset="0x1212AAC", VA="0x1212AAC", Slot="5")]
	public void HandleBattleQuit()
	{
	}

	[Address(RVA="0x1212B68", Offset="0x1212B68", VA="0x1212B68")]
	private void SendBattleCompleteTelemetry(bool quit, EventBattleEndRequest request, EventBattleEndResponse response)
	{
	}

	[Address(RVA="0x1212868", Offset="0x1212868", VA="0x1212868")]
	private void SendBattleEnd(EventBattleEndRequest request, BattleLib_UpdateResult.Types.BattleEnded.Types.Reason reason, bool quit)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B27C", Offset="0x104B27C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static EventBattleEndHandler.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Func<bool> <>9__5_2;

		[Address(RVA="0x121328C", Offset="0x121328C", VA="0x121328C")]
		static <>c()
		{
		}

		[Address(RVA="0x12132F0", Offset="0x12132F0", VA="0x12132F0")]
		public <>c()
		{
		}

		[Address(RVA="0x12132F8", Offset="0x12132F8", VA="0x12132F8")]
		internal bool <SendBattleEnd>b__5_2()
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B26C", Offset="0x104B26C")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset="0x10")]
		public EventBattleEndHandler <>4__this;

		[FieldOffset(Offset="0x18")]
		public bool quit;

		[FieldOffset(Offset="0x20")]
		public EventBattleEndRequest request;

		[FieldOffset(Offset="0x28")]
		public bool delayExit;

		[FieldOffset(Offset="0x2C")]
		public BattleLib_UpdateResult.Types.BattleEnded.Types.Reason reason;

		[Address(RVA="0x1212B60", Offset="0x1212B60", VA="0x1212B60")]
		public <>c__DisplayClass5_0()
		{
		}

		[Address(RVA="0x1213300", Offset="0x1213300", VA="0x1213300")]
		internal void <SendBattleEnd>b__0(EventBattleEndResponse response)
		{
		}

		[Address(RVA="0x1213660", Offset="0x1213660", VA="0x1213660")]
		internal void <SendBattleEnd>b__1(long errorCode)
		{
		}
	}
}