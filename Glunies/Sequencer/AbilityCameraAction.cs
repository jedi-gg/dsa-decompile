using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Glunies.Sequencer
{
	public class AbilityCameraAction : ASequenceAction, IDiContainerSequenceAction, ILoggable<LogCategory>
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1064C04", Offset="0x1064C04")]
		[FieldOffset(Offset="0x28")]
		private Zenject.DiContainer <DiContainer>k__BackingField;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1064C14", Offset="0x1064C14")]
		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private BoundGameObject _leftSideCameraGo;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private BoundGameObject _rightSideCameraGo;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		private BoundGameObject _sourceUnit;

		[FieldOffset(Offset="0x48")]
		[SerializeField]
		private BoundVector3 _sourcePos;

		[FieldOffset(Offset="0x50")]
		[SerializeField]
		private BoundGameObject _targetUnit;

		[FieldOffset(Offset="0x58")]
		[SerializeField]
		private BoundVector3 _targetPos;

		[FieldOffset(Offset="0x60")]
		[SerializeField]
		private BoundGameObject _lookAtOverride;

		[FieldOffset(Offset="0x68")]
		[SerializeField]
		private BoundGameObject _cullingReference;

		[FieldOffset(Offset="0x70")]
		[SerializeField]
		private BoundBool _sourceLooksAtTarget;

		[FieldOffset(Offset="0x78")]
		[SerializeField]
		private BoundBool _targetLooksAtSource;

		[FieldOffset(Offset="0x80")]
		[SerializeField]
		private BoundFloat _cullingOffset;

		[FieldOffset(Offset="0x88")]
		[SerializeField]
		private BoundEnum _cullingMode;

		[FieldOffset(Offset="0x90")]
		[SerializeField]
		private BoundBool _2dRotate;

		[FieldOffset(Offset="0x98")]
		[SerializeField]
		private BoundBool _applyBattleCamTransform;

		[FieldOffset(Offset="0xA0")]
		[SerializeField]
		private BoundFloat _fovZoomPercent;

		[FieldOffset(Offset="0xA8")]
		private BattleAbilityCameraManager _abilityCamManager;

		[FieldOffset(Offset="0xB0")]
		private BattleUnitsController _battleUnitsController;

		[FieldOffset(Offset="0xB8")]
		private BattleEnvironmentController _battleEnvironmentController;

		[FieldOffset(Offset="0xC0")]
		private AbilityCameraActionComponent _camRefs;

		[FieldOffset(Offset="0xC8")]
		private Vector3 _realSourcePos;

		[FieldOffset(Offset="0xD4")]
		private Vector3 _realTargetPos;

		[FieldOffset(Offset="0xE0")]
		private UnitSubObjectRefComponent _sourceRefs;

		[FieldOffset(Offset="0xE8")]
		private UnitSubObjectRefComponent _targetRefs;

		public Zenject.DiContainer DiContainer
		{
			[Address(RVA="0x152B164", Offset="0x152B164", VA="0x152B164")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A830", Offset="0x108A830")]
			get
			{
				return JustDecompileGenerated_get_DiContainer();
			}
			[Address(RVA="0x152B16C", Offset="0x152B16C", VA="0x152B16C", Slot="12")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A840", Offset="0x108A840")]
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

		public LogCategory LogCategory
		{
			[Address(RVA="0x152B15C", Offset="0x152B15C", VA="0x152B15C", Slot="13")]
			get
			{
				return new LogCategory();
			}
		}

		public GameObject SourceUnit
		{
			[Address(RVA="0x152B174", Offset="0x152B174", VA="0x152B174")]
			get
			{
				return null;
			}
		}

		public GameObject TargetUnit
		{
			[Address(RVA="0x152B1F8", Offset="0x152B1F8", VA="0x152B1F8")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x152CB88", Offset="0x152CB88", VA="0x152CB88")]
		public AbilityCameraAction()
		{
		}

		[Address(RVA="0x152B224", Offset="0x152B224", VA="0x152B224", Slot="5")]
		public override void Initialize(List<Binding> bindings)
		{
		}

		[Address(RVA="0x152CA74", Offset="0x152CA74", VA="0x152CA74", Slot="10")]
		protected override void InternalExit()
		{
		}

		[Address(RVA="0x152B7E0", Offset="0x152B7E0", VA="0x152B7E0", Slot="8")]
		protected override void InternalPlay()
		{
		}

		[Address(RVA="0x152C1C0", Offset="0x152C1C0", VA="0x152C1C0", Slot="9")]
		protected override void InternalTickUpdate(float deltaTime)
		{
		}

		[Address(RVA="0x152B480", Offset="0x152B480", VA="0x152B480", Slot="7")]
		public override void InvalidateGameObject(GameObject go)
		{
		}

		[Address(RVA="0x152C010", Offset="0x152C010", VA="0x152C010")]
		private void UpdateSourcePos()
		{
		}

		[Address(RVA="0x152C7EC", Offset="0x152C7EC", VA="0x152C7EC")]
		private void UpdateSourceRotation()
		{
		}

		[Address(RVA="0x152BE98", Offset="0x152BE98", VA="0x152BE98")]
		private void UpdateTargetPos()
		{
		}

		[Address(RVA="0x152C548", Offset="0x152C548", VA="0x152C548")]
		private void UpdateTargetRotation()
		{
		}

		[Attribute(Name="SequencerEnumAttribute", RVA="0x1051288", Offset="0x1051288")]
		public enum AbilityCameraCullingMode
		{
			[FieldOffset(Offset="0x0")]
			None,
			[FieldOffset(Offset="0x0")]
			CameraToReference,
			[FieldOffset(Offset="0x0")]
			SourceToTarget,
			[FieldOffset(Offset="0x0")]
			CameraToTarget,
			[FieldOffset(Offset="0x0")]
			CameraToSource
		}
	}
}