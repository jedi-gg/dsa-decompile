using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class MethodProviderWithContainer<TParam1, TParam2, TValue> : IProvider
	{
		[FieldOffset(Offset="0x0")]
		private readonly Func<DiContainer, TParam1, TParam2, TValue> _method;

		[Address(RVA="0x2356CA0", Offset="0x2356CA0", VA="0x2356CA0")]
		public MethodProviderWithContainer(Func<DiContainer, TParam1, TParam2, TValue> method)
		{
		}

		[Address(RVA="0x2356D4C", Offset="0x2356D4C", VA="0x2356D4C", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x107383C", Offset="0x107383C")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x2356CD8", Offset="0x2356CD8", VA="0x2356CD8", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DF88", Offset="0x104DF88")]
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
			public MethodProviderWithContainer<TParam1, TParam2, TValue> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x2356C28", Offset="0x2356C28", VA="0x2356C28", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x2356C98", Offset="0x2356C98", VA="0x2356C98", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x23566B4", Offset="0x23566B4", VA="0x23566B4")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__3(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x23566F0", Offset="0x23566F0", VA="0x23566F0", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x2356C30", Offset="0x2356C30", VA="0x2356C30", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x23566EC", Offset="0x23566EC", VA="0x23566EC", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}