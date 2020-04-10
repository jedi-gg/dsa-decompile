using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleAbilityCardWidgetBuffStatusOverlay : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private GameObject _critChanceUpOverlay;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private GameObject _critChanceDownOverlay;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private GameObject _critPowerUpOverlay;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private GameObject _critPowerDownOverlay;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private GameObject _offenseUpOverlay;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private GameObject _offenseDownOverlay;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private GameObject _tacticsOverlay;

	[Address(RVA="0x116744C", Offset="0x116744C", VA="0x116744C")]
	public BattleAbilityCardWidgetBuffStatusOverlay()
	{
	}

	[Address(RVA="0x116645C", Offset="0x116645C", VA="0x116645C")]
	public void SetBuffStatus(AbilityBuffStatus buffStatus)
	{
	}
}