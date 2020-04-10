using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSetColorAction : ASequenceAction
{
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private BoundString _name;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BoundColor _value;

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
	private Color _initialValue;

	[FieldOffset(Offset="0x60")]
	private float _totalTime;

	[FieldOffset(Offset="0x64")]
	private int _materialStackId;

	public override float Duration
	{
		[Address(RVA="0x11DB744", Offset="0x11DB744", VA="0x11DB744", Slot="4")]
		get
		{
			return new float();
		}
	}

	[Address(RVA="0x11DBCB8", Offset="0x11DBCB8", VA="0x11DBCB8")]
	public MaterialSetColorAction()
	{
	}

	[Address(RVA="0x11DB774", Offset="0x11DB774", VA="0x11DB774", Slot="5")]
	public override void Initialize(List<Binding> bindings)
	{
	}

	[Address(RVA="0x11DBC90", Offset="0x11DBC90", VA="0x11DBC90", Slot="10")]
	protected override void InternalExit()
	{
	}

	[Address(RVA="0x11DB98C", Offset="0x11DB98C", VA="0x11DB98C", Slot="8")]
	protected override void InternalPlay()
	{
	}

	[Address(RVA="0x11DBAA8", Offset="0x11DBAA8", VA="0x11DBAA8", Slot="9")]
	protected override void InternalTickUpdate(float deltaTime)
	{
	}

	[Address(RVA="0x11DB818", Offset="0x11DB818", VA="0x11DB818", Slot="7")]
	public override void InvalidateGameObject(GameObject go)
	{
	}

	[Address(RVA="0x11DB880", Offset="0x11DB880", VA="0x11DB880")]
	private void RestoreProperty()
	{
	}

	[Address(RVA="0x11DBB90", Offset="0x11DBB90", VA="0x11DBB90")]
	private void SetProperty(Color value)
	{
	}
}