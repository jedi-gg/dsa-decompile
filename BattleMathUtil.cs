using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;

public static class BattleMathUtil
{
	[FieldOffset(Offset="0x0")]
	public const float GRID_SCALE = 2f;

	[FieldOffset(Offset="0x0")]
	public const int ENCOUNTER_GRID_WIDTH = 10;

	[FieldOffset(Offset="0x0")]
	public const int ENCOUNTER_LANE_GRID_HEIGHT = 3;

	[Address(RVA="0x11124E8", Offset="0x11124E8", VA="0x11124E8")]
	public static float GetEncounterLaneWorldYOffset(BattleLib_Bootstrap.Types.Encounter encounter, int laneNum)
	{
		return new float();
	}

	[Address(RVA="0x111240C", Offset="0x111240C", VA="0x111240C")]
	public static Vector2 GetEncounterWorldSize(uint numLanes, uint gridGap)
	{
		return new Vector2();
	}

	[Address(RVA="0x1112454", Offset="0x1112454", VA="0x1112454")]
	public static Vector2 GetEncounterWorldSize(BattleLib_Bootstrap.Types.Encounter encounter)
	{
		return new Vector2();
	}

	[Address(RVA="0x11122B8", Offset="0x11122B8", VA="0x11122B8")]
	public static Vector2 GridToWorld(Vector2Int gridPos)
	{
		return new Vector2();
	}

	[Address(RVA="0x1112324", Offset="0x1112324", VA="0x1112324")]
	public static Vector2 GridToWorld(Vector3Int gridPos)
	{
		return new Vector2();
	}

	[Address(RVA="0x1112388", Offset="0x1112388", VA="0x1112388")]
	public static Vector3 GridToWorld3(Vector2Int gridPos)
	{
		return new Vector3();
	}

	[Address(RVA="0x11123C8", Offset="0x11123C8", VA="0x11123C8")]
	public static Vector3 GridToWorld3(Vector3Int gridPos)
	{
		return new Vector3();
	}

	[Address(RVA="0x11121CC", Offset="0x11121CC", VA="0x11121CC")]
	public static Vector2Int WorldToGrid(Vector2 worldPos)
	{
		return new Vector2Int();
	}

	[Address(RVA="0x1112284", Offset="0x1112284", VA="0x1112284")]
	public static Vector2Int WorldToGrid(Vector3 worldPos)
	{
		return new Vector2Int();
	}
}