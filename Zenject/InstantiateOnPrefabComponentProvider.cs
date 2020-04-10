using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Zenject
{
	public class InstantiateOnPrefabComponentProvider : IProvider
	{
		[FieldOffset(Offset="0x10")]
		private readonly IPrefabInstantiator _prefabInstantiator;

		[FieldOffset(Offset="0x18")]
		private readonly Type _componentType;

		[Address(RVA="0x1835D9C", Offset="0x1835D9C", VA="0x1835D9C")]
		public InstantiateOnPrefabComponentProvider(Type componentType, IPrefabInstantiator prefabInstantiator)
		{
		}

		[Address(RVA="0x183BCC8", Offset="0x183BCC8", VA="0x183BCC8", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1072EB0", Offset="0x1072EB0")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x183BCC0", Offset="0x183BCC0", VA="0x183BCC0", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DE18", Offset="0x104DE18")]
		private sealed class <GetAllInstancesWithInjectSplit>d__4 : IEnumerator<List<object>>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private List<object> <>2__current;

			[FieldOffset(Offset="0x20")]
			public InjectContext context;

			[FieldOffset(Offset="0x28")]
			public InstantiateOnPrefabComponentProvider <>4__this;

			[FieldOffset(Offset="0x30")]
			public List<TypeValuePair> args;

			[FieldOffset(Offset="0x38")]
			private IEnumerator<GameObject> <gameObjectRunner>5__2;

			[FieldOffset(Offset="0x40")]
			private bool <hasMore>5__3;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x183C0C0", Offset="0x183C0C0", VA="0x183C0C0", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x183C130", Offset="0x183C130", VA="0x183C130", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x183BD74", Offset="0x183BD74", VA="0x183BD74")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__4(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x183BDA4", Offset="0x183BDA4", VA="0x183BDA4", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x183C0C8", Offset="0x183C0C8", VA="0x183C0C8", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x183BDA0", Offset="0x183BDA0", VA="0x183BDA0", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}