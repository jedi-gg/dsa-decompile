using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Zenject
{
	public abstract class AddToGameObjectComponentProviderBase : IProvider
	{
		[FieldOffset(Offset="0x10")]
		private readonly object _concreteIdentifier;

		[FieldOffset(Offset="0x18")]
		private readonly Type _componentType;

		[FieldOffset(Offset="0x20")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x28")]
		private readonly List<TypeValuePair> _extraArguments;

		protected Type ComponentType
		{
			[Address(RVA="0x15AAA50", Offset="0x15AAA50", VA="0x15AAA50")]
			get
			{
				return null;
			}
		}

		protected object ConcreteIdentifier
		{
			[Address(RVA="0x15AAA58", Offset="0x15AAA58", VA="0x15AAA58")]
			get
			{
				return null;
			}
		}

		protected DiContainer Container
		{
			[Address(RVA="0x15AAA48", Offset="0x15AAA48", VA="0x15AAA48")]
			get
			{
				return null;
			}
		}

		protected abstract bool ShouldToggleActive
		{
			get;
		}

		[Address(RVA="0x15AA8D4", Offset="0x15AA8D4", VA="0x15AA8D4")]
		public AddToGameObjectComponentProviderBase(DiContainer container, Type componentType, object concreteIdentifier, List<TypeValuePair> extraArguments)
		{
		}

		[Address(RVA="0x15AAA68", Offset="0x15AAA68", VA="0x15AAA68", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1072DE8", Offset="0x1072DE8")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		protected abstract GameObject GetGameObject(InjectContext context);

		[Address(RVA="0x15AAA60", Offset="0x15AAA60", VA="0x15AAA60", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DDF8", Offset="0x104DDF8")]
		private sealed class <GetAllInstancesWithInjectSplit>d__14 : IEnumerator<List<object>>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private List<object> <>2__current;

			[FieldOffset(Offset="0x20")]
			public InjectContext context;

			[FieldOffset(Offset="0x28")]
			public AddToGameObjectComponentProviderBase <>4__this;

			[FieldOffset(Offset="0x30")]
			public List<TypeValuePair> args;

			[FieldOffset(Offset="0x38")]
			private object <instance>5__2;

			[FieldOffset(Offset="0x40")]
			private GameObject <gameObj>5__3;

			[FieldOffset(Offset="0x48")]
			private bool <wasActive>5__4;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x15AAF4C", Offset="0x15AAF4C", VA="0x15AAF4C", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x15AAFBC", Offset="0x15AAFBC", VA="0x15AAFBC", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x15AAB14", Offset="0x15AAB14", VA="0x15AAB14")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__14(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x15AAB44", Offset="0x15AAB44", VA="0x15AAB44", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x15AAF54", Offset="0x15AAF54", VA="0x15AAF54", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x15AAB40", Offset="0x15AAB40", VA="0x15AAB40", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}