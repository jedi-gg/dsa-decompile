using Il2CppDummyDll;
using ModestTree.Util;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerCreatorByNewPrefabMethod<TParam1, TParam2, TParam3, TParam4, TParam5> : SubContainerCreatorByNewPrefabDynamicContext
	{
		[FieldOffset(Offset="0x0")]
		private readonly ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4, TParam5> _installerMethod;

		[Address(RVA="0x2BADBEC", Offset="0x2BADBEC", VA="0x2BADBEC")]
		public SubContainerCreatorByNewPrefabMethod(DiContainer container, IPrefabProvider prefabProvider, GameObjectCreationParameters gameObjectBindInfo, ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4, TParam5> installerMethod)
		{
		}

		[Address(RVA="0x2BADC4C", Offset="0x2BADC4C", VA="0x2BADC4C", Slot="5")]
		protected override void AddInstallers(List<TypeValuePair> args, GameObjectContext context)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E078", Offset="0x104E078")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x0")]
			public SubContainerCreatorByNewPrefabMethod<TParam1, TParam2, TParam3, TParam4, TParam5> <>4__this;

			[FieldOffset(Offset="0x0")]
			public List<TypeValuePair> args;

			[Address(RVA="0x2BAD784", Offset="0x2BAD784", VA="0x2BAD784")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x2BAD7B0", Offset="0x2BAD7B0", VA="0x2BAD7B0")]
			internal void <AddInstallers>b__0(DiContainer subContainer)
			{
			}
		}
	}
}