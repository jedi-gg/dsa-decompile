using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class MethodProviderWithContainer<TValue> : IProvider
	{
		[FieldOffset(Offset="0x0")]
		private readonly Func<DiContainer, TValue> _method;

		[Address(RVA="0x2355F28", Offset="0x2355F28", VA="0x2355F28")]
		public MethodProviderWithContainer(Func<DiContainer, TValue> method)
		{
		}

		[Address(RVA="0x2355FD4", Offset="0x2355FD4", VA="0x2355FD4", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1073774", Offset="0x1073774")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x2355F60", Offset="0x2355F60", VA="0x2355F60", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DF68", Offset="0x104DF68")]
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
			public MethodProviderWithContainer<TValue> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x2355EB0", Offset="0x2355EB0", VA="0x2355EB0", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x2355F20", Offset="0x2355F20", VA="0x2355F20", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x2355BDC", Offset="0x2355BDC", VA="0x2355BDC")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__3(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x2355C18", Offset="0x2355C18", VA="0x2355C18", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x2355EB8", Offset="0x2355EB8", VA="0x2355EB8", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x2355C14", Offset="0x2355C14", VA="0x2355C14", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}