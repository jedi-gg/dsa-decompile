using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class IFactoryResolveProvider<TParam1, TParam2, TValue> : IProvider
	{
		[FieldOffset(Offset="0x0")]
		private readonly object _subIdentifier;

		[FieldOffset(Offset="0x0")]
		private readonly DiContainer _container;

		[Address(RVA="0x234DEE0", Offset="0x234DEE0", VA="0x234DEE0")]
		public IFactoryResolveProvider(DiContainer container, object subIdentifier)
		{
		}

		[Address(RVA="0x234DF98", Offset="0x234DF98", VA="0x234DF98", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1073380", Offset="0x1073380")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x234DF24", Offset="0x234DF24", VA="0x234DF24", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DED8", Offset="0x104DED8")]
		private sealed class <GetAllInstancesWithInjectSplit>d__4 : IEnumerator<List<object>>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x0")]
			private int <>1__state;

			[FieldOffset(Offset="0x0")]
			private List<object> <>2__current;

			[FieldOffset(Offset="0x0")]
			public List<TypeValuePair> args;

			[FieldOffset(Offset="0x0")]
			public InjectContext context;

			[FieldOffset(Offset="0x0")]
			public IFactoryResolveProvider<TParam1, TParam2, TValue> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x234DE68", Offset="0x234DE68", VA="0x234DE68", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x234DED8", Offset="0x234DED8", VA="0x234DED8", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x234D734", Offset="0x234D734", VA="0x234D734")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__4(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x234D770", Offset="0x234D770", VA="0x234D770", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x234DE70", Offset="0x234DE70", VA="0x234DE70", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x234D76C", Offset="0x234D76C", VA="0x234D76C", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}