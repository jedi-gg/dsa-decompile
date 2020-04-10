using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Glunies.Sequencer
{
	public class SetGraphicColorAction : ASequenceAction
	{
		[FieldOffset(Offset="0x28")]
		private Graphic _graphic;

		[FieldOffset(Offset="0x30")]
		private Color _startColor;

		[FieldOffset(Offset="0x40")]
		private float _totalTime;

		[FieldOffset(Offset="0x48")]
		[SerializeField]
		private BoundGameObject _graphicGameObject;

		[FieldOffset(Offset="0x50")]
		[SerializeField]
		private BoundColor _color;

		[FieldOffset(Offset="0x58")]
		[SerializeField]
		private BoundFloat _duration;

		public override float Duration
		{
			[Address(RVA="0x1534E34", Offset="0x1534E34", VA="0x1534E34", Slot="4")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0x1535320", Offset="0x1535320", VA="0x1535320")]
		public SetGraphicColorAction()
		{
		}

		[Address(RVA="0x1534E74", Offset="0x1534E74", VA="0x1534E74", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x1534EEC", Offset="0x1534EEC", VA="0x1534EEC", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x15351BC", Offset="0x15351BC", VA="0x15351BC", Slot="9")]
		protected override void InternalTickUpdate(float deltaTime)
		{
		}

		[Address(RVA="0x15350E0", Offset="0x15350E0", VA="0x15350E0")]
		private void SetColor(Color color)
		{
		}
	}
}