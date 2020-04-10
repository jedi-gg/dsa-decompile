using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PassportSeasonUpgradePreviewViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PassportSeasonUpgradePreviewView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1409BA0", Offset="0x1409BA0", VA="0x1409BA0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1409BA8", Offset="0x1409BA8", VA="0x1409BA8")]
	public PassportSeasonUpgradePreviewViewMonoBehaviour()
	{
	}
}