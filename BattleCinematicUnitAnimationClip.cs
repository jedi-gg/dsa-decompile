using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class BattleCinematicUnitAnimationClip : PlayableAsset, ITimelineClipAsset
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private BattleCinematicUnitAnimationBehaviour _template;

	public ClipCaps clipCaps
	{
		[Address(RVA="0x113F184", Offset="0x113F184", VA="0x113F184", Slot="9")]
		get
		{
			return new ClipCaps();
		}
	}

	[Address(RVA="0x113F22C", Offset="0x113F22C", VA="0x113F22C")]
	public BattleCinematicUnitAnimationClip()
	{
	}

	[Address(RVA="0x113F18C", Offset="0x113F18C", VA="0x113F18C", Slot="6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return new Playable();
	}
}