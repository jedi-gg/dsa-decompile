using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Zenject
{
	public class ConventionAssemblySelectionBinder
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FEC8", Offset="0x105FEC8")]
		[FieldOffset(Offset="0x10")]
		private ConventionBindInfo <BindInfo>k__BackingField;

		protected ConventionBindInfo BindInfo
		{
			[Address(RVA="0x15B180C", Offset="0x15B180C", VA="0x15B180C")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10720D0", Offset="0x10720D0")]
			get
			{
				return null;
			}
			[Address(RVA="0x15B1804", Offset="0x15B1804", VA="0x15B1804")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10720E0", Offset="0x10720E0")]
			private set
			{
			}
		}

		[Address(RVA="0x15B17D8", Offset="0x15B17D8", VA="0x15B17D8")]
		public ConventionAssemblySelectionBinder(ConventionBindInfo bindInfo)
		{
		}

		[Address(RVA="0x15B1814", Offset="0x15B1814", VA="0x15B1814")]
		public void FromAllAssemblies()
		{
		}

		[Address(RVA="0x15B1AD0", Offset="0x15B1AD0", VA="0x15B1AD0")]
		public void FromAssemblies(params Assembly[] assemblies)
		{
		}

		[Address(RVA="0x15B1940", Offset="0x15B1940", VA="0x15B1940")]
		public void FromAssemblies(IEnumerable<Assembly> assemblies)
		{
		}

		[Address(RVA="0x15B1818", Offset="0x15B1818", VA="0x15B1818")]
		public void FromAssembliesContaining(params Type[] types)
		{
		}

		[Address(RVA="0x15B181C", Offset="0x15B181C", VA="0x15B181C")]
		public void FromAssembliesContaining(IEnumerable<Type> types)
		{
		}

		[Address(RVA="0x15B1C0C", Offset="0x15B1C0C", VA="0x15B1C0C")]
		public void FromAssembliesWhere(Func<Assembly, bool> predicate)
		{
		}

		[Address(RVA="0x15B1AD4", Offset="0x15B1AD4", VA="0x15B1AD4")]
		public void FromAssembly(Assembly assembly)
		{
		}

		[Address(RVA="0x16A6EE4", Offset="0x16A6EE4", VA="0x16A6EE4")]
		public void FromAssemblyContaining<T>()
		{
		}

		[Address(RVA="0x15B1A04", Offset="0x15B1A04", VA="0x15B1A04")]
		public void FromThisAssembly()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D488", Offset="0x104D488")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ConventionAssemblySelectionBinder.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<Type, Assembly> <>9__8_0;

			[Address(RVA="0x15B1C40", Offset="0x15B1C40", VA="0x15B1C40")]
			static <>c()
			{
			}

			[Address(RVA="0x15B1CA4", Offset="0x15B1CA4", VA="0x15B1CA4")]
			public <>c()
			{
			}

			[Address(RVA="0x15B1CAC", Offset="0x15B1CAC", VA="0x15B1CAC")]
			internal Assembly <FromAssembliesContaining>b__8_0(Type t)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D498", Offset="0x104D498")]
		private sealed class <>c__DisplayClass12_0
		{
			[FieldOffset(Offset="0x10")]
			public IEnumerable<Assembly> assemblies;

			[Address(RVA="0x15B1B94", Offset="0x15B1B94", VA="0x15B1B94")]
			public <>c__DisplayClass12_0()
			{
			}

			[Address(RVA="0x15B1CE4", Offset="0x15B1CE4", VA="0x15B1CE4")]
			internal bool <FromAssemblies>b__0(Assembly assembly)
			{
				return new bool();
			}
		}
	}
}