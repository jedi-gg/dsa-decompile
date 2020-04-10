using Il2CppDummyDll;
using System;

namespace Glu.Plugins.GluAnalytics.Utils
{
	public static class JniUtil
	{
		[Address(RVA="0x14ED508", Offset="0x14ED508", VA="0x14ED508")]
		public static void CallInLocalFrame(Action action)
		{
		}

		[Address(RVA="0x16A9870", Offset="0x16A9870", VA="0x16A9870")]
		public static T CallInLocalFrame<T>(Func<T> func)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E378", Offset="0x104E378")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset="0x10")]
			public Action action;

			[Address(RVA="0x14F3C58", Offset="0x14F3C58", VA="0x14F3C58")]
			public <>c__DisplayClass0_0()
			{
			}

			[Address(RVA="0x14F3C60", Offset="0x14F3C60", VA="0x14F3C60")]
			internal object <CallInLocalFrame>b__0()
			{
				return null;
			}
		}
	}
}