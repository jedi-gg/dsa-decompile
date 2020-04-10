using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;

public class BattleGridComponent : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private PlayableDirector _encounterStart;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private PlayableDirector _encounterEnd;

	[Address(RVA="0x11488F4", Offset="0x11488F4", VA="0x11488F4")]
	public BattleGridComponent()
	{
	}

	[Address(RVA="0x11487B8", Offset="0x11487B8", VA="0x11487B8")]
	public void PlayEncounterEnd()
	{
	}

	[Address(RVA="0x1148678", Offset="0x1148678", VA="0x1148678")]
	public void PlayEncounterStart()
	{
	}
}