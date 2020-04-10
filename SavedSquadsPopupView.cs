using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class SavedSquadsPopupView : APopupView
{
	[FieldOffset(Offset="0x68")]
	private List<PlayerSquadSelection> _squads;

	[FieldOffset(Offset="0x70")]
	private Sequence _showSequence;

	[FieldOffset(Offset="0x78")]
	private object _ownerIdentifier;

	[FieldOffset(Offset="0x80")]
	private uint _numFreeSquads;

	private SavedSquadsPopupView.SerializedFields Fields
	{
		[Address(RVA="0x2C3E440", Offset="0x2C3E440", VA="0x2C3E440")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x2C3E904", Offset="0x2C3E904", VA="0x2C3E904")]
	public SavedSquadsPopupView()
	{
	}

	[Address(RVA="0x2C3E7B8", Offset="0x2C3E7B8", VA="0x2C3E7B8")]
	private void BindSquadListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x2C3E6E8", Offset="0x2C3E6E8", VA="0x2C3E6E8")]
	private void InitSquadListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x2C3E3D0", Offset="0x2C3E3D0", VA="0x2C3E3D0")]
	public void SetDispatchOwner(object owner)
	{
	}

	[Address(RVA="0x2C3E128", Offset="0x2C3E128", VA="0x2C3E128")]
	public void SetSquads(List<PlayerSquadSelection> squads, uint numFreeSquads)
	{
	}

	[Address(RVA="0x2C3E520", Offset="0x2C3E520", VA="0x2C3E520", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x2C3E6A4", Offset="0x2C3E6A4", VA="0x2C3E6A4", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x2C3E628", Offset="0x2C3E628", VA="0x2C3E628", Slot="12")]
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

		[Address(RVA="0x2C3E974", Offset="0x2C3E974", VA="0x2C3E974")]
		public SerializedFields()
		{
		}
	}
}