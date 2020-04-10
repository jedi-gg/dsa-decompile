using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class CopyTransformAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private BoundGameObject _copyFrom;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundGameObject _copyTo;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private BoundVector3 _worldPosOffset;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		private bool _position;

		[FieldOffset(Offset="0x41")]
		[SerializeField]
		private bool _rotation;

		[FieldOffset(Offset="0x42")]
		[SerializeField]
		private bool _scale;

		[FieldOffset(Offset="0x43")]
		[SerializeField]
		private bool _everyFrame;

		[Address(RVA="0x152ECA0", Offset="0x152ECA0", VA="0x152ECA0")]
		public CopyTransformAction()
		{
		}

		[Address(RVA="0x152E8C0", Offset="0x152E8C0", VA="0x152E8C0")]
		private void CopyTransform()
		{
		}

		[Address(RVA="0x152E844", Offset="0x152E844", VA="0x152E844", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x152E8BC", Offset="0x152E8BC", VA="0x152E8BC", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x152EC90", Offset="0x152EC90", VA="0x152EC90", Slot="9")]
		protected override void InternalTickUpdate(float deltaTime)
		{
		}
	}
}