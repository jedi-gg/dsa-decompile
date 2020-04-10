using Il2CppDummyDll;
using ModestTree.Util;
using System;

namespace Zenject
{
	public class FactoryFromBinder<TContract, TParam1, TParam2, TParam3, TParam4, TParam5> : FactoryFromBinderBase<TContract>
	{
		[Address(RVA="0x1F4B1B0", Offset="0x1F4B1B0", VA="0x1F4B1B0")]
		public FactoryFromBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x2AF83D0", Offset="0x2AF83D0", VA="0x2AF83D0")]
		public ConditionCopyNonLazyBinder FromFactory<TSubFactory>()
		where TSubFactory : IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TContract>
		{
			return null;
		}

		[Address(RVA="0x1F4B300", Offset="0x1F4B300", VA="0x1F4B300")]
		public ConditionCopyNonLazyBinder FromIFactoryResolve()
		{
			return null;
		}

		[Address(RVA="0x1F4B340", Offset="0x1F4B340", VA="0x1F4B340")]
		public ConditionCopyNonLazyBinder FromIFactoryResolve(object subIdentifier)
		{
			return null;
		}

		[Address(RVA="0x1F4B204", Offset="0x1F4B204", VA="0x1F4B204")]
		public ConditionCopyNonLazyBinder FromMethod(ModestTree.Util.Func<DiContainer, TParam1, TParam2, TParam3, TParam4, TParam5, TContract> method)
		{
			return null;
		}

		[Address(RVA="0x1F4B47C", Offset="0x1F4B47C", VA="0x1F4B47C")]
		public FactorySubContainerBinder<TParam1, TParam2, TParam3, TParam4, TParam5, TContract> FromSubContainerResolve()
		{
			return null;
		}

		[Address(RVA="0x1F4B4BC", Offset="0x1F4B4BC", VA="0x1F4B4BC")]
		public FactorySubContainerBinder<TParam1, TParam2, TParam3, TParam4, TParam5, TContract> FromSubContainerResolve(object subIdentifier)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D6A8", Offset="0x104D6A8")]
		[Serializable]
		private sealed class <>c__2<TSubFactory>
		where TSubFactory : IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TContract>
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FactoryFromBinder<TParam1, TParam2, TParam3, TParam4, TParam5, TContract>.<>c__2<TSubFactory> <>9;

			[FieldOffset(Offset="0x0")]
			public static Func<DiContainer, IProvider> <>9__2_0;

			[Address(RVA="0x1F4AEBC", Offset="0x1F4AEBC", VA="0x1F4AEBC")]
			static <>c__2()
			{
			}

			[Address(RVA="0x1F4AF94", Offset="0x1F4AF94", VA="0x1F4AF94")]
			public <>c__2()
			{
			}

			[Address(RVA="0x1F4AFC0", Offset="0x1F4AFC0", VA="0x1F4AFC0")]
			internal IProvider <FromFactory>b__2_0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D698", Offset="0x104D698")]
		private sealed class <>c__DisplayClass1_0
		{
			[FieldOffset(Offset="0x0")]
			public ModestTree.Util.Func<DiContainer, TParam1, TParam2, TParam3, TParam4, TParam5, TContract> method;

			[Address(RVA="0x1F4B078", Offset="0x1F4B078", VA="0x1F4B078")]
			public <>c__DisplayClass1_0()
			{
			}

			[Address(RVA="0x1F4B0A4", Offset="0x1F4B0A4", VA="0x1F4B0A4")]
			internal IProvider <FromMethod>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D6B8", Offset="0x104D6B8")]
		private sealed class <>c__DisplayClass4_0
		{
			[FieldOffset(Offset="0x0")]
			public object subIdentifier;

			[Address(RVA="0x1F4B110", Offset="0x1F4B110", VA="0x1F4B110")]
			public <>c__DisplayClass4_0()
			{
			}

			[Address(RVA="0x1F4B13C", Offset="0x1F4B13C", VA="0x1F4B13C")]
			internal IProvider <FromIFactoryResolve>b__0(DiContainer container)
			{
				return null;
			}
		}
	}
}