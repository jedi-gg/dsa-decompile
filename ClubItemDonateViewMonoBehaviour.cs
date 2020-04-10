using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubItemDonateViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubItemDonateView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x12593E4", Offset="0x12593E4", VA="0x12593E4", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12593EC", Offset="0x12593EC", VA="0x12593EC")]
	public ClubItemDonateViewMonoBehaviour()
	{
	}
}