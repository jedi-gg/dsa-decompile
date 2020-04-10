using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class KothLobbyViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private KothLobbyView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11D58F4", Offset="0x11D58F4", VA="0x11D58F4", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11D58FC", Offset="0x11D58FC", VA="0x11D58FC")]
	public KothLobbyViewMonoBehaviour()
	{
	}
}