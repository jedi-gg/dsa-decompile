using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Rendering;

public class LightingOverride : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private LightingOverride.DData _previousData;

	[FieldOffset(Offset="0x50")]
	private bool _setOverrides;

	[FieldOffset(Offset="0x54")]
	[SerializeField]
	private LightingOverride.DData _data;

	[Address(RVA="0x11D8FFC", Offset="0x11D8FFC", VA="0x11D8FFC")]
	public LightingOverride()
	{
	}

	[Address(RVA="0x11D8E04", Offset="0x11D8E04", VA="0x11D8E04")]
	private void ApplySceneLighting()
	{
	}

	[Address(RVA="0x11D8EC4", Offset="0x11D8EC4", VA="0x11D8EC4")]
	private void OnDisable()
	{
	}

	[Address(RVA="0x11D8E00", Offset="0x11D8E00", VA="0x11D8E00")]
	private void OnEnable()
	{
	}

	[Address(RVA="0x11D8F1C", Offset="0x11D8F1C", VA="0x11D8F1C")]
	private void RestoreSceneLighting()
	{
	}

	[Address(RVA="0x11D8F74", Offset="0x11D8F74", VA="0x11D8F74")]
	private void SetCurrentSettings(LightingOverride.DData data)
	{
	}

	[Serializable]
	public struct DData
	{
		[FieldOffset(Offset="0x0")]
		public Color SkyColor;

		[FieldOffset(Offset="0x10")]
		public bool FogEnabled;

		[FieldOffset(Offset="0x14")]
		public Color FogColor;

		[FieldOffset(Offset="0x24")]
		public FogMode FogMode;

		[FieldOffset(Offset="0x28")]
		public float FogStart;

		[FieldOffset(Offset="0x2C")]
		public float FogEnd;

		[FieldOffset(Offset="0x30")]
		public float FogDensity;

		[FieldOffset(Offset="0x34")]
		public AmbientMode AmbientMode;
	}
}