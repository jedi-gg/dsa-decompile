using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubWarNodePopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubWarNodePopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x14D796C", Offset="0x14D796C", VA="0x14D796C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14D7974", Offset="0x14D7974", VA="0x14D7974")]
	public ClubWarNodePopupViewMonoBehaviour()
	{
	}
}