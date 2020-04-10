using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class FactoryProvider<TValue, TFactory, TParam1, TParam2, TParam3, TParam4, TParam5> : FactoryProviderBase<TValue, TFactory>
	where TFactory : IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TValue>
	{
		[Address(RVA="0x2342984", Offset="0x2342984", VA="0x2342984")]
		public FactoryProvider(DiContainer container, List<TypeValuePair> factoryArgs)
		{
		}

		[Address(RVA="0x23429D8", Offset="0x23429D8", VA="0x23429D8", Slot="6")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1073128", Offset="0x1073128")]
		public override IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DE78", Offset="0x104DE78")]
		private sealed class <GetAllInstancesWithInjectSplit>d__1 : IEnumerator<List<object>>, IEnumerator, IDisposable
		// where TFactory : IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TValue>
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
			public FactoryProvider<TParam1, TParam2, TParam3, TParam4, TParam5, TValue, TFactory> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x1F4F144", Offset="0x1F4F144", VA="0x1F4F144", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1F4F1B4", Offset="0x1F4F1B4", VA="0x1F4F1B4", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1F4E68C", Offset="0x1F4E68C", VA="0x1F4E68C")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__1(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1F4E6C8", Offset="0x1F4E6C8", VA="0x1F4E6C8", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1F4F14C", Offset="0x1F4F14C", VA="0x1F4F14C", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1F4E6C4", Offset="0x1F4E6C4", VA="0x1F4E6C4", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}