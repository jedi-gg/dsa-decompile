using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class MiniAbilityDetailsListItem : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x20")]
	private int _abilityIndex;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private AbilityCardWidget _abilityCardWidget;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private RectTransform _offsetContainer;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private Vector3 _selectedOffsetPosition;

	[FieldOffset(Offset="0x4C")]
	[SerializeField]
	private Vector3 _selectedOffsetScale;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private GameObject _selectedIcon;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private GameObject _lockedIcon;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private GameObject _leaderIcon;

	[Address(RVA="0x12F2814", Offset="0x12F2814", VA="0x12F2814")]
	public MiniAbilityDetailsListItem()
	{
	}

	[Address(RVA="0x12F2790", Offset="0x12F2790", VA="0x12F2790")]
	private void ButtonClicked()
	{
	}

	[Address(RVA="0x12F21E8", Offset="0x12F21E8", VA="0x12F21E8")]
	public void Initialize(WidgetDependencyContainer dependencies, int abilityIndex)
	{
	}

	[Address(RVA="0x12F234C", Offset="0x12F234C", VA="0x12F234C")]
	public void SetAbility(UnitAbility ability, ulong abilityLevel)
	{
	}

	[Address(RVA="0x12F2634", Offset="0x12F2634", VA="0x12F2634")]
	public void SetSelected(bool selected)
	{
	}

	[Address(RVA="0x12F24D0", Offset="0x12F24D0", VA="0x12F24D0")]
	public void SetSpell(Spell spell, ulong spellLevel)
	{
	}

	[Address(RVA="0x12F22DC", Offset="0x12F22DC", VA="0x12F22DC")]
	public void Shutdown()
	{
	}
}