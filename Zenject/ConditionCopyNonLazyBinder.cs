using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class ConditionCopyNonLazyBinder : CopyNonLazyBinder
	{
		[Address(RVA="0x15AB6B0", Offset="0x15AB6B0", VA="0x15AB6B0")]
		public ConditionCopyNonLazyBinder(Zenject.BindInfo bindInfo)
		{
		}

		[Address(RVA="0x15AF7CC", Offset="0x15AF7CC", VA="0x15AF7CC")]
		public CopyNonLazyBinder When(BindingCondition condition)
		{
			return null;
		}

		[Address(RVA="0x15AF8DC", Offset="0x15AF8DC", VA="0x15AF8DC")]
		public CopyNonLazyBinder WhenInjectedInto(params Type[] targets)
		{
			return null;
		}

		[Address(RVA="0x2AF8AB8", Offset="0x2AF8AB8", VA="0x2AF8AB8")]
		public CopyNonLazyBinder WhenInjectedInto<T>()
		{
			return null;
		}

		[Address(RVA="0x15AF810", Offset="0x15AF810", VA="0x15AF810")]
		public CopyNonLazyBinder WhenInjectedIntoInstance(object instance)
		{
			return null;
		}

		[Address(RVA="0x2AF8C70", Offset="0x2AF8C70", VA="0x2AF8C70")]
		public CopyNonLazyBinder WhenNotInjectedInto<T>()
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D468", Offset="0x104D468")]
		[Serializable]
		private sealed class <>c__4<T>
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ConditionCopyNonLazyBinder.<>c__4<T> <>9;

			[FieldOffset(Offset="0x0")]
			public static BindingCondition <>9__4_0;

			[Address(RVA="0x1F4582C", Offset="0x1F4582C", VA="0x1F4582C")]
			static <>c__4()
			{
			}

			[Address(RVA="0x1F45904", Offset="0x1F45904", VA="0x1F45904")]
			public <>c__4()
			{
			}

			[Address(RVA="0x1F45930", Offset="0x1F45930", VA="0x1F45930")]
			internal bool <WhenInjectedInto>b__4_0(InjectContext r)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D478", Offset="0x104D478")]
		[Serializable]
		private sealed class <>c__5<T>
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ConditionCopyNonLazyBinder.<>c__5<T> <>9;

			[FieldOffset(Offset="0x0")]
			public static BindingCondition <>9__5_0;

			[Address(RVA="0x1F45A40", Offset="0x1F45A40", VA="0x1F45A40")]
			static <>c__5()
			{
			}

			[Address(RVA="0x1F45B18", Offset="0x1F45B18", VA="0x1F45B18")]
			public <>c__5()
			{
			}

			[Address(RVA="0x1F45B44", Offset="0x1F45B44", VA="0x1F45B44")]
			internal bool <WhenNotInjectedInto>b__5_0(InjectContext r)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D438", Offset="0x104D438")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x10")]
			public object instance;

			[Address(RVA="0x15AF8D4", Offset="0x15AF8D4", VA="0x15AF8D4")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x15AF9A8", Offset="0x15AF9A8", VA="0x15AF9A8")]
			internal bool <WhenInjectedIntoInstance>b__0(InjectContext r)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D448", Offset="0x104D448")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset="0x10")]
			public Type[] targets;

			[Address(RVA="0x15AF9A0", Offset="0x15AF9A0", VA="0x15AF9A0")]
			public <>c__DisplayClass3_0()
			{
			}

			[Address(RVA="0x15AF9EC", Offset="0x15AF9EC", VA="0x15AF9EC")]
			internal bool <WhenInjectedInto>b__0(InjectContext r)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D458", Offset="0x104D458")]
		private sealed class <>c__DisplayClass3_1
		{
			[FieldOffset(Offset="0x10")]
			public InjectContext r;

			[Address(RVA="0x15AFAC0", Offset="0x15AFAC0", VA="0x15AFAC0")]
			public <>c__DisplayClass3_1()
			{
			}

			[Address(RVA="0x15AFAC8", Offset="0x15AFAC8", VA="0x15AFAC8")]
			internal bool <WhenInjectedInto>b__1(Type x)
			{
				return new bool();
			}
		}
	}
}