using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PinPageItemComponent : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private SingleAssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x20")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x28")]
	private BadgingController _badgingController;

	[FieldOffset(Offset="0x30")]
	private PinPageItemData _data;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private RawImage _image;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private GameObject _lockObject;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private GameObject _progressContainer;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private Image _progressFill;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private UiLabel _progressLabel;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private GameObject _obscuredIconObject;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private Color _mysteryColor;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private Badge _badge;

	[Address(RVA="0x14110A4", Offset="0x14110A4", VA="0x14110A4")]
	public PinPageItemComponent()
	{
	}

	[Address(RVA="0x1411020", Offset="0x1411020", VA="0x1411020")]
	private void ButtonClicked()
	{
	}

	[Address(RVA="0x1410E60", Offset="0x1410E60", VA="0x1410E60")]
	public void ForceUpdateBadge()
	{
	}

	[Address(RVA="0x14104A8", Offset="0x14104A8", VA="0x14104A8")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1410994", Offset="0x1410994", VA="0x1410994")]
	public void SetData(PinPageItemData data)
	{
	}

	[Address(RVA="0x1410770", Offset="0x1410770", VA="0x1410770")]
	public void Shutdown()
	{
	}
}