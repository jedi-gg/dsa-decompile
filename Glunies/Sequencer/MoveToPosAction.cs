using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class MoveToPosAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		protected BoundGameObject _gameObject;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		protected BoundVector3 _target;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		protected BoundFloat _duration;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		protected BoundVector3 _worldPosOffset;

		[FieldOffset(Offset="0x48")]
		[SerializeField]
		protected bool _rotateToTarget;

		[FieldOffset(Offset="0x49")]
		[SerializeField]
		protected bool _worldSpace;

		[FieldOffset(Offset="0x4C")]
		protected float _totalTime;

		[FieldOffset(Offset="0x50")]
		protected Vector3 _startPos;

		[FieldOffset(Offset="0x5C")]
		protected Vector3 _targetPos;

		[FieldOffset(Offset="0x68")]
		protected LookAtHelper _lookAtHelper;

		public override float Duration
		{
			[Address(RVA="0x1531638", Offset="0x1531638", VA="0x1531638", Slot="4")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0x1531C68", Offset="0x1531C68", VA="0x1531C68")]
		public MoveToPosAction()
		{
		}

		[Address(RVA="0x1531678", Offset="0x1531678", VA="0x1531678", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x153170C", Offset="0x153170C", VA="0x153170C", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x1531A24", Offset="0x1531A24", VA="0x1531A24", Slot="9")]
		protected override void InternalTickUpdate(float deltaTime)
		{
		}

		[Address(RVA="0x15318F4", Offset="0x15318F4", VA="0x15318F4")]
		protected void UpdateTargetPos()
		{
		}
	}
}