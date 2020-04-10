using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class StoreView : AStandardView, IDispatchHandler<DUiTabGroupAction>, IDispatchHandler, IDispatchHandler<DStoreSpecialOfferTabAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105D268", Offset="0x105D268")]
	[FieldOffset(Offset="0x68")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x105D278", Offset="0x105D278")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105D288", Offset="0x105D288")]
	[FieldOffset(Offset="0x78")]
	private StoreDomainController _storeDc;

	[FieldOffset(Offset="0x80")]
	private StoreData _data;

	[FieldOffset(Offset="0x88")]
	private List<StoreUiTab> _storeUiTabs;

	[FieldOffset(Offset="0x90")]
	private int _selectedTabIndex;

	[FieldOffset(Offset="0x94")]
	private int _selectedSpecialOfferTabIndex;

	private StoreView.SerializedFields Fields
	{
		[Address(RVA="0x13179B0", Offset="0x13179B0", VA="0x13179B0")]
		get
		{
			return null;
		}
	}

	public int SelectedTabIndex
	{
		[Address(RVA="0x13176F0", Offset="0x13176F0", VA="0x13176F0")]
		get
		{
			return new int();
		}
	}

	[Address(RVA="0x131A76C", Offset="0x131A76C", VA="0x131A76C")]
	public StoreView()
	{
	}

	[Address(RVA="0x131A418", Offset="0x131A418", VA="0x131A418")]
	private void BindSpecialOfferTab(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x131A120", Offset="0x131A120", VA="0x131A120")]
	private void BindStoreItemWidget(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x1318550", Offset="0x1318550", VA="0x1318550")]
	public void ClearData()
	{
	}

	[Address(RVA="0x1319D00", Offset="0x1319D00", VA="0x1319D00", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x1317A90", Offset="0x1317A90", VA="0x1317A90")]
	private WrappedScrollRect GetSelectedTabScrollRect()
	{
		return null;
	}

	[Address(RVA="0x1319120", Offset="0x1319120", VA="0x1319120")]
	public void GoToStoreItem(ulong itemId)
	{
	}

	[Address(RVA="0x1318688", Offset="0x1318688", VA="0x1318688")]
	public void GoToTabIndex(int tabIndex)
	{
	}

	[Address(RVA="0x131934C", Offset="0x131934C", VA="0x131934C", Slot="21")]
	public void HandleDispatchAction(DUiTabGroupAction action)
	{
	}

	[Address(RVA="0x1319400", Offset="0x1319400", VA="0x1319400", Slot="22")]
	public void HandleDispatchAction(DStoreSpecialOfferTabAction action)
	{
	}

	[Address(RVA="0x131A33C", Offset="0x131A33C", VA="0x131A33C")]
	private void InitializeSpecialOfferTab(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x131A040", Offset="0x131A040", VA="0x131A040")]
	private void InitializeStoreItemWidget(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x1318DF4", Offset="0x1318DF4", VA="0x1318DF4")]
	private bool SelectedTabShouldShowOfferWall()
	{
		return new bool();
	}

	[Address(RVA="0x1318ED8", Offset="0x1318ED8", VA="0x1318ED8")]
	private void SelectSpecialOfferItemIndex(int index)
	{
	}

	[Address(RVA="0x1317C60", Offset="0x1317C60", VA="0x1317C60")]
	public void SetData(StoreData storeData)
	{
	}

	[Address(RVA="0x1318404", Offset="0x1318404", VA="0x1318404")]
	private bool TabShouldShowOfferWall(StoreTab tab)
	{
		return new bool();
	}

	[Address(RVA="0x13176F8", Offset="0x13176F8", VA="0x13176F8")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1319404", Offset="0x1319404", VA="0x1319404", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1319B20", Offset="0x1319B20", VA="0x1319B20", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x1319814", Offset="0x1319814", VA="0x1319814", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106BDCC", Offset="0x106BDCC")]
		[FieldOffset(Offset="0x28")]
		public UiLabel HeadingLabel;

		[FieldOffset(Offset="0x30")]
		public StoreUiTab TabTemplate;

		[FieldOffset(Offset="0x38")]
		public UiTabGroup TabGroup;

		[Attribute(Name="HeaderAttribute", RVA="0x106BE04", Offset="0x106BE04")]
		[FieldOffset(Offset="0x40")]
		public WrappedScrollRect ThinStoreItemScrollRect;

		[FieldOffset(Offset="0x48")]
		public WrappedScrollRect MediumStoreItemScrollRect;

		[FieldOffset(Offset="0x50")]
		public WrappedScrollRect WideStoreItemScrollRect;

		[FieldOffset(Offset="0x58")]
		public WrappedScrollRect SquareStoreItemScrollRect;

		[Attribute(Name="HeaderAttribute", RVA="0x106BE3C", Offset="0x106BE3C")]
		[FieldOffset(Offset="0x60")]
		public UnityEngine.GameObject SpecialOfferRoot;

		[FieldOffset(Offset="0x68")]
		public StoreItemWidget SpecialOfferWidget;

		[FieldOffset(Offset="0x70")]
		public WrappedScrollRect SpecialOfferTabScrollRect;

		[Attribute(Name="HeaderAttribute", RVA="0x106BE74", Offset="0x106BE74")]
		[FieldOffset(Offset="0x78")]
		public StoreItemShowcaseWidget ShowcaseWidget;

		[FieldOffset(Offset="0x80")]
		public Camera ShowcaseCamera;

		[FieldOffset(Offset="0x88")]
		public Canvas ShowcaseCanvas;

		[Address(RVA="0x131A7E4", Offset="0x131A7E4", VA="0x131A7E4")]
		public SerializedFields()
		{
		}
	}
}