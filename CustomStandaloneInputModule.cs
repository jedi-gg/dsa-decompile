using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class CustomStandaloneInputModule : StandaloneInputModule
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051ABC", Offset="0x1051ABC")]
	[FieldOffset(Offset="0xB8")]
	private Action<GameObject> ButtonPressed;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051ACC", Offset="0x1051ACC")]
	[FieldOffset(Offset="0xC0")]
	private Action IsolatedInputObjectClicked;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051ADC", Offset="0x1051ADC")]
	[FieldOffset(Offset="0xC8")]
	private GameObject <IsolatedAllowedInputObject>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051AEC", Offset="0x1051AEC")]
	[FieldOffset(Offset="0xD0")]
	private bool <BypassIsolatedAllowedInputObject>k__BackingField;

	public bool BypassIsolatedAllowedInputObject
	{
		[Address(RVA="0x153B788", Offset="0x153B788", VA="0x153B788")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DCE4", Offset="0x106DCE4")]
		get
		{
			return new bool();
		}
		[Address(RVA="0x153B790", Offset="0x153B790", VA="0x153B790")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DCF4", Offset="0x106DCF4")]
		set
		{
		}
	}

	public GameObject IsolatedAllowedInputObject
	{
		[Address(RVA="0x153B778", Offset="0x153B778", VA="0x153B778")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DCC4", Offset="0x106DCC4")]
		get
		{
			return null;
		}
		[Address(RVA="0x153B780", Offset="0x153B780", VA="0x153B780")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DCD4", Offset="0x106DCD4")]
		set
		{
		}
	}

	[Address(RVA="0x153CBB8", Offset="0x153CBB8", VA="0x153CBB8")]
	public CustomStandaloneInputModule()
	{
	}

	[Address(RVA="0x153C33C", Offset="0x153C33C", VA="0x153C33C")]
	private void HandleClick(PointerEventData pointerEvent, GameObject isolatedAllowedInputObject, bool clickEventWillFire)
	{
	}

	[Address(RVA="0x153BFFC", Offset="0x153BFFC", VA="0x153BFFC")]
	private void HandlePointerClickPress(PointerEventData data)
	{
	}

	[Address(RVA="0x153B79C", Offset="0x153B79C", VA="0x153B79C", Slot="17")]
	public override void Process()
	{
	}

	[Address(RVA="0x153C68C", Offset="0x153C68C", VA="0x153C68C", Slot="29")]
	protected override void ProcessDrag(PointerEventData pointerEvent)
	{
	}

	[Address(RVA="0x153BB68", Offset="0x153BB68", VA="0x153BB68")]
	protected new void ProcessMouseEvent()
	{
	}

	[Address(RVA="0x153BB70", Offset="0x153BB70", VA="0x153BB70")]
	protected new void ProcessMouseEvent(int id)
	{
	}

	[Address(RVA="0x153B8C8", Offset="0x153B8C8", VA="0x153B8C8")]
	private bool ProcessTouchEvents()
	{
		return new bool();
	}

	[Address(RVA="0x153B8A4", Offset="0x153B8A4", VA="0x153B8A4")]
	private bool ShouldIgnoreEventsOnNoFocus()
	{
		return new bool();
	}

	[Address(RVA="0x153C528", Offset="0x153C528", VA="0x153C528")]
	private bool ShouldProcessPress(PointerEventData pointerEventData, bool pressed, bool released, GameObject isolatedAllowedInputObject)
	{
		return new bool();
	}

	[Address(RVA="0x153CA9C", Offset="0x153CA9C", VA="0x153CA9C")]
	private bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
	{
		return new bool();
	}

	[Address(RVA="0x153C114", Offset="0x153C114", VA="0x153C114")]
	private bool WillClickProcessThisFrame(PointerEventData pointerEvent, bool pressedThisFrame, bool releasedThisFrame)
	{
		return new bool();
	}

	public event Action<GameObject> ButtonPressed
	{
		[Address(RVA="0x153B3C8", Offset="0x153B3C8", VA="0x153B3C8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DC84", Offset="0x106DC84")]
		add
		{
		}
		[Address(RVA="0x153B4B4", Offset="0x153B4B4", VA="0x153B4B4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DC94", Offset="0x106DC94")]
		remove
		{
		}
	}

	public event Action IsolatedInputObjectClicked
	{
		[Address(RVA="0x153B5A0", Offset="0x153B5A0", VA="0x153B5A0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DCA4", Offset="0x106DCA4")]
		add
		{
		}
		[Address(RVA="0x153B68C", Offset="0x153B68C", VA="0x153B68C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DCB4", Offset="0x106DCB4")]
		remove
		{
		}
	}
}