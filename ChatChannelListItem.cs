using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ChatChannelListItem : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x20")]
	private SingleAssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x28")]
	private ChatDomainController.Channel _channel;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UiLabel _label;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private GameObject _customIcon;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private RawImage _customIconImage;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private GameObject _defaultIcon;

	public ChatDomainController.Channel Channel
	{
		[Address(RVA="0x1196E34", Offset="0x1196E34", VA="0x1196E34")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11971C8", Offset="0x11971C8", VA="0x11971C8")]
	public ChatChannelListItem()
	{
	}

	[Address(RVA="0x1197144", Offset="0x1197144", VA="0x1197144")]
	private void Clicked()
	{
	}

	[Address(RVA="0x1196E3C", Offset="0x1196E3C", VA="0x1196E3C")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1196FD8", Offset="0x1196FD8", VA="0x1196FD8")]
	public void SetData(ChatDomainController.Channel channel)
	{
	}

	[Address(RVA="0x1196F9C", Offset="0x1196F9C", VA="0x1196F9C")]
	public void SetSelected(bool isSelected)
	{
	}

	[Address(RVA="0x1196F30", Offset="0x1196F30", VA="0x1196F30")]
	public void Shutdown()
	{
	}
}