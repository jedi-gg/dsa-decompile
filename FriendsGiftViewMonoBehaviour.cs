using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class FriendsGiftViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private FriendsGiftView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x15E94B0", Offset="0x15E94B0", VA="0x15E94B0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x15E94B8", Offset="0x15E94B8", VA="0x15E94B8")]
	public FriendsGiftViewMonoBehaviour()
	{
	}
}