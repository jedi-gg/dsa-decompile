using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class ItemConversionPopupView : APopupView
{
	[Attribute(Name="TupleElementNamesAttribute", RVA="0x1059964", Offset="0x1059964")]
	[FieldOffset(Offset="0x68")]
	private ValueTuple<List<ItemConversionPopupController.ConversionData>, List<ItemConversionPopupController.ConversionData>> _data;

	private ItemConversionPopupView.SerializedFields Fields
	{
		[Address(RVA="0x137EE64", Offset="0x137EE64", VA="0x137EE64")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x137F450", Offset="0x137F450", VA="0x137F450")]
	public ItemConversionPopupView()
	{
	}

	[Address(RVA="0x137F220", Offset="0x137F220", VA="0x137F220")]
	private void BindAnItem(WrappedScrollRectListItem listItem, ItemConversionPopupController.ConversionData item)
	{
	}

	[Address(RVA="0x137F350", Offset="0x137F350", VA="0x137F350")]
	private void BindFromItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x137F3D0", Offset="0x137F3D0", VA="0x137F3D0")]
	private void BindToItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x137F140", Offset="0x137F140", VA="0x137F140")]
	private void InitializeAnItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x137ED30", Offset="0x137ED30", VA="0x137ED30")]
	public void SetData([Attribute(Name="TupleElementNamesAttribute", RVA="0x109103C", Offset="0x109103C")] ValueTuple<List<ItemConversionPopupController.ConversionData>, List<ItemConversionPopupController.ConversionData>> data)
	{
	}

	[Address(RVA="0x137EF44", Offset="0x137EF44", VA="0x137EF44", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x137F0B4", Offset="0x137F0B4", VA="0x137F0B4", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect FromItems;

		[FieldOffset(Offset="0x38")]
		public WrappedScrollRect ToItems;

		[Address(RVA="0x137F458", Offset="0x137F458", VA="0x137F458")]
		public SerializedFields()
		{
		}
	}
}