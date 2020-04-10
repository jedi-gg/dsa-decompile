using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

[Attribute(Name="RequireComponent", RVA="0x1048ACC", Offset="0x1048ACC")]
public class TowerWorldInputHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatchSystem;

	[Address(RVA="0x143C098", Offset="0x143C098", VA="0x143C098")]
	public TowerWorldInputHandler()
	{
	}

	[Address(RVA="0x1437380", Offset="0x1437380", VA="0x1437380")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x143BFFC", Offset="0x143BFFC", VA="0x143BFFC", Slot="4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Address(RVA="0x1437378", Offset="0x1437378", VA="0x1437378")]
	public void Shutdown()
	{
	}
}