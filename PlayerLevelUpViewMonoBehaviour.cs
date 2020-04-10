using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PlayerLevelUpViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PlayerLevelUpView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x133CB8C", Offset="0x133CB8C", VA="0x133CB8C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x133CB94", Offset="0x133CB94", VA="0x133CB94")]
	public PlayerLevelUpViewMonoBehaviour()
	{
	}
}