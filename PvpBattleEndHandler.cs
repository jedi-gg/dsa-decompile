using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class PvpBattleEndHandler : ARemoteBattleEndHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x10544C0", Offset="0x10544C0")]
	[FieldOffset(Offset="0x28")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x10544D0", Offset="0x10544D0")]
	[FieldOffset(Offset="0x30")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x10544E0", Offset="0x10544E0")]
	[FieldOffset(Offset="0x38")]
	private TelemetryTranslator _telemetryTranslator;

	[Attribute(Name="InjectAttribute", RVA="0x10544F0", Offset="0x10544F0")]
	[FieldOffset(Offset="0x40")]
	private BattleAutoBattleController _autoBattleController;

	[Attribute(Name="InjectAttribute", RVA="0x1054500", Offset="0x1054500")]
	[FieldOffset(Offset="0x48")]
	private RevSdkController _revSdk;

	[FieldOffset(Offset="0x50")]
	private PvpBattleGameState.TransitionContext _context;

	[Address(RVA="0x12814F0", Offset="0x12814F0", VA="0x12814F0")]
	public PvpBattleEndHandler(PvpBattleGameState.TransitionContext context)
	{
	}

	[Address(RVA="0x128151C", Offset="0x128151C", VA="0x128151C", Slot="7")]
	public override void HandleBattleEnd(BattleLib_UpdateResult.Types.BattleEnded battleEnded)
	{
	}

	[Address(RVA="0x12819B0", Offset="0x12819B0", VA="0x12819B0")]
	private void SendBattleCompleteTelemetry(bool win, MultiplayerBattleResultResponse results)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B2DC", Offset="0x104B2DC")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset="0x10")]
		public PvpBattleEndHandler <>4__this;

		[FieldOffset(Offset="0x18")]
		public bool win;

		[FieldOffset(Offset="0x20")]
		public BattleLib_UpdateResult.Types.BattleEnded battleEnded;

		[FieldOffset(Offset="0x28")]
		public PvpScore oldPvpScore;

		[FieldOffset(Offset="0x30")]
		public ulong stars;

		[Address(RVA="0x12819A8", Offset="0x12819A8", VA="0x12819A8")]
		public <>c__DisplayClass1_0()
		{
		}

		[Address(RVA="0x1281F08", Offset="0x1281F08", VA="0x1281F08")]
		internal void <HandleBattleEnd>b__0(MultiplayerBattleResultResponse results)
		{
		}

		[Address(RVA="0x1282258", Offset="0x1282258", VA="0x1282258")]
		internal void <HandleBattleEnd>b__1()
		{
		}
	}
}