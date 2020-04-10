using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class LookAtAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private BoundGameObject _gameObject;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundGameObject _target;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private BoundVector3 _targetPos;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		private BoundEnum _optionalRotateBehavior;

		[FieldOffset(Offset="0x48")]
		[SerializeField]
		private BoundFloat _optionalRotateSpeed;

		[FieldOffset(Offset="0x50")]
		[SerializeField]
		private bool _2dRotate;

		[FieldOffset(Offset="0x51")]
		[SerializeField]
		private bool _rotateDuringExit;

		[FieldOffset(Offset="0x54")]
		private Vector3 _lookAtPos;

		[FieldOffset(Offset="0x60")]
		private LookAtHelper _lookAtHelper;

		[FieldOffset(Offset="0x68")]
		private LookAtAction.RotateBehavior _rotateBehavior;

		[Address(RVA="0x1530CEC", Offset="0x1530CEC", VA="0x1530CEC")]
		public LookAtAction()
		{
		}

		[Address(RVA="0x153076C", Offset="0x153076C", VA="0x153076C", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x15309C0", Offset="0x15309C0", VA="0x15309C0", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x1530B9C", Offset="0x1530B9C", VA="0x1530B9C", Slot="9")]
		protected override void InternalTickUpdate(float deltaTime)
		{
		}

		[Address(RVA="0x153081C", Offset="0x153081C", VA="0x153081C", Slot="7")]
		public override void InvalidateGameObject(GameObject go)
		{
		}

		[Address(RVA="0x1530878", Offset="0x1530878", VA="0x1530878")]
		protected void UpdatePositions()
		{
		}

		[Attribute(Name="SequencerEnumAttribute", RVA="0x1051298", Offset="0x1051298")]
		public enum RotateBehavior
		{
			[FieldOffset(Offset="0x0")]
			DefaultQuick,
			[FieldOffset(Offset="0x0")]
			Instant,
			[FieldOffset(Offset="0x0")]
			Manual
		}
	}
}