using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	[DebuggerStepThrough]
	public static class InjectUtil
	{
		[Address(RVA="0x183B450", Offset="0x183B450", VA="0x183B450")]
		public static List<TypeValuePair> CreateArgList(IEnumerable<object> args)
		{
			return null;
		}

		[Address(RVA="0x13ED910", Offset="0x13ED910", VA="0x13ED910")]
		public static List<TypeValuePair> CreateArgListExplicit<T>(T param)
		{
			return null;
		}

		[Address(RVA="0x13ED820", Offset="0x13ED820", VA="0x13ED820")]
		public static List<TypeValuePair> CreateArgListExplicit<TParam1, TParam2>(TParam1 param1, TParam2 param2)
		{
			return null;
		}

		[Address(RVA="0x13ED6F8", Offset="0x13ED6F8", VA="0x13ED6F8")]
		public static List<TypeValuePair> CreateArgListExplicit<TParam1, TParam2, TParam3>(TParam1 param1, TParam2 param2, TParam3 param3)
		{
			return null;
		}

		[Address(RVA="0x13ED590", Offset="0x13ED590", VA="0x13ED590")]
		public static List<TypeValuePair> CreateArgListExplicit<TParam1, TParam2, TParam3, TParam4>(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4)
		{
			return null;
		}

		[Address(RVA="0x13ED3F0", Offset="0x13ED3F0", VA="0x13ED3F0")]
		public static List<TypeValuePair> CreateArgListExplicit<TParam1, TParam2, TParam3, TParam4, TParam5>(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5)
		{
			return null;
		}

		[Address(RVA="0x13ED210", Offset="0x13ED210", VA="0x13ED210")]
		public static List<TypeValuePair> CreateArgListExplicit<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6>(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6)
		{
			return null;
		}

		[Address(RVA="0x2AFEEDC", Offset="0x2AFEEDC", VA="0x2AFEEDC")]
		public static TypeValuePair CreateTypePair<T>(T param)
		{
			return null;
		}

		[Address(RVA="0x183B580", Offset="0x183B580", VA="0x183B580")]
		public static bool PopValueWithType(List<TypeValuePair> extraArgMap, Type injectedFieldType, out object value)
		{
			value = null;
			return new bool();
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DCB8", Offset="0x104DCB8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InjectUtil.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<object, TypeValuePair> <>9__0_0;

			[Address(RVA="0x183B6A4", Offset="0x183B6A4", VA="0x183B6A4")]
			static <>c()
			{
			}

			[Address(RVA="0x183B708", Offset="0x183B708", VA="0x183B708")]
			public <>c()
			{
			}

			[Address(RVA="0x183B710", Offset="0x183B710", VA="0x183B710")]
			internal TypeValuePair <CreateArgList>b__0_0(object x)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DCC8", Offset="0x104DCC8")]
		private sealed class <>c__DisplayClass8_0
		{
			[FieldOffset(Offset="0x10")]
			public Type injectedFieldType;

			[Address(RVA="0x183B69C", Offset="0x183B69C", VA="0x183B69C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Address(RVA="0x183B7A0", Offset="0x183B7A0", VA="0x183B7A0")]
			internal bool <PopValueWithType>b__0(TypeValuePair x)
			{
				return new bool();
			}
		}
	}
}