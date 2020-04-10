using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PvpLeaderboardPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PvpLeaderboardPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1286848", Offset="0x1286848", VA="0x1286848", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1286850", Offset="0x1286850", VA="0x1286850")]
	public PvpLeaderboardPopupViewMonoBehaviour()
	{
	}
}