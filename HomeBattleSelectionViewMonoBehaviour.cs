using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class HomeBattleSelectionViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private HomeBattleSelectionView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x12EAA54", Offset="0x12EAA54", VA="0x12EAA54", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12EAA5C", Offset="0x12EAA5C", VA="0x12EAA5C")]
	public HomeBattleSelectionViewMonoBehaviour()
	{
	}
}