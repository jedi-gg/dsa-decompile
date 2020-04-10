using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ClubDungeonMapWidget : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private ClubDungeonNodeWidget[] _nodes;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private ClubDungeonDoorWidget[] _doors;

	[Address(RVA="0x11B2558", Offset="0x11B2558", VA="0x11B2558")]
	public ClubDungeonMapWidget()
	{
	}

	[Address(RVA="0x11ADB34", Offset="0x11ADB34", VA="0x11ADB34")]
	public void HideOtherDoors(int doorIndex)
	{
	}

	[Address(RVA="0x11AE644", Offset="0x11AE644", VA="0x11AE644")]
	public void Initialize(Camera worldCamera, DClubDungeonNodeVisuals nodeVisuals, WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x11AE8B8", Offset="0x11AE8B8", VA="0x11AE8B8")]
	public void SetMapDoors(List<ulong> failedDoors)
	{
	}

	[Address(RVA="0x11B1D24", Offset="0x11B1D24", VA="0x11B1D24")]
	public void SetMapNodes(int mapIndex, ClubDungeonContext dungeonContext)
	{
	}

	[Address(RVA="0x11AE0D8", Offset="0x11AE0D8", VA="0x11AE0D8")]
	public void Shutdown()
	{
	}
}