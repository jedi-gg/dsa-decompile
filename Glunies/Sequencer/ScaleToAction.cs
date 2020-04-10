using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class ScaleToAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private BoundGameObject _gameObject;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundVector3 _targetScale;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private BoundFloat _duration;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		private Easing _easing;

		[FieldOffset(Offset="0x44")]
		private float _totalTime;

		[FieldOffset(Offset="0x48")]
		private Vector3 _startScale;

		public override float Duration
		{
			[Address(RVA="0x1532F90", Offset="0x1532F90", VA="0x1532F90", Slot="4")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0x153335C", Offset="0x153335C", VA="0x153335C")]
		public ScaleToAction()
		{
		}

		[Address(RVA="0x1532FD0", Offset="0x1532FD0", VA="0x1532FD0", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x1533048", Offset="0x1533048", VA="0x1533048", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x1533158", Offset="0x1533158", VA="0x1533158", Slot="9")]
		protected override void InternalTickUpdate(float deltaTime)
		{
		}
	}
}