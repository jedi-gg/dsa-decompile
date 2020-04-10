using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class AgeGateNameViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private AgeGateNameView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1158BA0", Offset="0x1158BA0", VA="0x1158BA0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1158BA8", Offset="0x1158BA8", VA="0x1158BA8")]
	public AgeGateNameViewMonoBehaviour()
	{
	}
}