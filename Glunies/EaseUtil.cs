using Il2CppDummyDll;
using System;

namespace Glunies
{
	public static class EaseUtil
	{
		[Address(RVA="0x1421840", Offset="0x1421840", VA="0x1421840")]
		public static float EaseInOutCubic(float currentTime, float startValue, float deltaValue, float totalDuration)
		{
			return new float();
		}

		[Address(RVA="0x1421774", Offset="0x1421774", VA="0x1421774")]
		public static float EaseInOutSine(float currentTime, float startValue, float deltaValue, float totalDuration)
		{
			return new float();
		}

		[Address(RVA="0x142154C", Offset="0x142154C", VA="0x142154C")]
		public static float EaseLinear(float currentTime, float startValue, float deltaValue, float totalDuration)
		{
			return new float();
		}

		[Address(RVA="0x14216B0", Offset="0x14216B0", VA="0x14216B0")]
		public static float EaseOutCirc(float currentTime, float startValue, float deltaValue, float totalDuration)
		{
			return new float();
		}

		[Address(RVA="0x142166C", Offset="0x142166C", VA="0x142166C")]
		public static float EaseOutCubic(float currentTime, float startValue, float deltaValue, float totalDuration)
		{
			return new float();
		}

		[Address(RVA="0x1421574", Offset="0x1421574", VA="0x1421574")]
		public static float EaseOutElastic(float currentTime, float startValue, float deltaValue, float totalDuration)
		{
			return new float();
		}

		public delegate float EaseFunction(float currentTime, float startValue, float deltaValue, float totalDuration);
	}
}