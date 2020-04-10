using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Attribute(Name="RequireComponent", RVA="0x1048BF8", Offset="0x1048BF8")]
public class ScrollRectDragHandlerRedirector : MonoBehaviour, IBeginDragHandler, IEventSystemHandler
{
	[FieldOffset(Offset="0x18")]
	private ScrollRect _thisScrollRect;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private ScrollRect _redirectScrollRect;

	[Address(RVA="0x2C40438", Offset="0x2C40438", VA="0x2C40438")]
	public ScrollRectDragHandlerRedirector()
	{
	}

	[Address(RVA="0x2C402CC", Offset="0x2C402CC", VA="0x2C402CC")]
	private void Awake()
	{
	}

	[Address(RVA="0x2C400F8", Offset="0x2C400F8", VA="0x2C400F8", Slot="4")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}
}