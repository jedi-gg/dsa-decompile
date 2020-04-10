using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerCreatorByNewPrefabMethod<TParam1, TParam2, TParam3> : SubContainerCreatorByNewPrefabDynamicContext
	{
		[FieldOffset(Offset="0x0")]
		private readonly Action<DiContainer, TParam1, TParam2, TParam3> _installerMethod;

		[Address(RVA="0x2BACD0C", Offset="0x2BACD0C", VA="0x2BACD0C")]
		public SubContainerCreatorByNewPrefabMethod(DiContainer container, IPrefabProvider prefabProvider, GameObjectCreationParameters gameObjectBindInfo, Action<DiContainer, TParam1, TParam2, TParam3> installerMethod)
		{
		}

		[Address(RVA="0x2BACD6C", Offset="0x2BACD6C", VA="0x2BACD6C", Slot="5")]
		protected override void AddInstallers(List<TypeValuePair> args, GameObjectContext context)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E058", Offset="0x104E058")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x0")]
			public SubContainerCreatorByNewPrefabMethod<TParam1, TParam2, TParam3> <>4__this;

			[FieldOffset(Offset="0x0")]
			public List<TypeValuePair> args;

			[Address(RVA="0x2BACA14", Offset="0x2BACA14", VA="0x2BACA14")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x2BACA40", Offset="0x2BACA40", VA="0x2BACA40")]
			internal void <AddInstallers>b__0(DiContainer subContainer)
			{
			}
		}
	}
}