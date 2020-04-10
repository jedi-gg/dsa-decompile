using Gamedata;
using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class SpellListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	protected DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x30")]
	protected SingleAssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x38")]
	protected LocalizationManager _lm;

	[FieldOffset(Offset="0x40")]
	protected ulong _spellDefinitionId;

	[FieldOffset(Offset="0x48")]
	protected object _ownerIdentifier;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	protected AudioClipGroup _clickAudioClipGroup;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	protected Button _clickHandler;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	protected RawImage _spellImage;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	protected UiLabel _levelPrefixLabel;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	protected UiLabel _levelLabel;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	protected GameObject _selectedState;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	protected Image _bottomPartFill;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	protected GameObject _activeBonusContainer;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	protected GameObject _ineligibleContainer;

	[Address(RVA="0x1242038", Offset="0x1242038", VA="0x1242038")]
	public SpellListItem()
	{
	}

	[Address(RVA="0x1241948", Offset="0x1241948", VA="0x1241948", Slot="7")]
	public virtual void Initialize(WidgetDependencyContainer dependencies, object ownerIdentifier)
	{
	}

	[Address(RVA="0x1242B30", Offset="0x1242B30", VA="0x1242B30")]
	private void ListItemClicked()
	{
	}

	[Address(RVA="0x12428A0", Offset="0x12428A0", VA="0x12428A0")]
	public void SetActiveBonusEnabled(bool enabled)
	{
	}

	[Address(RVA="0x1241E70", Offset="0x1241E70", VA="0x1241E70")]
	public void SetBottomPartFillAmount(float fillAmount)
	{
	}

	[Address(RVA="0x12427EC", Offset="0x12427EC", VA="0x12427EC")]
	public void SetEligible(bool eligible)
	{
	}

	[Address(RVA="0x124273C", Offset="0x124273C", VA="0x124273C")]
	public void SetSelected(bool selected)
	{
	}

	[Address(RVA="0x1242950", Offset="0x1242950", VA="0x1242950")]
	public void SetSpell(Serverproto.Spell spell)
	{
	}

	[Address(RVA="0x1242A04", Offset="0x1242A04", VA="0x1242A04")]
	public void SetSpell(Gamedata.Spell spellDef)
	{
	}

	[Address(RVA="0x1241F7C", Offset="0x1241F7C", VA="0x1241F7C", Slot="9")]
	protected virtual void SetSpellDefinitionData(Gamedata.Spell spellDef)
	{
	}

	[Address(RVA="0x1241DD8", Offset="0x1241DD8", VA="0x1241DD8", Slot="8")]
	protected virtual void SetSpellInstanceData(Serverproto.Spell spell, Gamedata.Spell spellDef)
	{
	}

	[Address(RVA="0x1242A68", Offset="0x1242A68", VA="0x1242A68")]
	public void ShowBottomPartFill(bool showing)
	{
	}

	[Address(RVA="0x1241B44", Offset="0x1241B44", VA="0x1241B44", Slot="4")]
	public override void Shutdown()
	{
	}
}