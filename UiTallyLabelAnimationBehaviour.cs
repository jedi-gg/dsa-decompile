using Il2CppDummyDll;
using System;
using UnityEngine.Playables;

[Serializable]
public class UiTallyLabelAnimationBehaviour : PlayableBehaviour
{
	[FieldOffset(Offset="0x10")]
	private bool _isPlaying;

	[FieldOffset(Offset="0x18")]
	private UiParticleFitToLabel _particleFitter;

	[FieldOffset(Offset="0x20")]
	private TallyLabelSigned _tallyLabel;

	[Address(RVA="0x158E9E8", Offset="0x158E9E8", VA="0x158E9E8")]
	public UiTallyLabelAnimationBehaviour()
	{
	}

	[Address(RVA="0x158E4C4", Offset="0x158E4C4", VA="0x158E4C4", Slot="18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Address(RVA="0x158E49C", Offset="0x158E49C", VA="0x158E49C", Slot="16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Address(RVA="0x158E644", Offset="0x158E644", VA="0x158E644", Slot="20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}
}