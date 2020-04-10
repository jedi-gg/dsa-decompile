using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class KothRankRewardsViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private KothRankRewardsView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11D7918", Offset="0x11D7918", VA="0x11D7918", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11D7920", Offset="0x11D7920", VA="0x11D7920")]
	public KothRankRewardsViewMonoBehaviour()
	{
	}
}