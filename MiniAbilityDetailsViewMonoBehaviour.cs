using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class MiniAbilityDetailsViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private MiniAbilityDetailsView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x12F3498", Offset="0x12F3498", VA="0x12F3498", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12F34A0", Offset="0x12F34A0", VA="0x12F34A0")]
	public MiniAbilityDetailsViewMonoBehaviour()
	{
	}
}