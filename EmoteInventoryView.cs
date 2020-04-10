using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmoteInventoryView : AStandardView, IDispatchHandler<DEmoteInventoryEquippedClickedAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x68")]
	private IReadOnlyList<InventoryItem?> _emotes;

	[FieldOffset(Offset="0x70")]
	private bool _equipSelectMode;

	private EmoteInventoryView.SerializedFields Fields
	{
		[Address(RVA="0x120A50C", Offset="0x120A50C", VA="0x120A50C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x120AE38", Offset="0x120AE38", VA="0x120AE38")]
	public EmoteInventoryView()
	{
	}

	[Address(RVA="0x120AA74", Offset="0x120AA74", VA="0x120AA74")]
	private void BindEmoteListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x120AE24", Offset="0x120AE24", VA="0x120AE24")]
	private void CancelEquip()
	{
	}

	[Address(RVA="0x1206F10", Offset="0x1206F10", VA="0x1206F10")]
	public void ConfigureViewForEquip()
	{
	}

	[Address(RVA="0x120A5EC", Offset="0x120A5EC", VA="0x120A5EC", Slot="21")]
	public void HandleDispatchAction(DEmoteInventoryEquippedClickedAction action)
	{
	}

	[Address(RVA="0x120A9AC", Offset="0x120A9AC", VA="0x120A9AC")]
	private void InitializeEmoteListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x1207E34", Offset="0x1207E34", VA="0x1207E34")]
	public void SetEmoteData(IReadOnlyList<InventoryItem?> emotes)
	{
	}

	[Address(RVA="0x1206E18", Offset="0x1206E18", VA="0x1206E18")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x120A6F0", Offset="0x120A6F0", VA="0x120A6F0", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x120A8B4", Offset="0x120A8B4", VA="0x120A8B4", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106AB84", Offset="0x106AB84")]
		[FieldOffset(Offset="0x28")]
		public WrappedScrollRect EmoteListScrollRect;

		[FieldOffset(Offset="0x30")]
		public EmoteInventorySelectedWidget SelectedWidget;

		[FieldOffset(Offset="0x38")]
		public Transform EquipFlowSelectionPosition;

		[FieldOffset(Offset="0x40")]
		public Button CancelEquipButton;

		[FieldOffset(Offset="0x48")]
		public UiLabel HelpLabel;

		[Address(RVA="0x120AE40", Offset="0x120AE40", VA="0x120AE40")]
		public SerializedFields()
		{
		}
	}
}