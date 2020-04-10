using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PassportSeasonLevelMultiRewardViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PassportSeasonLevelMultiRewardView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x140059C", Offset="0x140059C", VA="0x140059C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14005A4", Offset="0x14005A4", VA="0x14005A4")]
	public PassportSeasonLevelMultiRewardViewMonoBehaviour()
	{
	}
}