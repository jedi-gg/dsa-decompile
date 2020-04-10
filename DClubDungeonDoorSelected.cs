using Il2CppDummyDll;
using System;
using UnityEngine;

public struct DClubDungeonDoorSelected
{
	[FieldOffset(Offset="0x0")]
	public int DoorIndex;

	[FieldOffset(Offset="0x8")]
	public GameObject Door;

	[Address(RVA="0xF03790", Offset="0xF03790", VA="0xF03790")]
	public DClubDungeonDoorSelected(int doorIndex, GameObject door)
	{
	}
}