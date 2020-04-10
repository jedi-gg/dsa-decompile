using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

[Attribute(Name="RequireComponent", RVA="0x1048C5C", Offset="0x1048C5C")]
public class TextLinkInputHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x20")]
	private UiLabel _label;

	[Address(RVA="0x1325B30", Offset="0x1325B30", VA="0x1325B30")]
	public TextLinkInputHandler()
	{
	}

	[Address(RVA="0x1325AD8", Offset="0x1325AD8", VA="0x1325AD8")]
	private void Awake()
	{
	}

	[Address(RVA="0x13258EC", Offset="0x13258EC", VA="0x13258EC")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1325928", Offset="0x1325928", VA="0x1325928", Slot="4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Address(RVA="0x1325920", Offset="0x1325920", VA="0x1325920")]
	public void Shutdown()
	{
	}
}