using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class PlayAnimatorStateAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private BoundGameObject _gameObject;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundString _animatorStateName;

		[Address(RVA="0x1532028", Offset="0x1532028", VA="0x1532028")]
		public PlayAnimatorStateAction()
		{
		}

		[Address(RVA="0x1531E4C", Offset="0x1531E4C", VA="0x1531E4C", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x1531EA8", Offset="0x1531EA8", VA="0x1531EA8", Slot="8")]
		protected override void InternalPlay()
		{
		}
	}
}