using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PlayerProfileViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PlayerProfileView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x13443C8", Offset="0x13443C8", VA="0x13443C8", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x13443D0", Offset="0x13443D0", VA="0x13443D0")]
	public PlayerProfileViewMonoBehaviour()
	{
	}
}