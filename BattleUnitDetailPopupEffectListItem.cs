using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnitDetailPopupEffectListItem : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private Image _icon;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private UiLabel _label;

	[Address(RVA="0x129E56C", Offset="0x129E56C", VA="0x129E56C")]
	public BattleUnitDetailPopupEffectListItem()
	{
	}

	[Address(RVA="0x129E49C", Offset="0x129E49C", VA="0x129E49C")]
	public void SetData(BattleBuffIconUiDatum datum, string text)
	{
	}
}