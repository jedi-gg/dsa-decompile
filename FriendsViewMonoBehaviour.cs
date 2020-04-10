using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class FriendsViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private FriendsView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x15EA42C", Offset="0x15EA42C", VA="0x15EA42C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x15EA434", Offset="0x15EA434", VA="0x15EA434")]
	public FriendsViewMonoBehaviour()
	{
	}
}