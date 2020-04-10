using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattlePlayerHandViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattlePlayerHandView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x128AD64", Offset="0x128AD64", VA="0x128AD64", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x128AD6C", Offset="0x128AD6C", VA="0x128AD6C")]
	public BattlePlayerHandViewMonoBehaviour()
	{
	}
}