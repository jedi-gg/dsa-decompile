using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class InboxViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private InboxView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1184C6C", Offset="0x1184C6C", VA="0x1184C6C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1184C74", Offset="0x1184C74", VA="0x1184C74")]
	public InboxViewMonoBehaviour()
	{
	}
}