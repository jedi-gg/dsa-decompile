using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Attribute(Name="RequireComponent", RVA="0x1048F8C", Offset="0x1048F8C")]
public class UiSuperSlider : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private Slider _slider;

	[FieldOffset(Offset="0x20")]
	private Tweener _valueChangedTween;

	[FieldOffset(Offset="0x28")]
	private IHapticController _hapticController;

	[FieldOffset(Offset="0x30")]
	private UiSuperSlider.DCappedColorData? _cappedColorData;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private float _valueChangedTweenDuration;

	[FieldOffset(Offset="0x4C")]
	[SerializeField]
	private float _valueChangedTweenMagnitude;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private UiLabel _valueLabel;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private UiLabel _minValueLabel;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private UiLabel _maxValueLabel;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private Button _decrementButton;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private Button _incrementButton;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private bool _hideMinMaxLabelBehindSlider;

	public bool Interactable
	{
		[Address(RVA="0x158C1C8", Offset="0x158C1C8", VA="0x158C1C8")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x158C268", Offset="0x158C268", VA="0x158C268")]
		set
		{
		}
	}

	public float MaxValue
	{
		[Address(RVA="0x158C128", Offset="0x158C128", VA="0x158C128")]
		get
		{
			return new float();
		}
	}

	public float MinValue
	{
		[Address(RVA="0x158C088", Offset="0x158C088", VA="0x158C088")]
		get
		{
			return new float();
		}
	}

	public float Value
	{
		[Address(RVA="0x158BEBC", Offset="0x158BEBC", VA="0x158BEBC")]
		get
		{
			return new float();
		}
		[Address(RVA="0x158BF64", Offset="0x158BF64", VA="0x158BF64")]
		set
		{
		}
	}

	[Address(RVA="0x158D2F4", Offset="0x158D2F4", VA="0x158D2F4")]
	public UiSuperSlider()
	{
	}

	[Address(RVA="0x158D288", Offset="0x158D288", VA="0x158D288")]
	private void DecrementSlider()
	{
	}

	[Address(RVA="0x158D21C", Offset="0x158D21C", VA="0x158D21C")]
	private void IncrementSlider()
	{
	}

	[Address(RVA="0x158C3B8", Offset="0x158C3B8", VA="0x158C3B8")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x158CC38", Offset="0x158CC38", VA="0x158CC38")]
	public void SetCappedColorData(UiSuperSlider.DCappedColorData data)
	{
	}

	[Address(RVA="0x158C858", Offset="0x158C858", VA="0x158C858")]
	public void SetMaxValue(float maxValue)
	{
	}

	[Address(RVA="0x158C780", Offset="0x158C780", VA="0x158C780")]
	public void SetMinValue(float minValue)
	{
	}

	[Address(RVA="0x158CB68", Offset="0x158CB68", VA="0x158CB68")]
	public void SetValueChangedCallback(UnityAction<float> valueChangedCallback)
	{
	}

	[Address(RVA="0x158C930", Offset="0x158C930", VA="0x158C930")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x158CCDC", Offset="0x158CCDC", VA="0x158CCDC")]
	private void SliderValueChanged(float value)
	{
	}

	public struct DCappedColorData
	{
		[FieldOffset(Offset="0x0")]
		public float CappedValue;

		[FieldOffset(Offset="0x4")]
		public Color CappedColor;
	}
}