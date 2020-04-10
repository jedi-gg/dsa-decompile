using Glunies;
using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayAudioAction : ASequenceAction, IDiContainerSequenceAction
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051CBC", Offset="0x1051CBC")]
	[FieldOffset(Offset="0x28")]
	private Zenject.DiContainer <DiContainer>k__BackingField;

	[FieldOffset(Offset="0x30")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private BoundGameObject _audioSourceGameObject;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private BoundAudioClipGroup _audioClipGroup;

	public Zenject.DiContainer DiContainer
	{
		[Address(RVA="0x1412748", Offset="0x1412748", VA="0x1412748")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DDE4", Offset="0x106DDE4")]
		get
		{
			return JustDecompileGenerated_get_DiContainer();
		}
		[Address(RVA="0x1412750", Offset="0x1412750", VA="0x1412750", Slot="12")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DDF4", Offset="0x106DDF4")]
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

	[Address(RVA="0x1412C58", Offset="0x1412C58", VA="0x1412C58")]
	public PlayAudioAction()
	{
	}

	[Address(RVA="0x1412758", Offset="0x1412758", VA="0x1412758", Slot="5")]
	public override void Initialize(List<Binding> bindings)
	{
	}

	[Address(RVA="0x1412B28", Offset="0x1412B28", VA="0x1412B28", Slot="10")]
	protected override void InternalExit()
	{
	}

	[Address(RVA="0x1412948", Offset="0x1412948", VA="0x1412948", Slot="8")]
	protected override void InternalPlay()
	{
	}

	[Address(RVA="0x14127FC", Offset="0x14127FC", VA="0x14127FC", Slot="7")]
	public override void InvalidateGameObject(GameObject go)
	{
	}
}