using Glunies;
using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BuffIconTimerAction : ASequenceAction, IDiContainerSequenceAction
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051B1C", Offset="0x1051B1C")]
	[FieldOffset(Offset="0x28")]
	private Zenject.DiContainer <DiContainer>k__BackingField;

	[FieldOffset(Offset="0x0")]
	private const uint INVALID_BUFF_ICON_ID = 4294967295;

	[FieldOffset(Offset="0x0")]
	private static uint s_nextBuffIconId;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BoundGameObject _target;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private BoundFloat _durationS;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private BoundEnum _buffIconType;

	[FieldOffset(Offset="0x48")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x50")]
	private BattleUnitsController _battleUnitsController;

	[FieldOffset(Offset="0x58")]
	private uint _buffIconId;

	public Zenject.DiContainer DiContainer
	{
		[Address(RVA="0x1121688", Offset="0x1121688", VA="0x1121688")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DD44", Offset="0x106DD44")]
		get
		{
			return JustDecompileGenerated_get_DiContainer();
		}
		[Address(RVA="0x1121690", Offset="0x1121690", VA="0x1121690", Slot="12")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DD54", Offset="0x106DD54")]
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

	public override float Duration
	{
		[Address(RVA="0x1121698", Offset="0x1121698", VA="0x1121698", Slot="4")]
		get
		{
			return new float();
		}
	}

	[Address(RVA="0x1121B00", Offset="0x1121B00", VA="0x1121B00")]
	public BuffIconTimerAction()
	{
	}

	[Address(RVA="0x112195C", Offset="0x112195C", VA="0x112195C")]
	private static uint GenerateBuffIconId()
	{
		return new uint();
	}

	[Address(RVA="0x11216C8", Offset="0x11216C8", VA="0x11216C8", Slot="5")]
	public override void Initialize(List<Binding> bindings)
	{
	}

	[Address(RVA="0x11219D0", Offset="0x11219D0", VA="0x11219D0", Slot="10")]
	protected override void InternalExit()
	{
	}

	[Address(RVA="0x11217B4", Offset="0x11217B4", VA="0x11217B4", Slot="8")]
	protected override void InternalPlay()
	{
	}

	[Address(RVA="0x11219CC", Offset="0x11219CC", VA="0x11219CC", Slot="9")]
	protected override void InternalTickUpdate(float deltaTime)
	{
	}
}