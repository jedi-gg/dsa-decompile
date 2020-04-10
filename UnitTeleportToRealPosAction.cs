using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class UnitTeleportToRealPosAction : ATickableSequenceAction, IDiContainerSequenceAction
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051DCC", Offset="0x1051DCC")]
	[FieldOffset(Offset="0x30")]
	private Zenject.DiContainer <DiContainer>k__BackingField;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private BoundGameObject _unitGameObject;

	[FieldOffset(Offset="0x40")]
	private BattleUnitsController _battleUnitsController;

	public Zenject.DiContainer DiContainer
	{
		[Address(RVA="0x1515920", Offset="0x1515920", VA="0x1515920")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DEC4", Offset="0x106DEC4")]
		get
		{
			return JustDecompileGenerated_get_DiContainer();
		}
		[Address(RVA="0x1515928", Offset="0x1515928", VA="0x1515928", Slot="12")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DED4", Offset="0x106DED4")]
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

	[Address(RVA="0x1515A9C", Offset="0x1515A9C", VA="0x1515A9C")]
	public UnitTeleportToRealPosAction()
	{
	}

	[Address(RVA="0x15159B8", Offset="0x15159B8", VA="0x15159B8")]
	private void DoTeleport()
	{
	}

	[Address(RVA="0x1515930", Offset="0x1515930", VA="0x1515930", Slot="5")]
	public override void Initialize(List<Binding> bindings)
	{
	}

	[Address(RVA="0x15159B4", Offset="0x15159B4", VA="0x15159B4", Slot="8")]
	protected override void InternalPlay()
	{
	}

	[Address(RVA="0x1515A98", Offset="0x1515A98", VA="0x1515A98", Slot="9")]
	protected override void InternalTickUpdate(float deltaTime)
	{
	}
}