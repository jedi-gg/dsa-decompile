using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ClubWarSquadRosterPopupView : APopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x10574F8", Offset="0x10574F8")]
	[FieldOffset(Offset="0x68")]
	private ClubWarDomainController _clubWarDc;

	[Attribute(Name="InjectAttribute", RVA="0x1057508", Offset="0x1057508")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDc;

	[FieldOffset(Offset="0x78")]
	private List<ClubWarSquad> _squads;

	[FieldOffset(Offset="0x80")]
	private Sequence _showSequence;

	[FieldOffset(Offset="0x88")]
	private ClubWarSquadRosterPopupController.ActionMode _actionMode;

	[FieldOffset(Offset="0x8C")]
	private bool _allowCreateSquad;

	private ClubWarSquadRosterPopupView.SerializedFields Fields
	{
		[Address(RVA="0x14E1780", Offset="0x14E1780", VA="0x14E1780")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14E1E88", Offset="0x14E1E88", VA="0x14E1E88")]
	public ClubWarSquadRosterPopupView()
	{
	}

	[Address(RVA="0x14E1B94", Offset="0x14E1B94", VA="0x14E1B94")]
	private void BindSquadListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x14DF384", Offset="0x14DF384", VA="0x14DF384")]
	public void EnableCreateSquad(bool enable)
	{
	}

	[Address(RVA="0x14E1E04", Offset="0x14E1E04", VA="0x14E1E04")]
	private void FilterToggleChanged(bool isOn)
	{
	}

	[Address(RVA="0x14E1AC8", Offset="0x14E1AC8", VA="0x14E1AC8")]
	private void InitSquadListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x14DF6A4", Offset="0x14DF6A4", VA="0x14DF6A4")]
	public void SetHeader(string text)
	{
	}

	[Address(RVA="0x14DF390", Offset="0x14DF390", VA="0x14DF390")]
	public void SetSquadRoster(bool filterOn, IReadOnlyList<ClubWarSquad> squads, ClubWarSquadRosterPopupController.ActionMode actionMode)
	{
	}

	[Address(RVA="0x14E1860", Offset="0x14E1860", VA="0x14E1860", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x14E1A84", Offset="0x14E1A84", VA="0x14E1A84", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x14E19DC", Offset="0x14E19DC", VA="0x14E19DC", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect SquadsScrollRect;

		[FieldOffset(Offset="0x38")]
		public CanvasGroup WindowRoot;

		[FieldOffset(Offset="0x40")]
		public UiLabel HeaderLabel;

		[FieldOffset(Offset="0x48")]
		public ToggleEx FilterToggle;

		[Address(RVA="0x14E1EF8", Offset="0x14E1EF8", VA="0x14E1EF8")]
		public SerializedFields()
		{
		}
	}
}