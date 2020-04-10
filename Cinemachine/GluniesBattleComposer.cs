using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x1049BCC", Offset="0x1049BCC")]
	[Attribute(Name="RequireComponent", RVA="0x1049BCC", Offset="0x1049BCC")]
	public class GluniesBattleComposer : CinemachineComposer
	{
		[Attribute(Name="SpaceAttribute", RVA="0x10657C8", Offset="0x10657C8")]
		[FieldOffset(Offset="0xA8")]
		[SerializeField]
		private float _groupFramingSize;

		[Attribute(Name="RangeAttribute", RVA="0x1065800", Offset="0x1065800")]
		[FieldOffset(Offset="0xAC")]
		[SerializeField]
		private float _frameDamping;

		[Attribute(Name="RangeAttribute", RVA="0x1065840", Offset="0x1065840")]
		[FieldOffset(Offset="0xB0")]
		[SerializeField]
		private float _minimumFOV;

		[Attribute(Name="RangeAttribute", RVA="0x1065884", Offset="0x1065884")]
		[FieldOffset(Offset="0xB4")]
		[SerializeField]
		private float _maximumFOV;

		[Attribute(Name="RangeAttribute", RVA="0x10658C8", Offset="0x10658C8")]
		[FieldOffset(Offset="0xB8")]
		[SerializeField]
		private float _focusWeight;

		[FieldOffset(Offset="0xBC")]
		[SerializeField]
		private float _unitHeight;

		[FieldOffset(Offset="0xC0")]
		[SerializeField]
		private float _unitRadius;

		[FieldOffset(Offset="0xC4")]
		private float _prevTargetHeight;

		[FieldOffset(Offset="0xC8")]
		private Vector3 _prevLookAt;

		[FieldOffset(Offset="0xD8")]
		private List<BattleUnit> _trackedUnits;

		[FieldOffset(Offset="0xE0")]
		private BattleUnit _focusUnit;

		[FieldOffset(Offset="0xE8")]
		private List<Vector3> _openSpawnPositions;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1065928", Offset="0x1065928")]
		[FieldOffset(Offset="0xF0")]
		private float <CurrentFOV>k__BackingField;

		public float CurrentFOV
		{
			[Address(RVA="0x145F888", Offset="0x145F888", VA="0x145F888")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A900", Offset="0x108A900")]
			get
			{
				return new float();
			}
			[Address(RVA="0x145F7BC", Offset="0x145F7BC", VA="0x145F7BC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A910", Offset="0x108A910")]
			private set
			{
			}
		}

		[Address(RVA="0x145F890", Offset="0x145F890", VA="0x145F890")]
		public GluniesBattleComposer()
		{
		}

		[Address(RVA="0x145EAAC", Offset="0x145EAAC", VA="0x145EAAC")]
		public void AddOpenSpawnPosition(Vector3 pos)
		{
		}

		[Address(RVA="0x145F3AC", Offset="0x145F3AC", VA="0x145F3AC")]
		private void AddToBounds(Vector3 tpos, Plane plane, Matrix4x4 inverseView, ref CameraState curState, ref Bounds bb, ref Bounds bbAligned)
		{
		}

		[Address(RVA="0x145E8FC", Offset="0x145E8FC", VA="0x145E8FC")]
		public void AddUnit(BattleUnit unit)
		{
		}

		[Address(RVA="0x145F684", Offset="0x145F684", VA="0x145F684")]
		private float GetTargetHeight(Bounds b)
		{
			return new float();
		}

		[Address(RVA="0x145EB94", Offset="0x145EB94", VA="0x145EB94", Slot="7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Address(RVA="0x145F7C4", Offset="0x145F7C4", VA="0x145F7C4")]
		private void OnValidate()
		{
		}

		[Address(RVA="0x145EA44", Offset="0x145EA44", VA="0x145EA44")]
		public void RemoveAllUnits()
		{
		}

		[Address(RVA="0x145EB34", Offset="0x145EB34", VA="0x145EB34")]
		public void RemoveOpenSpawnPositions()
		{
		}

		[Address(RVA="0x145E96C", Offset="0x145E96C", VA="0x145E96C")]
		public void RemoveUnit(BattleUnit unit)
		{
		}

		[Address(RVA="0x145EAA4", Offset="0x145EAA4", VA="0x145EAA4")]
		public void SetFocusUnit(BattleUnit unit)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10512A8", Offset="0x10512A8")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset="0x10")]
			public BattleUnit unit;

			[Address(RVA="0x145EA3C", Offset="0x145EA3C", VA="0x145EA3C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Address(RVA="0x145F980", Offset="0x145F980", VA="0x145F980")]
			internal bool <RemoveUnit>b__0(BattleUnit u)
			{
				return new bool();
			}
		}
	}
}