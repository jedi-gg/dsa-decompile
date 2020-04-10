using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class PlayAnimationClipAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private BoundGameObject _gameObject;

		[Address(RVA="0x1531E44", Offset="0x1531E44", VA="0x1531E44")]
		public PlayAnimationClipAction()
		{
		}

		[Address(RVA="0x1531CE4", Offset="0x1531CE4", VA="0x1531CE4", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x1531D18", Offset="0x1531D18", VA="0x1531D18", Slot="8")]
		protected override void InternalPlay()
		{
		}
	}
}