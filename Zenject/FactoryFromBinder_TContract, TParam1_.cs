using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class FactoryFromBinder<TContract, TParam1> : FactoryFromBinderBase<TContract>
	{
		[Address(RVA="0x1F49670", Offset="0x1F49670", VA="0x1F49670")]
		public FactoryFromBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x2AF7C80", Offset="0x2AF7C80", VA="0x2AF7C80")]
		public ConditionCopyNonLazyBinder FromFactory<TSubFactory>()
		where TSubFactory : IFactory<TParam1, TContract>
		{
			return null;
		}

		[Address(RVA="0x1F497C0", Offset="0x1F497C0", VA="0x1F497C0")]
		public ConditionCopyNonLazyBinder FromIFactoryResolve()
		{
			return null;
		}

		[Address(RVA="0x1F49800", Offset="0x1F49800", VA="0x1F49800")]
		public ConditionCopyNonLazyBinder FromIFactoryResolve(object subIdentifier)
		{
			return null;
		}

		[Address(RVA="0x1F496C4", Offset="0x1F496C4", VA="0x1F496C4")]
		public ConditionCopyNonLazyBinder FromMethod(Func<DiContainer, TParam1, TContract> method)
		{
			return null;
		}

		[Address(RVA="0x1F4993C", Offset="0x1F4993C", VA="0x1F4993C")]
		public FactorySubContainerBinder<TParam1, TContract> FromSubContainerResolve()
		{
			return null;
		}

		[Address(RVA="0x1F4997C", Offset="0x1F4997C", VA="0x1F4997C")]
		public FactorySubContainerBinder<TParam1, TContract> FromSubContainerResolve(object subIdentifier)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D5E8", Offset="0x104D5E8")]
		[Serializable]
		private sealed class <>c__2<TSubFactory>
		where TSubFactory : IFactory<TParam1, TContract>
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FactoryFromBinder<TParam1, TContract>.<>c__2<TSubFactory> <>9;

			[FieldOffset(Offset="0x0")]
			public static Func<DiContainer, IProvider> <>9__2_0;

			[Address(RVA="0x1F4937C", Offset="0x1F4937C", VA="0x1F4937C")]
			static <>c__2()
			{
			}

			[Address(RVA="0x1F49454", Offset="0x1F49454", VA="0x1F49454")]
			public <>c__2()
			{
			}

			[Address(RVA="0x1F49480", Offset="0x1F49480", VA="0x1F49480")]
			internal IProvider <FromFactory>b__2_0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D5D8", Offset="0x104D5D8")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset="0x0")]
			public Func<DiContainer, TParam1, TContract> method;

			[Address(RVA="0x1F49538", Offset="0x1F49538", VA="0x1F49538")]
			public <>c__DisplayClass1_0()
			{
			}

			[Address(RVA="0x1F49564", Offset="0x1F49564", VA="0x1F49564")]
			internal IProvider <FromMethod>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D5F8", Offset="0x104D5F8")]
		private sealed class <>c__DisplayClass4_0
		{
			[FieldOffset(Offset="0x0")]
			public object subIdentifier;

			[Address(RVA="0x1F495D0", Offset="0x1F495D0", VA="0x1F495D0")]
			public <>c__DisplayClass4_0()
			{
			}

			[Address(RVA="0x1F495FC", Offset="0x1F495FC", VA="0x1F495FC")]
			internal IProvider <FromIFactoryResolve>b__0(DiContainer container)
			{
				return null;
			}
		}
	}
}