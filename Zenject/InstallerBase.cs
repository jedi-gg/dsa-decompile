using Il2CppDummyDll;
using System;

namespace Zenject
{
	public abstract class InstallerBase : IInstaller
	{
		[Attribute(Name="InjectAttribute", RVA="0x1060540", Offset="0x1060540")]
		[FieldOffset(Offset="0x10")]
		private DiContainer _container;

		protected DiContainer Container
		{
			[Address(RVA="0x1833F38", Offset="0x1833F38", VA="0x1833F38")]
			get
			{
				return null;
			}
		}

		public virtual bool IsEnabled
		{
			[Address(RVA="0x183B9F0", Offset="0x183B9F0", VA="0x183B9F0", Slot="6")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x183B9E8", Offset="0x183B9E8", VA="0x183B9E8")]
		protected InstallerBase()
		{
		}

		public abstract void InstallBindings();
	}
}