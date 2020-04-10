using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
	public class FactoryFromBinder<TContract> : FactoryFromBinderBase<TContract>
	{
		[Address(RVA="0x1F4891C", Offset="0x1F4891C", VA="0x1F4891C")]
		public FactoryFromBinder(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x1F49054", Offset="0x1F49054", VA="0x1F49054")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072110", Offset="0x1072110")]
		private TContract <FromComponentInHierarchy>b__10_0(DiContainer container)
		{
			return null;
		}

		[Address(RVA="0x2AFAAE4", Offset="0x2AFAAE4", VA="0x2AFAAE4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072100", Offset="0x1072100")]
		private IProvider <FromFactory>b__5_0<TSubFactory>(DiContainer container)
		where TSubFactory : IFactory<TContract>
		{
			return null;
		}

		[Address(RVA="0x1F48E5C", Offset="0x1F48E5C", VA="0x1F48E5C")]
		public ConditionCopyNonLazyBinder FromComponentInHierarchy()
		{
			return null;
		}

		[Address(RVA="0x2AF6F48", Offset="0x2AF6F48", VA="0x2AF6F48")]
		public ArgConditionCopyNonLazyBinder FromFactory<TSubFactory>()
		where TSubFactory : IFactory<TContract>
		{
			return null;
		}

		[Address(RVA="0x1F48BD0", Offset="0x1F48BD0", VA="0x1F48BD0")]
		public ConditionCopyNonLazyBinder FromIFactoryResolve()
		{
			return null;
		}

		[Address(RVA="0x1F48C10", Offset="0x1F48C10", VA="0x1F48C10")]
		public ConditionCopyNonLazyBinder FromIFactoryResolve(object subIdentifier)
		{
			return null;
		}

		[Address(RVA="0x1F48A6C", Offset="0x1F48A6C", VA="0x1F48A6C")]
		public ConditionCopyNonLazyBinder FromInstance(object instance)
		{
			return null;
		}

		[Address(RVA="0x1F48970", Offset="0x1F48970", VA="0x1F48970")]
		public ConditionCopyNonLazyBinder FromMethod(Func<DiContainer, TContract> method)
		{
			return null;
		}

		[Address(RVA="0x2AF7B00", Offset="0x2AF7B00", VA="0x2AF7B00")]
		public ConditionCopyNonLazyBinder FromResolveGetter<TObj>(Func<TObj, TContract> method)
		{
			return null;
		}

		[Address(RVA="0x2AF7B4C", Offset="0x2AF7B4C", VA="0x2AF7B4C")]
		public ConditionCopyNonLazyBinder FromResolveGetter<TObj>(object subIdentifier, Func<TObj, TContract> method)
		{
			return null;
		}

		[Address(RVA="0x1F48F14", Offset="0x1F48F14", VA="0x1F48F14")]
		public ConditionCopyNonLazyBinder FromResource(string resourcePath)
		{
			return null;
		}

		[Address(RVA="0x1F48D4C", Offset="0x1F48D4C", VA="0x1F48D4C")]
		public FactorySubContainerBinder<TContract> FromSubContainerResolve()
		{
			return null;
		}

		[Address(RVA="0x1F48D8C", Offset="0x1F48D8C", VA="0x1F48D8C")]
		public FactorySubContainerBinder<TContract> FromSubContainerResolve(object subIdentifier)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D5B8", Offset="0x104D5B8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static FactoryFromBinder<TContract>.<>c <>9;

			[FieldOffset(Offset="0x0")]
			public static Func<GameObject, IEnumerable<TContract>> <>9__10_1;

			[Address(RVA="0x1F48448", Offset="0x1F48448", VA="0x1F48448")]
			static <>c()
			{
			}

			[Address(RVA="0x1F48520", Offset="0x1F48520", VA="0x1F48520")]
			public <>c()
			{
			}

			[Address(RVA="0x1F4854C", Offset="0x1F4854C", VA="0x1F4854C")]
			internal IEnumerable<TContract> <FromComponentInHierarchy>b__10_1(GameObject x)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D5C8", Offset="0x104D5C8")]
		private sealed class <>c__DisplayClass11_0
		{
			[FieldOffset(Offset="0x0")]
			public string resourcePath;

			[FieldOffset(Offset="0x0")]
			public FactoryFromBinder<TContract> <>4__this;

			[Address(RVA="0x1F4858C", Offset="0x1F4858C", VA="0x1F4858C")]
			public <>c__DisplayClass11_0()
			{
			}

			[Address(RVA="0x1F485B8", Offset="0x1F485B8", VA="0x1F485B8")]
			internal IProvider <FromResource>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D578", Offset="0x104D578")]
		private sealed class <>c__DisplayClass2_0<TContract>
		{
			[FieldOffset(Offset="0x0")]
			public object subIdentifier;

			[FieldOffset(Offset="0x0")]
			public Func<TObj, TContract> method;

			[Address(RVA="0x1F4865C", Offset="0x1F4865C", VA="0x1F4865C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x1F48688", Offset="0x1F48688", VA="0x1F48688")]
			internal IProvider <FromResolveGetter>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D588", Offset="0x104D588")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset="0x0")]
			public Func<DiContainer, TContract> method;

			[Address(RVA="0x1F48708", Offset="0x1F48708", VA="0x1F48708")]
			public <>c__DisplayClass3_0()
			{
			}

			[Address(RVA="0x1F48734", Offset="0x1F48734", VA="0x1F48734")]
			internal IProvider <FromMethod>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D598", Offset="0x104D598")]
		private sealed class <>c__DisplayClass4_0
		{
			[FieldOffset(Offset="0x0")]
			public FactoryFromBinder<TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public object instance;

			[Address(RVA="0x1F487A0", Offset="0x1F487A0", VA="0x1F487A0")]
			public <>c__DisplayClass4_0()
			{
			}

			[Address(RVA="0x1F487CC", Offset="0x1F487CC", VA="0x1F487CC")]
			internal IProvider <FromInstance>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D5A8", Offset="0x104D5A8")]
		private sealed class <>c__DisplayClass7_0
		{
			[FieldOffset(Offset="0x0")]
			public object subIdentifier;

			[Address(RVA="0x1F4887C", Offset="0x1F4887C", VA="0x1F4887C")]
			public <>c__DisplayClass7_0()
			{
			}

			[Address(RVA="0x1F488A8", Offset="0x1F488A8", VA="0x1F488A8")]
			internal IProvider <FromIFactoryResolve>b__0(DiContainer container)
			{
				return null;
			}
		}
	}
}