using Glunies;
using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class StopAudioAction : ASequenceAction, IDiContainerSequenceAction
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051DAC", Offset="0x1051DAC")]
	[FieldOffset(Offset="0x28")]
	private Zenject.DiContainer <DiContainer>k__BackingField;

	[FieldOffset(Offset="0x30")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private BoundAudioClipGroup _audioClipGroup;

	public Zenject.DiContainer DiContainer
	{
		[Address(RVA="0x1227844", Offset="0x1227844", VA="0x1227844")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DEA4", Offset="0x106DEA4")]
		get
		{
			return JustDecompileGenerated_get_DiContainer();
		}
		[Address(RVA="0x122784C", Offset="0x122784C", VA="0x122784C", Slot="12")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DEB4", Offset="0x106DEB4")]
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

	[Address(RVA="0x12279CC", Offset="0x12279CC", VA="0x12279CC")]
	public StopAudioAction()
	{
	}

	[Address(RVA="0x1227854", Offset="0x1227854", VA="0x1227854", Slot="5")]
	public override void Initialize(List<Binding> bindings)
	{
	}

	[Address(RVA="0x12278D8", Offset="0x12278D8", VA="0x12278D8", Slot="8")]
	protected override void InternalPlay()
	{
	}
}