using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubWarRewardsPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubWarRewardsPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x14DADC0", Offset="0x14DADC0", VA="0x14DADC0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14DADC8", Offset="0x14DADC8", VA="0x14DADC8")]
	public ClubWarRewardsPopupViewMonoBehaviour()
	{
	}
}