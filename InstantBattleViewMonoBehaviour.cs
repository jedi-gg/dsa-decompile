using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class InstantBattleViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private InstantBattleView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x136BA7C", Offset="0x136BA7C", VA="0x136BA7C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x136BA84", Offset="0x136BA84", VA="0x136BA84")]
	public InstantBattleViewMonoBehaviour()
	{
	}
}