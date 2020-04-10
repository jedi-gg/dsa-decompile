using Glunies;
using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class AlertTextSequenceAction : ASequenceAction, IDiContainerSequenceAction
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051AFC", Offset="0x1051AFC")]
	[FieldOffset(Offset="0x28")]
	private Zenject.DiContainer <DiContainer>k__BackingField;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BoundString _locKey;

	[FieldOffset(Offset="0x38")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x40")]
	private LocalizationManager _locMgr;

	[FieldOffset(Offset="0x48")]
	private string _localizedText;

	public Zenject.DiContainer DiContainer
	{
		[Address(RVA="0x1159AB0", Offset="0x1159AB0", VA="0x1159AB0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DD24", Offset="0x106DD24")]
		get
		{
			return JustDecompileGenerated_get_DiContainer();
		}
		[Address(RVA="0x1159AB8", Offset="0x1159AB8", VA="0x1159AB8", Slot="12")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DD34", Offset="0x106DD34")]
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

	[Address(RVA="0x1159C5C", Offset="0x1159C5C", VA="0x1159C5C")]
	public AlertTextSequenceAction()
	{
	}

	[Address(RVA="0x1159AC0", Offset="0x1159AC0", VA="0x1159AC0", Slot="5")]
	public override void Initialize(List<Binding> bindings)
	{
	}

	[Address(RVA="0x1159B6C", Offset="0x1159B6C", VA="0x1159B6C", Slot="8")]
	protected override void InternalPlay()
	{
	}
}