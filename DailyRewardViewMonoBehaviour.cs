using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class DailyRewardViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private DailyRewardView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11FFEFC", Offset="0x11FFEFC", VA="0x11FFEFC", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11FFF04", Offset="0x11FFF04", VA="0x11FFF04")]
	public DailyRewardViewMonoBehaviour()
	{
	}
}