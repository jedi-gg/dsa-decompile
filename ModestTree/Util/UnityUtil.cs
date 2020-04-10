using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ModestTree.Util
{
	public static class UnityUtil
	{
		public static IEnumerable<Scene> AllLoadedScenes
		{
			[Address(RVA="0x12FA56C", Offset="0x12FA56C", VA="0x12FA56C")]
			get
			{
				return null;
			}
		}

		public static IEnumerable<Scene> AllScenes
		{
			[Address(RVA="0x12FA4C4", Offset="0x12FA4C4", VA="0x12FA4C4")]
			[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1071EAC", Offset="0x1071EAC")]
			get
			{
				return null;
			}
		}

		public static bool IsAltKeyDown
		{
			[Address(RVA="0x12FA664", Offset="0x12FA664", VA="0x12FA664")]
			get
			{
				return new bool();
			}
		}

		public static bool IsControlKeyDown
		{
			[Address(RVA="0x12FA698", Offset="0x12FA698", VA="0x12FA698")]
			get
			{
				return new bool();
			}
		}

		public static bool IsShiftKeyDown
		{
			[Address(RVA="0x12FA6CC", Offset="0x12FA6CC", VA="0x12FA6CC")]
			get
			{
				return new bool();
			}
		}

		public static bool WasAltKeyJustPressed
		{
			[Address(RVA="0x12FA734", Offset="0x12FA734", VA="0x12FA734")]
			get
			{
				return new bool();
			}
		}

		public static bool WasShiftKeyJustPressed
		{
			[Address(RVA="0x12FA700", Offset="0x12FA700", VA="0x12FA700")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x12FAE70", Offset="0x12FAE70", VA="0x12FAE70")]
		public static IEnumerable<GameObject> GetAllGameObjects()
		{
			return null;
		}

		[Address(RVA="0x12FAF94", Offset="0x12FAF94", VA="0x12FAF94")]
		public static List<GameObject> GetAllRootGameObjects()
		{
			return null;
		}

		[Address(RVA="0x12FABD8", Offset="0x12FABD8", VA="0x12FABD8")]
		public static IEnumerable<Component> GetComponentsInChildrenBottomUp(GameObject gameObject, bool includeInactive)
		{
			return null;
		}

		[Address(RVA="0x12FAAB8", Offset="0x12FAAB8", VA="0x12FAAB8")]
		public static IEnumerable<Component> GetComponentsInChildrenTopDown(GameObject gameObject, bool includeInactive)
		{
			return null;
		}

		[Address(RVA="0x12FA768", Offset="0x12FA768", VA="0x12FA768")]
		public static int GetDepthLevel(Transform transform)
		{
			return new int();
		}

		[Address(RVA="0x12FADB4", Offset="0x12FADB4", VA="0x12FADB4")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x107203C", Offset="0x107203C")]
		public static IEnumerable<GameObject> GetDirectChildren(GameObject obj)
		{
			return null;
		}

		[Address(RVA="0x12FACF8", Offset="0x12FACF8", VA="0x12FACF8")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1071FD8", Offset="0x1071FD8")]
		public static IEnumerable<GameObject> GetDirectChildrenAndSelf(GameObject obj)
		{
			return null;
		}

		[Address(RVA="0x12FA9C4", Offset="0x12FA9C4", VA="0x12FA9C4")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1071F10", Offset="0x1071F10")]
		public static IEnumerable<Transform> GetParents(Transform transform)
		{
			return null;
		}

		[Address(RVA="0x12FA940", Offset="0x12FA940", VA="0x12FA940")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1071F74", Offset="0x1071F74")]
		public static IEnumerable<Transform> GetParentsAndSelf(Transform transform)
		{
			return null;
		}

		[Address(RVA="0x12FA81C", Offset="0x12FA81C", VA="0x12FA81C")]
		public static GameObject GetRootParentOrSelf(GameObject gameObject)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D3D8", Offset="0x104D3D8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static UnityUtil.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<Scene, bool> <>9__3_0;

			[FieldOffset(Offset="0x10")]
			public static Func<Transform, GameObject> <>9__15_0;

			[FieldOffset(Offset="0x18")]
			public static Func<Component, int> <>9__18_0;

			[FieldOffset(Offset="0x20")]
			public static Func<Component, int> <>9__19_0;

			[FieldOffset(Offset="0x28")]
			public static Func<Transform, GameObject> <>9__22_0;

			[FieldOffset(Offset="0x30")]
			public static Func<GameObject, bool> <>9__23_0;

			[Address(RVA="0x12FB09C", Offset="0x12FB09C", VA="0x12FB09C")]
			static <>c()
			{
			}

			[Address(RVA="0x12FB100", Offset="0x12FB100", VA="0x12FB100")]
			public <>c()
			{
			}

			[Address(RVA="0x12FB108", Offset="0x12FB108", VA="0x12FB108")]
			internal bool <get_AllLoadedScenes>b__3_0(Scene scene)
			{
				return new bool();
			}

			[Address(RVA="0x12FB29C", Offset="0x12FB29C", VA="0x12FB29C")]
			internal GameObject <GetAllGameObjects>b__22_0(Transform x)
			{
				return null;
			}

			[Address(RVA="0x12FB2CC", Offset="0x12FB2CC", VA="0x12FB2CC")]
			internal bool <GetAllRootGameObjects>b__23_0(GameObject x)
			{
				return new bool();
			}

			[Address(RVA="0x12FB200", Offset="0x12FB200", VA="0x12FB200")]
			internal int <GetComponentsInChildrenBottomUp>b__19_0(Component x)
			{
				return new int();
			}

			[Address(RVA="0x12FB164", Offset="0x12FB164", VA="0x12FB164")]
			internal int <GetComponentsInChildrenTopDown>b__18_0(Component x)
			{
				return new int();
			}

			[Address(RVA="0x12FB134", Offset="0x12FB134", VA="0x12FB134")]
			internal GameObject <GetRootParentOrSelf>b__15_0(Transform x)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D3C8", Offset="0x104D3C8")]
		private sealed class <get_AllScenes>d__1 : IEnumerable<Scene>, IEnumerable, IEnumerator<Scene>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x14")]
			private Scene <>2__current;

			[FieldOffset(Offset="0x18")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x1C")]
			private int <i>5__2;

			private Scene System.Collections.Generic.IEnumerator<UnityEngine.SceneManagement.Scene>.Current
			{
				[Address(RVA="0x12FC7B0", Offset="0x12FC7B0", VA="0x12FC7B0", Slot="6")]
				[DebuggerHidden]
				get
				{
					return new Scene();
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x12FC820", Offset="0x12FC820", VA="0x12FC820", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x12FA534", Offset="0x12FA534", VA="0x12FA534")]
			[DebuggerHidden]
			public <get_AllScenes>d__1(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x12FC72C", Offset="0x12FC72C", VA="0x12FC72C", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x12FC884", Offset="0x12FC884", VA="0x12FC884", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<Scene> System.Collections.Generic.IEnumerable<UnityEngine.SceneManagement.Scene>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12FC91C", Offset="0x12FC91C", VA="0x12FC91C", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12FC7B8", Offset="0x12FC7B8", VA="0x12FC7B8", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x12FC728", Offset="0x12FC728", VA="0x12FC728", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D418", Offset="0x104D418")]
		private sealed class <GetDirectChildren>d__21 : IEnumerable<GameObject>, IEnumerable, IEnumerator<GameObject>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private GameObject <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			private GameObject obj;

			[FieldOffset(Offset="0x30")]
			public GameObject <>3__obj;

			[FieldOffset(Offset="0x38")]
			private IEnumerator <>7__wrap1;

			private GameObject System.Collections.Generic.IEnumerator<UnityEngine.GameObject>.Current
			{
				[Address(RVA="0x12FB728", Offset="0x12FB728", VA="0x12FB728", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x12FB798", Offset="0x12FB798", VA="0x12FB798", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x12FAE38", Offset="0x12FAE38", VA="0x12FAE38")]
			[DebuggerHidden]
			public <GetDirectChildren>d__21(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x12FB38C", Offset="0x12FB38C", VA="0x12FB38C")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x12FB458", Offset="0x12FB458", VA="0x12FB458", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x12FB7A0", Offset="0x12FB7A0", VA="0x12FB7A0", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<GameObject> System.Collections.Generic.IEnumerable<UnityEngine.GameObject>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12FB850", Offset="0x12FB850", VA="0x12FB850", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12FB730", Offset="0x12FB730", VA="0x12FB730", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x12FB370", Offset="0x12FB370", VA="0x12FB370", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D408", Offset="0x104D408")]
		private sealed class <GetDirectChildrenAndSelf>d__20 : IEnumerable<GameObject>, IEnumerable, IEnumerator<GameObject>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private GameObject <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			private GameObject obj;

			[FieldOffset(Offset="0x30")]
			public GameObject <>3__obj;

			[FieldOffset(Offset="0x38")]
			private IEnumerator <>7__wrap1;

			private GameObject System.Collections.Generic.IEnumerator<UnityEngine.GameObject>.Current
			{
				[Address(RVA="0x12FBC2C", Offset="0x12FBC2C", VA="0x12FBC2C", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x12FBC9C", Offset="0x12FBC9C", VA="0x12FBC9C", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x12FAD7C", Offset="0x12FAD7C", VA="0x12FAD7C")]
			[DebuggerHidden]
			public <GetDirectChildrenAndSelf>d__20(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x12FB870", Offset="0x12FB870", VA="0x12FB870")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x12FB93C", Offset="0x12FB93C", VA="0x12FB93C", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x12FBCA4", Offset="0x12FBCA4", VA="0x12FBCA4", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<GameObject> System.Collections.Generic.IEnumerable<UnityEngine.GameObject>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12FBD54", Offset="0x12FBD54", VA="0x12FBD54", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12FBC34", Offset="0x12FBC34", VA="0x12FBC34", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x12FB854", Offset="0x12FB854", VA="0x12FB854", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D3E8", Offset="0x104D3E8")]
		private sealed class <GetParents>d__16 : IEnumerable<Transform>, IEnumerable, IEnumerator<Transform>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private Transform <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			private Transform transform;

			[FieldOffset(Offset="0x30")]
			public Transform <>3__transform;

			[FieldOffset(Offset="0x38")]
			private IEnumerator<Transform> <>7__wrap1;

			private Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current
			{
				[Address(RVA="0x12FC100", Offset="0x12FC100", VA="0x12FC100", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x12FC170", Offset="0x12FC170", VA="0x12FC170", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x12FAA48", Offset="0x12FAA48", VA="0x12FAA48")]
			[DebuggerHidden]
			public <GetParents>d__16(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x12FBD74", Offset="0x12FBD74", VA="0x12FBD74")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x12FBE34", Offset="0x12FBE34", VA="0x12FBE34", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x12FC178", Offset="0x12FC178", VA="0x12FC178", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<Transform> System.Collections.Generic.IEnumerable<UnityEngine.Transform>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12FC228", Offset="0x12FC228", VA="0x12FC228", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12FC108", Offset="0x12FC108", VA="0x12FC108", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x12FBD58", Offset="0x12FBD58", VA="0x12FBD58", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D3F8", Offset="0x104D3F8")]
		private sealed class <GetParentsAndSelf>d__17 : IEnumerable<Transform>, IEnumerable, IEnumerator<Transform>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private Transform <>2__current;

			[FieldOffset(Offset="0x20")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x28")]
			private Transform transform;

			[FieldOffset(Offset="0x30")]
			public Transform <>3__transform;

			[FieldOffset(Offset="0x38")]
			private IEnumerator<Transform> <>7__wrap1;

			private Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current
			{
				[Address(RVA="0x12FC5FC", Offset="0x12FC5FC", VA="0x12FC5FC", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x12FC66C", Offset="0x12FC66C", VA="0x12FC66C", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x12FAA80", Offset="0x12FAA80", VA="0x12FAA80")]
			[DebuggerHidden]
			public <GetParentsAndSelf>d__17(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x12FC248", Offset="0x12FC248", VA="0x12FC248")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x12FC308", Offset="0x12FC308", VA="0x12FC308", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x12FC674", Offset="0x12FC674", VA="0x12FC674", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<Transform> System.Collections.Generic.IEnumerable<UnityEngine.Transform>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12FC724", Offset="0x12FC724", VA="0x12FC724", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x12FC604", Offset="0x12FC604", VA="0x12FC604", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x12FC22C", Offset="0x12FC22C", VA="0x12FC22C", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}