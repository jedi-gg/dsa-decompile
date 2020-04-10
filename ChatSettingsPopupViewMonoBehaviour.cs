using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ChatSettingsPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ChatSettingsPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11A215C", Offset="0x11A215C", VA="0x11A215C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11A2164", Offset="0x11A2164", VA="0x11A2164")]
	public ChatSettingsPopupViewMonoBehaviour()
	{
	}
}