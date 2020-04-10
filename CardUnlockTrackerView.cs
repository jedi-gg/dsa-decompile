using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardUnlockTrackerView : APopupView, IDispatchHandler<DUnitListItemAction>, IDispatchHandler, IDispatchHandler<DSpellListItemAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x10559B8", Offset="0x10559B8")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x70")]
	private List<UnitListItem> _unitListItems;

	[FieldOffset(Offset="0x78")]
	private List<SpellListItem> _spellListItems;

	[FieldOffset(Offset="0x80")]
	private ulong _selectedUnitId;

	[FieldOffset(Offset="0x88")]
	private ulong _selectedSpellId;

	private CardUnlockTrackerView.SerializedFields Fields
	{
		[Address(RVA="0x1195BD0", Offset="0x1195BD0", VA="0x1195BD0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1196810", Offset="0x1196810", VA="0x1196810")]
	public CardUnlockTrackerView()
	{
	}

	[Address(RVA="0x1196788", Offset="0x1196788", VA="0x1196788")]
	private void CloseClicked()
	{
	}

	[Address(RVA="0x11966E0", Offset="0x11966E0", VA="0x11966E0")]
	private void GoClicked()
	{
	}

	[Address(RVA="0x11961A0", Offset="0x11961A0", VA="0x11961A0", Slot="22")]
	public void HandleDispatchAction(DUnitListItemAction action)
	{
	}

	[Address(RVA="0x11961B8", Offset="0x11961B8", VA="0x11961B8", Slot="23")]
	public void HandleDispatchAction(DSpellListItemAction action)
	{
	}

	[Address(RVA="0x1195F28", Offset="0x1195F28", VA="0x1195F28")]
	private void SelectSpell(ulong spellDefId)
	{
	}

	[Address(RVA="0x1195CB0", Offset="0x1195CB0", VA="0x1195CB0")]
	private void SelectUnit(ulong unitDefId)
	{
	}

	[Address(RVA="0x11954E0", Offset="0x11954E0", VA="0x11954E0")]
	public void SetData(List<ulong> unitDefIds, List<ulong> spellDefIds)
	{
	}

	[Address(RVA="0x11961C8", Offset="0x11961C8", VA="0x11961C8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11963C8", Offset="0x11963C8", VA="0x11963C8", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x1069E5C", Offset="0x1069E5C")]
		[FieldOffset(Offset="0x30")]
		public UnitListItem UnitListItem;

		[FieldOffset(Offset="0x38")]
		public SpellListItem SpellListItem;

		[FieldOffset(Offset="0x40")]
		public Transform ScrollListItemParent;

		[FieldOffset(Offset="0x48")]
		public Button GoButton;

		[FieldOffset(Offset="0x50")]
		public Button CloseButton;

		[FieldOffset(Offset="0x58")]
		public UiLabel CardNameLabel;

		[FieldOffset(Offset="0x60")]
		public UiLabel TitleLabel;

		[Address(RVA="0x1196818", Offset="0x1196818", VA="0x1196818")]
		public SerializedFields()
		{
		}
	}
}