using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class UiDragHandler : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105E164", Offset="0x105E164")]
	[FieldOffset(Offset="0x18")]
	private Action<PointerEventData> BeginDrag;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105E174", Offset="0x105E174")]
	[FieldOffset(Offset="0x20")]
	private Action<PointerEventData> Drag;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105E184", Offset="0x105E184")]
	[FieldOffset(Offset="0x28")]
	private Action<PointerEventData, UiDragHandler.Swipe, Vector2> EndDrag;

	[FieldOffset(Offset="0x0")]
	private const float SWIPE_TIME = 0.3f;

	[FieldOffset(Offset="0x30")]
	private Vector2 _startDragPos;

	[FieldOffset(Offset="0x38")]
	private float _dragStartTime;

	[FieldOffset(Offset="0x3C")]
	private float _swipeThresholdXSq;

	[FieldOffset(Offset="0x40")]
	private float _swipeThresholdYSq;

	[Attribute(Name="TooltipAttribute", RVA="0x105E194", Offset="0x105E194")]
	[FieldOffset(Offset="0x44")]
	[SerializeField]
	public float _swipeThresholdX;

	[Attribute(Name="TooltipAttribute", RVA="0x105E1E0", Offset="0x105E1E0")]
	[FieldOffset(Offset="0x48")]
	[SerializeField]
	public float _swipeThresholdY;

	[Address(RVA="0x1585A1C", Offset="0x1585A1C", VA="0x1585A1C")]
	public UiDragHandler()
	{
	}

	[Address(RVA="0x1585A08", Offset="0x1585A08", VA="0x1585A08")]
	private void Awake()
	{
	}

	[Address(RVA="0x1585794", Offset="0x1585794", VA="0x1585794", Slot="4")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Address(RVA="0x1585830", Offset="0x1585830", VA="0x1585830", Slot="5")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Address(RVA="0x15858A4", Offset="0x15858A4", VA="0x15858A4", Slot="6")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	public event Action<PointerEventData> BeginDrag
	{
		[Address(RVA="0x158520C", Offset="0x158520C", VA="0x158520C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070F1C", Offset="0x1070F1C")]
		add
		{
		}
		[Address(RVA="0x15852F8", Offset="0x15852F8", VA="0x15852F8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070F2C", Offset="0x1070F2C")]
		remove
		{
		}
	}

	public event Action<PointerEventData> Drag
	{
		[Address(RVA="0x15853E4", Offset="0x15853E4", VA="0x15853E4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070F3C", Offset="0x1070F3C")]
		add
		{
		}
		[Address(RVA="0x15854D0", Offset="0x15854D0", VA="0x15854D0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070F4C", Offset="0x1070F4C")]
		remove
		{
		}
	}

	public event Action<PointerEventData, UiDragHandler.Swipe, Vector2> EndDrag
	{
		[Address(RVA="0x15855BC", Offset="0x15855BC", VA="0x15855BC")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070F5C", Offset="0x1070F5C")]
		add
		{
		}
		[Address(RVA="0x15856A8", Offset="0x15856A8", VA="0x15856A8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070F6C", Offset="0x1070F6C")]
		remove
		{
		}
	}

	public enum Swipe
	{
		[FieldOffset(Offset="0x0")]
		None,
		[FieldOffset(Offset="0x0")]
		XSwipe,
		[FieldOffset(Offset="0x0")]
		YSwipe,
		[FieldOffset(Offset="0x0")]
		XYSwipe
	}
}