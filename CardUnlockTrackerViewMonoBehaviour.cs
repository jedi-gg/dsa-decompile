using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class CardUnlockTrackerViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private CardUnlockTrackerView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1196820", Offset="0x1196820", VA="0x1196820", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1196828", Offset="0x1196828", VA="0x1196828")]
	public CardUnlockTrackerViewMonoBehaviour()
	{
	}
}