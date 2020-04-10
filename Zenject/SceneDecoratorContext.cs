using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
	public class SceneDecoratorContext : Context
	{
		[FieldOffset(Offset="0x40")]
		[SerializeField]
		private List<MonoInstaller> _lateInstallers;

		[FieldOffset(Offset="0x48")]
		[SerializeField]
		private List<MonoInstaller> _lateInstallerPrefabs;

		[FieldOffset(Offset="0x50")]
		[SerializeField]
		private List<ScriptableObjectInstaller> _lateScriptableObjectInstallers;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x10604F4", Offset="0x10604F4")]
		[FieldOffset(Offset="0x58")]
		[SerializeField]
		private string _decoratedContractName;

		[FieldOffset(Offset="0x60")]
		private DiContainer _container;

		[FieldOffset(Offset="0x68")]
		private List<MonoBehaviour> _injectableMonoBehaviours;

		public override DiContainer Container
		{
			[Address(RVA="0x1847154", Offset="0x1847154", VA="0x1847154", Slot="4")]
			get
			{
				return null;
			}
		}

		public string DecoratedContractName
		{
			[Address(RVA="0x1846C10", Offset="0x1846C10", VA="0x1846C10")]
			get
			{
				return null;
			}
		}

		public IEnumerable<MonoInstaller> LateInstallerPrefabs
		{
			[Address(RVA="0x184701C", Offset="0x184701C", VA="0x184701C")]
			get
			{
				return null;
			}
			[Address(RVA="0x1847024", Offset="0x1847024", VA="0x1847024")]
			set
			{
			}
		}

		public IEnumerable<MonoInstaller> LateInstallers
		{
			[Address(RVA="0x1846F80", Offset="0x1846F80", VA="0x1846F80")]
			get
			{
				return null;
			}
			[Address(RVA="0x1846F88", Offset="0x1846F88", VA="0x1846F88")]
			set
			{
			}
		}

		public IEnumerable<ScriptableObjectInstaller> LateScriptableObjectInstallers
		{
			[Address(RVA="0x18470B8", Offset="0x18470B8", VA="0x18470B8")]
			get
			{
				return null;
			}
			[Address(RVA="0x18470C0", Offset="0x18470C0", VA="0x18470C0")]
			set
			{
			}
		}

		[Address(RVA="0x1847214", Offset="0x1847214", VA="0x1847214")]
		public SceneDecoratorContext()
		{
		}

		[Address(RVA="0x18471D0", Offset="0x18471D0", VA="0x18471D0", Slot="6")]
		protected override void GetInjectableMonoBehaviours(List<MonoBehaviour> monoBehaviours)
		{
		}

		[Address(RVA="0x1847180", Offset="0x1847180", VA="0x1847180", Slot="5")]
		public override IEnumerable<GameObject> GetRootGameObjects()
		{
			return null;
		}

		[Address(RVA="0x184602C", Offset="0x184602C", VA="0x184602C")]
		public void Initialize(DiContainer container)
		{
		}

		[Address(RVA="0x1846900", Offset="0x1846900", VA="0x1846900")]
		public void InstallDecoratorInstallers()
		{
		}

		[Address(RVA="0x184686C", Offset="0x184686C", VA="0x184686C")]
		public void InstallDecoratorSceneBindings()
		{
		}

		[Address(RVA="0x1846908", Offset="0x1846908", VA="0x1846908")]
		public void InstallLateDecoratorInstallers()
		{
		}
	}
}