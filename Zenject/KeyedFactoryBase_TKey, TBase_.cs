using Il2CppDummyDll;
using ModestTree.Util;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public abstract class KeyedFactoryBase<TKey, TBase> : IValidatable
	{
		[Attribute(Name="InjectAttribute", RVA="0x1060108", Offset="0x1060108")]
		[FieldOffset(Offset="0x0")]
		private readonly DiContainer _container;

		[Attribute(Name="InjectOptionalAttribute", RVA="0x1060118", Offset="0x1060118")]
		[FieldOffset(Offset="0x0")]
		private readonly List<ValuePair<TKey, Type>> _typePairs;

		[FieldOffset(Offset="0x0")]
		private Dictionary<TKey, Type> _typeMap;

		[Attribute(Name="InjectOptionalAttribute", RVA="0x1060128", Offset="0x1060128")]
		[FieldOffset(Offset="0x0")]
		private readonly Type _fallbackType;

		protected DiContainer Container
		{
			[Address(RVA="0x2351E40", Offset="0x2351E40", VA="0x2351E40")]
			get
			{
				return null;
			}
		}

		public ICollection<TKey> Keys
		{
			[Address(RVA="0x2351E48", Offset="0x2351E48", VA="0x2351E48")]
			get
			{
				return null;
			}
		}

		protected abstract IEnumerable<Type> ProvidedTypes
		{
			get;
		}

		protected Dictionary<TKey, Type> TypeMap
		{
			[Address(RVA="0x2351E88", Offset="0x2351E88", VA="0x2351E88")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2352674", Offset="0x2352674", VA="0x2352674")]
		protected KeyedFactoryBase()
		{
		}

		[Address(RVA="0x2AF85A4", Offset="0x2AF85A4", VA="0x2AF85A4")]
		protected static ConditionCopyNonLazyBinder AddBindingInternal<TDerived>(DiContainer container, TKey key)
		where TDerived : TBase
		{
			return null;
		}

		[Address(RVA="0x2352354", Offset="0x2352354", VA="0x2352354")]
		protected Type GetTypeForKey(TKey key)
		{
			return null;
		}

		[Address(RVA="0x2352304", Offset="0x2352304", VA="0x2352304")]
		public bool HasKey(TKey key)
		{
			return new bool();
		}

		[Address(RVA="0x2351E90", Offset="0x2351E90", VA="0x2351E90")]
		[Attribute(Name="InjectAttribute", RVA="0x10728DC", Offset="0x10728DC")]
		public void Initialize()
		{
		}

		[Address(RVA="0x235240C", Offset="0x235240C", VA="0x235240C", Slot="6")]
		public virtual void Validate()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DC78", Offset="0x104DC78")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static KeyedFactoryBase<TBase, TKey>.<>c <>9;

			[FieldOffset(Offset="0x0")]
			public static Func<ValuePair<TKey, Type>, TKey> <>9__12_0;

			[FieldOffset(Offset="0x0")]
			public static Func<ValuePair<TKey, Type>, Type> <>9__12_1;

			[Address(RVA="0x2351CE4", Offset="0x2351CE4", VA="0x2351CE4")]
			static <>c()
			{
			}

			[Address(RVA="0x2351DBC", Offset="0x2351DBC", VA="0x2351DBC")]
			public <>c()
			{
			}

			[Address(RVA="0x2351DE8", Offset="0x2351DE8", VA="0x2351DE8")]
			internal TKey <Initialize>b__12_0(ValuePair<TKey, Type> x)
			{
				return null;
			}

			[Address(RVA="0x2351E14", Offset="0x2351E14", VA="0x2351E14")]
			internal Type <Initialize>b__12_1(ValuePair<TKey, Type> x)
			{
				return null;
			}
		}
	}
}