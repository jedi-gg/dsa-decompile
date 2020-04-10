using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
public class BattleCinematicUnitAnimationBehaviour : PlayableBehaviour
{
	[FieldOffset(Offset="0x10")]
	[SerializeField]
	private BattleCinematicUnitAnimationBehaviour.Mode _mode;

	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private string _animatorTriggerName;

	[FieldOffset(Offset="0x20")]
	private GameObject _unitObj;

	[FieldOffset(Offset="0x28")]
	private bool _canTriggerAnimation;

	[FieldOffset(Offset="0x30")]
	private Animator _animatorComponent;

	[FieldOffset(Offset="0x38")]
	private int _animatorTriggerHash;

	[Address(RVA="0x113F17C", Offset="0x113F17C", VA="0x113F17C")]
	public BattleCinematicUnitAnimationBehaviour()
	{
	}

	[Address(RVA="0x113EF94", Offset="0x113EF94", VA="0x113EF94", Slot="18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Address(RVA="0x113F0B0", Offset="0x113F0B0", VA="0x113F0B0", Slot="14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Address(RVA="0x113ED94", Offset="0x113ED94", VA="0x113ED94", Slot="15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Address(RVA="0x113EDC8", Offset="0x113EDC8", VA="0x113EDC8", Slot="20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	public enum Mode
	{
		[FieldOffset(Offset="0x0")]
		Hide,
		[FieldOffset(Offset="0x0")]
		TriggerAnimation
	}
}