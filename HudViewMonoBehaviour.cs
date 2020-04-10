using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class HudViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private HudView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x117C7A4", Offset="0x117C7A4", VA="0x117C7A4", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x117C7AC", Offset="0x117C7AC", VA="0x117C7AC")]
	public HudViewMonoBehaviour()
	{
	}
}