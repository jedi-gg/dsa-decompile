using Glunies;
using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ShowHealthBarAction : ASequenceAction, IDiContainerSequenceAction
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051D7C", Offset="0x1051D7C")]
	[FieldOffset(Offset="0x28")]
	private Zenject.DiContainer <DiContainer>k__BackingField;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BoundGameObject _target;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private BoundEnum _healthBarVisibility;

	[FieldOffset(Offset="0x40")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x48")]
	private BattleUnitsController _battleUnitsController;

	public Zenject.DiContainer DiContainer
	{
		[Address(RVA="0x14C36E8", Offset="0x14C36E8", VA="0x14C36E8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DE84", Offset="0x106DE84")]
		get
		{
			return JustDecompileGenerated_get_DiContainer();
		}
		[Address(RVA="0x14C36F0", Offset="0x14C36F0", VA="0x14C36F0", Slot="12")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DE94", Offset="0x106DE94")]
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

	[Address(RVA="0x14C38A8", Offset="0x14C38A8", VA="0x14C38A8")]
	public ShowHealthBarAction()
	{
	}

	[Address(RVA="0x14C36F8", Offset="0x14C36F8", VA="0x14C36F8", Slot="5")]
	public override void Initialize(List<Binding> bindings)
	{
	}

	[Address(RVA="0x14C37C4", Offset="0x14C37C4", VA="0x14C37C4", Slot="8")]
	protected override void InternalPlay()
	{
	}

	[Address(RVA="0x14C38A4", Offset="0x14C38A4", VA="0x14C38A4", Slot="9")]
	protected override void InternalTickUpdate(float deltaTime)
	{
	}
}