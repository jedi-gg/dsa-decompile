using Il2CppDummyDll;
using System;
using UnityEngine.Playables;

[Serializable]
public class UiParticleStreamAnimationBehaviour : PlayableBehaviour
{
	[FieldOffset(Offset="0x10")]
	private bool _isPlaying;

	[Address(RVA="0x158AE68", Offset="0x158AE68", VA="0x158AE68")]
	public UiParticleStreamAnimationBehaviour()
	{
	}

	[Address(RVA="0x158ACB0", Offset="0x158ACB0", VA="0x158ACB0", Slot="18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Address(RVA="0x158AD04", Offset="0x158AD04", VA="0x158AD04", Slot="20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}
}