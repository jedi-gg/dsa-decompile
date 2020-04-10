using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PlayerActivityChooseRewardViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PlayerActivityChooseRewardView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x132C8FC", Offset="0x132C8FC", VA="0x132C8FC", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x132C904", Offset="0x132C904", VA="0x132C904")]
	public PlayerActivityChooseRewardViewMonoBehaviour()
	{
	}
}