using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class StoreItemOddsPopupView : APopupView
{
	[FieldOffset(Offset="0x68")]
	private List<StoreItemGrant> _grants;

	private StoreItemOddsPopupView.SerializedFields Fields
	{
		[Address(RVA="0x1310590", Offset="0x1310590", VA="0x1310590")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1310918", Offset="0x1310918", VA="0x1310918")]
	public StoreItemOddsPopupView()
	{
	}

	[Address(RVA="0x13107B0", Offset="0x13107B0", VA="0x13107B0")]
	private void BindGrantListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x13106D4", Offset="0x13106D4", VA="0x13106D4")]
	private void InitializeGrantListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x130F720", Offset="0x130F720", VA="0x130F720")]
	public void SetData(StoreItemDetail itemDetail)
	{
	}

	[Address(RVA="0x1310670", Offset="0x1310670", VA="0x1310670", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1310678", Offset="0x1310678", VA="0x1310678", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CE1C", Offset="0x104CE1C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static StoreItemOddsPopupView.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Comparison<StoreItemGrant> <>9__0_0;

		[Address(RVA="0x1310988", Offset="0x1310988", VA="0x1310988")]
		static <>c()
		{
		}

		[Address(RVA="0x13109EC", Offset="0x13109EC", VA="0x13109EC")]
		public <>c()
		{
		}

		[Address(RVA="0x13109F4", Offset="0x13109F4", VA="0x13109F4")]
		internal int <SetData>b__0_0(StoreItemGrant a, StoreItemGrant b)
		{
			return new int();
		}
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect GrantsScrollRect;

		[FieldOffset(Offset="0x38")]
		public UiLabel DescriptionLabel;

		[FieldOffset(Offset="0x40")]
		public RectTransform GrantsRoot;

		[FieldOffset(Offset="0x48")]
		public RectTransform DescriptionLabelRoot;

		[Address(RVA="0x1310A60", Offset="0x1310A60", VA="0x1310A60")]
		public SerializedFields()
		{
		}
	}
}