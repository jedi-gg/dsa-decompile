using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PressEventHandler : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerExitHandler
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105DE00", Offset="0x105DE00")]
	[FieldOffset(Offset="0x18")]
	private Vector2 <PressPosition>k__BackingField;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private PressEventHandler.PointerDownEvent _onPress;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private PressEventHandler.PointerLongDownEvent _onLongPress;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PressEventHandler.PointerShortReleaseEvent _onShortRelease;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private float _longPressDurationSec;

	[FieldOffset(Offset="0x40")]
	private PointerEventData _pointerDownEventData;

	[FieldOffset(Offset="0x48")]
	private DateTime _longPressActivationTime;

	[FieldOffset(Offset="0x50")]
	private bool _hasLongPressFired;

	[FieldOffset(Offset="0x51")]
	private bool _isPointerDown;

	public PressEventHandler.PointerLongDownEvent OnLongPress
	{
		[Address(RVA="0x127DE7C", Offset="0x127DE7C", VA="0x127DE7C")]
		get
		{
			return null;
		}
		[Address(RVA="0x127DE84", Offset="0x127DE84", VA="0x127DE84")]
		set
		{
		}
	}

	public PressEventHandler.PointerDownEvent OnPress
	{
		[Address(RVA="0x127DE6C", Offset="0x127DE6C", VA="0x127DE6C")]
		get
		{
			return null;
		}
		[Address(RVA="0x127DE74", Offset="0x127DE74", VA="0x127DE74")]
		set
		{
		}
	}

	public PressEventHandler.PointerShortReleaseEvent OnShortRelease
	{
		[Address(RVA="0x127DE8C", Offset="0x127DE8C", VA="0x127DE8C")]
		get
		{
			return null;
		}
		[Address(RVA="0x127DE94", Offset="0x127DE94", VA="0x127DE94")]
		set
		{
		}
	}

	public Vector2 PressPosition
	{
		[Address(RVA="0x127DE9C", Offset="0x127DE9C", VA="0x127DE9C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070EDC", Offset="0x1070EDC")]
		get
		{
			return new Vector2();
		}
		[Address(RVA="0x127DEA4", Offset="0x127DEA4", VA="0x127DEA4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070EEC", Offset="0x1070EEC")]
		private set
		{
		}
	}

	[Address(RVA="0x127E0DC", Offset="0x127E0DC", VA="0x127E0DC")]
	public PressEventHandler()
	{
	}

	[Address(RVA="0x127E0C4", Offset="0x127E0C4", VA="0x127E0C4", Slot="11")]
	protected virtual void OnApplicationFocus(bool focus)
	{
	}

	[Address(RVA="0x127E0D0", Offset="0x127E0D0", VA="0x127E0D0", Slot="12")]
	protected virtual void OnApplicationPause(bool pause)
	{
	}

	[Address(RVA="0x127E0BC", Offset="0x127E0BC", VA="0x127E0BC", Slot="10")]
	public virtual void OnDisable()
	{
	}

	[Address(RVA="0x127DF68", Offset="0x127DF68", VA="0x127DF68", Slot="7")]
	public virtual void OnPointerDown(PointerEventData eventData)
	{
	}

	[Address(RVA="0x127E0B4", Offset="0x127E0B4", VA="0x127E0B4", Slot="9")]
	public virtual void OnPointerExit(PointerEventData eventData)
	{
	}

	[Address(RVA="0x127E044", Offset="0x127E044", VA="0x127E044", Slot="8")]
	public virtual void OnPointerUp(PointerEventData eventData)
	{
	}

	[Address(RVA="0x127DEAC", Offset="0x127DEAC", VA="0x127DEAC")]
	private void Update()
	{
	}

	[Serializable]
	public class PointerDownEvent : UnityEvent
	{
		[Address(RVA="0x127E1BC", Offset="0x127E1BC", VA="0x127E1BC")]
		public PointerDownEvent()
		{
		}
	}

	[Serializable]
	public class PointerLongDownEvent : UnityEvent
	{
		[Address(RVA="0x127E1C4", Offset="0x127E1C4", VA="0x127E1C4")]
		public PointerLongDownEvent()
		{
		}
	}

	[Serializable]
	public class PointerShortReleaseEvent : UnityEvent
	{
		[Address(RVA="0x127E1CC", Offset="0x127E1CC", VA="0x127E1CC")]
		public PointerShortReleaseEvent()
		{
		}
	}
}