using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Zenject
{
	public class PrefabGameObjectProvider : IProvider
	{
		[FieldOffset(Offset="0x10")]
		private readonly IPrefabInstantiator _prefabCreator;

		[Address(RVA="0x183FA74", Offset="0x183FA74", VA="0x183FA74")]
		public PrefabGameObjectProvider(IPrefabInstantiator prefabCreator)
		{
		}

		[Address(RVA="0x183FB10", Offset="0x183FB10", VA="0x183FB10", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10731F0", Offset="0x10731F0")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x183FAA0", Offset="0x183FAA0", VA="0x183FAA0", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DE98", Offset="0x104DE98")]
		private sealed class <GetAllInstancesWithInjectSplit>d__3 : IEnumerator<List<object>>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private List<object> <>2__current;

			[FieldOffset(Offset="0x20")]
			public PrefabGameObjectProvider <>4__this;

			[FieldOffset(Offset="0x28")]
			public List<TypeValuePair> args;

			[FieldOffset(Offset="0x30")]
			private IEnumerator<GameObject> <runner>5__2;

			[FieldOffset(Offset="0x38")]
			private bool <hasMore>5__3;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x183FEBC", Offset="0x183FEBC", VA="0x183FEBC", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x183FF2C", Offset="0x183FF2C", VA="0x183FF2C", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x183FBA8", Offset="0x183FBA8", VA="0x183FBA8")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__3(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x183FBD8", Offset="0x183FBD8", VA="0x183FBD8", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x183FEC4", Offset="0x183FEC4", VA="0x183FEC4", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x183FBD4", Offset="0x183FBD4", VA="0x183FBD4", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}