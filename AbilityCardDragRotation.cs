using Il2CppDummyDll;
using System;
using UnityEngine;

public class AbilityCardDragRotation : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	private const float ENABLED_DISTANCE_SQUARED = 1f;

	[FieldOffset(Offset="0x0")]
	private const float LOOK_AT_SCREEN_MAGNITUDE = 30f;

	[FieldOffset(Offset="0x0")]
	private const float LERP_FACTOR_POSITION = 0.2f;

	[FieldOffset(Offset="0x0")]
	private const float LERP_FACTOR_ROTATION = 0.3f;

	[FieldOffset(Offset="0x18")]
	private RectTransform _rectTransform;

	[FieldOffset(Offset="0x20")]
	private Vector3 _screenPos;

	[FieldOffset(Offset="0x2C")]
	private Vector3 _lookAtPos;

	public Vector2 DesiredPosition
	{
		[Address(RVA="0x10F63D4", Offset="0x10F63D4", VA="0x10F63D4")]
		set
		{
		}
	}

	[Address(RVA="0x10F6858", Offset="0x10F6858", VA="0x10F6858")]
	public AbilityCardDragRotation()
	{
	}

	[Address(RVA="0x10F63E8", Offset="0x10F63E8", VA="0x10F63E8")]
	private void Awake()
	{
	}

	[Address(RVA="0x10F6470", Offset="0x10F6470", VA="0x10F6470")]
	private void OnEnable()
	{
	}

	[Address(RVA="0x10F64C4", Offset="0x10F64C4", VA="0x10F64C4")]
	private void Update()
	{
	}
}