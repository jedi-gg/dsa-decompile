using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public static class ImageExtensions
{
	[Address(RVA="0x117C7B4", Offset="0x117C7B4", VA="0x117C7B4")]
	public static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs)
	{
	}

	[Address(RVA="0x117C9A8", Offset="0x117C9A8", VA="0x117C9A8")]
	public static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax)
	{
	}

	[Address(RVA="0x117D0C8", Offset="0x117D0C8", VA="0x117D0C8")]
	public static Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect, RectTransform rectTransform)
	{
		return new Vector4();
	}

	[Address(RVA="0x117CC1C", Offset="0x117CC1C", VA="0x117CC1C")]
	public static Vector4 GetDrawingDimensions(bool shouldPreserveAspect, Graphic graphic, Sprite activeSprite)
	{
		return new Vector4();
	}

	public static class SetPropertyUtility
	{
		[Address(RVA="0x1F64F18", Offset="0x1F64F18", VA="0x1F64F18")]
		public static bool SetClass<T>(ref T currentValue, T newValue)
		where T : class
		{
			return new bool();
		}

		[Address(RVA="0x117D2C8", Offset="0x117D2C8", VA="0x117D2C8")]
		public static bool SetColor(ref Color currentValue, Color newValue)
		{
			return new bool();
		}

		[Address(RVA="0x1F64F6C", Offset="0x1F64F6C", VA="0x1F64F6C")]
		public static bool SetStruct<T>(ref T currentValue, T newValue)
		where T : struct
		{
			return new bool();
		}
	}
}