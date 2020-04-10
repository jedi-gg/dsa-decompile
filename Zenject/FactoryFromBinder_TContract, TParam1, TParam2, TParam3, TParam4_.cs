using Il2CppDummyDll;
using ModestTree.Util;
using System;

namespace Zenject
{
	public class FactoryFromBinder<TContract, TParam1, TParam2, TParam3, TParam4> : FactoryFromBinderBase<TContract>
	{
		[Address(RVA="0x1F4AAE0", Offset="0x1F4AAE0", VA="0x1F4AAE0")]
		public FactoryFromBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x2AF81FC", Offset="0x2AF81FC", VA="0x2AF81FC")]
		public ConditionCopyNonLazyBinder FromFactory<TSubFactory>()
		where TSubFactory : IFactory<TParam1, TParam2, TParam3, TParam4, TContract>
		{
			return null;
		}

		[Address(RVA="0x1F4AC30", Offset="0x1F4AC30", VA="0x1F4AC30")]
		public ConditionCopyNonLazyBinder FromIFactoryResolve()
		{
			return null;
		}

		[Address(RVA="0x1F4AC70", Offset="0x1F4AC70", VA="0x1F4AC70")]
		public ConditionCopyNonLazyBinder FromIFactoryResolve(object subIdentifier)
		{
			return null;
		}

		[Address(RVA="0x1F4AB34", Offset="0x1F4AB34", VA="0x1F4AB34")]
		public ConditionCopyNonLazyBinder FromMethod(ModestTree.Util.Func<DiContainer, TParam1, TParam2, TParam3, TParam4, TContract> method)
		{
			return null;
		}

		[Address(RVA="0x1F4ADAC", Offset="0x1F4ADAC", VA="0x1F4ADAC")]
		public FactorySubContainerBinder<TParam1, TParam2, TParam3, TParam4, TContract> FromSubContainerResolve()
		{
			return null;
		}

		[Address(RVA="0x1F4ADEC", Offset="0x1F4ADEC", VA="0x1F4ADEC")]
		public FactorySubContainerBinder<TParam1, TParam2, TParam3, TParam4, TContract> FromSubContainerResolve(object subIdentifier)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D678", Offset="0x104D678")]
		[Serializable]
		private sealed class <>c__2<TSubFactory>
		where TSubFactory : IFactory<TParam1, TParam2, TParam3, TParam4, TContract>
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FactoryFromBinder<TParam1, TParam2, TParam3, TParam4, TContract>.<>c__2<TSubFactory> <>9;

			[FieldOffset(Offset="0x0")]
			public static Func<DiContainer, IProvider> <>9__2_0;

			[Address(RVA="0x1F4A7EC", Offset="0x1F4A7EC", VA="0x1F4A7EC")]
			static <>c__2()
			{
			}

			[Address(RVA="0x1F4A8C4", Offset="0x1F4A8C4", VA="0x1F4A8C4")]
			public <>c__2()
			{
			}

			[Address(RVA="0x1F4A8F0", Offset="0x1F4A8F0", VA="0x1F4A8F0")]
			internal IProvider <FromFactory>b__2_0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D668", Offset="0x104D668")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset="0x0")]
			public ModestTree.Util.Func<DiContainer, TParam1, TParam2, TParam3, TParam4, TContract> method;

			[Address(RVA="0x1F4A9A8", Offset="0x1F4A9A8", VA="0x1F4A9A8")]
			public <>c__DisplayClass1_0()
			{
			}

			[Address(RVA="0x1F4A9D4", Offset="0x1F4A9D4", VA="0x1F4A9D4")]
			internal IProvider <FromMethod>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D688", Offset="0x104D688")]
		private sealed class <>c__DisplayClass4_0
		{
			[FieldOffset(Offset="0x0")]
			public object subIdentifier;

			[Address(RVA="0x1F4AA40", Offset="0x1F4AA40", VA="0x1F4AA40")]
			public <>c__DisplayClass4_0()
			{
			}

			[Address(RVA="0x1F4AA6C", Offset="0x1F4AA6C", VA="0x1F4AA6C")]
			internal IProvider <FromIFactoryResolve>b__0(DiContainer container)
			{
				return null;
			}
		}
	}
}