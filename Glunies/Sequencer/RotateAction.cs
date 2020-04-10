using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class RotateAction : ATickableSequenceAction
	{
		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundGameObject _gameObject;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private BoundVector3 _rotationSpeed;

		[FieldOffset(Offset="0x40")]
		private Quaternion _rotation;

		[Address(RVA="0x1532678", Offset="0x1532678", VA="0x1532678")]
		public RotateAction()
		{
		}

		[Address(RVA="0x1532310", Offset="0x1532310", VA="0x1532310", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x153236C", Offset="0x153236C", VA="0x153236C", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x1532450", Offset="0x1532450", VA="0x1532450", Slot="9")]
		protected override void InternalTickUpdate(float deltaTime)
		{
		}
	}
}