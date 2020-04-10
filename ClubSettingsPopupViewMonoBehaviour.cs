using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubSettingsPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubSettingsPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1267938", Offset="0x1267938", VA="0x1267938", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1267940", Offset="0x1267940", VA="0x1267940")]
	public ClubSettingsPopupViewMonoBehaviour()
	{
	}
}