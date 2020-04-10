using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

[Attribute(Name="RequireComponent", RVA="0x1048E10", Offset="0x1048E10")]
public class ToggleEx : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private Graphic _offGraphic;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private UiLabel _onLabel;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private UiLabel _offLabel;

	[FieldOffset(Offset="0x0")]
	private readonly static Color s_nonInteractableColor;

	[FieldOffset(Offset="0x30")]
	private Toggle _toggle;

	[FieldOffset(Offset="0x38")]
	private Action<bool> _onChange;

	[FieldOffset(Offset="0x40")]
	private Color _offGraphicOriginalColor;

	[Address(RVA="0x1329850", Offset="0x1329850", VA="0x1329850")]
	static ToggleEx()
	{
	}

	[Address(RVA="0x1329848", Offset="0x1329848", VA="0x1329848")]
	public ToggleEx()
	{
	}

	[Address(RVA="0x132906C", Offset="0x132906C", VA="0x132906C")]
	public void Initialize(bool isOn, Action<bool> onChange, LocalizationManager lm)
	{
	}

	[Address(RVA="0x13295D8", Offset="0x13295D8", VA="0x13295D8")]
	private void OnEnable()
	{
	}

	[Address(RVA="0x13293F0", Offset="0x13293F0", VA="0x13293F0")]
	public void SetToggleInteractable(bool interactable)
	{
	}

	[Address(RVA="0x1329370", Offset="0x1329370", VA="0x1329370")]
	public void SetToggleIsOn(bool isOn, bool broadcast = true)
	{
	}

	[Address(RVA="0x1329324", Offset="0x1329324", VA="0x1329324")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x13296FC", Offset="0x13296FC", VA="0x13296FC")]
	private void ToggleChanged(bool isOn)
	{
	}
}