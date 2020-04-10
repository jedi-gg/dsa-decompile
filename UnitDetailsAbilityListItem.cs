using Gamedata;
using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class UnitDetailsAbilityListItem : WrappedScrollRectListItem, IPointerClickHandler, IEventSystemHandler
{
	[FieldOffset(Offset="0x28")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x30")]
	private BadgingController _badgingController;

	[FieldOffset(Offset="0x38")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x40")]
	private UnitAbility? _abilityDef;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private AbilityCardWidget _abilityCardWidget;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private UiLabel _abilityLevelLabel;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private UiLabel _abilityTypeLabel;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private UiLabel _abilityNameLabel;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private GameObject _abilityLockedContainer;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private Badge _badge;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private AudioClipGroup _clickAudio;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private GameObject _leaderContainer;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private GameObject _celebrationRoot;

	[Address(RVA="0x11DF66C", Offset="0x11DF66C", VA="0x11DF66C")]
	public UnitDetailsAbilityListItem()
	{
	}

	[Address(RVA="0x11DF088", Offset="0x11DF088", VA="0x11DF088")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x11DF560", Offset="0x11DF560", VA="0x11DF560", Slot="7")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Address(RVA="0x11DF558", Offset="0x11DF558", VA="0x11DF558")]
	public void PlayUnlockCelebration()
	{
	}

	[Address(RVA="0x11DDDFC", Offset="0x11DDDFC", VA="0x11DDDFC")]
	public void SetAbility(UnitAbility? ability, ulong abilityLevel, ulong unitDefId)
	{
	}

	[Address(RVA="0x11DF298", Offset="0x11DF298", VA="0x11DF298")]
	public void SetAbility(Spell? spell, ulong abilityLevel)
	{
	}

	[Address(RVA="0x11DF174", Offset="0x11DF174", VA="0x11DF174")]
	private void ShowCelebration(bool show)
	{
	}

	[Address(RVA="0x11DF224", Offset="0x11DF224", VA="0x11DF224", Slot="4")]
	public override void Shutdown()
	{
	}
}