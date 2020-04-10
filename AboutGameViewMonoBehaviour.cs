using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class AboutGameViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private AboutGameView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x115514C", Offset="0x115514C", VA="0x115514C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1155154", Offset="0x1155154", VA="0x1155154")]
	public AboutGameViewMonoBehaviour()
	{
	}
}