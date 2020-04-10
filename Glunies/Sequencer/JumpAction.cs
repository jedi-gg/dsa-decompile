using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Glunies.Sequencer
{
	public class JumpAction : ASequenceAction, IDiContainerSequenceAction
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1064DC0", Offset="0x1064DC0")]
		[FieldOffset(Offset="0x28")]
		private Zenject.DiContainer <DiContainer>k__BackingField;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundGameObject _gameObject;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private BoundFloat _duration;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		private BoundFloat _height;

		[FieldOffset(Offset="0x48")]
		[SerializeField]
		private Easing _easing;

		[FieldOffset(Offset="0x50")]
		private BattleEnvironmentController _battleEnvController;

		[FieldOffset(Offset="0x58")]
		private float _totalTime;

		[FieldOffset(Offset="0x5C")]
		private Vector3 _startPos;

		public Zenject.DiContainer DiContainer
		{
			[Address(RVA="0x152F6D0", Offset="0x152F6D0", VA="0x152F6D0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A850", Offset="0x108A850")]
			get
			{
				return JustDecompileGenerated_get_DiContainer();
			}
			[Address(RVA="0x152F6D8", Offset="0x152F6D8", VA="0x152F6D8", Slot="12")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A860", Offset="0x108A860")]
			set
			{
				JustDecompileGenerated_set_DiContainer(value);
			}
		}

		private Zenject.DiContainer JustDecompileGenerated_get_DiContainer()
		{
			return null;
		}

		public void JustDecompileGenerated_set_DiContainer(Zenject.DiContainer value)
		{
		}

		public override float Duration
		{
			[Address(RVA="0x152F6E0", Offset="0x152F6E0", VA="0x152F6E0", Slot="4")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0x152FADC", Offset="0x152FADC", VA="0x152FADC")]
		public JumpAction()
		{
		}

		[Address(RVA="0x152F720", Offset="0x152F720", VA="0x152F720", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x152F7DC", Offset="0x152F7DC", VA="0x152F7DC", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x152F908", Offset="0x152F908", VA="0x152F908", Slot="9")]
		protected override void InternalTickUpdate(float deltaTime)
		{
		}
	}
}