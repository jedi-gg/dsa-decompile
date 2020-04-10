using BattleLib;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class KothBattleEndHandler : IBattleEndHandler, ILoggable<LogCategory>
{
	[Attribute(Name="InjectAttribute", RVA="0x1054310", Offset="0x1054310")]
	[FieldOffset(Offset="0x10")]
	protected ABattle _battle;

	[Attribute(Name="InjectAttribute", RVA="0x1054320", Offset="0x1054320")]
	[FieldOffset(Offset="0x18")]
	protected BattleHandler _battleHandler;

	[Attribute(Name="InjectAttribute", RVA="0x1054330", Offset="0x1054330")]
	[FieldOffset(Offset="0x20")]
	private BattleService _battleService;

	[Attribute(Name="InjectAttribute", RVA="0x1054340", Offset="0x1054340")]
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1054350", Offset="0x1054350")]
	[FieldOffset(Offset="0x30")]
	private TelemetryTranslator _telemetryTranslator;

	[Attribute(Name="InjectAttribute", RVA="0x1054360", Offset="0x1054360")]
	[FieldOffset(Offset="0x38")]
	private BattleAutoBattleController _autoBattleController;

	[FieldOffset(Offset="0x40")]
	private KothBattleGameState.TransitionContext _context;

	public LogCategory LogCategory
	{
		[Address(RVA="0x11C7BB8", Offset="0x11C7BB8", VA="0x11C7BB8", Slot="6")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x11C7BC0", Offset="0x11C7BC0", VA="0x11C7BC0")]
	public KothBattleEndHandler(KothBattleGameState.TransitionContext context)
	{
	}

	[Address(RVA="0x11C7BEC", Offset="0x11C7BEC", VA="0x11C7BEC", Slot="4")]
	public void HandleBattleEnd(BattleLib_UpdateResult.Types.BattleEnded battleEnded)
	{
	}

	[Address(RVA="0x11C7F78", Offset="0x11C7F78", VA="0x11C7F78", Slot="5")]
	public void HandleBattleQuit()
	{
	}

	[Address(RVA="0x11C7FF4", Offset="0x11C7FF4", VA="0x11C7FF4")]
	private void SendBattleCompleteTelemetry(bool win, ulong rankDelta, ulong newRank)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B2AC", Offset="0x104B2AC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static KothBattleEndHandler.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Func<bool> <>9__3_2;

		[Address(RVA="0x11C82E4", Offset="0x11C82E4", VA="0x11C82E4")]
		static <>c()
		{
		}

		[Address(RVA="0x11C8348", Offset="0x11C8348", VA="0x11C8348")]
		public <>c()
		{
		}

		[Address(RVA="0x11C8350", Offset="0x11C8350", VA="0x11C8350")]
		internal bool <HandleBattleEnd>b__3_2()
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B28C", Offset="0x104B28C")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public KothBattleEndHandler <>4__this;

		[FieldOffset(Offset="0x18")]
		public BattleLib_UpdateResult.Types.BattleEnded battleEnded;

		[Address(RVA="0x11C7F68", Offset="0x11C7F68", VA="0x11C7F68")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x11C8358", Offset="0x11C8358", VA="0x11C8358")]
		internal void <HandleBattleEnd>b__1(long errorCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B29C", Offset="0x104B29C")]
	private sealed class <>c__DisplayClass3_1
	{
		[FieldOffset(Offset="0x10")]
		public bool win;

		[FieldOffset(Offset="0x18")]
		public KothBattleEndHandler.<>c__DisplayClass3_0 CS$<>8__locals1;

		[Address(RVA="0x11C7F70", Offset="0x11C7F70", VA="0x11C7F70")]
		public <>c__DisplayClass3_1()
		{
		}

		[Address(RVA="0x11C8484", Offset="0x11C8484", VA="0x11C8484")]
		internal void <HandleBattleEnd>b__0(KothBattleResultResponse response)
		{
		}
	}
}