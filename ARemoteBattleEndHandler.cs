using BattleLib;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public abstract class ARemoteBattleEndHandler : IBattleEndHandler, ILoggable<LogCategory>
{
	[Attribute(Name="InjectAttribute", RVA="0x1052A6C", Offset="0x1052A6C")]
	[FieldOffset(Offset="0x10")]
	protected ABattle _battle;

	[Attribute(Name="InjectAttribute", RVA="0x1052A7C", Offset="0x1052A7C")]
	[FieldOffset(Offset="0x18")]
	protected BattleHandler _battleHandler;

	[Attribute(Name="InjectAttribute", RVA="0x1052A8C", Offset="0x1052A8C")]
	[FieldOffset(Offset="0x20")]
	private BattleService _battleService;

	public LogCategory LogCategory
	{
		[Address(RVA="0x10F493C", Offset="0x10F493C", VA="0x10F493C", Slot="6")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x10F4CD0", Offset="0x10F4CD0", VA="0x10F4CD0")]
	protected ARemoteBattleEndHandler()
	{
	}

	public abstract void HandleBattleEnd(BattleLib_UpdateResult.Types.BattleEnded battleEnded);

	[Address(RVA="0x10F4944", Offset="0x10F4944", VA="0x10F4944", Slot="5")]
	public void HandleBattleQuit()
	{
	}

	[Address(RVA="0x10F49C0", Offset="0x10F49C0", VA="0x10F49C0")]
	protected void RequestBattleResults(Action<MultiplayerBattleResultResponse> success, Action failure)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AF3C", Offset="0x104AF3C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static ARemoteBattleEndHandler.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Func<bool> <>9__4_2;

		[Address(RVA="0x10F4CD8", Offset="0x10F4CD8", VA="0x10F4CD8")]
		static <>c()
		{
		}

		[Address(RVA="0x10F4D3C", Offset="0x10F4D3C", VA="0x10F4D3C")]
		public <>c()
		{
		}

		[Address(RVA="0x10F4D44", Offset="0x10F4D44", VA="0x10F4D44")]
		internal bool <RequestBattleResults>b__4_2()
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AF2C", Offset="0x104AF2C")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public Action<MultiplayerBattleResultResponse> success;

		[FieldOffset(Offset="0x18")]
		public ARemoteBattleEndHandler <>4__this;

		[FieldOffset(Offset="0x20")]
		public Action failure;

		[Address(RVA="0x10F4CC8", Offset="0x10F4CC8", VA="0x10F4CC8")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x10F4D4C", Offset="0x10F4D4C", VA="0x10F4D4C")]
		internal void <RequestBattleResults>b__0(MultiplayerBattleResultResponse response)
		{
		}

		[Address(RVA="0x10F4DC0", Offset="0x10F4DC0", VA="0x10F4DC0")]
		internal void <RequestBattleResults>b__1(long errorCode)
		{
		}
	}
}