using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class ProjectileAction : ArcMoveToAction
	{
		[FieldOffset(Offset="0xB0")]
		private UnitSubObjectRefComponent _targetUnitSubObjectRef;

		[Address(RVA="0x153230C", Offset="0x153230C", VA="0x153230C")]
		public ProjectileAction()
		{
		}

		[Address(RVA="0x15320E0", Offset="0x15320E0", VA="0x15320E0", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x1532030", Offset="0x1532030", VA="0x1532030", Slot="7")]
		public override void InvalidateGameObject(GameObject go)
		{
		}

		[Address(RVA="0x15321D0", Offset="0x15321D0", VA="0x15321D0", Slot="12")]
		protected override void UpdateEndPosition()
		{
		}
	}
}