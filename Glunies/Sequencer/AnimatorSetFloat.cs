using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class AnimatorSetFloat : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private BoundGameObject _gameObject;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundString _floatParamName;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private BoundFloat _value;

		[FieldOffset(Offset="0x40")]
		private Animator _animator;

		[FieldOffset(Offset="0x48")]
		private int _animParamHash;

		[Address(RVA="0x152D03C", Offset="0x152D03C", VA="0x152D03C")]
		public AnimatorSetFloat()
		{
		}

		[Address(RVA="0x152CE28", Offset="0x152CE28", VA="0x152CE28", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x152D034", Offset="0x152D034", VA="0x152D034", Slot="10")]
		protected override void InternalExit()
		{
		}

		[Address(RVA="0x152CEEC", Offset="0x152CEEC", VA="0x152CEEC", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x152CEA0", Offset="0x152CEA0", VA="0x152CEA0", Slot="7")]
		public override void InvalidateGameObject(GameObject go)
		{
		}
	}
}