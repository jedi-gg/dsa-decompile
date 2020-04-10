using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PassportSeasonLevelsViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PassportSeasonLevelsView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1405C84", Offset="0x1405C84", VA="0x1405C84", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1405C8C", Offset="0x1405C8C", VA="0x1405C8C")]
	public PassportSeasonLevelsViewMonoBehaviour()
	{
	}
}