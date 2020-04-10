using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PassportSeasonTabViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PassportSeasonTabView.PassportSeasonTabSerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1408BB0", Offset="0x1408BB0", VA="0x1408BB0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1408BB8", Offset="0x1408BB8", VA="0x1408BB8")]
	public PassportSeasonTabViewMonoBehaviour()
	{
	}
}