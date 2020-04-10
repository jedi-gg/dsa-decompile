using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class AdRewardViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private AdRewardView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1157504", Offset="0x1157504", VA="0x1157504", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x115750C", Offset="0x115750C", VA="0x115750C")]
	public AdRewardViewMonoBehaviour()
	{
	}
}