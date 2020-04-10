using Il2CppDummyDll;
using System;

namespace Zenject
{
	public enum SingletonTypes
	{
		[FieldOffset(Offset="0x0")]
		FromNew,
		[FieldOffset(Offset="0x0")]
		FromMethod,
		[FieldOffset(Offset="0x0")]
		FromSubContainerMethod,
		[FieldOffset(Offset="0x0")]
		FromSubContainerInstaller,
		[FieldOffset(Offset="0x0")]
		FromInstance,
		[FieldOffset(Offset="0x0")]
		FromPrefab,
		[FieldOffset(Offset="0x0")]
		FromPrefabResource,
		[FieldOffset(Offset="0x0")]
		FromFactory,
		[FieldOffset(Offset="0x0")]
		FromGameObject,
		[FieldOffset(Offset="0x0")]
		FromComponent,
		[FieldOffset(Offset="0x0")]
		FromComponentGameObject,
		[FieldOffset(Offset="0x0")]
		FromGetter,
		[FieldOffset(Offset="0x0")]
		FromResolve,
		[FieldOffset(Offset="0x0")]
		FromResource,
		[FieldOffset(Offset="0x0")]
		FromNewScriptableObjectResource,
		[FieldOffset(Offset="0x0")]
		FromSubContainerPrefab,
		[FieldOffset(Offset="0x0")]
		FromSubContainerPrefabResource,
		[FieldOffset(Offset="0x0")]
		FromScriptableObjectResource
	}
}