using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleMenuViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleMenuView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11132B8", Offset="0x11132B8", VA="0x11132B8", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11132C0", Offset="0x11132C0", VA="0x11132C0")]
	public BattleMenuViewMonoBehaviour()
	{
	}
}