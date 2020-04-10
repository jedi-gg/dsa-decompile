using Il2CppDummyDll;
using ModestTree.Util;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class InitializableManager
	{
		[FieldOffset(Offset="0x10")]
		private List<InitializableManager.InitializableInfo> _initializables;

		[FieldOffset(Offset="0x18")]
		private bool _hasInitialized;

		[Address(RVA="0x1839278", Offset="0x1839278", VA="0x1839278")]
		[Attribute(Name="InjectAttribute", RVA="0x1073DAC", Offset="0x1073DAC")]
		public InitializableManager([Attribute(Name="InjectAttribute", RVA="0x1091470", Offset="0x1091470")] List<IInitializable> initializables, [Attribute(Name="InjectAttribute", RVA="0x10914B8", Offset="0x10914B8")] List<ValuePair<Type, int>> priorities)
		{
		}

		[Address(RVA="0x1839588", Offset="0x1839588", VA="0x1839588")]
		public void Initialize()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E148", Offset="0x104E148")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static InitializableManager.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<ValuePair<Type, int>, int> <>9__2_1;

			[FieldOffset(Offset="0x10")]
			public static Func<InitializableManager.InitializableInfo, int> <>9__3_0;

			[Address(RVA="0x183998C", Offset="0x183998C", VA="0x183998C")]
			static <>c()
			{
			}

			[Address(RVA="0x18399F0", Offset="0x18399F0", VA="0x18399F0")]
			public <>c()
			{
			}

			[Address(RVA="0x18399F8", Offset="0x18399F8", VA="0x18399F8")]
			internal int <.ctor>b__2_1(ValuePair<Type, int> x)
			{
				return new int();
			}

			[Address(RVA="0x1839A24", Offset="0x1839A24", VA="0x1839A24")]
			internal int <Initialize>b__3_0(InitializableManager.InitializableInfo x)
			{
				return new int();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E138", Offset="0x104E138")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x10")]
			public IInitializable initializable;

			[Address(RVA="0x1839544", Offset="0x1839544", VA="0x1839544")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x1839A50", Offset="0x1839A50", VA="0x1839A50")]
			internal bool <.ctor>b__0(ValuePair<Type, int> x)
			{
				return new bool();
			}
		}

		private class InitializableInfo
		{
			[FieldOffset(Offset="0x10")]
			public IInitializable Initializable;

			[FieldOffset(Offset="0x18")]
			public int Priority;

			[Address(RVA="0x183954C", Offset="0x183954C", VA="0x183954C")]
			public InitializableInfo(IInitializable initializable, int priority)
			{
			}
		}
	}
}