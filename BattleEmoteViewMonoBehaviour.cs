using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleEmoteViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleEmoteView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1143644", Offset="0x1143644", VA="0x1143644", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x114364C", Offset="0x114364C", VA="0x114364C")]
	public BattleEmoteViewMonoBehaviour()
	{
	}
}