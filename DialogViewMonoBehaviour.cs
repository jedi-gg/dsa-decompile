using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class DialogViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ADialogView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1203F6C", Offset="0x1203F6C", VA="0x1203F6C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1203F74", Offset="0x1203F74", VA="0x1203F74")]
	public DialogViewMonoBehaviour()
	{
	}
}