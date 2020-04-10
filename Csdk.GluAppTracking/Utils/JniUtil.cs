using Il2CppDummyDll;
using System;

namespace Csdk.GluAppTracking.Utils
{
	public static class JniUtil
	{
		[Address(RVA="0x15594AC", Offset="0x15594AC", VA="0x15594AC")]
		public static void CallInLocalFrame(Action action)
		{
		}

		[Address(RVA="0x16A8018", Offset="0x16A8018", VA="0x16A8018")]
		public static T CallInLocalFrame<T>(Func<T> func)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E4E8", Offset="0x104E4E8")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset="0x10")]
			public Action action;

			[Address(RVA="0x155C450", Offset="0x155C450", VA="0x155C450")]
			public <>c__DisplayClass0_0()
			{
			}

			[Address(RVA="0x155C458", Offset="0x155C458", VA="0x155C458")]
			internal object <CallInLocalFrame>b__0()
			{
				return null;
			}
		}
	}
}