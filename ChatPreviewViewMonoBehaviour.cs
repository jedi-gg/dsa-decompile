using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ChatPreviewViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ChatPreviewView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11A0BA8", Offset="0x11A0BA8", VA="0x11A0BA8", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11A0BB0", Offset="0x11A0BB0", VA="0x11A0BB0")]
	public ChatPreviewViewMonoBehaviour()
	{
	}
}