using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class BattleBuffIconGlossaryView : APopupView
{
	[FieldOffset(Offset="0x68")]
	private List<BattleBuffIconGlossaryView.ListItemData> _allPossiblePositiveBuffs;

	[FieldOffset(Offset="0x70")]
	private List<BattleBuffIconGlossaryView.ListItemData> _allPossibleNegativeBuffs;

	[FieldOffset(Offset="0x78")]
	private List<BattleBuffIconGlossaryView.ListItemData> _positiveBuffs;

	[FieldOffset(Offset="0x80")]
	private List<BattleBuffIconGlossaryView.ListItemData> _negativeBuffs;

	[FieldOffset(Offset="0x88")]
	private HashSet<uint> _selectedBuffIconTypes;

	private BattleBuffIconGlossaryView.SerializedFields Fields
	{
		[Address(RVA="0x11373A0", Offset="0x11373A0", VA="0x11373A0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1137784", Offset="0x1137784", VA="0x1137784")]
	public BattleBuffIconGlossaryView()
	{
	}

	[Address(RVA="0x113786C", Offset="0x113786C", VA="0x113786C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E798", Offset="0x106E798")]
	private int <SortData>g__CompareBuffIconDatum|5_0(BattleBuffIconGlossaryView.ListItemData a, BattleBuffIconGlossaryView.ListItemData b)
	{
		return new int();
	}

	[Address(RVA="0x1137584", Offset="0x1137584", VA="0x1137584")]
	private void BindBuffIconScrollListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x11369E8", Offset="0x11369E8", VA="0x11369E8")]
	public void SetActiveBuffTypes(HashSet<uint> iconTypes)
	{
	}

	[Address(RVA="0x1137000", Offset="0x1137000", VA="0x1137000")]
	private void SortData()
	{
	}

	[Address(RVA="0x11371A4", Offset="0x11371A4", VA="0x11371A4", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x113752C", Offset="0x113752C", VA="0x113752C", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x11374D0", Offset="0x11374D0", VA="0x11374D0", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	private class ListItemData
	{
		[FieldOffset(Offset="0x10")]
		public BattleBuffIconUiDatum IconUiDatum;

		[FieldOffset(Offset="0x18")]
		public uint Duration;

		[FieldOffset(Offset="0x1C")]
		public bool IsPermanent;

		[Address(RVA="0x1137488", Offset="0x1137488", VA="0x1137488")]
		public ListItemData(BattleBuffIconUiDatum datum, bool isPermanent = false, uint duration = 0)
		{
		}
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x1069C2C", Offset="0x1069C2C")]
		[FieldOffset(Offset="0x30")]
		public BattleBuffIconUiData BuffIconData;

		[FieldOffset(Offset="0x38")]
		public WrappedScrollRect BuffIconScrollList;

		[Address(RVA="0x11379AC", Offset="0x11379AC", VA="0x11379AC")]
		public SerializedFields()
		{
		}
	}
}