using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubDungeonLeaderboardPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubDungeonLeaderboardPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11B1568", Offset="0x11B1568", VA="0x11B1568", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11B1570", Offset="0x11B1570", VA="0x11B1570")]
	public ClubDungeonLeaderboardPopupViewMonoBehaviour()
	{
	}
}