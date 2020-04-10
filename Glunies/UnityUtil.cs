using Il2CppDummyDll;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Glunies
{
	public static class UnityUtil
	{
		[FieldOffset(Offset="0x0")]
		private static Vector3[] s_rectWorldCoords;

		[Address(RVA="0x161805C", Offset="0x161805C", VA="0x161805C")]
		static UnityUtil()
		{
		}

		[Address(RVA="0x1616CC4", Offset="0x1616CC4", VA="0x1616CC4")]
		public static Color ConvertColor(string htmlColor)
		{
			return new Color();
		}

		[Address(RVA="0x1617B78", Offset="0x1617B78", VA="0x1617B78")]
		public static void DeactivateChildren(Transform t)
		{
		}

		[Address(RVA="0x1616F40", Offset="0x1616F40", VA="0x1616F40")]
		public static Vector3 DivideComponents(Vector3 a, Vector3 b)
		{
			return new Vector3();
		}

		[Address(RVA="0x1616F74", Offset="0x1616F74", VA="0x1616F74")]
		public static Vector2 DivideComponents(Vector2 a, Vector2 b)
		{
			return new Vector2();
		}

		[Address(RVA="0x1617AD8", Offset="0x1617AD8", VA="0x1617AD8")]
		public static void ForceCanvasScale(Canvas canvas)
		{
		}

		[Address(RVA="0x1617420", Offset="0x1617420", VA="0x1617420")]
		public static Vector3[] GetWorldCornersNonAlloc(RectTransform rectTransform)
		{
			return null;
		}

		[Address(RVA="0x16179D4", Offset="0x16179D4", VA="0x16179D4")]
		public static Quaternion LookRotationSafe(Vector3 forward)
		{
			return new Quaternion();
		}

		[Address(RVA="0x1616D80", Offset="0x1616D80", VA="0x1616D80")]
		public static void ResetLocalTransform(Transform transform)
		{
		}

		[Address(RVA="0x1617704", Offset="0x1617704", VA="0x1617704")]
		public static void RestrictToRectTransformBounds(RectTransform rectTransform, RectTransform boundaryRectTransform)
		{
		}

		[Address(RVA="0x16174BC", Offset="0x16174BC", VA="0x16174BC")]
		public static void RestrictToScreenBounds(RectTransform rectTransform, float xPadding = 0f, float yPadding = 0f)
		{
		}

		[Address(RVA="0x1617ED4", Offset="0x1617ED4", VA="0x1617ED4")]
		public static void RotateRectTransformTowardsTarget(RectTransform origin, RectTransform target)
		{
		}

		[Address(RVA="0x1616EBC", Offset="0x1616EBC", VA="0x1616EBC")]
		public static void SetColorAlpha(Graphic graphic, float alpha)
		{
		}

		[Address(RVA="0x1616F9C", Offset="0x1616F9C", VA="0x1616F9C")]
		public static void SetLayerRecursively(Transform transform, int layer)
		{
		}

		[Address(RVA="0x16170A0", Offset="0x16170A0", VA="0x16170A0")]
		public static void SetLayerRecursively(GameObject obj, int layer)
		{
		}

		[Address(RVA="0x1616CF4", Offset="0x1616CF4", VA="0x1616CF4")]
		public static void SetParentAndResetTransform(Transform trans, Transform parent)
		{
		}

		[Address(RVA="0x1617324", Offset="0x1617324", VA="0x1617324")]
		public static Vector3 ToScreenPos(RectTransform rectTransform)
		{
			return new Vector3();
		}

		[Address(RVA="0x1617134", Offset="0x1617134", VA="0x1617134")]
		public static Rect ToScreenSpaceRect(RectTransform rectTransform)
		{
			return new Rect();
		}
	}
}