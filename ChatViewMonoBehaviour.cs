using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ChatViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ChatView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11A3DB8", Offset="0x11A3DB8", VA="0x11A3DB8", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11A3DC0", Offset="0x11A3DC0", VA="0x11A3DC0")]
	public ChatViewMonoBehaviour()
	{
	}
}