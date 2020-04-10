using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104ABE4", Offset="0x104ABE4")]
	public sealed class NoiseSettings : ScriptableObject
	{
		[Attribute(Name="TooltipAttribute", RVA="0x106943C", Offset="0x106943C")]
		[FieldOffset(Offset="0x18")]
		[SerializeField]
		private NoiseSettings.TransformNoiseParams[] m_Position;

		[Attribute(Name="TooltipAttribute", RVA="0x1069488", Offset="0x1069488")]
		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private NoiseSettings.TransformNoiseParams[] m_Orientation;

		public NoiseSettings.TransformNoiseParams[] OrientationNoise
		{
			[Address(RVA="0x145FD8C", Offset="0x145FD8C", VA="0x145FD8C")]
			get
			{
				return null;
			}
		}

		public NoiseSettings.TransformNoiseParams[] PositionNoise
		{
			[Address(RVA="0x145FD84", Offset="0x145FD84", VA="0x145FD84")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x145FE88", Offset="0x145FE88", VA="0x145FE88")]
		public NoiseSettings()
		{
		}

		[Address(RVA="0x145FD94", Offset="0x145FD94", VA="0x145FD94")]
		public void CopyFrom(NoiseSettings other)
		{
		}

		[Attribute(Name="DocumentationSortingAttribute", RVA="0x10514D0", Offset="0x10514D0")]
		[Serializable]
		public struct NoiseParams
		{
			[Attribute(Name="TooltipAttribute", RVA="0x106D728", Offset="0x106D728")]
			[FieldOffset(Offset="0x0")]
			public float Amplitude;

			[Attribute(Name="TooltipAttribute", RVA="0x106D760", Offset="0x106D760")]
			[FieldOffset(Offset="0x4")]
			public float Frequency;
		}

		[Attribute(Name="DocumentationSortingAttribute", RVA="0x10514EC", Offset="0x10514EC")]
		[Serializable]
		public struct TransformNoiseParams
		{
			[Attribute(Name="TooltipAttribute", RVA="0x106D798", Offset="0x106D798")]
			[FieldOffset(Offset="0x0")]
			public NoiseSettings.NoiseParams X;

			[Attribute(Name="TooltipAttribute", RVA="0x106D7D0", Offset="0x106D7D0")]
			[FieldOffset(Offset="0x8")]
			public NoiseSettings.NoiseParams Y;

			[Attribute(Name="TooltipAttribute", RVA="0x106D808", Offset="0x106D808")]
			[FieldOffset(Offset="0x10")]
			public NoiseSettings.NoiseParams Z;
		}
	}
}