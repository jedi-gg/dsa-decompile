using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Sequencer
{
	public abstract class ATickableSequenceAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private ATickableSequenceAction.TickRate _updateRate;

		[Address(RVA="0x152B154", Offset="0x152B154", VA="0x152B154")]
		protected ATickableSequenceAction()
		{
		}

		[Address(RVA="0x152B120", Offset="0x152B120", VA="0x152B120", Slot="11")]
		protected override bool ShouldTickUpdate()
		{
			return new bool();
		}

		private enum TickRate
		{
			[FieldOffset(Offset="0x0")]
			EveryFrame,
			[FieldOffset(Offset="0x0")]
			EveryFrameBeforeExit,
			[FieldOffset(Offset="0x0")]
			Never
		}
	}
}