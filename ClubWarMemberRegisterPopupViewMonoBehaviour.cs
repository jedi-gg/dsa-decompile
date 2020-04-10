using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubWarMemberRegisterPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubWarMemberRegisterPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x14CFA9C", Offset="0x14CFA9C", VA="0x14CFA9C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14CFAA4", Offset="0x14CFAA4", VA="0x14CFAA4")]
	public ClubWarMemberRegisterPopupViewMonoBehaviour()
	{
	}
}