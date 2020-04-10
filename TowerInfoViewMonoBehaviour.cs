using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class TowerInfoViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private TowerInfoView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x14369F4", Offset="0x14369F4", VA="0x14369F4", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14369FC", Offset="0x14369FC", VA="0x14369FC")]
	public TowerInfoViewMonoBehaviour()
	{
	}
}