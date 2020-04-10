using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubDungeonDoorSelectViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubDungeonDoorSelectView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11AEA28", Offset="0x11AEA28", VA="0x11AEA28", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11AEA30", Offset="0x11AEA30", VA="0x11AEA30")]
	public ClubDungeonDoorSelectViewMonoBehaviour()
	{
	}
}