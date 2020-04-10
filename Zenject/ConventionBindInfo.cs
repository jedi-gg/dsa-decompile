using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Zenject
{
	public class ConventionBindInfo
	{
		[FieldOffset(Offset="0x10")]
		private readonly List<Func<Type, bool>> _typeFilters;

		[FieldOffset(Offset="0x18")]
		private readonly List<Func<Assembly, bool>> _assemblyFilters;

		[FieldOffset(Offset="0x0")]
		private static Dictionary<Assembly, Type[]> _assemblyTypeCache;

		[Address(RVA="0x15B20A4", Offset="0x15B20A4", VA="0x15B20A4")]
		static ConventionBindInfo()
		{
		}

		[Address(RVA="0x15AF460", Offset="0x15AF460", VA="0x15AF460")]
		public ConventionBindInfo()
		{
		}

		[Address(RVA="0x15B2118", Offset="0x15B2118", VA="0x15B2118")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10720F0", Offset="0x10720F0")]
		private IEnumerable<Type> <ResolveTypes>b__9_0(Assembly assembly)
		{
			return null;
		}

		[Address(RVA="0x15B1B9C", Offset="0x15B1B9C", VA="0x15B1B9C")]
		public void AddAssemblyFilter(Func<Assembly, bool> predicate)
		{
		}

		[Address(RVA="0x15B1D44", Offset="0x15B1D44", VA="0x15B1D44")]
		public void AddTypeFilter(Func<Type, bool> predicate)
		{
		}

		[Address(RVA="0x15B1DB4", Offset="0x15B1DB4", VA="0x15B1DB4")]
		private IEnumerable<Assembly> GetAllAssemblies()
		{
			return null;
		}

		[Address(RVA="0x15B1F80", Offset="0x15B1F80", VA="0x15B1F80")]
		private Type[] GetTypes(Assembly assembly)
		{
			return null;
		}

		[Address(RVA="0x15AF524", Offset="0x15AF524", VA="0x15AF524")]
		public List<Type> ResolveTypes()
		{
			return null;
		}

		[Address(RVA="0x15B1DE8", Offset="0x15B1DE8", VA="0x15B1DE8")]
		private bool ShouldIncludeAssembly(Assembly assembly)
		{
			return new bool();
		}

		[Address(RVA="0x15B1EB4", Offset="0x15B1EB4", VA="0x15B1EB4")]
		private bool ShouldIncludeType(Type type)
		{
			return new bool();
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D4A8", Offset="0x104D4A8")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset="0x10")]
			public Assembly assembly;

			[Address(RVA="0x15B1EAC", Offset="0x15B1EAC", VA="0x15B1EAC")]
			public <>c__DisplayClass6_0()
			{
			}

			[Address(RVA="0x15B211C", Offset="0x15B211C", VA="0x15B211C")]
			internal bool <ShouldIncludeAssembly>b__0(Func<Assembly, bool> predicate)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D4B8", Offset="0x104D4B8")]
		private sealed class <>c__DisplayClass7_0
		{
			[FieldOffset(Offset="0x10")]
			public Type type;

			[Address(RVA="0x15B1F78", Offset="0x15B1F78", VA="0x15B1F78")]
			public <>c__DisplayClass7_0()
			{
			}

			[Address(RVA="0x15B218C", Offset="0x15B218C", VA="0x15B218C")]
			internal bool <ShouldIncludeType>b__0(Func<Type, bool> predicate)
			{
				return new bool();
			}
		}
	}
}