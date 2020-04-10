using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public abstract class FactoryProviderBase<TValue, TFactory> : IProvider
	where TFactory : IFactory
	{
		[FieldOffset(Offset="0x0")]
		private readonly List<TypeValuePair> _factoryArgs;

		[FieldOffset(Offset="0x0")]
		private object _factory;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10606F4", Offset="0x10606F4")]
		[FieldOffset(Offset="0x0")]
		private DiContainer <Container>k__BackingField;

		protected DiContainer Container
		{
			[Address(RVA="0x1F4B608", Offset="0x1F4B608", VA="0x1F4B608")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072F14", Offset="0x1072F14")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F4B610", Offset="0x1F4B610", VA="0x1F4B610")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072F24", Offset="0x1072F24")]
			private set
			{
			}
		}

		[Address(RVA="0x1F4B58C", Offset="0x1F4B58C", VA="0x1F4B58C")]
		public FactoryProviderBase(DiContainer container, List<TypeValuePair> factoryArgs)
		{
		}

		[Address(RVA="0x1F4B68C", Offset="0x1F4B68C", VA="0x1F4B68C")]
		protected object CreateFactory()
		{
			return null;
		}

		public abstract IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args);

		[Address(RVA="0x1F4B618", Offset="0x1F4B618", VA="0x1F4B618", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}
	}
}