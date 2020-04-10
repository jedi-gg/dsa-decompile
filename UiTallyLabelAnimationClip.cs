using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class UiTallyLabelAnimationClip : PlayableAsset, ITimelineClipAsset
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private UiTallyLabelAnimationBehaviour _template;

	public ClipCaps clipCaps
	{
		[Address(RVA="0x158E9F0", Offset="0x158E9F0", VA="0x158E9F0", Slot="9")]
		get
		{
			return new ClipCaps();
		}
	}

	[Address(RVA="0x158EA98", Offset="0x158EA98", VA="0x158EA98")]
	public UiTallyLabelAnimationClip()
	{
	}

	[Address(RVA="0x158E9F8", Offset="0x158E9F8", VA="0x158E9F8", Slot="6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return new Playable();
	}
}