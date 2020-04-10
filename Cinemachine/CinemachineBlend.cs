using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	public class CinemachineBlend
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1068FAC", Offset="0x1068FAC")]
		[FieldOffset(Offset="0x10")]
		private ICinemachineCamera <CamA>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1068FBC", Offset="0x1068FBC")]
		[FieldOffset(Offset="0x18")]
		private ICinemachineCamera <CamB>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1068FCC", Offset="0x1068FCC")]
		[FieldOffset(Offset="0x20")]
		private AnimationCurve <BlendCurve>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1068FDC", Offset="0x1068FDC")]
		[FieldOffset(Offset="0x28")]
		private float <TimeInBlend>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1068FEC", Offset="0x1068FEC")]
		[FieldOffset(Offset="0x2C")]
		private float <Duration>k__BackingField;

		public AnimationCurve BlendCurve
		{
			[Address(RVA="0x1D3BF80", Offset="0x1D3BF80", VA="0x1D3BF80")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AE94", Offset="0x108AE94")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D3BF88", Offset="0x1D3BF88", VA="0x1D3BF88")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AEA4", Offset="0x108AEA4")]
			set
			{
			}
		}

		public float BlendWeight
		{
			[Address(RVA="0x1D3BFA0", Offset="0x1D3BFA0", VA="0x1D3BFA0")]
			get
			{
				return new float();
			}
		}

		public ICinemachineCamera CamA
		{
			[Address(RVA="0x1D39C8C", Offset="0x1D39C8C", VA="0x1D39C8C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AE54", Offset="0x108AE54")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D3BF70", Offset="0x1D3BF70", VA="0x1D3BF70")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AE64", Offset="0x108AE64")]
			set
			{
			}
		}

		public ICinemachineCamera CamB
		{
			[Address(RVA="0x1D3A054", Offset="0x1D3A054", VA="0x1D3A054")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AE74", Offset="0x108AE74")]
			get
			{
				return null;
			}
			[Address(RVA="0x1D3BF78", Offset="0x1D3BF78", VA="0x1D3BF78")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AE84", Offset="0x108AE84")]
			set
			{
			}
		}

		public string Description
		{
			[Address(RVA="0x1D39DBC", Offset="0x1D39DBC", VA="0x1D39DBC")]
			get
			{
				return null;
			}
		}

		public float Duration
		{
			[Address(RVA="0x1D3BFE0", Offset="0x1D3BFE0", VA="0x1D3BFE0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AED4", Offset="0x108AED4")]
			get
			{
				return new float();
			}
			[Address(RVA="0x1D3BFE8", Offset="0x1D3BFE8", VA="0x1D3BFE8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AEE4", Offset="0x108AEE4")]
			set
			{
			}
		}

		public bool IsComplete
		{
			[Address(RVA="0x1D3BFF0", Offset="0x1D3BFF0", VA="0x1D3BFF0")]
			get
			{
				return new bool();
			}
		}

		public bool IsValid
		{
			[Address(RVA="0x1D3BFC0", Offset="0x1D3BFC0", VA="0x1D3BFC0")]
			get
			{
				return new bool();
			}
		}

		public CameraState State
		{
			[Address(RVA="0x1D3A1C0", Offset="0x1D3A1C0", VA="0x1D3A1C0")]
			get
			{
				return new CameraState();
			}
		}

		public float TimeInBlend
		{
			[Address(RVA="0x1D3BF90", Offset="0x1D3BF90", VA="0x1D3BF90")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AEB4", Offset="0x108AEB4")]
			get
			{
				return new float();
			}
			[Address(RVA="0x1D3BF98", Offset="0x1D3BF98", VA="0x1D3BF98")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108AEC4", Offset="0x108AEC4")]
			set
			{
			}
		}

		[Address(RVA="0x1D3C124", Offset="0x1D3C124", VA="0x1D3C124")]
		public CinemachineBlend(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t)
		{
		}

		[Address(RVA="0x1D3A0DC", Offset="0x1D3A0DC", VA="0x1D3A0DC")]
		public void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		[Address(RVA="0x1D3C000", Offset="0x1D3C000", VA="0x1D3C000")]
		public bool Uses(ICinemachineCamera cam)
		{
			return new bool();
		}
	}
}