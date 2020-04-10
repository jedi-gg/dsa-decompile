using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerSelectListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x40")]
	private SingleAssetRegistry _imageAssetRegistry;

	[FieldOffset(Offset="0x48")]
	private AssetRegistry _showcaseItemImagesRegistry;

	[FieldOffset(Offset="0x50")]
	private TowerMap _towerMap;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private RawImage _image;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private UiLabel _nameLabel;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private UiLabel _descriptionLabel;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private UiLabel _progressLabel;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private List<TowerSelectListItem.ShowcaseItem> _showcaseItems;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private GameObject _lockContainer;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private GameObject _completedContainer;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private GameObject _badge;

	public RectTransform ButtonRect
	{
		[Address(RVA="0x1438F40", Offset="0x1438F40", VA="0x1438F40")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1439C70", Offset="0x1439C70", VA="0x1439C70")]
	public TowerSelectListItem()
	{
	}

	[Address(RVA="0x1439A28", Offset="0x1439A28", VA="0x1439A28")]
	private void ButtonClicked()
	{
	}

	[Address(RVA="0x1438FB8", Offset="0x1438FB8", VA="0x1438FB8")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1439424", Offset="0x1439424", VA="0x1439424")]
	public void SetData(TowerMap towerMap, TowerStatus towerStatus, bool isFinalMap)
	{
	}

	[Address(RVA="0x1439AC8", Offset="0x1439AC8", VA="0x1439AC8")]
	private void ShowcaseItemClicked(int index)
	{
	}

	[Address(RVA="0x1439290", Offset="0x1439290", VA="0x1439290", Slot="4")]
	public override void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CF2C", Offset="0x104CF2C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public int closureIndex;

		[FieldOffset(Offset="0x18")]
		public TowerSelectListItem <>4__this;

		[Address(RVA="0x1439288", Offset="0x1439288", VA="0x1439288")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x1439C78", Offset="0x1439C78", VA="0x1439C78")]
		internal void <Initialize>b__0()
		{
		}
	}

	[Serializable]
	public class ShowcaseItem
	{
		[FieldOffset(Offset="0x10")]
		public GameObject Root;

		[FieldOffset(Offset="0x18")]
		public RawImage Image;

		[FieldOffset(Offset="0x20")]
		public Button Button;

		[Address(RVA="0x1439CAC", Offset="0x1439CAC", VA="0x1439CAC")]
		public ShowcaseItem()
		{
		}
	}
}