using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
public class AnimationTriggerTrackBehaviour : PlayableBehaviour
{
	[FieldOffset(Offset="0x10")]
	[SerializeField]
	private string _triggerName;

	[FieldOffset(Offset="0x18")]
	private bool _firstFrame;

	[FieldOffset(Offset="0x20")]
	private Animator _animatorComponent;

	[FieldOffset(Offset="0x28")]
	private int _triggerHash;

	[Address(RVA="0x115BFF4", Offset="0x115BFF4", VA="0x115BFF4")]
	public AnimationTriggerTrackBehaviour()
	{
	}

	[Address(RVA="0x115C164", Offset="0x115C164", VA="0x115C164", Slot="14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Address(RVA="0x115C064", Offset="0x115C064", VA="0x115C064", Slot="20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}
}