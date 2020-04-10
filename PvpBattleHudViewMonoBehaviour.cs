using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PvpBattleHudViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PvpBattleHudView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1282BC4", Offset="0x1282BC4", VA="0x1282BC4", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1282BCC", Offset="0x1282BCC", VA="0x1282BCC")]
	public PvpBattleHudViewMonoBehaviour()
	{
	}
}