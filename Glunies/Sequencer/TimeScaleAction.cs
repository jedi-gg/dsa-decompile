using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class TimeScaleAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private BoundFloat _timeScale;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundFloat _duration;

		[FieldOffset(Offset="0x38")]
		private uint _timeScaleId;

		[Address(RVA="0x16136B8", Offset="0x16136B8", VA="0x16136B8")]
		public TimeScaleAction()
		{
		}

		[Address(RVA="0x16134A4", Offset="0x16134A4", VA="0x16134A4", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x1613638", Offset="0x1613638", VA="0x1613638", Slot="10")]
		protected override void InternalExit()
		{
		}

		[Address(RVA="0x16134DC", Offset="0x16134DC", VA="0x16134DC", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x16135C0", Offset="0x16135C0", VA="0x16135C0", Slot="9")]
		protected override void InternalTickUpdate(float deltaTime)
		{
		}
	}
}