using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class SetPositionAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private BoundGameObject _gameObject;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundVector3 _positionRef;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private BoundVector3 _positionOffset;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		private bool _everyFrame;

		[Address(RVA="0x15355B4", Offset="0x15355B4", VA="0x15355B4")]
		public SetPositionAction()
		{
		}

		[Address(RVA="0x1535328", Offset="0x1535328", VA="0x1535328", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x15353A0", Offset="0x15353A0", VA="0x15353A0", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x15355A4", Offset="0x15355A4", VA="0x15355A4", Slot="9")]
		protected override void InternalTickUpdate(float deltaTime)
		{
		}

		[Address(RVA="0x15353A4", Offset="0x15353A4", VA="0x15353A4")]
		private void SetPosition()
		{
		}
	}
}