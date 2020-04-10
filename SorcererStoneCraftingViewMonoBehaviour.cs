using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class SorcererStoneCraftingViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private SorcererStoneCraftingView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x123C730", Offset="0x123C730", VA="0x123C730", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x123C738", Offset="0x123C738", VA="0x123C738")]
	public SorcererStoneCraftingViewMonoBehaviour()
	{
	}
}