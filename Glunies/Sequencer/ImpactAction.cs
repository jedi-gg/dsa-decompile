using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class ImpactAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private BoundGameObject _vfxGameObject;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundGameObject _targetGameObject;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private BoundGameObject _sourceGameObject;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		private BoundGameObject _particleCollisionPlane;

		[FieldOffset(Offset="0x48")]
		[SerializeField]
		private BoundVector3 _sourcePos;

		[Address(RVA="0x152F6C8", Offset="0x152F6C8", VA="0x152F6C8")]
		public ImpactAction()
		{
		}

		[Address(RVA="0x152ECD0", Offset="0x152ECD0", VA="0x152ECD0", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x152F51C", Offset="0x152F51C", VA="0x152F51C", Slot="10")]
		protected override void InternalExit()
		{
		}

		[Address(RVA="0x152ED80", Offset="0x152ED80", VA="0x152ED80", Slot="8")]
		protected override void InternalPlay()
		{
		}
	}
}