using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class MethodProviderWithContainer<TParam1, TValue> : IProvider
	{
		[FieldOffset(Offset="0x0")]
		private readonly Func<DiContainer, TParam1, TValue> _method;

		[Address(RVA="0x2356554", Offset="0x2356554", VA="0x2356554")]
		public MethodProviderWithContainer(Func<DiContainer, TParam1, TValue> method)
		{
		}

		[Address(RVA="0x2356600", Offset="0x2356600", VA="0x2356600", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10737D8", Offset="0x10737D8")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x235658C", Offset="0x235658C", VA="0x235658C", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DF78", Offset="0x104DF78")]
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
			public MethodProviderWithContainer<TParam1, TValue> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x23564DC", Offset="0x23564DC", VA="0x23564DC", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x235654C", Offset="0x235654C", VA="0x235654C", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x2356088", Offset="0x2356088", VA="0x2356088")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__3(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x23560C4", Offset="0x23560C4", VA="0x23560C4", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x23564E4", Offset="0x23564E4", VA="0x23564E4", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x23560C0", Offset="0x23560C0", VA="0x23560C0", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}