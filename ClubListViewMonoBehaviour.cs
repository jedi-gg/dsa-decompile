using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubListViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubListView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x125DD34", Offset="0x125DD34", VA="0x125DD34", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x125DD3C", Offset="0x125DD3C", VA="0x125DD3C")]
	public ClubListViewMonoBehaviour()
	{
	}
}