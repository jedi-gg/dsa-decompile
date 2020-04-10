using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject
{
	public class ProjectContext : Context
	{
		[FieldOffset(Offset="0x0")]
		public const string ProjectContextResourcePath = "ProjectContext";

		[FieldOffset(Offset="0x0")]
		public const string ProjectContextResourcePathOld = "ProjectCompositionRoot";

		[FieldOffset(Offset="0x0")]
		private static ProjectContext _instance;

		[FieldOffset(Offset="0x40")]
		private DiContainer _container;

		[FieldOffset(Offset="0x48")]
		private readonly List<object> _dependencyRoots;

		public override DiContainer Container
		{
			[Address(RVA="0x18427DC", Offset="0x18427DC", VA="0x18427DC", Slot="4")]
			get
			{
				return null;
			}
		}

		public static bool HasInstance
		{
			[Address(RVA="0x18427E4", Offset="0x18427E4", VA="0x18427E4")]
			get
			{
				return new bool();
			}
		}

		public static ProjectContext Instance
		{
			[Address(RVA="0x1842860", Offset="0x1842860", VA="0x1842860")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1843720", Offset="0x1843720", VA="0x1843720")]
		public ProjectContext()
		{
		}

		[Address(RVA="0x1843190", Offset="0x1843190", VA="0x1843190")]
		public void Awake()
		{
		}

		[Address(RVA="0x184318C", Offset="0x184318C", VA="0x184318C")]
		public void EnsureIsInitialized()
		{
		}

		[Address(RVA="0x18436F8", Offset="0x18436F8", VA="0x18436F8", Slot="6")]
		protected override void GetInjectableMonoBehaviours(List<MonoBehaviour> monoBehaviours)
		{
		}

		[Address(RVA="0x1842BD8", Offset="0x1842BD8", VA="0x1842BD8", Slot="5")]
		public override IEnumerable<GameObject> GetRootGameObjects()
		{
			return null;
		}

		[Address(RVA="0x1842E04", Offset="0x1842E04", VA="0x1842E04")]
		private void Initialize()
		{
		}

		[Address(RVA="0x1843224", Offset="0x1843224", VA="0x1843224")]
		private void InstallBindings(List<MonoBehaviour> injectableMonoBehaviours)
		{
		}

		[Address(RVA="0x1842908", Offset="0x1842908", VA="0x1842908")]
		private static void InstantiateAndInitialize()
		{
		}

		[Address(RVA="0x1842C9C", Offset="0x1842C9C", VA="0x1842C9C")]
		public static GameObject TryGetPrefab()
		{
			return null;
		}
	}
}