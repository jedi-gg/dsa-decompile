using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PackOpeningViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PackOpeningView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x130855C", Offset="0x130855C", VA="0x130855C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1308564", Offset="0x1308564", VA="0x1308564")]
	public PackOpeningViewMonoBehaviour()
	{
	}
}