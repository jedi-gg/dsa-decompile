using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PlayerCollectionPowerViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PlayerCollectionPowerView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x132F8E0", Offset="0x132F8E0", VA="0x132F8E0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x132F8E8", Offset="0x132F8E8", VA="0x132F8E8")]
	public PlayerCollectionPowerViewMonoBehaviour()
	{
	}
}