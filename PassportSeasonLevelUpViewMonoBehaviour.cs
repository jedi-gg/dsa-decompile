using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PassportSeasonLevelUpViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PassportSeasonLevelUpView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x14034F0", Offset="0x14034F0", VA="0x14034F0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14034F8", Offset="0x14034F8", VA="0x14034F8")]
	public PassportSeasonLevelUpViewMonoBehaviour()
	{
	}
}