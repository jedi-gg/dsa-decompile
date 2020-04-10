using Il2CppDummyDll;
using System;
using System.Diagnostics;
using UnityEngine;

namespace Zenject
{
	[DebuggerStepThrough]
	public class MonoInstallerBase : MonoBehaviour, IInstaller
	{
		[Attribute(Name="InjectAttribute", RVA="0x1060550", Offset="0x1060550")]
		[FieldOffset(Offset="0x18")]
		private DiContainer _container;

		protected DiContainer Container
		{
			[Address(RVA="0x183DB84", Offset="0x183DB84", VA="0x183DB84")]
			get
			{
				return null;
			}
		}

		public virtual bool IsEnabled
		{
			[Address(RVA="0x183DB8C", Offset="0x183DB8C", VA="0x183DB8C", Slot="6")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x183DB7C", Offset="0x183DB7C", VA="0x183DB7C")]
		public MonoInstallerBase()
		{
		}

		[Address(RVA="0x183DB98", Offset="0x183DB98", VA="0x183DB98", Slot="8")]
		public virtual void InstallBindings()
		{
		}

		[Address(RVA="0x183DB94", Offset="0x183DB94", VA="0x183DB94", Slot="7")]
		public virtual void Start()
		{
		}
	}
}