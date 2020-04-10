using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UiCarouselPip : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x20")]
	private int _index;

	[FieldOffset(Offset="0x28")]
	private object _ownerIdentifier;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private GameObject _selectedObj;

	[Address(RVA="0x15851B0", Offset="0x15851B0", VA="0x15851B0")]
	public UiCarouselPip()
	{
	}

	[Address(RVA="0x1585128", Offset="0x1585128", VA="0x1585128")]
	private void ButtonClicked()
	{
	}

	[Address(RVA="0x1584F9C", Offset="0x1584F9C", VA="0x1584F9C")]
	public void Initialize(WidgetDependencyContainer dependencies, object ownerIdentifier)
	{
	}

	[Address(RVA="0x15850B0", Offset="0x15850B0", VA="0x15850B0")]
	public void SetIndex(int index)
	{
	}

	[Address(RVA="0x1584E88", Offset="0x1584E88", VA="0x1584E88")]
	public void SetSelected(bool selected)
	{
	}

	[Address(RVA="0x1584A2C", Offset="0x1584A2C", VA="0x1584A2C")]
	public void Shutdown()
	{
	}
}