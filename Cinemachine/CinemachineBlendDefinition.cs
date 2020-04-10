using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104AB40", Offset="0x104AB40")]
	[Serializable]
	public struct CinemachineBlendDefinition
	{
		[Attribute(Name="TooltipAttribute", RVA="0x1068FFC", Offset="0x1068FFC")]
		[FieldOffset(Offset="0x0")]
		public CinemachineBlendDefinition.Style m_Style;

		[Attribute(Name="TooltipAttribute", RVA="0x1069034", Offset="0x1069034")]
		[FieldOffset(Offset="0x4")]
		public float m_Time;

		public AnimationCurve BlendCurve
		{
			[Address(RVA="0xF2E234", Offset="0xF2E234", VA="0xF2E234")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF2E228", Offset="0xF2E228", VA="0xF2E228")]
		public CinemachineBlendDefinition(CinemachineBlendDefinition.Style style, float time)
		{
		}

		[Attribute(Name="DocumentationSortingAttribute", RVA="0x105147C", Offset="0x105147C")]
		public enum Style
		{
			[FieldOffset(Offset="0x0")]
			Cut,
			[FieldOffset(Offset="0x0")]
			EaseInOut,
			[FieldOffset(Offset="0x0")]
			EaseIn,
			[FieldOffset(Offset="0x0")]
			EaseOut,
			[FieldOffset(Offset="0x0")]
			HardIn,
			[FieldOffset(Offset="0x0")]
			HardOut,
			[FieldOffset(Offset="0x0")]
			Linear
		}
	}
}