using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class VfxBehaviour : StateMachineBehaviour, ILoggable<LogCategory>
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private string _vfxSubObjId;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private VfxBehaviour.BehaviourType _behaviourType;

	[FieldOffset(Offset="0x24")]
	[SerializeField]
	private bool _executeOnEnter;

	[FieldOffset(Offset="0x25")]
	[SerializeField]
	private bool _executeOnExit;

	public LogCategory LogCategory
	{
		[Address(RVA="0x15A279C", Offset="0x15A279C", VA="0x15A279C", Slot="18")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x15A2F38", Offset="0x15A2F38", VA="0x15A2F38")]
	public VfxBehaviour()
	{
	}

	[Address(RVA="0x15A27F8", Offset="0x15A27F8", VA="0x15A27F8")]
	private void Execute(GameObject gameObject)
	{
	}

	[Address(RVA="0x15A2968", Offset="0x15A2968", VA="0x15A2968")]
	private ParticleSystem FindVfx(GameObject gameObject)
	{
		return null;
	}

	[Address(RVA="0x15A27A4", Offset="0x15A27A4", VA="0x15A27A4", Slot="4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Address(RVA="0x15A2914", Offset="0x15A2914", VA="0x15A2914", Slot="6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	private enum BehaviourType
	{
		[FieldOffset(Offset="0x0")]
		Play,
		[FieldOffset(Offset="0x0")]
		Stop
	}
}