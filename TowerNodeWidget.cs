using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class TowerNodeWidget : MonoBehaviour, IDispatchHandler<DTowerNodeSelectedAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private UiLabel _indexLabel;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private GameObject _completedContainer;

	[Attribute(Name="HeaderAttribute", RVA="0x105D7D8", Offset="0x105D7D8")]
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private TowerNodeWidget.DBannerFields _normalBanner;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private TowerNodeWidget.DBannerFields _bossBanner;

	[FieldOffset(Offset="0x68")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x70")]
	private int _nodeIndex;

	[FieldOffset(Offset="0x74")]
	private int _selectedIndex;

	public RectTransform ButtonRect
	{
		[Address(RVA="0x1436A04", Offset="0x1436A04", VA="0x1436A04")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1437034", Offset="0x1437034", VA="0x1437034")]
	public TowerNodeWidget()
	{
	}

	[Address(RVA="0x1436FA8", Offset="0x1436FA8", VA="0x1436FA8")]
	private void ButtonClicked()
	{
	}

	[Address(RVA="0x1436E4C", Offset="0x1436E4C", VA="0x1436E4C")]
	private void ConfigureBanner(TowerNodeWidget.NodeType type, bool isLocked)
	{
	}

	[Address(RVA="0x1436F3C", Offset="0x1436F3C", VA="0x1436F3C", Slot="4")]
	public void HandleDispatchAction(DTowerNodeSelectedAction action)
	{
	}

	[Address(RVA="0x1436ABC", Offset="0x1436ABC", VA="0x1436ABC")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1436CB0", Offset="0x1436CB0", VA="0x1436CB0")]
	public void SetNodeData(TowerNodeWidget.NodeType type, int nodeIndex, int currentNodeIndex)
	{
	}

	[Address(RVA="0x1436D90", Offset="0x1436D90", VA="0x1436D90")]
	private void SetSelected(bool selected)
	{
	}

	[Address(RVA="0x1436C08", Offset="0x1436C08", VA="0x1436C08")]
	public void Shutdown()
	{
	}

	[Serializable]
	private struct DBannerFields
	{
		[FieldOffset(Offset="0x0")]
		public Button Button;

		[FieldOffset(Offset="0x8")]
		public Sprite UnselectedSprite;

		[FieldOffset(Offset="0x10")]
		public Sprite SelectedSprite;

		[FieldOffset(Offset="0x18")]
		public GameObject LockContainer;
	}

	public enum NodeType
	{
		[FieldOffset(Offset="0x0")]
		Normal,
		[FieldOffset(Offset="0x0")]
		Boss
	}
}