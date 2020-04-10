using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
	public abstract class Context : MonoBehaviour
	{
		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1060238", Offset="0x1060238")]
		[FieldOffset(Offset="0x18")]
		[SerializeField]
		private List<MonoInstaller> _installers;

		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private List<MonoInstaller> _installerPrefabs;

		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private List<ScriptableObjectInstaller> _scriptableObjectInstallers;

		[FieldOffset(Offset="0x30")]
		private List<InstallerBase> _normalInstallers;

		[FieldOffset(Offset="0x38")]
		private List<Type> _normalInstallerTypes;

		public abstract DiContainer Container
		{
			get;
		}

		public IEnumerable<MonoInstaller> InstallerPrefabs
		{
			[Address(RVA="0x15AFC40", Offset="0x15AFC40", VA="0x15AFC40")]
			get
			{
				return null;
			}
			[Address(RVA="0x15AFC48", Offset="0x15AFC48", VA="0x15AFC48")]
			set
			{
			}
		}

		public IEnumerable<MonoInstaller> Installers
		{
			[Address(RVA="0x15AFBA4", Offset="0x15AFBA4", VA="0x15AFBA4")]
			get
			{
				return null;
			}
			[Address(RVA="0x15AFBAC", Offset="0x15AFBAC", VA="0x15AFBAC")]
			set
			{
			}
		}

		public IEnumerable<InstallerBase> NormalInstallers
		{
			[Address(RVA="0x15AFED0", Offset="0x15AFED0", VA="0x15AFED0")]
			get
			{
				return null;
			}
			[Address(RVA="0x15AFED8", Offset="0x15AFED8", VA="0x15AFED8")]
			set
			{
			}
		}

		public IEnumerable<Type> NormalInstallerTypes
		{
			[Address(RVA="0x15AFD78", Offset="0x15AFD78", VA="0x15AFD78")]
			get
			{
				return null;
			}
			[Address(RVA="0x15AFD80", Offset="0x15AFD80", VA="0x15AFD80")]
			set
			{
			}
		}

		public IEnumerable<ScriptableObjectInstaller> ScriptableObjectInstallers
		{
			[Address(RVA="0x15AFCDC", Offset="0x15AFCDC", VA="0x15AFCDC")]
			get
			{
				return null;
			}
			[Address(RVA="0x15AFCE4", Offset="0x15AFCE4", VA="0x15AFCE4")]
			set
			{
			}
		}

		[Address(RVA="0x15B15D0", Offset="0x15B15D0", VA="0x15B15D0")]
		protected Context()
		{
		}

		[Address(RVA="0x15B0008", Offset="0x15B0008", VA="0x15B0008")]
		public void AddNormalInstaller(InstallerBase installer)
		{
		}

		[Address(RVA="0x15AFF6C", Offset="0x15AFF6C", VA="0x15AFF6C")]
		public void AddNormalInstallerType(Type installerType)
		{
		}

		[Address(RVA="0x15B0078", Offset="0x15B0078", VA="0x15B0078")]
		private void CheckInstallerPrefabTypes(List<MonoInstaller> installers, List<MonoInstaller> installerPrefabs)
		{
		}

		protected abstract void GetInjectableMonoBehaviours(List<MonoBehaviour> components);

		public abstract IEnumerable<GameObject> GetRootGameObjects();

		[Address(RVA="0x15B0338", Offset="0x15B0338", VA="0x15B0338")]
		protected void InstallInstallers()
		{
		}

		[Address(RVA="0x15B0348", Offset="0x15B0348", VA="0x15B0348")]
		protected void InstallInstallers(List<InstallerBase> normalInstallers, List<Type> normalInstallerTypes, List<ScriptableObjectInstaller> scriptableObjectInstallers, List<MonoInstaller> installers, List<MonoInstaller> installerPrefabs)
		{
		}

		[Address(RVA="0x15B0B70", Offset="0x15B0B70", VA="0x15B0B70")]
		protected void InstallSceneBindings(List<MonoBehaviour> injectableMonoBehaviours)
		{
		}

		[Address(RVA="0x15B0F7C", Offset="0x15B0F7C", VA="0x15B0F7C")]
		private void InstallZenjectBinding(ZenjectBinding binding)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DCD8", Offset="0x104DCD8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static Context.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<Type, bool> <>9__16_0;

			[Address(RVA="0x15B16D8", Offset="0x15B16D8", VA="0x15B16D8")]
			static <>c()
			{
			}

			[Address(RVA="0x15B173C", Offset="0x15B173C", VA="0x15B173C")]
			public <>c()
			{
			}

			[Address(RVA="0x15B1744", Offset="0x15B1744", VA="0x15B1744")]
			internal bool <set_NormalInstallerTypes>b__16_0(Type x)
			{
				return new bool();
			}
		}
	}
}