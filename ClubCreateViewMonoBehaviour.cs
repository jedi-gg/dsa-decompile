using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubCreateViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubCreateView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x146A8A0", Offset="0x146A8A0", VA="0x146A8A0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x146A8A8", Offset="0x146A8A8", VA="0x146A8A8")]
	public ClubCreateViewMonoBehaviour()
	{
	}
}