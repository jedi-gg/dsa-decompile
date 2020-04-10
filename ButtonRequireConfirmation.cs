using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="RequireComponent", RVA="0x1048B30", Offset="0x1048B30")]
public class ButtonRequireConfirmation : MonoBehaviour, ILoggable<LogCategory>
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105DA90", Offset="0x105DA90")]
	[FieldOffset(Offset="0x18")]
	private Action ConfirmationInitiated;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105DAA0", Offset="0x105DAA0")]
	[FieldOffset(Offset="0x20")]
	private Action ConfirmationExpired;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private InteractableOverrideButton _button;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UiLabel _confirmLabel;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private UiAnimatedGradientEffect _gradientEffect;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private float _confirmTimeoutSeconds;

	[FieldOffset(Offset="0x44")]
	[SerializeField]
	private float _confirmAnimationDuration;

	[FieldOffset(Offset="0x48")]
	private Sequence _confirmSeq;

	[FieldOffset(Offset="0x50")]
	private bool _waitingForConfirmationPress;

	[FieldOffset(Offset="0x54")]
	private float _confirmTimer;

	public UiLabel Label
	{
		[Address(RVA="0x1121F04", Offset="0x1121F04", VA="0x1121F04")]
		get
		{
			return null;
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x1121EC0", Offset="0x1121EC0", VA="0x1121EC0", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	public bool WaitingForConfirmationPress
	{
		[Address(RVA="0x1121EC8", Offset="0x1121EC8", VA="0x1121EC8")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11231C0", Offset="0x11231C0", VA="0x11231C0")]
	public ButtonRequireConfirmation()
	{
	}

	[Address(RVA="0x11222B0", Offset="0x11222B0", VA="0x11222B0")]
	private void Awake()
	{
	}

	[Address(RVA="0x1122EBC", Offset="0x1122EBC", VA="0x1122EBC")]
	private void ConfirmSequenceEnded()
	{
	}

	[Address(RVA="0x1122E28", Offset="0x1122E28", VA="0x1122E28")]
	private void ConfirmSequenceStarted()
	{
	}

	[Address(RVA="0x1122264", Offset="0x1122264", VA="0x1122264")]
	private void HideConfirmEnded()
	{
	}

	[Address(RVA="0x1121FA8", Offset="0x1121FA8", VA="0x1121FA8")]
	private void HideConfirmStarted()
	{
	}

	[Address(RVA="0x1122E10", Offset="0x1122E10", VA="0x1122E10")]
	private void OnDestroy()
	{
	}

	[Address(RVA="0x1121F6C", Offset="0x1121F6C", VA="0x1121F6C")]
	public void ResetState()
	{
	}

	[Address(RVA="0x1121F0C", Offset="0x1121F0C", VA="0x1121F0C")]
	public void ShowConfirmation(bool show)
	{
	}

	[Address(RVA="0x1122F04", Offset="0x1122F04", VA="0x1122F04")]
	private void ShowConfirmEnded()
	{
	}

	[Address(RVA="0x1122E70", Offset="0x1122E70", VA="0x1122E70")]
	private void ShowConfirmStarted()
	{
	}

	[Address(RVA="0x1122D4C", Offset="0x1122D4C", VA="0x1122D4C")]
	private void Update()
	{
	}

	public event Action ConfirmationExpired
	{
		[Address(RVA="0x1121CE8", Offset="0x1121CE8", VA="0x1121CE8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070E7C", Offset="0x1070E7C")]
		add
		{
		}
		[Address(RVA="0x1121DD4", Offset="0x1121DD4", VA="0x1121DD4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070E8C", Offset="0x1070E8C")]
		remove
		{
		}
	}

	public event Action ConfirmationInitiated
	{
		[Address(RVA="0x1121B10", Offset="0x1121B10", VA="0x1121B10")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070E5C", Offset="0x1070E5C")]
		add
		{
		}
		[Address(RVA="0x1121BFC", Offset="0x1121BFC", VA="0x1121BFC")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070E6C", Offset="0x1070E6C")]
		remove
		{
		}
	}
}