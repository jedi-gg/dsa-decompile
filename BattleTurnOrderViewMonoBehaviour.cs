using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleTurnOrderViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleTurnOrderView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1299818", Offset="0x1299818", VA="0x1299818", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1299820", Offset="0x1299820", VA="0x1299820")]
	public BattleTurnOrderViewMonoBehaviour()
	{
	}
}