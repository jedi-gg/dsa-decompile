using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PolymorphAction : ASequenceAction, IDiContainerSequenceAction
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051D1C", Offset="0x1051D1C")]
	[FieldOffset(Offset="0x28")]
	private Zenject.DiContainer <DiContainer>k__BackingField;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BoundGameObject _target;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private BoundGameObject _polymorphUnitPrefab;

	[FieldOffset(Offset="0x40")]
	private BattleUnitsController _battleUnitsController;

	public Zenject.DiContainer DiContainer
	{
		[Address(RVA="0x127DAC8", Offset="0x127DAC8", VA="0x127DAC8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DE24", Offset="0x106DE24")]
		get
		{
			return JustDecompileGenerated_get_DiContainer();
		}
		[Address(RVA="0x127DAD0", Offset="0x127DAD0", VA="0x127DAD0", Slot="12")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DE34", Offset="0x106DE34")]
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

	[Address(RVA="0x127DCE4", Offset="0x127DCE4", VA="0x127DCE4")]
	public PolymorphAction()
	{
	}

	[Address(RVA="0x127DAD8", Offset="0x127DAD8", VA="0x127DAD8", Slot="5")]
	public override void Initialize(List<Binding> bindings)
	{
	}

	[Address(RVA="0x127DB7C", Offset="0x127DB7C", VA="0x127DB7C", Slot="8")]
	protected override void InternalPlay()
	{
	}

	[Address(RVA="0x127DCE0", Offset="0x127DCE0", VA="0x127DCE0", Slot="9")]
	protected override void InternalTickUpdate(float deltaTime)
	{
	}
}