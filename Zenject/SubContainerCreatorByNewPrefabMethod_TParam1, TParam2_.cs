using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerCreatorByNewPrefabMethod<TParam1, TParam2> : SubContainerCreatorByNewPrefabDynamicContext
	{
		[FieldOffset(Offset="0x0")]
		private readonly Action<DiContainer, TParam1, TParam2> _installerMethod;

		[Address(RVA="0x2BAC73C", Offset="0x2BAC73C", VA="0x2BAC73C")]
		public SubContainerCreatorByNewPrefabMethod(DiContainer container, IPrefabProvider prefabProvider, GameObjectCreationParameters gameObjectBindInfo, Action<DiContainer, TParam1, TParam2> installerMethod)
		{
		}

		[Address(RVA="0x2BAC79C", Offset="0x2BAC79C", VA="0x2BAC79C", Slot="5")]
		protected override void AddInstallers(List<TypeValuePair> args, GameObjectContext context)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E048", Offset="0x104E048")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x0")]
			public SubContainerCreatorByNewPrefabMethod<TParam1, TParam2> <>4__this;

			[FieldOffset(Offset="0x0")]
			public List<TypeValuePair> args;

			[Address(RVA="0x2BAC4F8", Offset="0x2BAC4F8", VA="0x2BAC4F8")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x2BAC524", Offset="0x2BAC524", VA="0x2BAC524")]
			internal void <AddInstallers>b__0(DiContainer subContainer)
			{
			}
		}
	}
}