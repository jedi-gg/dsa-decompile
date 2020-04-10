using Glunies;
using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayUnitAudioRefAction : ASequenceAction, IDiContainerSequenceAction
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051CEC", Offset="0x1051CEC")]
	[FieldOffset(Offset="0x28")]
	private Zenject.DiContainer <DiContainer>k__BackingField;

	[FieldOffset(Offset="0x30")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private BoundGameObject _audioSourceGameObject;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private BoundString _audioClipId;

	public Zenject.DiContainer DiContainer
	{
		[Address(RVA="0x1412C60", Offset="0x1412C60", VA="0x1412C60")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DE04", Offset="0x106DE04")]
		get
		{
			return JustDecompileGenerated_get_DiContainer();
		}
		[Address(RVA="0x1412C68", Offset="0x1412C68", VA="0x1412C68", Slot="12")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DE14", Offset="0x106DE14")]
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

	[Address(RVA="0x1413058", Offset="0x1413058", VA="0x1413058")]
	public PlayUnitAudioRefAction()
	{
	}

	[Address(RVA="0x1412C70", Offset="0x1412C70", VA="0x1412C70", Slot="5")]
	public override void Initialize(List<Binding> bindings)
	{
	}

	[Address(RVA="0x1412E68", Offset="0x1412E68", VA="0x1412E68", Slot="8")]
	protected override void InternalPlay()
	{
	}

	[Address(RVA="0x1412D14", Offset="0x1412D14", VA="0x1412D14", Slot="7")]
	public override void InvalidateGameObject(GameObject go)
	{
	}
}