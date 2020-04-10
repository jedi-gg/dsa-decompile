using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PassportSeasonActivitiesViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PassportSeasonActivitiesView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x13FB4E8", Offset="0x13FB4E8", VA="0x13FB4E8", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x13FB4F0", Offset="0x13FB4F0", VA="0x13FB4F0")]
	public PassportSeasonActivitiesViewMonoBehaviour()
	{
	}
}