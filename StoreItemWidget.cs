using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreItemWidget : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDc;

	[FieldOffset(Offset="0x48")]
	private InventoryUtility _inventoryUtility;

	[FieldOffset(Offset="0x50")]
	private SingleAssetRegistry _imageRegistry;

	[FieldOffset(Offset="0x58")]
	private SingleAssetRegistry _vfxAssetRegistry;

	[FieldOffset(Offset="0x60")]
	private object _ownerIdentifier;

	[FieldOffset(Offset="0x68")]
	private StoreItemData _itemData;

	[FieldOffset(Offset="0x70")]
	private bool _isOfferWall;

	[FieldOffset(Offset="0x78")]
	private UiTimerLabel _uiTimerLabel;

	[FieldOffset(Offset="0x80")]
	private Vector2 _stickerRootPosWithTimerVisible;

	[FieldOffset(Offset="0x88")]
	private Color _defaultFrameColor;

	[FieldOffset(Offset="0x98")]
	private List<StoreItemContentPreview> _contentPreviews;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private RawImage _mainImage;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private Button _detailsButton;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private StoreItemBuyButtons _buyButtons;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private List<Graphic> _coloredFramePieces;

	[Attribute(Name="HeaderAttribute", RVA="0x105CF4C", Offset="0x105CF4C")]
	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private StoreItemContentPreview _contentPreviewArchetype;

	[FieldOffset(Offset="0xC8")]
	[SerializeField]
	private int _maxContentPreviews;

	[FieldOffset(Offset="0xD0")]
	[SerializeField]
	private GameObject _contentPreviewOverflowRoot;

	[FieldOffset(Offset="0xD8")]
	[SerializeField]
	private UiLabel _contentPreviewOverflowLabel;

	[Attribute(Name="HeaderAttribute", RVA="0x105CFC8", Offset="0x105CFC8")]
	[FieldOffset(Offset="0xE0")]
	[SerializeField]
	private UiLabel _packNameLabel;

	[FieldOffset(Offset="0xE8")]
	[SerializeField]
	private UiLabel _packSubtitleLabel;

	[FieldOffset(Offset="0xF0")]
	[SerializeField]
	private UiLabel _bottomLabel;

	[Attribute(Name="HeaderAttribute", RVA="0x105D034", Offset="0x105D034")]
	[FieldOffset(Offset="0xF8")]
	[SerializeField]
	private RectTransform _timerRoot;

	[FieldOffset(Offset="0x100")]
	[SerializeField]
	private UiLabel _timerLabel;

	[FieldOffset(Offset="0x108")]
	[SerializeField]
	private RectTransform _stickerRoot;

	[FieldOffset(Offset="0x110")]
	[SerializeField]
	private UiLabel _stickerLabel;

	[Attribute(Name="HeaderAttribute", RVA="0x105D0B0", Offset="0x105D0B0")]
	[FieldOffset(Offset="0x118")]
	[SerializeField]
	private List<GameObject> _vipContainers;

	[FieldOffset(Offset="0x120")]
	[SerializeField]
	private StoreItemWidget.VipFields _vipInitialGems;

	[FieldOffset(Offset="0x128")]
	[SerializeField]
	private StoreItemWidget.VipFields _vipDailyGems;

	[FieldOffset(Offset="0x130")]
	[SerializeField]
	private StoreItemWidget.VipFields _vipTotalGems;

	[Attribute(Name="HeaderAttribute", RVA="0x105D12C", Offset="0x105D12C")]
	[FieldOffset(Offset="0x138")]
	[SerializeField]
	private Texture2D _offerWallTexture;

	[Address(RVA="0x13158CC", Offset="0x13158CC", VA="0x13158CC")]
	public StoreItemWidget()
	{
	}

	[Address(RVA="0x131594C", Offset="0x131594C", VA="0x131594C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070B1C", Offset="0x1070B1C")]
	private void <ShowOfferWall>b__4_0(Graphic g)
	{
	}

	[Address(RVA="0x1314EA8", Offset="0x1314EA8", VA="0x1314EA8")]
	private void BuyClicked()
	{
	}

	[Address(RVA="0x1314AD8", Offset="0x1314AD8", VA="0x1314AD8")]
	public RectTransform GetPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x1312C38", Offset="0x1312C38", VA="0x1312C38")]
	public void Initialize(WidgetDependencyContainer dependencies, object ownerIdentifier)
	{
	}

	[Address(RVA="0x13145BC", Offset="0x13145BC", VA="0x13145BC")]
	private void SetBottomLabel()
	{
	}

	[Address(RVA="0x13136B0", Offset="0x13136B0", VA="0x13136B0")]
	public void SetData(StoreItemData itemData, bool isSpecialOffer = false)
	{
	}

	[Address(RVA="0x1315480", Offset="0x1315480", VA="0x1315480")]
	private bool SetPromotionMaterialOwnedGoalCount()
	{
		return new bool();
	}

	[Address(RVA="0x131502C", Offset="0x131502C", VA="0x131502C")]
	private bool SetPurchaseLimits()
	{
		return new bool();
	}

	[Address(RVA="0x13144D8", Offset="0x13144D8", VA="0x13144D8")]
	private void SetStickerPosition()
	{
	}

	[Address(RVA="0x1314274", Offset="0x1314274", VA="0x1314274")]
	private void SetTextOrHideLabel(string locKey, UiLabel label, GameObject labelRootOverride = // 
	// Current member / type: System.Void StoreItemWidget::SetTextOrHideLabel(System.String,UiLabel,UnityEngine.GameObject)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void SetTextOrHideLabel(System.String,UiLabel,UnityEngine.GameObject)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x13143B4", Offset="0x13143B4", VA="0x13143B4")]
	private void SetTimerVisibility()
	{
	}

	[Address(RVA="0x1313F80", Offset="0x1313F80", VA="0x1313F80")]
	private void SetVipData()
	{
	}

	[Address(RVA="0x1314CC0", Offset="0x1314CC0", VA="0x1314CC0")]
	private void ShowDetailsClicked()
	{
	}

	[Address(RVA="0x1314628", Offset="0x1314628", VA="0x1314628")]
	public void ShowOfferWall()
	{
	}

	[Address(RVA="0x13132E8", Offset="0x13132E8", VA="0x13132E8", Slot="4")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x13134B4", Offset="0x13134B4", VA="0x13134B4", Slot="5")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x1313604", Offset="0x1313604", VA="0x1313604")]
	private void UpdateTimer()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CD2C", Offset="0x104CD2C")]
	private sealed class <>c__DisplayClass15_0
	{
		[FieldOffset(Offset="0x10")]
		public bool isVip;

		[Address(RVA="0x13158C4", Offset="0x13158C4", VA="0x13158C4")]
		public <>c__DisplayClass15_0()
		{
		}

		[Address(RVA="0x13159AC", Offset="0x13159AC", VA="0x13159AC")]
		internal void <SetVipData>b__0(GameObject g)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CD1C", Offset="0x104CD1C")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public Color frameColor;

		[FieldOffset(Offset="0x20")]
		public StoreItemWidget <>4__this;

		[Address(RVA="0x1313F78", Offset="0x1313F78", VA="0x1313F78")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x13159E8", Offset="0x13159E8", VA="0x13159E8")]
		internal void <SetData>b__0(Graphic g)
		{
		}

		[Address(RVA="0x1315A88", Offset="0x1315A88", VA="0x1315A88")]
		internal void <SetData>b__1(AssetHandle assetHandle)
		{
		}
	}

	[Serializable]
	public class VipFields
	{
		[FieldOffset(Offset="0x10")]
		public UiLabel GemCountLabel;

		[FieldOffset(Offset="0x18")]
		public UiLabel TitleLabel;

		[FieldOffset(Offset="0x20")]
		public string TitleLocKey;

		[Address(RVA="0x1315C40", Offset="0x1315C40", VA="0x1315C40")]
		public VipFields()
		{
		}
	}
}