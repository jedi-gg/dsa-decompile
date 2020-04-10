using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104AB5C", Offset="0x104AB5C")]
	[Serializable]
	public sealed class CinemachineBlenderSettings : ScriptableObject
	{
		[Attribute(Name="TooltipAttribute", RVA="0x106906C", Offset="0x106906C")]
		[FieldOffset(Offset="0x18")]
		public CinemachineBlenderSettings.CustomBlend[] m_CustomBlends;

		[FieldOffset(Offset="0x0")]
		public const string kBlendFromAnyCameraLabel = "**ANY CAMERA**";

		[Address(RVA="0x1D3DEEC", Offset="0x1D3DEEC", VA="0x1D3DEEC")]
		public CinemachineBlenderSettings()
		{
		}

		[Address(RVA="0x1D3DCD4", Offset="0x1D3DCD4", VA="0x1D3DCD4")]
		public AnimationCurve GetBlendCurveForVirtualCameras(string fromCameraName, string toCameraName, AnimationCurve defaultCurve)
		{
			return null;
		}

		[Attribute(Name="DocumentationSortingAttribute", RVA="0x1051498", Offset="0x1051498")]
		[Serializable]
		public struct CustomBlend
		{
			[Attribute(Name="TooltipAttribute", RVA="0x106D5BC", Offset="0x106D5BC")]
			[FieldOffset(Offset="0x0")]
			public string m_From;

			[Attribute(Name="TooltipAttribute", RVA="0x106D5F4", Offset="0x106D5F4")]
			[FieldOffset(Offset="0x8")]
			public string m_To;

			[Attribute(Name="TooltipAttribute", RVA="0x106D62C", Offset="0x106D62C")]
			[FieldOffset(Offset="0x10")]
			public CinemachineBlendDefinition m_Blend;
		}
	}
}