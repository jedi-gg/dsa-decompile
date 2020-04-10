using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

[Attribute(Name="ExecuteInEditMode", RVA="0x1049258", Offset="0x1049258")]
public class TCP2_PlanarReflection : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	public bool m_DisablePixelLights;

	[FieldOffset(Offset="0x1C")]
	public int m_TextureSize;

	[FieldOffset(Offset="0x20")]
	public float m_ClipPlaneOffset;

	[FieldOffset(Offset="0x24")]
	public LayerMask m_ReflectLayers;

	[FieldOffset(Offset="0x28")]
	private Hashtable m_ReflectionCameras;

	[FieldOffset(Offset="0x30")]
	private RenderTexture m_ReflectionTexture;

	[FieldOffset(Offset="0x38")]
	private int m_OldReflectionTextureSize;

	[FieldOffset(Offset="0x0")]
	private static bool s_InsideRendering;

	[Address(RVA="0x1320678", Offset="0x1320678", VA="0x1320678")]
	static TCP2_PlanarReflection()
	{
	}

	[Address(RVA="0x13205F0", Offset="0x13205F0", VA="0x13205F0")]
	public TCP2_PlanarReflection()
	{
	}

	[Address(RVA="0x131FCD8", Offset="0x131FCD8", VA="0x131FCD8")]
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
	}

	[Address(RVA="0x131FF7C", Offset="0x131FF7C", VA="0x131FF7C")]
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		return new Vector4();
	}

	[Address(RVA="0x131F174", Offset="0x131F174", VA="0x131F174")]
	private void CreateMirrorObjects(Camera currentCamera, out Camera reflectionCamera)
	{
		reflectionCamera = null;
	}

	[Address(RVA="0x1320164", Offset="0x1320164", VA="0x1320164")]
	private void OnDisable()
	{
	}

	[Address(RVA="0x131EA18", Offset="0x131EA18", VA="0x131EA18")]
	public void OnWillRenderObject()
	{
	}

	[Address(RVA="0x13205D0", Offset="0x13205D0", VA="0x13205D0")]
	private static float sgn(float a)
	{
		return new float();
	}

	[Address(RVA="0x131F87C", Offset="0x131F87C", VA="0x131F87C")]
	private void UpdateCameraModes(Camera src, Camera dest)
	{
	}
}