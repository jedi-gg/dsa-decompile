using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Zenject
{
	public class ZenjectTypeInfo
	{
		[FieldOffset(Offset="0x10")]
		private readonly List<PostInjectableInfo> _postInjectMethods;

		[FieldOffset(Offset="0x18")]
		private readonly List<InjectableInfo> _constructorInjectables;

		[FieldOffset(Offset="0x20")]
		private readonly List<InjectableInfo> _fieldInjectables;

		[FieldOffset(Offset="0x28")]
		private readonly List<InjectableInfo> _propertyInjectables;

		[FieldOffset(Offset="0x30")]
		private readonly ConstructorInfo _injectConstructor;

		[FieldOffset(Offset="0x38")]
		private readonly System.Type _typeAnalyzed;

		public IEnumerable<InjectableInfo> AllInjectables
		{
			[Address(RVA="0x23365DC", Offset="0x23365DC", VA="0x23365DC")]
			get
			{
				return null;
			}
		}

		public IEnumerable<InjectableInfo> ConstructorInjectables
		{
			[Address(RVA="0x2340AE8", Offset="0x2340AE8", VA="0x2340AE8")]
			get
			{
				return null;
			}
		}

		public IEnumerable<InjectableInfo> FieldInjectables
		{
			[Address(RVA="0x2340AD8", Offset="0x2340AD8", VA="0x2340AD8")]
			get
			{
				return null;
			}
		}

		public ConstructorInfo InjectConstructor
		{
			[Address(RVA="0x2340AF0", Offset="0x2340AF0", VA="0x2340AF0")]
			get
			{
				return null;
			}
		}

		public IEnumerable<PostInjectableInfo> PostInjectMethods
		{
			[Address(RVA="0x2340AD0", Offset="0x2340AD0", VA="0x2340AD0")]
			get
			{
				return null;
			}
		}

		public IEnumerable<InjectableInfo> PropertyInjectables
		{
			[Address(RVA="0x2340AE0", Offset="0x2340AE0", VA="0x2340AE0")]
			get
			{
				return null;
			}
		}

		public System.Type Type
		{
			[Address(RVA="0x2340AC8", Offset="0x2340AC8", VA="0x2340AC8")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x233D7D8", Offset="0x233D7D8", VA="0x233D7D8")]
		public ZenjectTypeInfo(System.Type typeAnalyzed, List<PostInjectableInfo> postInjectMethods, ConstructorInfo injectConstructor, List<InjectableInfo> fieldInjectables, List<InjectableInfo> propertyInjectables, List<InjectableInfo> constructorInjectables)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E268", Offset="0x104E268")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ZenjectTypeInfo.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<PostInjectableInfo, IEnumerable<InjectableInfo>> <>9__12_0;

			[Address(RVA="0x2340AF8", Offset="0x2340AF8", VA="0x2340AF8")]
			static <>c()
			{
			}

			[Address(RVA="0x2340B5C", Offset="0x2340B5C", VA="0x2340B5C")]
			public <>c()
			{
			}

			[Address(RVA="0x2340B64", Offset="0x2340B64", VA="0x2340B64")]
			internal IEnumerable<InjectableInfo> <get_AllInjectables>b__12_0(PostInjectableInfo x)
			{
				return null;
			}
		}
	}
}