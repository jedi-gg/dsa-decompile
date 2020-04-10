using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class KothBattleHistoryView : APopupView
{
	[FieldOffset(Offset="0x68")]
	private IList<KothBattleHistory> _battleHistories;

	private KothBattleHistoryView.SerializedFields Fields
	{
		[Address(RVA="0x11CA7F8", Offset="0x11CA7F8", VA="0x11CA7F8")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11CAC5C", Offset="0x11CAC5C", VA="0x11CAC5C")]
	public KothBattleHistoryView()
	{
	}

	[Address(RVA="0x11CAAF4", Offset="0x11CAAF4", VA="0x11CAAF4")]
	private void BindDefenseHistoryListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x11CAA18", Offset="0x11CAA18", VA="0x11CAA18")]
	private void InitializeDefenseHistoryListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11C919C", Offset="0x11C919C", VA="0x11C919C")]
	public void SetData(KothBattleHistoryResponse data)
	{
	}

	[Address(RVA="0x11CA8D8", Offset="0x11CA8D8", VA="0x11CA8D8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11CA9BC", Offset="0x11CA9BC", VA="0x11CA9BC", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect DefenseHistoryScrollRect;

		[Address(RVA="0x11CAC64", Offset="0x11CAC64", VA="0x11CAC64")]
		public SerializedFields()
		{
		}
	}
}