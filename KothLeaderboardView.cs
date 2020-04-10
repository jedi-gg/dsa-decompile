using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class KothLeaderboardView : APopupView
{
	[FieldOffset(Offset="0x68")]
	private IReadOnlyList<PlayerListItemData> _entries;

	[FieldOffset(Offset="0x70")]
	private UiTimerLabel _payoutCountdown;

	private KothLeaderboardView.SerializedFields Fields
	{
		[Address(RVA="0x11CDE54", Offset="0x11CDE54", VA="0x11CDE54")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11CE410", Offset="0x11CE410", VA="0x11CE410")]
	public KothLeaderboardView()
	{
	}

	[Address(RVA="0x11CE1FC", Offset="0x11CE1FC", VA="0x11CE1FC")]
	private void BindKothLeaderboardListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x11CE118", Offset="0x11CE118", VA="0x11CE118")]
	private void InitializeKothLeaderboardListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11CDB04", Offset="0x11CDB04", VA="0x11CDB04")]
	public void ScrollToIndex(int i, bool immediately)
	{
	}

	[Address(RVA="0x11CDA04", Offset="0x11CDA04", VA="0x11CDA04")]
	public void SetData(IReadOnlyList<PlayerListItemData> entries)
	{
	}

	[Address(RVA="0x11CDD2C", Offset="0x11CDD2C", VA="0x11CDD2C")]
	public void SetPayoutEta(DateTime? v)
	{
	}

	[Address(RVA="0x11CD618", Offset="0x11CD618", VA="0x11CD618")]
	public void ShowErrorMessage(bool showing)
	{
	}

	[Address(RVA="0x11CD5D0", Offset="0x11CD5D0", VA="0x11CD5D0")]
	public void ShowSpinner(bool showing)
	{
	}

	[Address(RVA="0x11CD1A4", Offset="0x11CD1A4", VA="0x11CD1A4")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x11CDF34", Offset="0x11CDF34", VA="0x11CDF34", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11CE0B8", Offset="0x11CE0B8", VA="0x11CE0B8", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public UnityEngine.GameObject LoadingScrim;

		[FieldOffset(Offset="0x38")]
		public WrappedScrollRect ScrollRect;

		[FieldOffset(Offset="0x40")]
		public UiLabel ErrorLabel;

		[FieldOffset(Offset="0x48")]
		public float AutoScrollDuration;

		[Attribute(Name="HeaderAttribute", RVA="0x106AD44", Offset="0x106AD44")]
		[FieldOffset(Offset="0x50")]
		public UnityEngine.GameObject PayoutCountdownContainer;

		[FieldOffset(Offset="0x58")]
		public UiLabel PayoutCountdown;

		[FieldOffset(Offset="0x60")]
		public UiColorPalette ColorPalette;

		[Address(RVA="0x11CE418", Offset="0x11CE418", VA="0x11CE418")]
		public SerializedFields()
		{
		}
	}
}