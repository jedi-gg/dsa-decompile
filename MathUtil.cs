using Il2CppDummyDll;
using System;
using UnityEngine;

public static class MathUtil
{
	[FieldOffset(Offset="0x0")]
	public const float TWO_PI = 6.28318548f;

	[FieldOffset(Offset="0x0")]
	private static Vector3[] s_lineVertices;

	[Address(RVA="0x11DCF00", Offset="0x11DCF00", VA="0x11DCF00")]
	static MathUtil()
	{
	}

	[Address(RVA="0x11DCA38", Offset="0x11DCA38", VA="0x11DCA38")]
	public static DMathPolygon CreateMathPolygonLine(Vector3 lineStartPoint, Vector3 lineEndPoint, float lineWidth)
	{
		return new DMathPolygon();
	}

	[Address(RVA="0x11DC80C", Offset="0x11DC80C", VA="0x11DC80C")]
	public static float DistSqrToSegment(Vector3 segP0, Vector3 segP1, Vector3 point)
	{
		return new float();
	}

	[Address(RVA="0x11DCE6C", Offset="0x11DCE6C", VA="0x11DCE6C")]
	public static int GetNextHighestPowerOfTwo(int number)
	{
		return new int();
	}

	[Address(RVA="0x11DCE54", Offset="0x11DCE54", VA="0x11DCE54")]
	public static bool InBetween(float value, float min, float max)
	{
		return new bool();
	}

	[Address(RVA="0x11DC47C", Offset="0x11DC47C", VA="0x11DC47C")]
	public static bool IsInArc(Vector3 queryPos, float queryRadius, Vector3 arcOrigin, Vector3 arcEndPoint, float radius, float arcSpanDegree)
	{
		return new bool();
	}

	[Address(RVA="0x11DC3A8", Offset="0x11DC3A8", VA="0x11DC3A8")]
	public static bool IsInCircle(Vector3 queryPos, float queryRadius, Vector3 circlePos, float circleRadius)
	{
		return new bool();
	}

	[Address(RVA="0x11DCEF0", Offset="0x11DCEF0", VA="0x11DCEF0")]
	public static bool IsPowerOfTwo(int x)
	{
		return new bool();
	}

	[Address(RVA="0x11DCDC8", Offset="0x11DCDC8", VA="0x11DCDC8")]
	public static ulong Lerp(ulong startValue, ulong endValue, float normalizedTime)
	{
		return new ulong();
	}

	[Address(RVA="0x11DCE20", Offset="0x11DCE20", VA="0x11DCE20")]
	public static long Lerp(long startValue, long endValue, float normalizedTime)
	{
		return new long();
	}

	[Address(RVA="0x11DC30C", Offset="0x11DC30C", VA="0x11DC30C")]
	public static float NonNegativeAtan2(Vector3 targetPos, Vector3 origin)
	{
		return new float();
	}

	[Address(RVA="0x11DCD1C", Offset="0x11DCD1C", VA="0x11DCD1C")]
	public static float RubberDelta(float overStretching, float viewSize)
	{
		return new float();
	}
}