using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class MethodProviderSimple<TReturn> : IProvider
	{
		[FieldOffset(Offset="0x0")]
		private readonly Func<TReturn> _method;

		[Address(RVA="0x2355A7C", Offset="0x2355A7C", VA="0x2355A7C")]
		public MethodProviderSimple(Func<TReturn> method)
		{
		}

		[Address(RVA="0x2355B28", Offset="0x2355B28", VA="0x2355B28", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10736AC", Offset="0x10736AC")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x2355AB4", Offset="0x2355AB4", VA="0x2355AB4", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DF48", Offset="0x104DF48")]
		private sealed class <GetAllInstancesWithInjectSplit>d__3 : IEnumerator<List<object>>, IEnumerator, IDisposable
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
			public MethodProviderSimple<TReturn> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x2355A04", Offset="0x2355A04", VA="0x2355A04", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x2355A74", Offset="0x2355A74", VA="0x2355A74", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x2355828", Offset="0x2355828", VA="0x2355828")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__3(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x2355864", Offset="0x2355864", VA="0x2355864", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x2355A0C", Offset="0x2355A0C", VA="0x2355A0C", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x2355860", Offset="0x2355860", VA="0x2355860", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}