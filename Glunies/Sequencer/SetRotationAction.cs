using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class SetRotationAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private BoundGameObject _gameObject;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundVector3 _rotationRef;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private bool _everyFrame;

		[FieldOffset(Offset="0x39")]
		[SerializeField]
		private bool _interpolate;

		[FieldOffset(Offset="0x3C")]
		[SerializeField]
		private float _speed;

		[FieldOffset(Offset="0x40")]
		private Quaternion _currentRotation;

		[Address(RVA="0x15359B4", Offset="0x15359B4", VA="0x15359B4")]
		public SetRotationAction()
		{
		}

		[Address(RVA="0x15355BC", Offset="0x15355BC", VA="0x15355BC", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x1535618", Offset="0x1535618", VA="0x1535618", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x15359A4", Offset="0x15359A4", VA="0x15359A4", Slot="9")]
		protected override void InternalTickUpdate(float deltaTime)
		{
		}

		[Address(RVA="0x1535718", Offset="0x1535718", VA="0x1535718")]
		private void SetRotation(float deltaTime = 0f)
		{
		}
	}
}