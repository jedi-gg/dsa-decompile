using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PvpRankRewardsViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PvpRankRewardsView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x2C2BCC0", Offset="0x2C2BCC0", VA="0x2C2BCC0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x2C2BCC8", Offset="0x2C2BCC8", VA="0x2C2BCC8")]
	public PvpRankRewardsViewMonoBehaviour()
	{
	}
}