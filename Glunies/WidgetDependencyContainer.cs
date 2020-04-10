using Il2CppDummyDll;
using System;
using Zenject;

namespace Glunies
{
	public class WidgetDependencyContainer
	{
		[FieldOffset(Offset="0x10")]
		public readonly Zenject.DiContainer DiContainer;

		[FieldOffset(Offset="0x18")]
		public readonly Glunies.DispatchSystem DispatchSystem;

		[FieldOffset(Offset="0x20")]
		public readonly LocalizationManager LocManager;

		[Address(RVA="0x16188C0", Offset="0x16188C0", VA="0x16188C0")]
		public WidgetDependencyContainer(Zenject.DiContainer diContainer, Glunies.DispatchSystem ds, LocalizationManager lm)
		{
		}

		[Address(RVA="0x1618900", Offset="0x1618900", VA="0x1618900")]
		public SingleAssetRegistry CreateNewSingleAssetRegistry()
		{
			return null;
		}

		[Address(RVA="0x16A9B64", Offset="0x16A9B64", VA="0x16A9B64")]
		public T Resolve<T>()
		{
			return null;
		}

		[Address(RVA="0x16A9BA0", Offset="0x16A9BA0", VA="0x16A9BA0")]
		public T TryResolve<T>()
		where T : class
		{
			return null;
		}
	}
}