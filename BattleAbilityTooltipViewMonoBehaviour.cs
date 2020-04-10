using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleAbilityTooltipViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleAbilityTooltipView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1168444", Offset="0x1168444", VA="0x1168444", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x116844C", Offset="0x116844C", VA="0x116844C")]
	public BattleAbilityTooltipViewMonoBehaviour()
	{
	}
}