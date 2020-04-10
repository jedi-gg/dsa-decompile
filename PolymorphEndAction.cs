using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PolymorphEndAction : ASequenceAction, IDiContainerSequenceAction
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051D4C", Offset="0x1051D4C")]
	[FieldOffset(Offset="0x28")]
	private Zenject.DiContainer <DiContainer>k__BackingField;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BoundGameObject _target;

	[FieldOffset(Offset="0x38")]
	private BattleUnitsController _battleUnitsController;

	public Zenject.DiContainer DiContainer
	{
		[Address(RVA="0x127DCEC", Offset="0x127DCEC", VA="0x127DCEC")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DE44", Offset="0x106DE44")]
		get
		{
			return JustDecompileGenerated_get_DiContainer();
		}
		[Address(RVA="0x127DCF4", Offset="0x127DCF4", VA="0x127DCF4", Slot="12")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DE54", Offset="0x106DE54")]
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

	[Address(RVA="0x127DE64", Offset="0x127DE64", VA="0x127DE64")]
	public PolymorphEndAction()
	{
	}

	[Address(RVA="0x127DCFC", Offset="0x127DCFC", VA="0x127DCFC", Slot="5")]
	public override void Initialize(List<Binding> bindings)
	{
	}

	[Address(RVA="0x127DD80", Offset="0x127DD80", VA="0x127DD80", Slot="8")]
	protected override void InternalPlay()
	{
	}

	[Address(RVA="0x127DE60", Offset="0x127DE60", VA="0x127DE60", Slot="9")]
	protected override void InternalTickUpdate(float deltaTime)
	{
	}
}