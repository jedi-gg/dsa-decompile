using BattleLib;
using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using Zenject;

public class ReportEncounterTransitionDoneAction : ASequenceAction, IDiContainerSequenceAction
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051D6C", Offset="0x1051D6C")]
	[FieldOffset(Offset="0x28")]
	private Zenject.DiContainer <DiContainer>k__BackingField;

	[FieldOffset(Offset="0x30")]
	private ABattle _battle;

	public Zenject.DiContainer DiContainer
	{
		[Address(RVA="0x2C2FA50", Offset="0x2C2FA50", VA="0x2C2FA50")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DE64", Offset="0x106DE64")]
		get
		{
			return JustDecompileGenerated_get_DiContainer();
		}
		[Address(RVA="0x2C2FA58", Offset="0x2C2FA58", VA="0x2C2FA58", Slot="12")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DE74", Offset="0x106DE74")]
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

	[Address(RVA="0x2C2FAD0", Offset="0x2C2FAD0", VA="0x2C2FAD0")]
	public ReportEncounterTransitionDoneAction()
	{
	}

	[Address(RVA="0x2C2FA60", Offset="0x2C2FA60", VA="0x2C2FA60", Slot="5")]
	public override void Initialize(List<Binding> bindings)
	{
	}

	[Address(RVA="0x2C2FABC", Offset="0x2C2FABC", VA="0x2C2FABC", Slot="8")]
	protected override void InternalPlay()
	{
	}
}