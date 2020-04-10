using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Zenject
{
	public class FactoryFromBinderBase<TContract> : ArgConditionCopyNonLazyBinder
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FF08", Offset="0x105FF08")]
		[FieldOffset(Offset="0x0")]
		private Zenject.FactoryBindInfo <FactoryBindInfo>k__BackingField;

		public IEnumerable<Type> AllParentTypes
		{
			[Address(RVA="0x1F470FC", Offset="0x1F470FC", VA="0x1F470FC")]
			[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10721A0", Offset="0x10721A0")]
			get
			{
				return null;
			}
		}

		protected Type ContractType
		{
			[Address(RVA="0x1F47088", Offset="0x1F47088", VA="0x1F47088")]
			get
			{
				return null;
			}
		}

		protected Zenject.FactoryBindInfo FactoryBindInfo
		{
			[Address(RVA="0x1F46FC0", Offset="0x1F46FC0", VA="0x1F46FC0")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072180", Offset="0x1072180")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F46FC8", Offset="0x1F46FC8", VA="0x1F46FC8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072190", Offset="0x1072190")]
			private set
			{
			}
		}

		protected Func<DiContainer, IProvider> ProviderFunc
		{
			[Address(RVA="0x1F46FD0", Offset="0x1F46FD0", VA="0x1F46FD0")]
			get
			{
				return null;
			}
			[Address(RVA="0x1F47024", Offset="0x1F47024", VA="0x1F47024")]
			set
			{
			}
		}

		[Address(RVA="0x1F46EC4", Offset="0x1F46EC4", VA="0x1F46EC4")]
		public FactoryFromBinderBase(Zenject.BindInfo bindInfo, Zenject.FactoryBindInfo factoryBindInfo)
		{
		}

		[Address(RVA="0x1F48328", Offset="0x1F48328", VA="0x1F48328")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1072204", Offset="0x1072204")]
		private IProvider <.ctor>b__0_0(DiContainer container)
		{
			return null;
		}

		[Address(RVA="0x1F47A80", Offset="0x1F47A80", VA="0x1F47A80")]
		public NameTransformConditionCopyNonLazyBinder FromComponentInNewPrefab(UnityEngine.Object prefab)
		{
			return null;
		}

		[Address(RVA="0x1F47C5C", Offset="0x1F47C5C", VA="0x1F47C5C")]
		public NameTransformConditionCopyNonLazyBinder FromComponentInNewPrefabResource(string resourcePath)
		{
			return null;
		}

		[Address(RVA="0x1F47178", Offset="0x1F47178", VA="0x1F47178")]
		public ConditionCopyNonLazyBinder FromNew()
		{
			return null;
		}

		[Address(RVA="0x1F47344", Offset="0x1F47344", VA="0x1F47344")]
		public ConditionCopyNonLazyBinder FromNewComponentOn(GameObject gameObject)
		{
			return null;
		}

		[Address(RVA="0x1F474F4", Offset="0x1F474F4", VA="0x1F474F4")]
		public ConditionCopyNonLazyBinder FromNewComponentOn(Func<InjectContext, GameObject> gameObjectGetter)
		{
			return null;
		}

		[Address(RVA="0x1F47680", Offset="0x1F47680", VA="0x1F47680")]
		public NameTransformConditionCopyNonLazyBinder FromNewComponentOnNewGameObject()
		{
			return null;
		}

		[Address(RVA="0x1F47858", Offset="0x1F47858", VA="0x1F47858")]
		public NameTransformConditionCopyNonLazyBinder FromNewComponentOnNewPrefab(UnityEngine.Object prefab)
		{
			return null;
		}

		[Address(RVA="0x1F47E38", Offset="0x1F47E38", VA="0x1F47E38")]
		public NameTransformConditionCopyNonLazyBinder FromNewComponentOnNewPrefabResource(string resourcePath)
		{
			return null;
		}

		[Address(RVA="0x1F48060", Offset="0x1F48060", VA="0x1F48060")]
		public ConditionCopyNonLazyBinder FromNewScriptableObjectResource(string resourcePath)
		{
			return null;
		}

		[Address(RVA="0x1F471F0", Offset="0x1F471F0", VA="0x1F471F0")]
		public ConditionCopyNonLazyBinder FromResolve()
		{
			return null;
		}

		[Address(RVA="0x1F47230", Offset="0x1F47230", VA="0x1F47230")]
		public ConditionCopyNonLazyBinder FromResolve(object subIdentifier)
		{
			return null;
		}

		[Address(RVA="0x1F481C4", Offset="0x1F481C4", VA="0x1F481C4")]
		public ConditionCopyNonLazyBinder FromScriptableObjectResource(string resourcePath)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D868", Offset="0x104D868")]
		private sealed class <>c__DisplayClass14_0
		{
			[FieldOffset(Offset="0x0")]
			public FactoryFromBinderBase<TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public object subIdentifier;

			[Address(RVA="0x1F45DB4", Offset="0x1F45DB4", VA="0x1F45DB4")]
			public <>c__DisplayClass14_0()
			{
			}

			[Address(RVA="0x1F45DE0", Offset="0x1F45DE0", VA="0x1F45DE0")]
			internal IProvider <FromResolve>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D878", Offset="0x104D878")]
		private sealed class <>c__DisplayClass15_0
		{
			[FieldOffset(Offset="0x0")]
			public GameObject gameObject;

			[FieldOffset(Offset="0x0")]
			public FactoryFromBinderBase<TContract> <>4__this;

			[Address(RVA="0x1F45E98", Offset="0x1F45E98", VA="0x1F45E98")]
			public <>c__DisplayClass15_0()
			{
			}

			[Address(RVA="0x1F45EC4", Offset="0x1F45EC4", VA="0x1F45EC4")]
			internal IProvider <FromNewComponentOn>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D888", Offset="0x104D888")]
		private sealed class <>c__DisplayClass16_0
		{
			[FieldOffset(Offset="0x0")]
			public Func<InjectContext, GameObject> gameObjectGetter;

			[FieldOffset(Offset="0x0")]
			public FactoryFromBinderBase<TContract> <>4__this;

			[Address(RVA="0x1F45FA4", Offset="0x1F45FA4", VA="0x1F45FA4")]
			public <>c__DisplayClass16_0()
			{
			}

			[Address(RVA="0x1F45FD0", Offset="0x1F45FD0", VA="0x1F45FD0")]
			internal IProvider <FromNewComponentOn>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D898", Offset="0x104D898")]
		private sealed class <>c__DisplayClass17_0
		{
			[FieldOffset(Offset="0x0")]
			public FactoryFromBinderBase<TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[Address(RVA="0x1F460B0", Offset="0x1F460B0", VA="0x1F460B0")]
			public <>c__DisplayClass17_0()
			{
			}

			[Address(RVA="0x1F460DC", Offset="0x1F460DC", VA="0x1F460DC")]
			internal IProvider <FromNewComponentOnNewGameObject>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D8A8", Offset="0x104D8A8")]
		private sealed class <>c__DisplayClass18_0
		{
			[FieldOffset(Offset="0x0")]
			public FactoryFromBinderBase<TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[FieldOffset(Offset="0x0")]
			public UnityEngine.Object prefab;

			[Address(RVA="0x1F461C0", Offset="0x1F461C0", VA="0x1F461C0")]
			public <>c__DisplayClass18_0()
			{
			}

			[Address(RVA="0x1F461EC", Offset="0x1F461EC", VA="0x1F461EC")]
			internal IProvider <FromNewComponentOnNewPrefab>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D8B8", Offset="0x104D8B8")]
		private sealed class <>c__DisplayClass19_0
		{
			[FieldOffset(Offset="0x0")]
			public FactoryFromBinderBase<TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[FieldOffset(Offset="0x0")]
			public UnityEngine.Object prefab;

			[Address(RVA="0x1F46348", Offset="0x1F46348", VA="0x1F46348")]
			public <>c__DisplayClass19_0()
			{
			}

			[Address(RVA="0x1F46374", Offset="0x1F46374", VA="0x1F46374")]
			internal IProvider <FromComponentInNewPrefab>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D8C8", Offset="0x104D8C8")]
		private sealed class <>c__DisplayClass20_0
		{
			[FieldOffset(Offset="0x0")]
			public FactoryFromBinderBase<TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[FieldOffset(Offset="0x0")]
			public string resourcePath;

			[Address(RVA="0x1F464D0", Offset="0x1F464D0", VA="0x1F464D0")]
			public <>c__DisplayClass20_0()
			{
			}

			[Address(RVA="0x1F464FC", Offset="0x1F464FC", VA="0x1F464FC")]
			internal IProvider <FromComponentInNewPrefabResource>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D8D8", Offset="0x104D8D8")]
		private sealed class <>c__DisplayClass21_0
		{
			[FieldOffset(Offset="0x0")]
			public FactoryFromBinderBase<TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			public GameObjectCreationParameters gameObjectInfo;

			[FieldOffset(Offset="0x0")]
			public string resourcePath;

			[Address(RVA="0x1F46658", Offset="0x1F46658", VA="0x1F46658")]
			public <>c__DisplayClass21_0()
			{
			}

			[Address(RVA="0x1F46684", Offset="0x1F46684", VA="0x1F46684")]
			internal IProvider <FromNewComponentOnNewPrefabResource>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D8E8", Offset="0x104D8E8")]
		private sealed class <>c__DisplayClass22_0
		{
			[FieldOffset(Offset="0x0")]
			public string resourcePath;

			[FieldOffset(Offset="0x0")]
			public FactoryFromBinderBase<TContract> <>4__this;

			[Address(RVA="0x1F467E0", Offset="0x1F467E0", VA="0x1F467E0")]
			public <>c__DisplayClass22_0()
			{
			}

			[Address(RVA="0x1F4680C", Offset="0x1F4680C", VA="0x1F4680C")]
			internal IProvider <FromNewScriptableObjectResource>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D8F8", Offset="0x104D8F8")]
		private sealed class <>c__DisplayClass23_0
		{
			[FieldOffset(Offset="0x0")]
			public string resourcePath;

			[FieldOffset(Offset="0x0")]
			public FactoryFromBinderBase<TContract> <>4__this;

			[Address(RVA="0x1F468F0", Offset="0x1F468F0", VA="0x1F468F0")]
			public <>c__DisplayClass23_0()
			{
			}

			[Address(RVA="0x1F4691C", Offset="0x1F4691C", VA="0x1F4691C")]
			internal IProvider <FromScriptableObjectResource>b__0(DiContainer container)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D858", Offset="0x104D858")]
		private sealed class <get_AllParentTypes>d__11 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x0")]
			private int <>1__state;

			[FieldOffset(Offset="0x0")]
			private Type <>2__current;

			[FieldOffset(Offset="0x0")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x0")]
			public FactoryFromBinderBase<TContract> <>4__this;

			[FieldOffset(Offset="0x0")]
			private List<Type>.Enumerator <>7__wrap1;

			private Type System.Collections.Generic.IEnumerator<System.Type>.Current
			{
				[Address(RVA="0x1F46D64", Offset="0x1F46D64", VA="0x1F46D64", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1F46DD4", Offset="0x1F46DD4", VA="0x1F46DD4", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1F46A00", Offset="0x1F46A00", VA="0x1F46A00")]
			[DebuggerHidden]
			public <get_AllParentTypes>d__11(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1F46C74", Offset="0x1F46C74", VA="0x1F46C74")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x1F46A70", Offset="0x1F46A70", VA="0x1F46A70", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1F46DDC", Offset="0x1F46DDC", VA="0x1F46DDC", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1F46E88", Offset="0x1F46E88", VA="0x1F46E88", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1F46D6C", Offset="0x1F46D6C", VA="0x1F46D6C", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1F46A44", Offset="0x1F46A44", VA="0x1F46A44", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}