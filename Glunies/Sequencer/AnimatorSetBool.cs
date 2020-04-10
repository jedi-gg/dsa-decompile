using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class AnimatorSetBool : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private BoundGameObject _gameObject;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundString _boolParamName;

		[FieldOffset(Offset="0x38")]
		private Animator _animator;

		[FieldOffset(Offset="0x40")]
		private int _animParamHash;

		[Address(RVA="0x152CE20", Offset="0x152CE20", VA="0x152CE20")]
		public AnimatorSetBool()
		{
		}

		[Address(RVA="0x152CB98", Offset="0x152CB98", VA="0x152CB98", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x152CD74", Offset="0x152CD74", VA="0x152CD74", Slot="10")]
		protected override void InternalExit()
		{
		}

		[Address(RVA="0x152CC40", Offset="0x152CC40", VA="0x152CC40", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x152CBF4", Offset="0x152CBF4", VA="0x152CBF4", Slot="7")]
		public override void InvalidateGameObject(GameObject go)
		{
		}
	}
}