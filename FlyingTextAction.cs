using Glunies;
using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class FlyingTextAction : ASequenceAction, IDiContainerSequenceAction
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051B7C", Offset="0x1051B7C")]
	[FieldOffset(Offset="0x28")]
	private Zenject.DiContainer <DiContainer>k__BackingField;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BoundGameObject _target;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private BoundVector3 _targetPos;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private BoundString _locKey;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private BoundEnum _flyingTextType;

	[FieldOffset(Offset="0x50")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x58")]
	private LocalizationManager _locMgr;

	[FieldOffset(Offset="0x60")]
	private BattleUnitsController _battleUnitsController;

	[FieldOffset(Offset="0x68")]
	private string _localizedText;

	public Zenject.DiContainer DiContainer
	{
		[Address(RVA="0x12CA198", Offset="0x12CA198", VA="0x12CA198")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DD84", Offset="0x106DD84")]
		get
		{
			return JustDecompileGenerated_get_DiContainer();
		}
		[Address(RVA="0x12CA1A0", Offset="0x12CA1A0", VA="0x12CA1A0", Slot="12")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DD94", Offset="0x106DD94")]
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

	[Address(RVA="0x12CA580", Offset="0x12CA580", VA="0x12CA580")]
	public FlyingTextAction()
	{
	}

	[Address(RVA="0x12CA1A8", Offset="0x12CA1A8", VA="0x12CA1A8", Slot="5")]
	public override void Initialize(List<Binding> bindings)
	{
	}

	[Address(RVA="0x12CA2DC", Offset="0x12CA2DC", VA="0x12CA2DC", Slot="8")]
	protected override void InternalPlay()
	{
	}
}