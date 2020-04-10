using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class StoreItemContentPreview : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private SingleAssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x20")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x30")]
	private ulong _itemId;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private RawImage _image;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private EmoteWidget _emoteWidget;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private UiLabel _quantityLabel;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private GameObject _chanceContainer;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private UiLabel _chanceLabel;

	[Address(RVA="0x1232138", Offset="0x1232138", VA="0x1232138")]
	public StoreItemContentPreview()
	{
	}

	[Address(RVA="0x123201C", Offset="0x123201C", VA="0x123201C")]
	private void ButtonClicked()
	{
	}

	[Address(RVA="0x1231308", Offset="0x1231308", VA="0x1231308")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1231670", Offset="0x1231670", VA="0x1231670")]
	public void SetData(StoreItemData data, ulong itemId)
	{
	}

	[Address(RVA="0x123152C", Offset="0x123152C", VA="0x123152C")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x123160C", Offset="0x123160C", VA="0x123160C")]
	public void TickUpdate()
	{
	}
}