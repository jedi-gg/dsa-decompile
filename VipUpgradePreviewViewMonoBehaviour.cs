using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class VipUpgradePreviewViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private VipUpgradePreviewView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x15A4C88", Offset="0x15A4C88", VA="0x15A4C88", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x15A4C90", Offset="0x15A4C90", VA="0x15A4C90")]
	public VipUpgradePreviewViewMonoBehaviour()
	{
	}
}