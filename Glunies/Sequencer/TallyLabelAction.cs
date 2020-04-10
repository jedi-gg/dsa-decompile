using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class TallyLabelAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private BoundGameObject _gameObject;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundFloat _duration;

		[Address(RVA="0x161349C", Offset="0x161349C", VA="0x161349C")]
		public TallyLabelAction()
		{
		}

		[Address(RVA="0x1613198", Offset="0x1613198", VA="0x1613198", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x16131FC", Offset="0x16131FC", VA="0x16131FC", Slot="8")]
		protected override void InternalPlay()
		{
		}
	}
}