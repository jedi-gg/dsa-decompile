using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class MatchmakingPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private MatchmakingPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11DAD14", Offset="0x11DAD14", VA="0x11DAD14", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11DAD1C", Offset="0x11DAD1C", VA="0x11DAD1C")]
	public MatchmakingPopupViewMonoBehaviour()
	{
	}
}