using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubInvitePopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubInvitePopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11BFBF4", Offset="0x11BFBF4", VA="0x11BFBF4", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11BFBFC", Offset="0x11BFBFC", VA="0x11BFBFC")]
	public ClubInvitePopupViewMonoBehaviour()
	{
	}
}