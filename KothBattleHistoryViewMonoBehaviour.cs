using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class KothBattleHistoryViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private KothBattleHistoryView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11CAC6C", Offset="0x11CAC6C", VA="0x11CAC6C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11CAC74", Offset="0x11CAC74", VA="0x11CAC74")]
	public KothBattleHistoryViewMonoBehaviour()
	{
	}
}