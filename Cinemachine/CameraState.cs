using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	public struct CameraState
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1068F0C", Offset="0x1068F0C")]
		[FieldOffset(Offset="0x0")]
		private LensSettings <Lens>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1068F1C", Offset="0x1068F1C")]
		[FieldOffset(Offset="0x1C")]
		private Vector3 <ReferenceUp>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1068F2C", Offset="0x1068F2C")]
		[FieldOffset(Offset="0x28")]
		private Vector3 <ReferenceLookAt>k__BackingField;

		[FieldOffset(Offset="0x0")]
		public static Vector3 kNoPoint;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1068F3C", Offset="0x1068F3C")]
		[FieldOffset(Offset="0x34")]
		private Vector3 <RawPosition>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1068F4C", Offset="0x1068F4C")]
		[FieldOffset(Offset="0x40")]
		private Quaternion <RawOrientation>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1068F5C", Offset="0x1068F5C")]
		[FieldOffset(Offset="0x50")]
		private Vector3 <PositionDampingBypass>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1068F6C", Offset="0x1068F6C")]
		[FieldOffset(Offset="0x5C")]
		private float <ShotQuality>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1068F7C", Offset="0x1068F7C")]
		[FieldOffset(Offset="0x60")]
		private Vector3 <PositionCorrection>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1068F8C", Offset="0x1068F8C")]
		[FieldOffset(Offset="0x6C")]
		private Quaternion <OrientationCorrection>k__BackingField;

		[FieldOffset(Offset="0x80")]
		private CameraState.CustomBlendable mCustom0;

		[FieldOffset(Offset="0x90")]
		private CameraState.CustomBlendable mCustom1;

		[FieldOffset(Offset="0xA0")]
		private CameraState.CustomBlendable mCustom2;

		[FieldOffset(Offset="0xB0")]
		private CameraState.CustomBlendable mCustom3;

		[FieldOffset(Offset="0xC0")]
		private List<CameraState.CustomBlendable> m_CustomOverflow;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1068F9C", Offset="0x1068F9C")]
		[FieldOffset(Offset="0xC8")]
		private int <NumCustomBlendables>k__BackingField;

		public Quaternion CorrectedOrientation
		{
			[Address(RVA="0xF2E1D8", Offset="0xF2E1D8", VA="0xF2E1D8")]
			get
			{
				return new Quaternion();
			}
		}

		public Vector3 CorrectedPosition
		{
			[Address(RVA="0xF2E1D0", Offset="0xF2E1D0", VA="0xF2E1D0")]
			get
			{
				return new Vector3();
			}
		}

		public static CameraState Default
		{
			[Address(RVA="0x1D3A630", Offset="0x1D3A630", VA="0x1D3A630")]
			get
			{
				return new CameraState();
			}
		}

		public Quaternion FinalOrientation
		{
			[Address(RVA="0xF2E1E8", Offset="0xF2E1E8", VA="0xF2E1E8")]
			get
			{
				return new Quaternion();
			}
		}

		public Vector3 FinalPosition
		{
			[Address(RVA="0xF2E1E0", Offset="0xF2E1E0", VA="0xF2E1E0")]
			get
			{
				return new Vector3();
			}
		}

		public bool HasLookAt
		{
			[Address(RVA="0xF2E140", Offset="0xF2E140", VA="0xF2E140")]
			get
			{
				return new bool();
			}
		}

		public LensSettings Lens
		{
			[Address(RVA="0xF2E0E0", Offset="0xF2E0E0", VA="0xF2E0E0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AD14", Offset="0x108AD14")]
			get
			{
				return new LensSettings();
			}
			[Address(RVA="0xF2E0F4", Offset="0xF2E0F4", VA="0xF2E0F4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AD24", Offset="0x108AD24")]
			set
			{
			}
		}

		public int NumCustomBlendables
		{
			[Address(RVA="0xF2E1F0", Offset="0xF2E1F0", VA="0xF2E1F0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AE34", Offset="0x108AE34")]
			get
			{
				return new int();
			}
			[Address(RVA="0xF2E1F8", Offset="0xF2E1F8", VA="0xF2E1F8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AE44", Offset="0x108AE44")]
			private set
			{
			}
		}

		public Quaternion OrientationCorrection
		{
			[Address(RVA="0xF2E1B8", Offset="0xF2E1B8", VA="0xF2E1B8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AE14", Offset="0x108AE14")]
			get
			{
				return new Quaternion();
			}
			[Address(RVA="0xF2E1C4", Offset="0xF2E1C4", VA="0xF2E1C4")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AE24", Offset="0x108AE24")]
			set
			{
			}
		}

		public Vector3 PositionCorrection
		{
			[Address(RVA="0xF2E1A0", Offset="0xF2E1A0", VA="0xF2E1A0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108ADF4", Offset="0x108ADF4")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0xF2E1AC", Offset="0xF2E1AC", VA="0xF2E1AC")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AE04", Offset="0x108AE04")]
			set
			{
			}
		}

		internal Vector3 PositionDampingBypass
		{
			[Address(RVA="0xF2E178", Offset="0xF2E178", VA="0xF2E178")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108ADB4", Offset="0x108ADB4")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0xF2E184", Offset="0xF2E184", VA="0xF2E184")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108ADC4", Offset="0x108ADC4")]
			set
			{
			}
		}

		public Quaternion RawOrientation
		{
			[Address(RVA="0xF2E160", Offset="0xF2E160", VA="0xF2E160")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AD94", Offset="0x108AD94")]
			get
			{
				return new Quaternion();
			}
			[Address(RVA="0xF2E16C", Offset="0xF2E16C", VA="0xF2E16C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108ADA4", Offset="0x108ADA4")]
			set
			{
			}
		}

		public Vector3 RawPosition
		{
			[Address(RVA="0xF2E148", Offset="0xF2E148", VA="0xF2E148")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AD74", Offset="0x108AD74")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0xF2E154", Offset="0xF2E154", VA="0xF2E154")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AD84", Offset="0x108AD84")]
			set
			{
			}
		}

		public Vector3 ReferenceLookAt
		{
			[Address(RVA="0xF2E128", Offset="0xF2E128", VA="0xF2E128")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AD54", Offset="0x108AD54")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0xF2E134", Offset="0xF2E134", VA="0xF2E134")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AD64", Offset="0x108AD64")]
			set
			{
			}
		}

		public Vector3 ReferenceUp
		{
			[Address(RVA="0xF2E110", Offset="0xF2E110", VA="0xF2E110")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AD34", Offset="0x108AD34")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0xF2E11C", Offset="0xF2E11C", VA="0xF2E11C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AD44", Offset="0x108AD44")]
			set
			{
			}
		}

		public float ShotQuality
		{
			[Address(RVA="0xF2E190", Offset="0xF2E190", VA="0xF2E190")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108ADD4", Offset="0x108ADD4")]
			get
			{
				return new float();
			}
			[Address(RVA="0xF2E198", Offset="0xF2E198", VA="0xF2E198")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108ADE4", Offset="0x108ADE4")]
			set
			{
			}
		}

		[Address(RVA="0x1D3B8AC", Offset="0x1D3B8AC", VA="0x1D3B8AC")]
		static CameraState()
		{
		}

		[Address(RVA="0xF2E210", Offset="0xF2E210", VA="0xF2E210")]
		public void AddCustomBlendable(CameraState.CustomBlendable b)
		{
		}

		[Address(RVA="0xF2E208", Offset="0xF2E208", VA="0xF2E208")]
		private int FindCustomBlendable(UnityEngine.Object custom)
		{
			return new int();
		}

		[Address(RVA="0xF2E200", Offset="0xF2E200", VA="0xF2E200")]
		public CameraState.CustomBlendable GetCustomBlendable(int index)
		{
			return new CameraState.CustomBlendable();
		}

		[Address(RVA="0xF2E218", Offset="0xF2E218", VA="0xF2E218")]
		private float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t)
		{
			return new float();
		}

		[Address(RVA="0x1D3AD00", Offset="0x1D3AD00", VA="0x1D3AD00")]
		public static CameraState Lerp(CameraState stateA, CameraState stateB, float t)
		{
			return new CameraState();
		}

		public struct CustomBlendable
		{
			[FieldOffset(Offset="0x0")]
			public UnityEngine.Object m_Custom;

			[FieldOffset(Offset="0x8")]
			public float m_Weight;

			[Address(RVA="0xF2E21C", Offset="0xF2E21C", VA="0xF2E21C")]
			public CustomBlendable(UnityEngine.Object custom, float weight)
			{
			}
		}
	}
}