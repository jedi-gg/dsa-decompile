using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubDungeonViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubDungeonView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11B6130", Offset="0x11B6130", VA="0x11B6130", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11B6138", Offset="0x11B6138", VA="0x11B6138")]
	public ClubDungeonViewMonoBehaviour()
	{
	}
}