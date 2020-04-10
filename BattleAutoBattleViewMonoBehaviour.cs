using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleAutoBattleViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleAutoBattleView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1135B94", Offset="0x1135B94", VA="0x1135B94", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1135B9C", Offset="0x1135B9C", VA="0x1135B9C")]
	public BattleAutoBattleViewMonoBehaviour()
	{
	}
}