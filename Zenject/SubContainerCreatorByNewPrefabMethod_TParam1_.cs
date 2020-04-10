using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class SubContainerCreatorByNewPrefabMethod<TParam1> : SubContainerCreatorByNewPrefabDynamicContext
	{
		[FieldOffset(Offset="0x0")]
		private readonly Action<DiContainer, TParam1> _installerMethod;

		[Address(RVA="0x2BAC27C", Offset="0x2BAC27C", VA="0x2BAC27C")]
		public SubContainerCreatorByNewPrefabMethod(DiContainer container, IPrefabProvider prefabProvider, GameObjectCreationParameters gameObjectBindInfo, Action<DiContainer, TParam1> installerMethod)
		{
		}

		[Address(RVA="0x2BAC2DC", Offset="0x2BAC2DC", VA="0x2BAC2DC", Slot="5")]
		protected override void AddInstallers(List<TypeValuePair> args, GameObjectContext context)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E038", Offset="0x104E038")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x0")]
			public SubContainerCreatorByNewPrefabMethod<TParam1> <>4__this;

			[FieldOffset(Offset="0x0")]
			public List<TypeValuePair> args;

			[Address(RVA="0x2BAC0F8", Offset="0x2BAC0F8", VA="0x2BAC0F8")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x2BAC124", Offset="0x2BAC124", VA="0x2BAC124")]
			internal void <AddInstallers>b__0(DiContainer subContainer)
			{
			}
		}
	}
}