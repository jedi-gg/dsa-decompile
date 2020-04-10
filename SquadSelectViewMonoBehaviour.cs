using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class SquadSelectViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private SquadSelectView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1227254", Offset="0x1227254", VA="0x1227254", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x122725C", Offset="0x122725C", VA="0x122725C")]
	public SquadSelectViewMonoBehaviour()
	{
	}
}