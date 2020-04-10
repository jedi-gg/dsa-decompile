using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SavedSquadListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	protected LocalizationManager _lm;

	[FieldOffset(Offset="0x30")]
	protected GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x38")]
	protected PlayerDomainController _playerDc;

	[FieldOffset(Offset="0x40")]
	protected DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x48")]
	private object _ownerIdentifier;

	[FieldOffset(Offset="0x50")]
	private int _squadSlot;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private GameObject _squadInfoContainer;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private List<ClubWarUnitListItem> _units;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private List<SpellListItem> _spells;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private LabelButton _loadButton;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private LabelButton _saveButton;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private GameObject _vipRoot;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private Button _vipButton;

	[Address(RVA="0x2C3D6C0", Offset="0x2C3D6C0", VA="0x2C3D6C0")]
	public SavedSquadListItem()
	{
	}

	[Address(RVA="0x2C3D6C8", Offset="0x2C3D6C8", VA="0x2C3D6C8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10707B4", Offset="0x10707B4")]
	private void <Initialize>b__0_0()
	{
	}

	[Address(RVA="0x2C3D6D0", Offset="0x2C3D6D0", VA="0x2C3D6D0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10707C4", Offset="0x10707C4")]
	private void <Initialize>b__0_1()
	{
	}

	[Address(RVA="0x2C3D6D8", Offset="0x2C3D6D8", VA="0x2C3D6D8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10707D4", Offset="0x10707D4")]
	private void <Initialize>b__0_2()
	{
	}

	[Address(RVA="0x2C3D618", Offset="0x2C3D618", VA="0x2C3D618")]
	private void Dispatch(DSavedSquadListItemAction.Type actionType)
	{
	}

	[Address(RVA="0x2C3C9F0", Offset="0x2C3C9F0", VA="0x2C3C9F0", Slot="7")]
	public virtual void Initialize(WidgetDependencyContainer dependencies, object ownerIdentifier)
	{
	}

	[Address(RVA="0x2C3D1B4", Offset="0x2C3D1B4", VA="0x2C3D1B4")]
	public void SetSquadData(PlayerSquadSelection squadData, int squadSlot, bool vipSlot)
	{
	}

	[Address(RVA="0x2C3CEEC", Offset="0x2C3CEEC", VA="0x2C3CEEC", Slot="4")]
	public override void Shutdown()
	{
	}
}