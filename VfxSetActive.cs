using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class VfxSetActive : StateMachineBehaviour, ILoggable<LogCategory>
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private string _targetSubObjId;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private VfxSetActive.BehaviourType _behaviourType;

	[FieldOffset(Offset="0x24")]
	[SerializeField]
	private bool _executeOnEnter;

	[FieldOffset(Offset="0x25")]
	[SerializeField]
	private bool _executeOnExit;

	public LogCategory LogCategory
	{
		[Address(RVA="0x15A2F40", Offset="0x15A2F40", VA="0x15A2F40", Slot="18")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x15A3468", Offset="0x15A3468", VA="0x15A3468")]
	public VfxSetActive()
	{
	}

	[Address(RVA="0x15A2F9C", Offset="0x15A2F9C", VA="0x15A2F9C")]
	private void Execute(GameObject gameObject)
	{
	}

	[Address(RVA="0x15A3104", Offset="0x15A3104", VA="0x15A3104")]
	private GameObject FindObj(GameObject gameObject)
	{
		return null;
	}

	[Address(RVA="0x15A2F48", Offset="0x15A2F48", VA="0x15A2F48", Slot="4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Address(RVA="0x15A30B0", Offset="0x15A30B0", VA="0x15A30B0", Slot="6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	private enum BehaviourType
	{
		[FieldOffset(Offset="0x0")]
		Activate,
		[FieldOffset(Offset="0x0")]
		DeActivate
	}
}