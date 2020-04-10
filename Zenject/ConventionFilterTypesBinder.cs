using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Zenject
{
	public class ConventionFilterTypesBinder : ConventionAssemblySelectionBinder
	{
		[Address(RVA="0x15B21FC", Offset="0x15B21FC", VA="0x15B21FC")]
		public ConventionFilterTypesBinder(ConventionBindInfo bindInfo)
		{
		}

		[Address(RVA="0x2AF8744", Offset="0x2AF8744", VA="0x2AF8744")]
		public ConventionFilterTypesBinder DerivingFrom<T>()
		{
			return null;
		}

		[Address(RVA="0x15B22FC", Offset="0x15B22FC", VA="0x15B22FC")]
		public ConventionFilterTypesBinder DerivingFrom(Type parentType)
		{
			return null;
		}

		[Address(RVA="0x2AF87E0", Offset="0x2AF87E0", VA="0x2AF87E0")]
		public ConventionFilterTypesBinder DerivingFromOrEqual<T>()
		{
			return null;
		}

		[Address(RVA="0x15B2228", Offset="0x15B2228", VA="0x15B2228")]
		public ConventionFilterTypesBinder DerivingFromOrEqual(Type parentType)
		{
			return null;
		}

		[Address(RVA="0x15B2630", Offset="0x15B2630", VA="0x15B2630")]
		public ConventionFilterTypesBinder InNamespace(string ns)
		{
			return null;
		}

		[Address(RVA="0x15B26F0", Offset="0x15B26F0", VA="0x15B26F0")]
		public ConventionFilterTypesBinder InNamespaces(params string[] namespaces)
		{
			return null;
		}

		[Address(RVA="0x15B26F4", Offset="0x15B26F4", VA="0x15B26F4")]
		public ConventionFilterTypesBinder InNamespaces(IEnumerable<string> namespaces)
		{
			return null;
		}

		[Address(RVA="0x15B2AC8", Offset="0x15B2AC8", VA="0x15B2AC8")]
		private static bool IsInNamespace(Type type, string requiredNs)
		{
			return new bool();
		}

		[Address(RVA="0x15B2970", Offset="0x15B2970", VA="0x15B2970")]
		public ConventionFilterTypesBinder MatchingRegex(string pattern)
		{
			return null;
		}

		[Address(RVA="0x15B2978", Offset="0x15B2978", VA="0x15B2978")]
		public ConventionFilterTypesBinder MatchingRegex(string pattern, RegexOptions options)
		{
			return null;
		}

		[Address(RVA="0x15B29F4", Offset="0x15B29F4", VA="0x15B29F4")]
		public ConventionFilterTypesBinder MatchingRegex(Regex regex)
		{
			return null;
		}

		[Address(RVA="0x15B25E8", Offset="0x15B25E8", VA="0x15B25E8")]
		public ConventionFilterTypesBinder Where(Func<Type, bool> predicate)
		{
			return null;
		}

		[Address(RVA="0x2AF887C", Offset="0x2AF887C", VA="0x2AF887C")]
		public ConventionFilterTypesBinder WithAttribute<T>()
		where T : Attribute
		{
			return null;
		}

		[Address(RVA="0x15B23D0", Offset="0x15B23D0", VA="0x15B23D0")]
		public ConventionFilterTypesBinder WithAttribute(Type attribute)
		{
			return null;
		}

		[Address(RVA="0x2AF8918", Offset="0x2AF8918", VA="0x2AF8918")]
		public ConventionFilterTypesBinder WithAttributeWhere<T>(Func<T, bool> predicate)
		where T : Attribute
		{
			return null;
		}

		[Address(RVA="0x2AF8A1C", Offset="0x2AF8A1C", VA="0x2AF8A1C")]
		public ConventionFilterTypesBinder WithoutAttribute<T>()
		where T : Attribute
		{
			return null;
		}

		[Address(RVA="0x15B24DC", Offset="0x15B24DC", VA="0x15B24DC")]
		public ConventionFilterTypesBinder WithoutAttribute(Type attribute)
		{
			return null;
		}

		[Address(RVA="0x15B289C", Offset="0x15B289C", VA="0x15B289C")]
		public ConventionFilterTypesBinder WithPrefix(string prefix)
		{
			return null;
		}

		[Address(RVA="0x15B27C8", Offset="0x15B27C8", VA="0x15B27C8")]
		public ConventionFilterTypesBinder WithSuffix(string suffix)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D518", Offset="0x104D518")]
		private sealed class <>c__DisplayClass13_0
		{
			[FieldOffset(Offset="0x10")]
			public IEnumerable<string> namespaces;

			[Address(RVA="0x15B27C0", Offset="0x15B27C0", VA="0x15B27C0")]
			public <>c__DisplayClass13_0()
			{
			}

			[Address(RVA="0x15B2C34", Offset="0x15B2C34", VA="0x15B2C34")]
			internal bool <InNamespaces>b__0(Type t)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D528", Offset="0x104D528")]
		private sealed class <>c__DisplayClass13_1
		{
			[FieldOffset(Offset="0x10")]
			public Type t;

			[Address(RVA="0x15B2CF8", Offset="0x15B2CF8", VA="0x15B2CF8")]
			public <>c__DisplayClass13_1()
			{
			}

			[Address(RVA="0x15B2D00", Offset="0x15B2D00", VA="0x15B2D00")]
			internal bool <InNamespaces>b__1(string n)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D538", Offset="0x104D538")]
		private sealed class <>c__DisplayClass14_0
		{
			[FieldOffset(Offset="0x10")]
			public string suffix;

			[Address(RVA="0x15B2894", Offset="0x15B2894", VA="0x15B2894")]
			public <>c__DisplayClass14_0()
			{
			}

			[Address(RVA="0x15B2D08", Offset="0x15B2D08", VA="0x15B2D08")]
			internal bool <WithSuffix>b__0(Type t)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D548", Offset="0x104D548")]
		private sealed class <>c__DisplayClass15_0
		{
			[FieldOffset(Offset="0x10")]
			public string prefix;

			[Address(RVA="0x15B2968", Offset="0x15B2968", VA="0x15B2968")]
			public <>c__DisplayClass15_0()
			{
			}

			[Address(RVA="0x15B2D60", Offset="0x15B2D60", VA="0x15B2D60")]
			internal bool <WithPrefix>b__0(Type t)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D558", Offset="0x104D558")]
		private sealed class <>c__DisplayClass18_0
		{
			[FieldOffset(Offset="0x10")]
			public Regex regex;

			[Address(RVA="0x15B2AC0", Offset="0x15B2AC0", VA="0x15B2AC0")]
			public <>c__DisplayClass18_0()
			{
			}

			[Address(RVA="0x15B2DB8", Offset="0x15B2DB8", VA="0x15B2DB8")]
			internal bool <MatchingRegex>b__0(Type t)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D4C8", Offset="0x104D4C8")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x10")]
			public Type parentType;

			[Address(RVA="0x15B22F4", Offset="0x15B22F4", VA="0x15B22F4")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x15B2E10", Offset="0x15B2E10", VA="0x15B2E10")]
			internal bool <DerivingFromOrEqual>b__0(Type type)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D4D8", Offset="0x104D4D8")]
		private sealed class <>c__DisplayClass4_0
		{
			[FieldOffset(Offset="0x10")]
			public Type parentType;

			[Address(RVA="0x15B23C8", Offset="0x15B23C8", VA="0x15B23C8")]
			public <>c__DisplayClass4_0()
			{
			}

			[Address(RVA="0x15B2E24", Offset="0x15B2E24", VA="0x15B2E24")]
			internal bool <DerivingFrom>b__0(Type type)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D4E8", Offset="0x104D4E8")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset="0x10")]
			public Type attribute;

			[Address(RVA="0x15B24D4", Offset="0x15B24D4", VA="0x15B24D4")]
			public <>c__DisplayClass6_0()
			{
			}

			[Address(RVA="0x15B2E38", Offset="0x15B2E38", VA="0x15B2E38")]
			internal bool <WithAttribute>b__0(Type t)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D4F8", Offset="0x104D4F8")]
		private sealed class <>c__DisplayClass8_0
		{
			[FieldOffset(Offset="0x10")]
			public Type attribute;

			[Address(RVA="0x15B25E0", Offset="0x15B25E0", VA="0x15B25E0")]
			public <>c__DisplayClass8_0()
			{
			}

			[Address(RVA="0x15B2F00", Offset="0x15B2F00", VA="0x15B2F00")]
			internal bool <WithoutAttribute>b__0(Type t)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D508", Offset="0x104D508")]
		private sealed class <>c__DisplayClass9_0<T>
		where T : Attribute
		{
			[FieldOffset(Offset="0x0")]
			public Func<T, bool> predicate;

			[Address(RVA="0x1F45C54", Offset="0x1F45C54", VA="0x1F45C54")]
			public <>c__DisplayClass9_0()
			{
			}

			[Address(RVA="0x1F45C80", Offset="0x1F45C80", VA="0x1F45C80")]
			internal bool <WithAttributeWhere>b__0(Type t)
			{
				return new bool();
			}
		}
	}
}