using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Zenject
{
	public class SceneContext : RunnableContext
	{
		[FieldOffset(Offset="0x0")]
		public static Action<DiContainer> ExtraBindingsInstallMethod;

		[FieldOffset(Offset="0x8")]
		public static Action<DiContainer> ExtraBindingsLateInstallMethod;

		[FieldOffset(Offset="0x10")]
		public static IEnumerable<DiContainer> ParentContainers;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1060370", Offset="0x1060370")]
		[Attribute(Name="TooltipAttribute", RVA="0x1060370", Offset="0x1060370")]
		[FieldOffset(Offset="0x42")]
		[SerializeField]
		private bool _parentNewObjectsUnderRoot;

		[Attribute(Name="TooltipAttribute", RVA="0x10603E0", Offset="0x10603E0")]
		[FieldOffset(Offset="0x48")]
		[SerializeField]
		private List<string> _contractNames;

		[Attribute(Name="TooltipAttribute", RVA="0x106042C", Offset="0x106042C")]
		[FieldOffset(Offset="0x50")]
		[SerializeField]
		private string _parentContractName;

		[Attribute(Name="TooltipAttribute", RVA="0x1060478", Offset="0x1060478")]
		[FieldOffset(Offset="0x58")]
		[SerializeField]
		private List<string> _parentContractNames;

		[FieldOffset(Offset="0x60")]
		private DiContainer _container;

		[FieldOffset(Offset="0x68")]
		private readonly List<object> _dependencyRoots;

		[FieldOffset(Offset="0x70")]
		private readonly List<SceneDecoratorContext> _decoratorContexts;

		[FieldOffset(Offset="0x78")]
		private bool _hasInstalled;

		[FieldOffset(Offset="0x79")]
		private bool _hasResolved;

		public override DiContainer Container
		{
			[Address(RVA="0x1844D88", Offset="0x1844D88", VA="0x1844D88", Slot="4")]
			get
			{
				return null;
			}
		}

		public IEnumerable<string> ContractNames
		{
			[Address(RVA="0x1844D98", Offset="0x1844D98", VA="0x1844D98")]
			get
			{
				return null;
			}
			[Address(RVA="0x1844DA0", Offset="0x1844DA0", VA="0x1844DA0")]
			set
			{
			}
		}

		public bool IsValidating
		{
			[Address(RVA="0x1844D90", Offset="0x1844D90", VA="0x1844D90")]
			get
			{
				return new bool();
			}
		}

		public IEnumerable<string> ParentContractNames
		{
			[Address(RVA="0x1844E34", Offset="0x1844E34", VA="0x1844E34")]
			get
			{
				return null;
			}
			[Address(RVA="0x1844F04", Offset="0x1844F04", VA="0x1844F04")]
			set
			{
			}
		}

		public bool ParentNewObjectsUnderRoot
		{
			[Address(RVA="0x1844F6C", Offset="0x1844F6C", VA="0x1844F6C")]
			get
			{
				return new bool();
			}
			[Address(RVA="0x1844F74", Offset="0x1844F74", VA="0x1844F74")]
			set
			{
			}
		}

		[Address(RVA="0x1846A88", Offset="0x1846A88", VA="0x1846A88")]
		public SceneContext()
		{
		}

		[Address(RVA="0x1846B90", Offset="0x1846B90", VA="0x1846B90")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072BC8", Offset="0x1072BC8")]
		private bool <LookupDecoratorContexts>b__30_2(SceneDecoratorContext decoratorContext)
		{
			return new bool();
		}

		[Address(RVA="0x184509C", Offset="0x184509C", VA="0x184509C")]
		public void Awake()
		{
		}

		[Address(RVA="0x1844F80", Offset="0x1844F80", VA="0x1844F80")]
		private void CheckParentContractName()
		{
		}

		[Address(RVA="0x18469F4", Offset="0x18469F4", VA="0x18469F4")]
		public static SceneContext Create()
		{
			return null;
		}

		[Address(RVA="0x18469B0", Offset="0x18469B0", VA="0x18469B0", Slot="6")]
		protected override void GetInjectableMonoBehaviours(List<MonoBehaviour> monoBehaviours)
		{
		}

		[Address(RVA="0x18457D0", Offset="0x18457D0", VA="0x18457D0")]
		private IEnumerable<DiContainer> GetParentContainers()
		{
			return null;
		}

		[Address(RVA="0x1845794", Offset="0x1845794", VA="0x1845794", Slot="5")]
		public override IEnumerable<GameObject> GetRootGameObjects()
		{
			return null;
		}

		[Address(RVA="0x1845100", Offset="0x1845100", VA="0x1845100")]
		public void Install()
		{
		}

		[Address(RVA="0x18461B4", Offset="0x18461B4", VA="0x18461B4")]
		private void InstallBindings(List<MonoBehaviour> injectableMonoBehaviours)
		{
		}

		[Address(RVA="0x1845D80", Offset="0x1845D80", VA="0x1845D80")]
		private List<SceneDecoratorContext> LookupDecoratorContexts()
		{
			return null;
		}

		[Address(RVA="0x18456A8", Offset="0x18456A8", VA="0x18456A8")]
		public void Resolve()
		{
		}

		[Address(RVA="0x18450C0", Offset="0x18450C0", VA="0x18450C0", Slot="7")]
		protected override void RunInternal()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DCF8", Offset="0x104DCF8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static SceneContext.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<Scene, IEnumerable<GameObject>> <>9__29_0;

			[FieldOffset(Offset="0x10")]
			public static Func<GameObject, IEnumerable<SceneContext>> <>9__29_1;

			[FieldOffset(Offset="0x18")]
			public static Func<SceneContext, DiContainer> <>9__29_3;

			[FieldOffset(Offset="0x20")]
			public static Func<Scene, IEnumerable<GameObject>> <>9__30_0;

			[FieldOffset(Offset="0x28")]
			public static Func<GameObject, IEnumerable<SceneDecoratorContext>> <>9__30_1;

			[Address(RVA="0x1846C18", Offset="0x1846C18", VA="0x1846C18")]
			static <>c()
			{
			}

			[Address(RVA="0x1846C7C", Offset="0x1846C7C", VA="0x1846C7C")]
			public <>c()
			{
			}

			[Address(RVA="0x1846C84", Offset="0x1846C84", VA="0x1846C84")]
			internal IEnumerable<GameObject> <GetParentContainers>b__29_0(Scene scene)
			{
				return null;
			}

			[Address(RVA="0x1846CAC", Offset="0x1846CAC", VA="0x1846CAC")]
			internal IEnumerable<SceneContext> <GetParentContainers>b__29_1(GameObject root)
			{
				return null;
			}

			[Address(RVA="0x1846D08", Offset="0x1846D08", VA="0x1846D08")]
			internal DiContainer <GetParentContainers>b__29_3(SceneContext x)
			{
				return null;
			}

			[Address(RVA="0x1846D3C", Offset="0x1846D3C", VA="0x1846D3C")]
			internal IEnumerable<GameObject> <LookupDecoratorContexts>b__30_0(Scene scene)
			{
				return null;
			}

			[Address(RVA="0x1846D64", Offset="0x1846D64", VA="0x1846D64")]
			internal IEnumerable<SceneDecoratorContext> <LookupDecoratorContexts>b__30_1(GameObject root)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DCE8", Offset="0x104DCE8")]
		private sealed class <>c__DisplayClass29_0
		{
			[FieldOffset(Offset="0x10")]
			public IEnumerable<string> parentContractNames;

			[FieldOffset(Offset="0x18")]
			public Func<string, bool> <>9__4;

			[Address(RVA="0x1845D78", Offset="0x1845D78", VA="0x1845D78")]
			public <>c__DisplayClass29_0()
			{
			}

			[Address(RVA="0x1846DC0", Offset="0x1846DC0", VA="0x1846DC0")]
			internal bool <GetParentContainers>b__2(SceneContext sceneContext)
			{
				return new bool();
			}

			[Address(RVA="0x1846E80", Offset="0x1846E80", VA="0x1846E80")]
			internal bool <GetParentContainers>b__4(string x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DD08", Offset="0x104DD08")]
		private sealed class <>c__DisplayClass31_0
		{
			[FieldOffset(Offset="0x10")]
			public IEnumerable<DiContainer> parents;

			[Address(RVA="0x1846024", Offset="0x1846024", VA="0x1846024")]
			public <>c__DisplayClass31_0()
			{
			}

			[Address(RVA="0x1846EE0", Offset="0x1846EE0", VA="0x1846EE0")]
			internal bool <Install>b__0(DiContainer x)
			{
				return new bool();
			}
		}
	}
}