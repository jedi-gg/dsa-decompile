using Gamedata;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;

public class ClubWarSceneNode : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private Renderer[] _tintableRenderers;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private string _tintPropertyName;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private UnityEngine.Color _teamAColor;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private UnityEngine.Color _teamBColor;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private UnityEngine.Color _teamCColor;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private GameObject _builtRoot;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private GameObject _rebuildingRoot;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private GameObject _midHealthRoot;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private ulong _midHealthMinDefendersDefeated;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private GameObject _lowHealthRoot;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private ulong _lowHealthMaxDefendersRemain;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private GameObject _targetRoot;

	[Address(RVA="0x14DB5FC", Offset="0x14DB5FC", VA="0x14DB5FC")]
	public ClubWarSceneNode()
	{
	}

	[Address(RVA="0x14DB5B0", Offset="0x14DB5B0", VA="0x14DB5B0")]
	private UnityEngine.Color GetColorForTeam(ClubWarTeam team)
	{
		return new UnityEngine.Color();
	}

	[Address(RVA="0x14DB158", Offset="0x14DB158", VA="0x14DB158")]
	public void SetData(Serverproto.ClubWar.Types.NodeSummary summary, bool isTargeted)
	{
	}

	private enum HealthState
	{
		[FieldOffset(Offset="0x0")]
		Full,
		[FieldOffset(Offset="0x0")]
		Mid,
		[FieldOffset(Offset="0x0")]
		Low,
		[FieldOffset(Offset="0x0")]
		Rebuilding
	}
}