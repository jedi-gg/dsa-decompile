using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSetFloatAction : ASequenceAction
{
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private BoundString _name;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BoundFloat _value;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private BoundGameObject _gameObject;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private BoundFloat _durationS;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private Easing _easing;

	[FieldOffset(Offset="0x4C")]
	private int _propertyId;

	[FieldOffset(Offset="0x50")]
	private float _initialValue;

	[FieldOffset(Offset="0x54")]
	private float _totalTime;

	[FieldOffset(Offset="0x58")]
	private int _materialStackId;

	public override float Duration
	{
		[Address(RVA="0x11DBD30", Offset="0x11DBD30", VA="0x11DBD30", Slot="4")]
		get
		{
			return new float();
		}
	}

	[Address(RVA="0x11DC294", Offset="0x11DC294", VA="0x11DC294")]
	public MaterialSetFloatAction()
	{
	}

	[Address(RVA="0x11DBD60", Offset="0x11DBD60", VA="0x11DBD60", Slot="5")]
	public override void Initialize(List<Binding> bindings)
	{
	}

	[Address(RVA="0x11DC26C", Offset="0x11DC26C", VA="0x11DC26C", Slot="10")]
	protected override void InternalExit()
	{
	}

	[Address(RVA="0x11DBF78", Offset="0x11DBF78", VA="0x11DBF78", Slot="8")]
	protected override void InternalPlay()
	{
	}

	[Address(RVA="0x11DC080", Offset="0x11DC080", VA="0x11DC080", Slot="9")]
	protected override void InternalTickUpdate(float deltaTime)
	{
	}

	[Address(RVA="0x11DBE04", Offset="0x11DBE04", VA="0x11DBE04", Slot="7")]
	public override void InvalidateGameObject(GameObject go)
	{
	}

	[Address(RVA="0x11DBE6C", Offset="0x11DBE6C", VA="0x11DBE6C")]
	private void RestoreProperty()
	{
	}

	[Address(RVA="0x11DC190", Offset="0x11DC190", VA="0x11DC190")]
	private void SetProperty(float value)
	{
	}
}