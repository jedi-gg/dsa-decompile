using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class UiParticleStreamAnimationClip : PlayableAsset, ITimelineClipAsset
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private UiParticleStreamAnimationBehaviour _template;

	public ClipCaps clipCaps
	{
		[Address(RVA="0x158AE70", Offset="0x158AE70", VA="0x158AE70", Slot="9")]
		get
		{
			return new ClipCaps();
		}
	}

	[Address(RVA="0x158AF18", Offset="0x158AF18", VA="0x158AF18")]
	public UiParticleStreamAnimationClip()
	{
	}

	[Address(RVA="0x158AE78", Offset="0x158AE78", VA="0x158AE78", Slot="6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return new Playable();
	}
}