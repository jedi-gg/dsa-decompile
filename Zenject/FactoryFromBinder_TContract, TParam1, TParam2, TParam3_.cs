using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class FactoryFromBinder<TContract, TParam1, TParam2, TParam3> : FactoryFromBinderBase<TContract>
	{
		[Address(RVA="0x1F4A410", Offset="0x1F4A410", VA="0x1F4A410")]
		public FactoryFromBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x2AF8028", Offset="0x2AF8028", VA="0x2AF8028")]
		public ConditionCopyNonLazyBinder FromFactory<TSubFactory>()
		where TSubFactory : IFactory<TParam1, TParam2, TParam3, TContract>
		{
			return null;
		}

		[Address(RVA="0x1F4A560", Offset="0x1F4A560", VA="0x1F4A560")]
		public ConditionCopyNonLazyBinder FromIFactoryResolve()
		{
			return null;
		}

		[Address(RVA="0x1F4A5A0", Offset="0x1F4A5A0", VA="0x1F4A5A0")]
		public ConditionCopyNonLazyBinder FromIFactoryResolve(object subIdentifier)
		{
			return null;
		}

		[Address(RVA="0x1F4A464", Offset="0x1F4A464", VA="0x1F4A464")]
		public ConditionCopyNonLazyBinder FromMethod(Func<DiContainer, TParam1, TParam2, TParam3, TContract> method)
		{
			return null;
		}

		[Address(RVA="0x1F4A6DC", Offset="0x1F4A6DC", VA="0x1F4A6DC")]
		public FactorySubContainerBinder<TParam1, TParam2, TParam3, TContract> FromSubContainerResolve()
		{
			return null;
		}

		[Address(RVA="0x1F4A71C", Offset="0x1F4A71C", VA="0x1F4A71C")]
		public FactorySubContainerBinder<TParam1, TParam2, TParam3, TContract> FromSubContainerResolve(object subIdentifier)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D648", Offset="0x104D648")]
		[Serializable]
		private sealed class <>c__2<TSubFactory>
		where TSubFactory : IFactory<TParam1, TParam2, TParam3, TContract>
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FactoryFromBinder<TParam1, TParam2, TParam3, TContract>.<>c__2<TSubFactory> <>9;

			[FieldOffset(Offset="0x0")]
			public static Func<DiContainer, IProvider> <>9__2_0;

			[Address(RVA="0x1F4A11C", Offset="0x1F4A11C", VA="0x1F4A11C")]
			static <>c__2()
			{
			}

			[Address(RVA="0x1F4A1F4", Offset="0x1F4A1F4", VA="0x1F4A1F4")]
			public <>c__2()
			{
			}

			[Address(RVA="0x1F4A220", Offset="0x1F4A220", VA="0x1F4A220")]
			internal IProvider <FromFactory>b__2_0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D638", Offset="0x104D638")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset="0x0")]
			public Func<DiContainer, TParam1, TParam2, TParam3, TContract> method;

			[Address(RVA="0x1F4A2D8", Offset="0x1F4A2D8", VA="0x1F4A2D8")]
			public <>c__DisplayClass1_0()
			{
			}

			[Address(RVA="0x1F4A304", Offset="0x1F4A304", VA="0x1F4A304")]
			internal IProvider <FromMethod>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D658", Offset="0x104D658")]
		private sealed class <>c__DisplayClass4_0
		{
			[FieldOffset(Offset="0x0")]
			public object subIdentifier;

			[Address(RVA="0x1F4A370", Offset="0x1F4A370", VA="0x1F4A370")]
			public <>c__DisplayClass4_0()
			{
			}

			[Address(RVA="0x1F4A39C", Offset="0x1F4A39C", VA="0x1F4A39C")]
			internal IProvider <FromIFactoryResolve>b__0(DiContainer container)
			{
				return null;
			}
		}
	}
}