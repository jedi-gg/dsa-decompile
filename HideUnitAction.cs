using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class HideUnitAction : ASequenceAction, IDiContainerSequenceAction
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051BFC", Offset="0x1051BFC")]
	[FieldOffset(Offset="0x28")]
	private Zenject.DiContainer <DiContainer>k__BackingField;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BoundGameObject _unitGo;

	[FieldOffset(Offset="0x38")]
	private BattleUnitsController _unitsController;

	[FieldOffset(Offset="0x40")]
	private DHiddenUnit _hidden;

	public Zenject.DiContainer DiContainer
	{
		[Address(RVA="0x12E84D4", Offset="0x12E84D4", VA="0x12E84D4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DDC4", Offset="0x106DDC4")]
		get
		{
			return JustDecompileGenerated_get_DiContainer();
		}
		[Address(RVA="0x12E84DC", Offset="0x12E84DC", VA="0x12E84DC", Slot="12")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DDD4", Offset="0x106DDD4")]
		set
		{
			JustDecompileGenerated_set_DiContainer(value);
		}
	}

	private Zenject.DiContainer JustDecompileGenerated_get_DiContainer()
	{
		return null;
	}

	public void JustDecompileGenerated_set_DiContainer(Zenject.DiContainer value)
	{
	}

	[Address(RVA="0x12E86B4", Offset="0x12E86B4", VA="0x12E86B4")]
	public HideUnitAction()
	{
	}

	[Address(RVA="0x12E84E4", Offset="0x12E84E4", VA="0x12E84E4", Slot="5")]
	public override void Initialize(List<Binding> bindings)
	{
	}

	[Address(RVA="0x12E86A8", Offset="0x12E86A8", VA="0x12E86A8", Slot="10")]
	protected override void InternalExit()
	{
	}

	[Address(RVA="0x12E85C0", Offset="0x12E85C0", VA="0x12E85C0", Slot="8")]
	protected override void InternalPlay()
	{
	}

	[Address(RVA="0x12E8568", Offset="0x12E8568", VA="0x12E8568", Slot="7")]
	public override void InvalidateGameObject(GameObject go)
	{
	}
}