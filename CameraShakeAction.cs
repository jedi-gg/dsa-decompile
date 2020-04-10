using Glunies;
using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class CameraShakeAction : ASequenceAction, IDiContainerSequenceAction
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051B5C", Offset="0x1051B5C")]
	[FieldOffset(Offset="0x28")]
	private Zenject.DiContainer <DiContainer>k__BackingField;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BoundEnum _intensity;

	[FieldOffset(Offset="0x38")]
	private DispatchSystem _dispatch;

	public Zenject.DiContainer DiContainer
	{
		[Address(RVA="0x1124E10", Offset="0x1124E10", VA="0x1124E10")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DD64", Offset="0x106DD64")]
		get
		{
			return JustDecompileGenerated_get_DiContainer();
		}
		[Address(RVA="0x1124E18", Offset="0x1124E18", VA="0x1124E18", Slot="12")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DD74", Offset="0x106DD74")]
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

	[Address(RVA="0x1124F40", Offset="0x1124F40", VA="0x1124F40")]
	public CameraShakeAction()
	{
	}

	[Address(RVA="0x1124E20", Offset="0x1124E20", VA="0x1124E20", Slot="5")]
	public override void Initialize(List<Binding> bindings)
	{
	}

	[Address(RVA="0x1124EA4", Offset="0x1124EA4", VA="0x1124EA4", Slot="8")]
	protected override void InternalPlay()
	{
	}

	[Address(RVA="0x1124F3C", Offset="0x1124F3C", VA="0x1124F3C", Slot="9")]
	protected override void InternalTickUpdate(float deltaTime)
	{
	}
}