using Cinemachine;
using Il2CppDummyDll;
using System;
using UnityEngine.Playables;

namespace Cinemachine.Timeline
{
	public sealed class CinemachineMixer : PlayableBehaviour
	{
		[FieldOffset(Offset="0x10")]
		private CinemachineBrain mBrain;

		[FieldOffset(Offset="0x18")]
		private int mBrainOverrideId;

		[FieldOffset(Offset="0x1C")]
		private bool mPlaying;

		[FieldOffset(Offset="0x20")]
		private float mLastOverrideFrame;

		[Address(RVA="0x1460530", Offset="0x1460530", VA="0x1460530")]
		public CinemachineMixer()
		{
		}

		[Address(RVA="0x145FFFC", Offset="0x145FFFC", VA="0x145FFFC", Slot="14")]
		public override void OnGraphStop(Playable playable)
		{
		}

		[Address(RVA="0x14604FC", Offset="0x14604FC", VA="0x14604FC", Slot="19")]
		public override void PrepareFrame(Playable playable, FrameData info)
		{
		}

		[Address(RVA="0x14600B0", Offset="0x14600B0", VA="0x14600B0", Slot="20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}
	}
}