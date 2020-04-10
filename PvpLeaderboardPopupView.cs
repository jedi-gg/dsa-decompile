using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PvpLeaderboardPopupView : APopupView
{
	[FieldOffset(Offset="0x68")]
	private IReadOnlyList<PlayerListItemData> _entries;

	[FieldOffset(Offset="0x70")]
	private UiTimerLabel _payoutCountdown;

	private PvpLeaderboardPopupView.SerializedFields Fields
	{
		[Address(RVA="0x1286040", Offset="0x1286040", VA="0x1286040")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1286830", Offset="0x1286830", VA="0x1286830")]
	public PvpLeaderboardPopupView()
	{
	}

	[Address(RVA="0x1286674", Offset="0x1286674", VA="0x1286674")]
	private void BindPvpLeaderboardListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x1286488", Offset="0x1286488", VA="0x1286488")]
	private void GlobalClicked()
	{
	}

	[Address(RVA="0x1285500", Offset="0x1285500", VA="0x1285500")]
	public void IgnoreTabInput(bool ignore)
	{
	}

	[Address(RVA="0x12858D8", Offset="0x12858D8", VA="0x12858D8")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1286590", Offset="0x1286590", VA="0x1286590")]
	private void InitializePvpLeaderboardListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x128650C", Offset="0x128650C", VA="0x128650C")]
	private void LocalClicked()
	{
	}

	[Address(RVA="0x1285F18", Offset="0x1285F18", VA="0x1285F18")]
	public void ScrollToIndex(int i, bool immediately)
	{
	}

	[Address(RVA="0x1285E18", Offset="0x1285E18", VA="0x1285E18")]
	public void SetData(IReadOnlyList<PlayerListItemData> entries)
	{
	}

	[Address(RVA="0x1285604", Offset="0x1285604", VA="0x1285604")]
	public void SetLeaderboardType(PlayerLeaderboardType leaderboardType)
	{
	}

	[Address(RVA="0x1285984", Offset="0x1285984", VA="0x1285984")]
	public void SetWeekEndEta(DateTime? v)
	{
	}

	[Address(RVA="0x1285548", Offset="0x1285548", VA="0x1285548")]
	public void ShowErrorMessage(bool showing)
	{
	}

	[Address(RVA="0x12854B8", Offset="0x12854B8", VA="0x12854B8")]
	public void ShowSpinner(bool showing)
	{
	}

	[Address(RVA="0x1284F80", Offset="0x1284F80", VA="0x1284F80")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1286120", Offset="0x1286120", VA="0x1286120", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x128639C", Offset="0x128639C", VA="0x128639C", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public Button GlobalTab;

		[FieldOffset(Offset="0x38")]
		public Button LocalTab;

		[FieldOffset(Offset="0x40")]
		public UiTabGroup TabGroup;

		[FieldOffset(Offset="0x48")]
		public UnityEngine.GameObject TabGroupInputBlocker;

		[FieldOffset(Offset="0x50")]
		public UnityEngine.GameObject LoadingScrim;

		[FieldOffset(Offset="0x58")]
		public WrappedScrollRect ScrollRect;

		[FieldOffset(Offset="0x60")]
		public UiLabel HeadingLabel;

		[FieldOffset(Offset="0x68")]
		public UiLabel ErrorLabel;

		[FieldOffset(Offset="0x70")]
		public float AutoScrollDuration;

		[Attribute(Name="HeaderAttribute", RVA="0x106B744", Offset="0x106B744")]
		[FieldOffset(Offset="0x78")]
		public UnityEngine.GameObject PayoutCountdownContainer;

		[FieldOffset(Offset="0x80")]
		public UiLabel PayoutCountdown;

		[FieldOffset(Offset="0x88")]
		public UiColorPalette ColorPalette;

		[Address(RVA="0x1286838", Offset="0x1286838", VA="0x1286838")]
		public SerializedFields()
		{
		}
	}
}