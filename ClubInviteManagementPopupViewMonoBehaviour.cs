using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubInviteManagementPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubInviteManagementPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11BEE2C", Offset="0x11BEE2C", VA="0x11BEE2C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11BEE34", Offset="0x11BEE34", VA="0x11BEE34")]
	public ClubInviteManagementPopupViewMonoBehaviour()
	{
	}
}