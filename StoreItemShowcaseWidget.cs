using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreItemShowcaseWidget : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x20")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x28")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x30")]
	private PlayerDomainController _playerDc;

	[FieldOffset(Offset="0x38")]
	private InventoryUtility _inventoryUtility;

	[FieldOffset(Offset="0x40")]
	private SingleAssetRegistry _3dAssetRegistry;

	[FieldOffset(Offset="0x48")]
	private object _ownerIdentifier;

	[FieldOffset(Offset="0x50")]
	private StoreItemData _itemData;

	[FieldOffset(Offset="0x58")]
	private UiTimerLabel _uiTimerLabel;

	[FieldOffset(Offset="0x60")]
	private Vector2 _stickerRootPosWithTimerVisible;

	[FieldOffset(Offset="0x68")]
	private Color _defaultFrameColor;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private GameObject _3dRoot;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private Transform _3dAssetRoot;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private Button _detailsButton;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private StoreItemBuyButtons _buyButtons;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private List<Graphic> _coloredFramePieces;

	[Attribute(Name="HeaderAttribute", RVA="0x105CE24", Offset="0x105CE24")]
	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private UiLabel _packNameLabel;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private UiLabel _packSubtitleLabel;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private UiLabel _bottomLabel;

	[Attribute(Name="HeaderAttribute", RVA="0x105CE90", Offset="0x105CE90")]
	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private RectTransform _timerRoot;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private UiLabel _timerLabel;

	[FieldOffset(Offset="0xC8")]
	[SerializeField]
	private RectTransform _stickerRoot;

	[FieldOffset(Offset="0xD0")]
	[SerializeField]
	private UiLabel _stickerLabel;

	[Address(RVA="0x13128E8", Offset="0x13128E8", VA="0x13128E8")]
	public StoreItemShowcaseWidget()
	{
	}

	[Address(RVA="0x131291C", Offset="0x131291C", VA="0x131291C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070B0C", Offset="0x1070B0C")]
	private void <Load3dAsset>b__6_0(AssetHandle assetHandle)
	{
	}

	[Address(RVA="0x1311ED8", Offset="0x1311ED8", VA="0x1311ED8")]
	private void BuyClicked()
	{
	}

	[Address(RVA="0x1311398", Offset="0x1311398", VA="0x1311398")]
	private string Get3dAssetName()
	{
		return null;
	}

	[Address(RVA="0x1310A78", Offset="0x1310A78", VA="0x1310A78")]
	public void Initialize(WidgetDependencyContainer dependencies, object ownerIdentifier)
	{
	}

	[Address(RVA="0x13118BC", Offset="0x13118BC", VA="0x13118BC")]
	private void Load3dAsset(string prefabName)
	{
	}

	[Address(RVA="0x1311CC4", Offset="0x1311CC4", VA="0x1311CC4")]
	private void SetBottomLabel()
	{
	}

	[Address(RVA="0x1310F6C", Offset="0x1310F6C", VA="0x1310F6C")]
	public void SetData(StoreItemData itemData)
	{
	}

	[Address(RVA="0x13124A4", Offset="0x13124A4", VA="0x13124A4")]
	private bool SetPromotionMaterialOwnedGoalCount()
	{
		return new bool();
	}

	[Address(RVA="0x131201C", Offset="0x131201C", VA="0x131201C")]
	private bool SetPurchaseLimits()
	{
		return new bool();
	}

	[Address(RVA="0x1311BE0", Offset="0x1311BE0", VA="0x1311BE0")]
	private void SetStickerPosition()
	{
	}

	[Address(RVA="0x131197C", Offset="0x131197C", VA="0x131197C")]
	private void SetTextOrHideLabel(string locKey, UiLabel label, GameObject labelRootOverride = // 
	// Current member / type: System.Void StoreItemShowcaseWidget::SetTextOrHideLabel(System.String,UiLabel,UnityEngine.GameObject)
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


	[Address(RVA="0x1311ABC", Offset="0x1311ABC", VA="0x1311ABC")]
	private void SetTimerVisibility()
	{
	}

	[Address(RVA="0x1310EC8", Offset="0x1310EC8", VA="0x1310EC8")]
	public void Show(bool show)
	{
	}

	[Address(RVA="0x1311D30", Offset="0x1311D30", VA="0x1311D30")]
	private void ShowDetailsClicked()
	{
	}

	[Address(RVA="0x1310D40", Offset="0x1310D40", VA="0x1310D40")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1310DD0", Offset="0x1310DD0", VA="0x1310DD0")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1310E1C", Offset="0x1310E1C", VA="0x1310E1C")]
	private void UpdateTimer()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CD0C", Offset="0x104CD0C")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public Color frameColor;

		[Address(RVA="0x1311390", Offset="0x1311390", VA="0x1311390")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x1312BD8", Offset="0x1312BD8", VA="0x1312BD8")]
		internal void <SetData>b__0(Graphic g)
		{
		}
	}
}