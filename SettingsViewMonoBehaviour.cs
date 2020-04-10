using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class SettingsViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private SettingsView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x14BAAEC", Offset="0x14BAAEC", VA="0x14BAAEC", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14BAAF4", Offset="0x14BAAF4", VA="0x14BAAF4")]
	public SettingsViewMonoBehaviour()
	{
	}
}