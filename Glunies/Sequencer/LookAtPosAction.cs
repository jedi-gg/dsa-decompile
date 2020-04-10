using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class LookAtPosAction : ATickableSequenceAction
	{
		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundGameObject _gameObject;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private BoundVector3 _target;

		[Address(RVA="0x1530F20", Offset="0x1530F20", VA="0x1530F20")]
		public LookAtPosAction()
		{
		}

		[Address(RVA="0x1530DC8", Offset="0x1530DC8", VA="0x1530DC8")]
		private void DoLookAt()
		{
		}

		[Address(RVA="0x1530D68", Offset="0x1530D68", VA="0x1530D68", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x1530DC4", Offset="0x1530DC4", VA="0x1530DC4", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x1530F1C", Offset="0x1530F1C", VA="0x1530F1C", Slot="9")]
		protected override void InternalTickUpdate(float deltaTime)
		{
		}
	}
}