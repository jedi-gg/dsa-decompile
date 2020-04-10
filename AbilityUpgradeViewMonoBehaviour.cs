using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class AbilityUpgradeViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private AAbilityUpgradeView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1154B4C", Offset="0x1154B4C", VA="0x1154B4C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1154B54", Offset="0x1154B54", VA="0x1154B54")]
	public AbilityUpgradeViewMonoBehaviour()
	{
	}
}