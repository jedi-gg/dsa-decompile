using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class StandardSingletonProviderCreator
	{
		[FieldOffset(Offset="0x10")]
		private readonly SingletonMarkRegistry _markRegistry;

		[FieldOffset(Offset="0x18")]
		private readonly Dictionary<SingletonId, StandardSingletonProviderCreator.ProviderInfo> _providerMap;

		[FieldOffset(Offset="0x20")]
		private readonly DiContainer _container;

		[Address(RVA="0x2333540", Offset="0x2333540", VA="0x2333540")]
		public StandardSingletonProviderCreator(DiContainer container, SingletonMarkRegistry markRegistry)
		{
		}

		[Address(RVA="0x2333830", Offset="0x2333830", VA="0x2333830")]
		public IProvider GetOrCreateProvider(StandardSingletonDeclaration dec, Func<DiContainer, Type, IProvider> providerCreator)
		{
			return null;
		}

		public class ProviderInfo
		{
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106C834", Offset="0x106C834")]
			[FieldOffset(Offset="0x10")]
			private List<TypeValuePair> <Arguments>k__BackingField;

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106C844", Offset="0x106C844")]
			[FieldOffset(Offset="0x18")]
			private object <SingletonSpecificId>k__BackingField;

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106C854", Offset="0x106C854")]
			[FieldOffset(Offset="0x20")]
			private SingletonTypes <Type>k__BackingField;

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106C864", Offset="0x106C864")]
			[FieldOffset(Offset="0x28")]
			private CachedProvider <Provider>k__BackingField;

			public List<TypeValuePair> Arguments
			{
				[Address(RVA="0x2334B08", Offset="0x2334B08", VA="0x2334B08")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108D24C", Offset="0x108D24C")]
				get
				{
					return null;
				}
				[Address(RVA="0x2334B88", Offset="0x2334B88", VA="0x2334B88")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108D25C", Offset="0x108D25C")]
				private set
				{
				}
			}

			public CachedProvider Provider
			{
				[Address(RVA="0x2334B68", Offset="0x2334B68", VA="0x2334B68")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108D2AC", Offset="0x108D2AC")]
				get
				{
					return null;
				}
				[Address(RVA="0x2334B78", Offset="0x2334B78", VA="0x2334B78")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108D2BC", Offset="0x108D2BC")]
				private set
				{
				}
			}

			public object SingletonSpecificId
			{
				[Address(RVA="0x2334B10", Offset="0x2334B10", VA="0x2334B10")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108D26C", Offset="0x108D26C")]
				get
				{
					return null;
				}
				[Address(RVA="0x2334B80", Offset="0x2334B80", VA="0x2334B80")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108D27C", Offset="0x108D27C")]
				private set
				{
				}
			}

			public SingletonTypes Type
			{
				[Address(RVA="0x2334B00", Offset="0x2334B00", VA="0x2334B00")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108D28C", Offset="0x108D28C")]
				get
				{
					return new SingletonTypes();
				}
				[Address(RVA="0x2334B70", Offset="0x2334B70", VA="0x2334B70")]
				[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108D29C", Offset="0x108D29C")]
				private set
				{
				}
			}

			[Address(RVA="0x2334B18", Offset="0x2334B18", VA="0x2334B18")]
			public ProviderInfo(SingletonTypes type, CachedProvider provider, object singletonSpecificId, List<TypeValuePair> arguments)
			{
			}
		}
	}
}