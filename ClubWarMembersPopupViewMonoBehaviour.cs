using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubWarMembersPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubWarMembersPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x14D0DC0", Offset="0x14D0DC0", VA="0x14D0DC0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14D0DC8", Offset="0x14D0DC8", VA="0x14D0DC8")]
	public ClubWarMembersPopupViewMonoBehaviour()
	{
	}
}