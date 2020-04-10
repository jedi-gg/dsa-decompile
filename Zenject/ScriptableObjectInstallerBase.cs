using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class ScriptableObjectInstallerBase : ScriptableObject, IInstaller
	{
		[Attribute(Name="InjectAttribute", RVA="0x1060560", Offset="0x1060560")]
		[FieldOffset(Offset="0x18")]
		private DiContainer _container;

		protected DiContainer Container
		{
			[Address(RVA="0x1847F4C", Offset="0x1847F4C", VA="0x1847F4C")]
			get
			{
				return null;
			}
		}

		private bool Zenject.IInstaller.IsEnabled
		{
			[Address(RVA="0x1847F54", Offset="0x1847F54", VA="0x1847F54", Slot="5")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x1847F44", Offset="0x1847F44", VA="0x1847F44")]
		public ScriptableObjectInstallerBase()
		{
		}

		[Address(RVA="0x1847F5C", Offset="0x1847F5C", VA="0x1847F5C", Slot="6")]
		public virtual void InstallBindings()
		{
		}
	}
}