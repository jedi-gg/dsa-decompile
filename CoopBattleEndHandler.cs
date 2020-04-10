using Il2CppDummyDll;
using Serverproto;
using System;

public class CoopBattleEndHandler : ARemoteBattleEndHandler
{
	[Address(RVA="0x154BF50", Offset="0x154BF50", VA="0x154BF50")]
	public CoopBattleEndHandler()
	{
	}

	[Address(RVA="0x154BDDC", Offset="0x154BDDC", VA="0x154BDDC", Slot="7")]
	public override void HandleBattleEnd(BattleLib_UpdateResult.Types.BattleEnded battleEnded)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B25C", Offset="0x104B25C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public CoopBattleEndHandler <>4__this;

		[FieldOffset(Offset="0x18")]
		public bool win;

		[FieldOffset(Offset="0x20")]
		public BattleLib_UpdateResult.Types.BattleEnded battleEnded;

		[Address(RVA="0x154BF48", Offset="0x154BF48", VA="0x154BF48")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x154BF58", Offset="0x154BF58", VA="0x154BF58")]
		internal void <HandleBattleEnd>b__0(MultiplayerBattleResultResponse results)
		{
		}

		[Address(RVA="0x154C0A0", Offset="0x154C0A0", VA="0x154C0A0")]
		internal void <HandleBattleEnd>b__1()
		{
		}
	}
}