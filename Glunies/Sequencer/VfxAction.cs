using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class VfxAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private BoundGameObject _vfxGameObject;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundGameObject _ownerGameObject;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private VfxAction.ActionType _actionType;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		private BoundGameObject _particleCollisionPlane;

		[Address(RVA="0x16144F4", Offset="0x16144F4", VA="0x16144F4")]
		public VfxAction()
		{
		}

		[Address(RVA="0x1613E30", Offset="0x1613E30", VA="0x1613E30", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x1614324", Offset="0x1614324", VA="0x1614324", Slot="10")]
		protected override void InternalExit()
		{
		}

		[Address(RVA="0x1613F18", Offset="0x1613F18", VA="0x1613F18", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x1613EB4", Offset="0x1613EB4", VA="0x1613EB4", Slot="7")]
		public override void InvalidateGameObject(GameObject go)
		{
		}

		public enum ActionType
		{
			[FieldOffset(Offset="0x0")]
			Play,
			[FieldOffset(Offset="0x0")]
			Stop
		}
	}
}