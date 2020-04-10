using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerCreatorByNewPrefabWithParams : ISubContainerCreator
	{
		[FieldOffset(Offset="0x10")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x18")]
		private readonly IPrefabProvider _prefabProvider;

		[FieldOffset(Offset="0x20")]
		private readonly Type _installerType;

		[FieldOffset(Offset="0x28")]
		private readonly GameObjectCreationParameters _gameObjectBindInfo;

		protected DiContainer Container
		{
			[Address(RVA="0x2336048", Offset="0x2336048", VA="0x2336048")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2335FFC", Offset="0x2335FFC", VA="0x2335FFC")]
		public SubContainerCreatorByNewPrefabWithParams(Type installerType, DiContainer container, IPrefabProvider prefabProvider, GameObjectCreationParameters gameObjectBindInfo)
		{
		}

		[Address(RVA="0x2336710", Offset="0x2336710", VA="0x2336710", Slot="4")]
		public DiContainer CreateSubContainer(List<TypeValuePair> args, InjectContext parentContext)
		{
			return null;
		}

		[Address(RVA="0x2336050", Offset="0x2336050", VA="0x2336050")]
		private DiContainer CreateTempContainer(List<TypeValuePair> args)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E088", Offset="0x104E088")]
		private sealed class <>c__DisplayClass7_0
		{
			[FieldOffset(Offset="0x10")]
			public TypeValuePair argPair;

			[Address(RVA="0x23365D4", Offset="0x23365D4", VA="0x23365D4")]
			public <>c__DisplayClass7_0()
			{
			}

			[Address(RVA="0x23368D4", Offset="0x23368D4", VA="0x23368D4")]
			internal bool <CreateTempContainer>b__0(InjectableInfo x)
			{
				return new bool();
			}

			[Address(RVA="0x233691C", Offset="0x233691C", VA="0x233691C")]
			internal int <CreateTempContainer>b__1(InjectableInfo x)
			{
				return new int();
			}
		}
	}
}