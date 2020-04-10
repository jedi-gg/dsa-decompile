using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubDungeonPlayersPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubDungeonPlayersPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11B3504", Offset="0x11B3504", VA="0x11B3504", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11B350C", Offset="0x11B350C", VA="0x11B350C")]
	public ClubDungeonPlayersPopupViewMonoBehaviour()
	{
	}
}