using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x104A364", Offset="0x104A364")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104A364", Offset="0x104A364")]
	[Attribute(Name="RequireComponent", RVA="0x104A364", Offset="0x104A364")]
	[Attribute(Name="SaveDuringPlayAttribute", RVA="0x104A364", Offset="0x104A364")]
	public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase
	{
		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1067380", Offset="0x1067380")]
		[Attribute(Name="HideInInspector", RVA="0x1067380", Offset="0x1067380")]
		[Attribute(Name="TooltipAttribute", RVA="0x1067380", Offset="0x1067380")]
		[FieldOffset(Offset="0x20")]
		public NoiseSettings m_NoiseProfile;

		[Attribute(Name="TooltipAttribute", RVA="0x10673F0", Offset="0x10673F0")]
		[FieldOffset(Offset="0x28")]
		public float m_AmplitudeGain;

		[Attribute(Name="TooltipAttribute", RVA="0x1067428", Offset="0x1067428")]
		[FieldOffset(Offset="0x2C")]
		public float m_FrequencyGain;

		[FieldOffset(Offset="0x30")]
		private bool mInitialized;

		[FieldOffset(Offset="0x34")]
		private float mNoiseTime;

		[FieldOffset(Offset="0x38")]
		private Vector3 mNoiseOffsets;

		public override bool IsValid
		{
			[Address(RVA="0x1D3B934", Offset="0x1D3B934", VA="0x1D3B934", Slot="4")]
			get
			{
				return new bool();
			}
		}

		public override CinemachineCore.Stage Stage
		{
			[Address(RVA="0x1D3B9C4", Offset="0x1D3B9C4", VA="0x1D3B9C4", Slot="6")]
			get
			{
				return new CinemachineCore.Stage();
			}
		}

		[Address(RVA="0x1D3BEE8", Offset="0x1D3BEE8", VA="0x1D3BEE8")]
		public CinemachineBasicMultiChannelPerlin()
		{
		}

		[Address(RVA="0x1D3BCB0", Offset="0x1D3BCB0", VA="0x1D3BCB0")]
		private static Vector3 GetCombinedFilterResults(NoiseSettings.TransformNoiseParams[] noiseParams, float time, Vector3 noiseOffsets)
		{
			return new Vector3();
		}

		[Address(RVA="0x1D3BBF8", Offset="0x1D3BBF8", VA="0x1D3BBF8")]
		private void Initialize()
		{
		}

		[Address(RVA="0x1D3B9CC", Offset="0x1D3B9CC", VA="0x1D3B9CC", Slot="7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}
	}
}