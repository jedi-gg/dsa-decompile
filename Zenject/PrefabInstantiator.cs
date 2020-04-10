using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Zenject
{
	public class PrefabInstantiator : IPrefabInstantiator
	{
		[FieldOffset(Offset="0x10")]
		private readonly IPrefabProvider _prefabProvider;

		[FieldOffset(Offset="0x18")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x20")]
		private readonly List<TypeValuePair> _extraArguments;

		[FieldOffset(Offset="0x28")]
		private readonly Zenject.GameObjectCreationParameters _gameObjectBindInfo;

		[FieldOffset(Offset="0x30")]
		private readonly Type _argumentTarget;

		public Type ArgumentTarget
		{
			[Address(RVA="0x183FF3C", Offset="0x183FF3C", VA="0x183FF3C", Slot="4")]
			get
			{
				return null;
			}
		}

		public List<TypeValuePair> ExtraArguments
		{
			[Address(RVA="0x183FF44", Offset="0x183FF44", VA="0x183FF44", Slot="5")]
			get
			{
				return null;
			}
		}

		public Zenject.GameObjectCreationParameters GameObjectCreationParameters
		{
			[Address(RVA="0x183FF34", Offset="0x183FF34", VA="0x183FF34", Slot="6")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x183F1BC", Offset="0x183F1BC", VA="0x183F1BC")]
		public PrefabInstantiator(DiContainer container, Zenject.GameObjectCreationParameters gameObjectBindInfo, Type argumentTarget, List<TypeValuePair> extraArguments, IPrefabProvider prefabProvider)
		{
		}

		[Address(RVA="0x183FF4C", Offset="0x183FF4C", VA="0x183FF4C", Slot="8")]
		public UnityEngine.Object GetPrefab()
		{
			return null;
		}

		[Address(RVA="0x1840000", Offset="0x1840000", VA="0x1840000", Slot="7")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10739CC", Offset="0x10739CC")]
		public IEnumerator<GameObject> Instantiate(List<TypeValuePair> args)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DFC8", Offset="0x104DFC8")]
		private sealed class <Instantiate>d__13 : IEnumerator<GameObject>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private GameObject <>2__current;

			[FieldOffset(Offset="0x20")]
			public PrefabInstantiator <>4__this;

			[FieldOffset(Offset="0x28")]
			public List<TypeValuePair> args;

			[FieldOffset(Offset="0x30")]
			private InjectContext <context>5__2;

			[FieldOffset(Offset="0x38")]
			private bool <shouldMakeActive>5__3;

			[FieldOffset(Offset="0x40")]
			private GameObject <gameObject>5__4;

			private GameObject System.Collections.Generic.IEnumerator<UnityEngine.GameObject>.Current
			{
				[Address(RVA="0x18403F8", Offset="0x18403F8", VA="0x18403F8", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1840468", Offset="0x1840468", VA="0x1840468", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1840098", Offset="0x1840098", VA="0x1840098")]
			[DebuggerHidden]
			public <Instantiate>d__13(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x18400C8", Offset="0x18400C8", VA="0x18400C8", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1840400", Offset="0x1840400", VA="0x1840400", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x18400C4", Offset="0x18400C4", VA="0x18400C4", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}