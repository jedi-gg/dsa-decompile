using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class FriendsGiftCelebrationViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private FriendsGiftCelebrationView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x12CF348", Offset="0x12CF348", VA="0x12CF348", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12CF350", Offset="0x12CF350", VA="0x12CF350")]
	public FriendsGiftCelebrationViewMonoBehaviour()
	{
	}
}