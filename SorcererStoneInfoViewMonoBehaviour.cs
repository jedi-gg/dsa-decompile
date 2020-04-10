using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class SorcererStoneInfoViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private SorcererStoneInfoView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x123CA48", Offset="0x123CA48", VA="0x123CA48", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x123CA50", Offset="0x123CA50", VA="0x123CA50")]
	public SorcererStoneInfoViewMonoBehaviour()
	{
	}
}