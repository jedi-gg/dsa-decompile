using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class StretchAction : ATickableSequenceAction
	{
		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundGameObject _gameObject;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private BoundGameObject _from;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		private BoundVector3 _fromPos;

		[FieldOffset(Offset="0x48")]
		[SerializeField]
		private BoundGameObject _to;

		[FieldOffset(Offset="0x50")]
		[SerializeField]
		private BoundVector3 _toPos;

		[FieldOffset(Offset="0x58")]
		[SerializeField]
		private BoundFloat _toPosOffset;

		[FieldOffset(Offset="0x60")]
		[SerializeField]
		private BoundFloat _width;

		[FieldOffset(Offset="0x68")]
		private Vector3 _cachedFromPos;

		[FieldOffset(Offset="0x74")]
		private Vector3 _cachedToPos;

		[Address(RVA="0x15363D8", Offset="0x15363D8", VA="0x15363D8")]
		public StretchAction()
		{
		}

		[Address(RVA="0x1535B88", Offset="0x1535B88", VA="0x1535B88", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x1535F3C", Offset="0x1535F3C", VA="0x1535F3C", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x1536334", Offset="0x1536334", VA="0x1536334", Slot="9")]
		protected override void InternalTickUpdate(float deltaTime)
		{
		}

		[Address(RVA="0x1535C70", Offset="0x1535C70", VA="0x1535C70", Slot="7")]
		public override void InvalidateGameObject(GameObject go)
		{
		}

		[Address(RVA="0x1535FE0", Offset="0x1535FE0", VA="0x1535FE0")]
		private void Stretch()
		{
		}

		[Address(RVA="0x1535CEC", Offset="0x1535CEC", VA="0x1535CEC")]
		protected void UpdatePositions()
		{
		}
	}
}