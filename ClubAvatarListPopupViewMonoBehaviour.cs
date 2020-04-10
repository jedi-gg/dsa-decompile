using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubAvatarListPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubAvatarListPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x146871C", Offset="0x146871C", VA="0x146871C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1468724", Offset="0x1468724", VA="0x1468724")]
	public ClubAvatarListPopupViewMonoBehaviour()
	{
	}
}