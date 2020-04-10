using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class LinePositionAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private BoundGameObject _lineRendererGo;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundGameObject _source;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private BoundVector3 _sourcePos;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		private BoundGameObject _target;

		[FieldOffset(Offset="0x48")]
		[SerializeField]
		private BoundVector3 _targetPos;

		[FieldOffset(Offset="0x50")]
		[SerializeField]
		private BoundVector3 _targetPosOffset;

		[FieldOffset(Offset="0x58")]
		private LineRenderer _lineRenderer;

		[FieldOffset(Offset="0x60")]
		private Vector3 _cachedSourcePos;

		[FieldOffset(Offset="0x6C")]
		private Vector3 _cachedTargetPos;

		[Address(RVA="0x1530764", Offset="0x1530764", VA="0x1530764")]
		public LinePositionAction()
		{
		}

		[Address(RVA="0x1530144", Offset="0x1530144", VA="0x1530144", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x15306C4", Offset="0x15306C4", VA="0x15306C4", Slot="10")]
		protected override void InternalExit()
		{
		}

		[Address(RVA="0x153057C", Offset="0x153057C", VA="0x153057C", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x1530610", Offset="0x1530610", VA="0x1530610", Slot="9")]
		protected override void InternalTickUpdate(float deltaTime)
		{
		}

		[Address(RVA="0x1530210", Offset="0x1530210", VA="0x1530210", Slot="7")]
		public override void InvalidateGameObject(GameObject go)
		{
		}

		[Address(RVA="0x153028C", Offset="0x153028C", VA="0x153028C")]
		protected void UpdatePositions()
		{
		}
	}
}