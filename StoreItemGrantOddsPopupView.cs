using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class StoreItemGrantOddsPopupView : APopupView
{
	[FieldOffset(Offset="0x68")]
	private List<StoreItemGrantOption> _options;

	private StoreItemGrantOddsPopupView.SerializedFields Fields
	{
		[Address(RVA="0x130EED0", Offset="0x130EED0", VA="0x130EED0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x130F2C8", Offset="0x130F2C8", VA="0x130F2C8")]
	public StoreItemGrantOddsPopupView()
	{
	}

	[Address(RVA="0x130F1CC", Offset="0x130F1CC", VA="0x130F1CC")]
	private void BindGrantItemListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x130F0F0", Offset="0x130F0F0", VA="0x130F0F0")]
	private void InitializeGrantItemListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x130E6C4", Offset="0x130E6C4", VA="0x130E6C4")]
	public void SetData(StoreItemGrant grant)
	{
	}

	[Address(RVA="0x130EFB0", Offset="0x130EFB0", VA="0x130EFB0", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x130F094", Offset="0x130F094", VA="0x130F094", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CDFC", Offset="0x104CDFC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static StoreItemGrantOddsPopupView.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Comparison<StoreItemGrantOption> <>9__0_0;

		[Address(RVA="0x130F338", Offset="0x130F338", VA="0x130F338")]
		static <>c()
		{
		}

		[Address(RVA="0x130F39C", Offset="0x130F39C", VA="0x130F39C")]
		public <>c()
		{
		}

		[Address(RVA="0x130F3A4", Offset="0x130F3A4", VA="0x130F3A4")]
		internal int <SetData>b__0_0(StoreItemGrantOption a, StoreItemGrantOption b)
		{
			return new int();
		}
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect GrantItemsScrollRect;

		[Address(RVA="0x130F410", Offset="0x130F410", VA="0x130F410")]
		public SerializedFields()
		{
		}
	}
}