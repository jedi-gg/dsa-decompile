using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class SetAnimationSpeedAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private BoundGameObject _gameObject;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundFloat _animSpeed;

		[Address(RVA="0x1534E2C", Offset="0x1534E2C", VA="0x1534E2C")]
		public SetAnimationSpeedAction()
		{
		}

		[Address(RVA="0x1534ADC", Offset="0x1534ADC", VA="0x1534ADC", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x1534E28", Offset="0x1534E28", VA="0x1534E28", Slot="10")]
		protected override void InternalExit()
		{
		}

		[Address(RVA="0x1534CC4", Offset="0x1534CC4", VA="0x1534CC4", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x1534B38", Offset="0x1534B38", VA="0x1534B38", Slot="7")]
		public override void InvalidateGameObject(GameObject go)
		{
		}

		[Address(RVA="0x1534B94", Offset="0x1534B94", VA="0x1534B94")]
		protected void ResetAnimSpeed()
		{
		}
	}
}