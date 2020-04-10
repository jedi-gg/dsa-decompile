using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Glunies.Sequencer
{
	public class JumpHoldReleaseAction : ASequenceAction, IDiContainerSequenceAction
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1064E10", Offset="0x1064E10")]
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
		private BoundFloat _holdPercent;

		[FieldOffset(Offset="0x48")]
		[SerializeField]
		private BoundFloat _height;

		[FieldOffset(Offset="0x50")]
		[SerializeField]
		private Easing _easing;

		[FieldOffset(Offset="0x58")]
		private BattleEnvironmentController _battleEnvController;

		[FieldOffset(Offset="0x60")]
		private float _totalTime;

		[FieldOffset(Offset="0x64")]
		private Vector3 _startPos;

		public Zenject.DiContainer DiContainer
		{
			[Address(RVA="0x152FAE4", Offset="0x152FAE4", VA="0x152FAE4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A870", Offset="0x108A870")]
			get
			{
				return JustDecompileGenerated_get_DiContainer();
			}
			[Address(RVA="0x152FAEC", Offset="0x152FAEC", VA="0x152FAEC", Slot="12")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A880", Offset="0x108A880")]
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
			[Address(RVA="0x152FAF4", Offset="0x152FAF4", VA="0x152FAF4", Slot="4")]
			get
			{
				return new float();
			}
		}

		private float TailPercent
		{
			[Address(RVA="0x15300EC", Offset="0x15300EC", VA="0x15300EC")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0x153013C", Offset="0x153013C", VA="0x153013C")]
		public JumpHoldReleaseAction()
		{
		}

		[Address(RVA="0x152FED0", Offset="0x152FED0", VA="0x152FED0")]
		private float GetEasedValue(float from, float to, float currentPercent)
		{
			return new float();
		}

		[Address(RVA="0x152FB34", Offset="0x152FB34", VA="0x152FB34", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x152FC0C", Offset="0x152FC0C", VA="0x152FC0C", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x152FD38", Offset="0x152FD38", VA="0x152FD38", Slot="9")]
		protected override void InternalTickUpdate(float deltaTime)
		{
		}
	}
}