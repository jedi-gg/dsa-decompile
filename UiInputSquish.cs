using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

[Attribute(Name="ExecuteAlways", RVA="0x1048E74", Offset="0x1048E74")]
[Attribute(Name="RequireComponent", RVA="0x1048E74", Offset="0x1048E74")]
public class UiInputSquish : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
	[FieldOffset(Offset="0x0")]
	private const float PRESSED_SCALE_UP_FACTOR = 1.15f;

	[FieldOffset(Offset="0x0")]
	private const float PRESSED_SCALE_DOWN_FACTOR = 0.85f;

	[FieldOffset(Offset="0x0")]
	private const float SELECTED_SCALE = 1.075f;

	[FieldOffset(Offset="0x0")]
	private const float DURATION = 0.25f;

	[FieldOffset(Offset="0x0")]
	private static EaseUtil.EaseFunction s_easeFunction;

	[FieldOffset(Offset="0x18")]
	private DrivenRectTransformTracker _drivenRectTracker;

	[FieldOffset(Offset="0x20")]
	private Transform _transform;

	[FieldOffset(Offset="0x28")]
	private Vector3 _defaultScale;

	[FieldOffset(Offset="0x34")]
	private Vector3 _selectedScale;

	[FieldOffset(Offset="0x40")]
	private Vector3 _pressScale;

	[FieldOffset(Offset="0x4C")]
	private float _timer;

	[FieldOffset(Offset="0x50")]
	private bool _isPressed;

	[FieldOffset(Offset="0x51")]
	private bool _isOver;

	[FieldOffset(Offset="0x52")]
	private bool _isSelected;

	[FieldOffset(Offset="0x53")]
	[SerializeField]
	private bool _scaleDown;

	[FieldOffset(Offset="0x54")]
	[SerializeField]
	private bool _overridePressScale;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private Vector3 _overridePressScaleValue;

	[FieldOffset(Offset="0x64")]
	[SerializeField]
	private bool _overrideSelectedScale;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private Vector3 _overrideSelectedScaleValue;

	[FieldOffset(Offset="0x74")]
	[SerializeField]
	private bool _overridePivot;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private Vector2 _overridePivotValue;

	[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x105E29C", Offset="0x105E29C")]
	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private bool _overrideTransform;

	[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x105E2E8", Offset="0x105E2E8")]
	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private Transform _overrideTransformValue;

	public bool IsInactive
	{
		[Address(RVA="0x1585FA8", Offset="0x1585FA8", VA="0x1585FA8")]
		get
		{
			return new bool();
		}
	}

	public Vector2 OverridePivotValue
	{
		[Address(RVA="0x15867C4", Offset="0x15867C4", VA="0x15867C4")]
		get
		{
			return new Vector2();
		}
		[Address(RVA="0x15867CC", Offset="0x15867CC", VA="0x15867CC")]
		set
		{
		}
	}

	[Address(RVA="0x1586890", Offset="0x1586890", VA="0x1586890")]
	static UiInputSquish()
	{
	}

	[Address(RVA="0x15867D4", Offset="0x15867D4", VA="0x15867D4")]
	public UiInputSquish()
	{
	}

	[Address(RVA="0x158650C", Offset="0x158650C", VA="0x158650C")]
	private void Awake()
	{
	}

	[Address(RVA="0x1586248", Offset="0x1586248", VA="0x1586248")]
	private void EaseScale()
	{
	}

	[Address(RVA="0x15867B8", Offset="0x15867B8", VA="0x15867B8")]
	private void OnDisable()
	{
	}

	[Address(RVA="0x15866CC", Offset="0x15866CC", VA="0x15866CC")]
	private void OnEnable()
	{
	}

	[Address(RVA="0x15864BC", Offset="0x15864BC", VA="0x15864BC", Slot="4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Address(RVA="0x15864E0", Offset="0x15864E0", VA="0x15864E0", Slot="6")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Address(RVA="0x15864F8", Offset="0x15864F8", VA="0x15864F8", Slot="7")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Address(RVA="0x15864CC", Offset="0x15864CC", VA="0x15864CC", Slot="5")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[Address(RVA="0x1585FCC", Offset="0x1585FCC", VA="0x1585FCC")]
	public void ResetState()
	{
	}

	[Address(RVA="0x1586228", Offset="0x1586228", VA="0x1586228")]
	public void SetSelected(bool selected, bool immediate = false)
	{
	}

	[Address(RVA="0x1585FD8", Offset="0x1585FD8", VA="0x1585FD8")]
	public void TickUpdate()
	{
	}
}