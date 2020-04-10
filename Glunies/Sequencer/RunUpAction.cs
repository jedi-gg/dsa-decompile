using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Glunies.Sequencer
{
	public class RunUpAction : ASequenceAction, IDiContainerSequenceAction
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1064E70", Offset="0x1064E70")]
		[FieldOffset(Offset="0x28")]
		private Zenject.DiContainer <DiContainer>k__BackingField;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundGameObject _unitGo;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private BoundGameObject _targetGo;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		private BoundVector3 _targetVec3;

		[FieldOffset(Offset="0x48")]
		[SerializeField]
		private BoundFloat _offsetFromTarget;

		[FieldOffset(Offset="0x50")]
		[SerializeField]
		private BoundFloat _speed;

		[FieldOffset(Offset="0x58")]
		private BattleUnitsController _battleUnitsController;

		[FieldOffset(Offset="0x60")]
		private BattleUnit _unit;

		[FieldOffset(Offset="0x68")]
		private Vector3 _initialPos;

		[FieldOffset(Offset="0x74")]
		private Vector3 _targetPos;

		[FieldOffset(Offset="0x80")]
		private float _totalTime;

		[FieldOffset(Offset="0x88")]
		private LookAtHelper _lookAtHelper;

		public Zenject.DiContainer DiContainer
		{
			[Address(RVA="0x1532680", Offset="0x1532680", VA="0x1532680")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A890", Offset="0x108A890")]
			get
			{
				return JustDecompileGenerated_get_DiContainer();
			}
			[Address(RVA="0x1532688", Offset="0x1532688", VA="0x1532688", Slot="12")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A8A0", Offset="0x108A8A0")]
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

		[Address(RVA="0x1532F1C", Offset="0x1532F1C", VA="0x1532F1C")]
		public RunUpAction()
		{
		}

		[Address(RVA="0x15327D0", Offset="0x15327D0", VA="0x15327D0", Slot="6")]
		public override float? GetOverrideSequenceDuration()
		{
			return null;
		}

		[Address(RVA="0x1532690", Offset="0x1532690", VA="0x1532690", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x1532EC4", Offset="0x1532EC4", VA="0x1532EC4", Slot="10")]
		protected override void InternalExit()
		{
		}

		[Address(RVA="0x1532838", Offset="0x1532838", VA="0x1532838", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x1532C88", Offset="0x1532C88", VA="0x1532C88", Slot="9")]
		protected override void InternalTickUpdate(float deltaTime)
		{
		}

		[Address(RVA="0x1532784", Offset="0x1532784", VA="0x1532784", Slot="7")]
		public override void InvalidateGameObject(GameObject go)
		{
		}
	}
}