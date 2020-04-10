using Gamedata.Json;
using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="ExecuteInEditMode", RVA="0x10487A8", Offset="0x10487A8")]
public class BattleMapEditableData : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	private readonly static Color GIZMO_MAP_COLOR;

	[FieldOffset(Offset="0x10")]
	private readonly static Color GIZMO_OBSTRUCTION_COLOR;

	[Attribute(Name="HideInInspector", RVA="0x1054A7C", Offset="0x1054A7C")]
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private string _battleMapId;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private BattleMap _battleMap;

	public BattleMap Map
	{
		[Address(RVA="0x1111B5C", Offset="0x1111B5C", VA="0x1111B5C")]
		get
		{
			return null;
		}
	}

	public string MapId
	{
		[Address(RVA="0x1111B54", Offset="0x1111B54", VA="0x1111B54")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11120E8", Offset="0x11120E8", VA="0x11120E8")]
	static BattleMapEditableData()
	{
	}

	[Address(RVA="0x11120E0", Offset="0x11120E0", VA="0x11120E0")]
	public BattleMapEditableData()
	{
	}

	[Address(RVA="0x1111BDC", Offset="0x1111BDC", VA="0x1111BDC")]
	private void Awake()
	{
	}

	[Address(RVA="0x1111BE4", Offset="0x1111BE4", VA="0x1111BE4")]
	private void OnDrawGizmos()
	{
	}

	[Address(RVA="0x1111BA0", Offset="0x1111BA0", VA="0x1111BA0")]
	public void SetMapData(BattleMap map)
	{
	}
}