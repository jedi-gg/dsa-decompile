using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class InboxMessagePopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private InboxMessagePopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1180D88", Offset="0x1180D88", VA="0x1180D88", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1180D90", Offset="0x1180D90", VA="0x1180D90")]
	public InboxMessagePopupViewMonoBehaviour()
	{
	}
}