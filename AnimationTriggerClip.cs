using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class AnimationTriggerClip : PlayableAsset, ITimelineClipAsset
{
	[FieldOffset(Offset="0x18")]
	private double DEFAULT_DURATION_FRAMES;

	[FieldOffset(Offset="0x20")]
	private double FRAMES_PER_SECOND;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private AnimationTriggerTrackBehaviour _template;

	public ClipCaps clipCaps
	{
		[Address(RVA="0x115BECC", Offset="0x115BECC", VA="0x115BECC", Slot="9")]
		get
		{
			return new ClipCaps();
		}
	}

	public override double duration
	{
		[Address(RVA="0x115BED4", Offset="0x115BED4", VA="0x115BED4", Slot="7")]
		get
		{
			return new double();
		}
	}

	[Address(RVA="0x115BF80", Offset="0x115BF80", VA="0x115BF80")]
	public AnimationTriggerClip()
	{
	}

	[Address(RVA="0x115BEE0", Offset="0x115BEE0", VA="0x115BEE0", Slot="6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return new Playable();
	}
}