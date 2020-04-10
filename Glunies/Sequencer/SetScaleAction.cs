using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class SetScaleAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private BoundGameObject _gameObject;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundVector3 _scaleRef;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private bool _everyFrame;

		[Address(RVA="0x1535B80", Offset="0x1535B80", VA="0x1535B80")]
		public SetScaleAction()
		{
		}

		[Address(RVA="0x15359BC", Offset="0x15359BC", VA="0x15359BC", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x1535A18", Offset="0x1535A18", VA="0x1535A18", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x1535B70", Offset="0x1535B70", VA="0x1535B70", Slot="9")]
		protected override void InternalTickUpdate(float deltaTime)
		{
		}

		[Address(RVA="0x1535A1C", Offset="0x1535A1C", VA="0x1535A1C")]
		private void SetScale()
		{
		}
	}
}