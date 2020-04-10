using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PvpLobbyViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PvpLobbyView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1288924", Offset="0x1288924", VA="0x1288924", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x128892C", Offset="0x128892C", VA="0x128892C")]
	public PvpLobbyViewMonoBehaviour()
	{
	}
}