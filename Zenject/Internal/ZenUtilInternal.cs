using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Zenject.Internal
{
	public class ZenUtilInternal
	{
		[Address(RVA="0x183C82C", Offset="0x183C82C", VA="0x183C82C")]
		public ZenUtilInternal()
		{
		}

		[Address(RVA="0x183C154", Offset="0x183C154", VA="0x183C154")]
		public static bool AreFunctionsEqual(Delegate left, Delegate right)
		{
			return new bool();
		}

		[Address(RVA="0x183C2F0", Offset="0x183C2F0", VA="0x183C2F0")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1074164", Offset="0x1074164")]
		public static IEnumerable<SceneContext> GetAllSceneContexts()
		{
			return null;
		}

		[Address(RVA="0x183C1F0", Offset="0x183C1F0", VA="0x183C1F0")]
		public static int GetInheritanceDelta(Type derived, Type parent)
		{
			return new int();
		}

		[Address(RVA="0x183C398", Offset="0x183C398", VA="0x183C398")]
		public static void GetInjectableMonoBehaviours(Scene scene, List<MonoBehaviour> monoBehaviours)
		{
		}

		[Address(RVA="0x18372F4", Offset="0x18372F4", VA="0x18372F4")]
		public static void GetInjectableMonoBehaviours(GameObject gameObject, List<MonoBehaviour> injectableComponents)
		{
		}

		[Address(RVA="0x183C670", Offset="0x183C670", VA="0x183C670")]
		public static IEnumerable<GameObject> GetRootGameObjects(Scene scene)
		{
			return null;
		}

		[Address(RVA="0x18371F4", Offset="0x18371F4", VA="0x18371F4")]
		public static bool IsInjectableMonoBehaviourType(Type type)
		{
			return new bool();
		}

		[Address(RVA="0x183C138", Offset="0x183C138", VA="0x183C138")]
		public static bool IsNull(object obj)
		{
			return new bool();
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E278", Offset="0x104E278")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static ZenUtilInternal.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<GameObject, IEnumerable<SceneContext>> <>9__3_0;

			[FieldOffset(Offset="0x10")]
			public static Func<GameObject, bool> <>9__7_0;

			[Address(RVA="0x183C834", Offset="0x183C834", VA="0x183C834")]
			static <>c()
			{
			}

			[Address(RVA="0x183C898", Offset="0x183C898", VA="0x183C898")]
			public <>c()
			{
			}

			[Address(RVA="0x183C8A0", Offset="0x183C8A0", VA="0x183C8A0")]
			internal IEnumerable<SceneContext> <GetAllSceneContexts>b__3_0(GameObject root)
			{
				return null;
			}

			[Address(RVA="0x183C8FC", Offset="0x183C8FC", VA="0x183C8FC")]
			internal bool <GetRootGameObjects>b__7_0(GameObject x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E298", Offset="0x104E298")]
		private sealed class <>c__DisplayClass7_0
		{
			[FieldOffset(Offset="0x10")]
			public Scene scene;

			[Address(RVA="0x183C824", Offset="0x183C824", VA="0x183C824")]
			public <>c__DisplayClass7_0()
			{
			}

			[Address(RVA="0x183C990", Offset="0x183C990", VA="0x183C990")]
			internal bool <GetRootGameObjects>b__1(GameObject x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E288", Offset="0x104E288")]
		private sealed class <GetAllSceneContexts>d__3 : IEnumerable<SceneContext>, IEnumerable, IEnumerator<SceneContext>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private SceneContext <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			private IEnumerator<Scene> <>7__wrap1;

			private SceneContext System.Collections.Generic.IEnumerator<Zenject.SceneContext>.Current
			{
				[Address(RVA="0x183CFCC", Offset="0x183CFCC", VA="0x183CFCC", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x183D03C", Offset="0x183D03C", VA="0x183D03C", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x183C360", Offset="0x183C360", VA="0x183C360")]
			[DebuggerHidden]
			public <GetAllSceneContexts>d__3(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x183CAF0", Offset="0x183CAF0", VA="0x183CAF0")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x183CBB0", Offset="0x183CBB0", VA="0x183CBB0", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x183D044", Offset="0x183D044", VA="0x183D044", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<SceneContext> System.Collections.Generic.IEnumerable<Zenject.SceneContext>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x183D0DC", Offset="0x183D0DC", VA="0x183D0DC", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x183CFD4", Offset="0x183CFD4", VA="0x183CFD4", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x183CAD4", Offset="0x183CAD4", VA="0x183CAD4", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}