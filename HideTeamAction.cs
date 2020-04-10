using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class HideTeamAction : ASequenceAction, IDiContainerSequenceAction
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051BCC", Offset="0x1051BCC")]
	[FieldOffset(Offset="0x28")]
	private Zenject.DiContainer <DiContainer>k__BackingField;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BoundGameObject _sourceUnitGo;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private BoundBool _hideSourceUnit;

	[FieldOffset(Offset="0x40")]
	private BattleUnitsController _unitsController;

	[FieldOffset(Offset="0x48")]
	private List<DHiddenUnit> _hiddenUnits;

	public Zenject.DiContainer DiContainer
	{
		[Address(RVA="0x12E7E48", Offset="0x12E7E48", VA="0x12E7E48")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DDA4", Offset="0x106DDA4")]
		get
		{
			return JustDecompileGenerated_get_DiContainer();
		}
		[Address(RVA="0x12E7E50", Offset="0x12E7E50", VA="0x12E7E50", Slot="12")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DDB4", Offset="0x106DDB4")]
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

	[Address(RVA="0x12E8460", Offset="0x12E8460", VA="0x12E8460")]
	public HideTeamAction()
	{
	}

	[Address(RVA="0x12E7E58", Offset="0x12E7E58", VA="0x12E7E58", Slot="5")]
	public override void Initialize(List<Binding> bindings)
	{
	}

	[Address(RVA="0x12E8314", Offset="0x12E8314", VA="0x12E8314", Slot="10")]
	protected override void InternalExit()
	{
	}

	[Address(RVA="0x12E8070", Offset="0x12E8070", VA="0x12E8070", Slot="8")]
	protected override void InternalPlay()
	{
	}

	[Address(RVA="0x12E7EFC", Offset="0x12E7EFC", VA="0x12E7EFC", Slot="7")]
	public override void InvalidateGameObject(GameObject go)
	{
	}
}