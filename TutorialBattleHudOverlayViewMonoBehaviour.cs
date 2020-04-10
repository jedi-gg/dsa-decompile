using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class TutorialBattleHudOverlayViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private TutorialBattleHudOverlayView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x143D378", Offset="0x143D378", VA="0x143D378", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x143D380", Offset="0x143D380", VA="0x143D380")]
	public TutorialBattleHudOverlayViewMonoBehaviour()
	{
	}
}