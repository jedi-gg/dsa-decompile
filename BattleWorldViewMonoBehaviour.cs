using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleWorldViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleWorldView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x111EDE0", Offset="0x111EDE0", VA="0x111EDE0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x111EDE8", Offset="0x111EDE8", VA="0x111EDE8")]
	public BattleWorldViewMonoBehaviour()
	{
	}
}