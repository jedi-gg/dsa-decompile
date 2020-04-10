using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class UnitPromotionCelebrationViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UnitPromotionCelebrationView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x150C470", Offset="0x150C470", VA="0x150C470", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x150C478", Offset="0x150C478", VA="0x150C478")]
	public UnitPromotionCelebrationViewMonoBehaviour()
	{
	}
}