using Il2CppDummyDll;
using ModestTree.Util;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerCreatorByNewPrefabMethod<TParam1, TParam2, TParam3, TParam4> : SubContainerCreatorByNewPrefabDynamicContext
	{
		[FieldOffset(Offset="0x0")]
		private readonly ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4> _installerMethod;

		[Address(RVA="0x2BAD3F4", Offset="0x2BAD3F4", VA="0x2BAD3F4")]
		public SubContainerCreatorByNewPrefabMethod(DiContainer container, IPrefabProvider prefabProvider, GameObjectCreationParameters gameObjectBindInfo, ModestTree.Util.Action<DiContainer, TParam1, TParam2, TParam3, TParam4> installerMethod)
		{
		}

		[Address(RVA="0x2BAD454", Offset="0x2BAD454", VA="0x2BAD454", Slot="5")]
		protected override void AddInstallers(List<TypeValuePair> args, GameObjectContext context)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E068", Offset="0x104E068")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x0")]
			public SubContainerCreatorByNewPrefabMethod<TParam1, TParam2, TParam3, TParam4> <>4__this;

			[FieldOffset(Offset="0x0")]
			public List<TypeValuePair> args;

			[Address(RVA="0x2BAD040", Offset="0x2BAD040", VA="0x2BAD040")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x2BAD06C", Offset="0x2BAD06C", VA="0x2BAD06C")]
			internal void <AddInstallers>b__0(DiContainer subContainer)
			{
			}
		}
	}
}