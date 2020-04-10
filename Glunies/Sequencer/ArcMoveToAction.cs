using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class ArcMoveToAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		protected BoundFloat _arcHeight;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		protected BoundGameObject _gameObject;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		protected BoundGameObject _targetGameObject;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		protected BoundVector3 _targetPos;

		[FieldOffset(Offset="0x48")]
		[SerializeField]
		protected BoundFloat _duration;

		[FieldOffset(Offset="0x50")]
		[SerializeField]
		protected Easing _easing;

		[FieldOffset(Offset="0x58")]
		[SerializeField]
		private BoundVector3 _worldPosOffset;

		[FieldOffset(Offset="0x60")]
		[SerializeField]
		protected bool _useCurve;

		[FieldOffset(Offset="0x68")]
		[SerializeField]
		protected AnimationCurve _heightCurve;

		[Attribute(Name="HeaderAttribute", RVA="0x1064FD0", Offset="0x1064FD0")]
		[FieldOffset(Offset="0x70")]
		[SerializeField]
		protected bool _rotateToTarget;

		[FieldOffset(Offset="0x71")]
		[SerializeField]
		protected bool _2dRotate;

		[Attribute(Name="HeaderAttribute", RVA="0x106502C", Offset="0x106502C")]
		[FieldOffset(Offset="0x74")]
		[SerializeField]
		protected float _durationAdjustS;

		[FieldOffset(Offset="0x78")]
		protected Vector3 _startPos;

		[FieldOffset(Offset="0x84")]
		protected Vector3 _endPos;

		[FieldOffset(Offset="0x90")]
		protected LookAtHelper _lookAtHelper;

		[FieldOffset(Offset="0x98")]
		protected Vector3 _previousPosition;

		[FieldOffset(Offset="0xA4")]
		protected float _adjustedDuration;

		[FieldOffset(Offset="0xA8")]
		protected bool _interpolateRotation;

		public override float Duration
		{
			[Address(RVA="0x152D044", Offset="0x152D044", VA="0x152D044", Slot="4")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0x152DEF0", Offset="0x152DEF0", VA="0x152DEF0")]
		public ArcMoveToAction()
		{
		}

		[Address(RVA="0x152D83C", Offset="0x152D83C", VA="0x152D83C")]
		private float CalculateCurrentHeight(float currentProgress)
		{
			return new float();
		}

		[Address(RVA="0x152D084", Offset="0x152D084", VA="0x152D084", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x152D1B4", Offset="0x152D1B4", VA="0x152D1B4", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x152D3AC", Offset="0x152D3AC", VA="0x152D3AC", Slot="9")]
		protected override void InternalTickUpdate(float deltaTime)
		{
		}

		[Address(RVA="0x152D150", Offset="0x152D150", VA="0x152D150", Slot="7")]
		public override void InvalidateGameObject(GameObject go)
		{
		}

		[Address(RVA="0x152DC28", Offset="0x152DC28", VA="0x152DC28", Slot="12")]
		protected virtual void UpdateEndPosition()
		{
		}
	}
}