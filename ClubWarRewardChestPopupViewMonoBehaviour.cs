using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubWarRewardChestPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubWarRewardChestPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x14D876C", Offset="0x14D876C", VA="0x14D876C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14D8774", Offset="0x14D8774", VA="0x14D8774")]
	public ClubWarRewardChestPopupViewMonoBehaviour()
	{
	}
}