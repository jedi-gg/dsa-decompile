using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class MoveToAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private BoundGameObject _gameObject;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundGameObject _target;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private BoundFloat _duration;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		private BoundVector3 _worldPosOffset;

		[FieldOffset(Offset="0x48")]
		[SerializeField]
		private bool _rotateToTarget;

		[FieldOffset(Offset="0x4C")]
		private float _totalTime;

		[FieldOffset(Offset="0x50")]
		private Vector3 _startPos;

		[FieldOffset(Offset="0x5C")]
		private Vector3 _targetPos;

		[FieldOffset(Offset="0x68")]
		private LookAtHelper _lookAtHelper;

		public override float Duration
		{
			[Address(RVA="0x1530F28", Offset="0x1530F28", VA="0x1530F28", Slot="4")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0x15315BC", Offset="0x15315BC", VA="0x15315BC")]
		public MoveToAction()
		{
		}

		[Address(RVA="0x1530F68", Offset="0x1530F68", VA="0x1530F68", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x15311E8", Offset="0x15311E8", VA="0x15311E8", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x1531398", Offset="0x1531398", VA="0x1531398", Slot="9")]
		protected override void InternalTickUpdate(float deltaTime)
		{
		}

		[Address(RVA="0x1530FFC", Offset="0x1530FFC", VA="0x1530FFC", Slot="7")]
		public override void InvalidateGameObject(GameObject go)
		{
		}

		[Address(RVA="0x1531058", Offset="0x1531058", VA="0x1531058")]
		protected void UpdateTargetPos()
		{
		}
	}
}