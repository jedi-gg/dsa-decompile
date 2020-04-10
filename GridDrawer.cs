using Il2CppDummyDll;
using System;
using UnityEngine;

public class GridDrawer : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	private const string GRID_SHADER_NAME = "Glunies/GridPlane";

	[FieldOffset(Offset="0x0")]
	private const float SMALL_GRID_RAMP_OUT_START = 8f;

	[FieldOffset(Offset="0x0")]
	private const float SMALL_GRID_RAMP_OUT_LENGTH = 10f;

	[FieldOffset(Offset="0x0")]
	private const float LARGE_GRID_RAMP_OUT_START = 80f;

	[FieldOffset(Offset="0x0")]
	private const float LARGE_GRID_RAMP_OUT_LENGTH = 20f;

	[FieldOffset(Offset="0x0")]
	private const float GRID_LINE_WIDTH_SCALE = 0.006f;

	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private Camera _camera;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private Renderer _gridRenderer;

	[Address(RVA="0x12E0BDC", Offset="0x12E0BDC", VA="0x12E0BDC")]
	public GridDrawer()
	{
	}

	[Address(RVA="0x12E0AB4", Offset="0x12E0AB4", VA="0x12E0AB4")]
	private float GetRampOutAlpha(float value, float rampStart, float rampLength)
	{
		return new float();
	}

	[Address(RVA="0x12E0B4C", Offset="0x12E0B4C", VA="0x12E0B4C")]
	private void OnValidate()
	{
	}

	[Address(RVA="0x12E06E4", Offset="0x12E06E4", VA="0x12E06E4")]
	private void Start()
	{
	}

	[Address(RVA="0x12E0768", Offset="0x12E0768", VA="0x12E0768")]
	private void Update()
	{
	}
}