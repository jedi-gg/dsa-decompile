using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleFlyingAlertTextViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleFlyingAlertTextView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x114637C", Offset="0x114637C", VA="0x114637C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1146384", Offset="0x1146384", VA="0x1146384")]
	public BattleFlyingAlertTextViewMonoBehaviour()
	{
	}
}