using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class InstantBattleRewardsViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private InstantBattleRewardsView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x136B3B4", Offset="0x136B3B4", VA="0x136B3B4", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x136B3BC", Offset="0x136B3BC", VA="0x136B3BC")]
	public InstantBattleRewardsViewMonoBehaviour()
	{
	}
}