using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class SocialTabViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private SocialTabView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1236C18", Offset="0x1236C18", VA="0x1236C18", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1236C20", Offset="0x1236C20", VA="0x1236C20")]
	public SocialTabViewMonoBehaviour()
	{
	}
}