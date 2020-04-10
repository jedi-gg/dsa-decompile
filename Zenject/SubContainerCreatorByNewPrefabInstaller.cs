using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerCreatorByNewPrefabInstaller : SubContainerCreatorByNewPrefabDynamicContext
	{
		[FieldOffset(Offset="0x28")]
		private readonly Type _installerType;

		[FieldOffset(Offset="0x30")]
		private readonly List<TypeValuePair> _extraArgs;

		[Address(RVA="0x2335B8C", Offset="0x2335B8C", VA="0x2335B8C")]
		public SubContainerCreatorByNewPrefabInstaller(DiContainer container, IPrefabProvider prefabProvider, GameObjectCreationParameters gameObjectBindInfo, Type installerType, List<TypeValuePair> extraArgs)
		{
		}

		[Address(RVA="0x2335C3C", Offset="0x2335C3C", VA="0x2335C3C", Slot="5")]
		protected override void AddInstallers(List<TypeValuePair> args, GameObjectContext context)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E028", Offset="0x104E028")]
		private sealed class <>c__DisplayClass3_0
		{
			[FieldOffset(Offset="0x10")]
			public SubContainerCreatorByNewPrefabInstaller <>4__this;

			[FieldOffset(Offset="0x18")]
			public List<TypeValuePair> args;

			[Address(RVA="0x2335D3C", Offset="0x2335D3C", VA="0x2335D3C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Address(RVA="0x2335D44", Offset="0x2335D44", VA="0x2335D44")]
			internal void <AddInstallers>b__0(DiContainer subContainer)
			{
			}
		}
	}
}