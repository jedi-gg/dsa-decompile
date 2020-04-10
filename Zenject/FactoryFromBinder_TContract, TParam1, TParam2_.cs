using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class FactoryFromBinder<TContract, TParam1, TParam2> : FactoryFromBinderBase<TContract>
	{
		[Address(RVA="0x1F49D40", Offset="0x1F49D40", VA="0x1F49D40")]
		public FactoryFromBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x2AF7E54", Offset="0x2AF7E54", VA="0x2AF7E54")]
		public ConditionCopyNonLazyBinder FromFactory<TSubFactory>()
		where TSubFactory : IFactory<TParam1, TParam2, TContract>
		{
			return null;
		}

		[Address(RVA="0x1F49E90", Offset="0x1F49E90", VA="0x1F49E90")]
		public ConditionCopyNonLazyBinder FromIFactoryResolve()
		{
			return null;
		}

		[Address(RVA="0x1F49ED0", Offset="0x1F49ED0", VA="0x1F49ED0")]
		public ConditionCopyNonLazyBinder FromIFactoryResolve(object subIdentifier)
		{
			return null;
		}

		[Address(RVA="0x1F49D94", Offset="0x1F49D94", VA="0x1F49D94")]
		public ConditionCopyNonLazyBinder FromMethod(Func<DiContainer, TParam1, TParam2, TContract> method)
		{
			return null;
		}

		[Address(RVA="0x1F4A00C", Offset="0x1F4A00C", VA="0x1F4A00C")]
		public FactorySubContainerBinder<TParam1, TParam2, TContract> FromSubContainerResolve()
		{
			return null;
		}

		[Address(RVA="0x1F4A04C", Offset="0x1F4A04C", VA="0x1F4A04C")]
		public FactorySubContainerBinder<TParam1, TParam2, TContract> FromSubContainerResolve(object subIdentifier)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D618", Offset="0x104D618")]
		[Serializable]
		private sealed class <>c__2<TSubFactory>
		where TSubFactory : IFactory<TParam1, TParam2, TContract>
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FactoryFromBinder<TParam1, TParam2, TContract>.<>c__2<TSubFactory> <>9;

			[FieldOffset(Offset="0x0")]
			public static Func<DiContainer, IProvider> <>9__2_0;

			[Address(RVA="0x1F49A4C", Offset="0x1F49A4C", VA="0x1F49A4C")]
			static <>c__2()
			{
			}

			[Address(RVA="0x1F49B24", Offset="0x1F49B24", VA="0x1F49B24")]
			public <>c__2()
			{
			}

			[Address(RVA="0x1F49B50", Offset="0x1F49B50", VA="0x1F49B50")]
			internal IProvider <FromFactory>b__2_0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D608", Offset="0x104D608")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset="0x0")]
			public Func<DiContainer, TParam1, TParam2, TContract> method;

			[Address(RVA="0x1F49C08", Offset="0x1F49C08", VA="0x1F49C08")]
			public <>c__DisplayClass1_0()
			{
			}

			[Address(RVA="0x1F49C34", Offset="0x1F49C34", VA="0x1F49C34")]
			internal IProvider <FromMethod>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D628", Offset="0x104D628")]
		private sealed class <>c__DisplayClass4_0
		{
			[FieldOffset(Offset="0x0")]
			public object subIdentifier;

			[Address(RVA="0x1F49CA0", Offset="0x1F49CA0", VA="0x1F49CA0")]
			public <>c__DisplayClass4_0()
			{
			}

			[Address(RVA="0x1F49CCC", Offset="0x1F49CCC", VA="0x1F49CCC")]
			internal IProvider <FromIFactoryResolve>b__0(DiContainer container)
			{
				return null;
			}
		}
	}
}