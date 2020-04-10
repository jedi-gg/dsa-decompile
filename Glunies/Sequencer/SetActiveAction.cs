using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class SetActiveAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private BoundGameObject _gameObject;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private bool _active;

		[Address(RVA="0x1534AD4", Offset="0x1534AD4", VA="0x1534AD4")]
		public SetActiveAction()
		{
		}

		[Address(RVA="0x15349C8", Offset="0x15349C8", VA="0x15349C8", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x15349FC", Offset="0x15349FC", VA="0x15349FC", Slot="8")]
		protected override void InternalPlay()
		{
		}
	}
}