using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PassportSeasonPreviewViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PassportSeasonPreviewView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x140762C", Offset="0x140762C", VA="0x140762C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1407634", Offset="0x1407634", VA="0x1407634")]
	public PassportSeasonPreviewViewMonoBehaviour()
	{
	}
}