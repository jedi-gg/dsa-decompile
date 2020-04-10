using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BackdropScrimViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BackdropScrimView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x115F520", Offset="0x115F520", VA="0x115F520", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x115F528", Offset="0x115F528", VA="0x115F528")]
	public BackdropScrimViewMonoBehaviour()
	{
	}
}