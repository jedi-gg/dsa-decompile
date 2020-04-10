using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Zenject
{
	public class PrefabInstantiatorCached : IPrefabInstantiator
	{
		[FieldOffset(Offset="0x10")]
		private readonly IPrefabInstantiator _subInstantiator;

		[FieldOffset(Offset="0x18")]
		private GameObject _gameObject;

		public Type ArgumentTarget
		{
			[Address(RVA="0x1840528", Offset="0x1840528", VA="0x1840528", Slot="4")]
			get
			{
				return null;
			}
		}

		public List<TypeValuePair> ExtraArguments
		{
			[Address(RVA="0x1840470", Offset="0x1840470", VA="0x1840470", Slot="5")]
			get
			{
				return null;
			}
		}

		public Zenject.GameObjectCreationParameters GameObjectCreationParameters
		{
			[Address(RVA="0x18405DC", Offset="0x18405DC", VA="0x18405DC", Slot="6")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x183F210", Offset="0x183F210", VA="0x183F210")]
		public PrefabInstantiatorCached(IPrefabInstantiator subInstantiator)
		{
		}

		[Address(RVA="0x1840694", Offset="0x1840694", VA="0x1840694", Slot="8")]
		public UnityEngine.Object GetPrefab()
		{
			return null;
		}

		[Address(RVA="0x184074C", Offset="0x184074C", VA="0x184074C", Slot="7")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1073A30", Offset="0x1073A30")]
		public IEnumerator<GameObject> Instantiate(List<TypeValuePair> args)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DFD8", Offset="0x104DFD8")]
		private sealed class <Instantiate>d__10 : IEnumerator<GameObject>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private GameObject <>2__current;

			[FieldOffset(Offset="0x20")]
			public List<TypeValuePair> args;

			[FieldOffset(Offset="0x28")]
			public PrefabInstantiatorCached <>4__this;

			[FieldOffset(Offset="0x30")]
			private IEnumerator<GameObject> <runner>5__2;

			[FieldOffset(Offset="0x38")]
			private bool <hasMore>5__3;

			private GameObject System.Collections.Generic.IEnumerator<UnityEngine.GameObject>.Current
			{
				[Address(RVA="0x1840B68", Offset="0x1840B68", VA="0x1840B68", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1840BD8", Offset="0x1840BD8", VA="0x1840BD8", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x18407E4", Offset="0x18407E4", VA="0x18407E4")]
			[DebuggerHidden]
			public <Instantiate>d__10(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1840814", Offset="0x1840814", VA="0x1840814", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1840B70", Offset="0x1840B70", VA="0x1840B70", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1840810", Offset="0x1840810", VA="0x1840810", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}