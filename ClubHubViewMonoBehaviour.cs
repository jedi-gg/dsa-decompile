using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubHubViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubHubView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11BDD84", Offset="0x11BDD84", VA="0x11BDD84", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11BDD8C", Offset="0x11BDD8C", VA="0x11BDD8C")]
	public ClubHubViewMonoBehaviour()
	{
	}
}