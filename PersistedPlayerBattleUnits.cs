using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class PersistedPlayerBattleUnits
{
	[FieldOffset(Offset="0x10")]
	private Dictionary<ulong, UnitBattleState> _unitStates;

	[Address(RVA="0x140B290", Offset="0x140B290", VA="0x140B290")]
	public PersistedPlayerBattleUnits()
	{
	}

	[Address(RVA="0x140B128", Offset="0x140B128", VA="0x140B128")]
	public void Add(UnitBattleState state)
	{
	}

	[Address(RVA="0x140B268", Offset="0x140B268", VA="0x140B268")]
	public float GetHealthPercent(ulong unitDefId)
	{
		return new float();
	}

	[Address(RVA="0x140B1E0", Offset="0x140B1E0", VA="0x140B1E0")]
	private UnitBattleState GetState(ulong unitDefId)
	{
		return null;
	}

	[Address(RVA="0x140B1B8", Offset="0x140B1B8", VA="0x140B1B8")]
	public bool IsAlive(ulong unitDefId)
	{
		return new bool();
	}
}