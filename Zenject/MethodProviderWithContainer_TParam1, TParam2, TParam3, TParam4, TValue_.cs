using Il2CppDummyDll;
using ModestTree.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class MethodProviderWithContainer<TParam1, TParam2, TParam3, TParam4, TValue> : IProvider
	{
		[FieldOffset(Offset="0x0")]
		private readonly ModestTree.Util.Func<DiContainer, TParam1, TParam2, TParam3, TParam4, TValue> _method;

		[Address(RVA="0x2357E78", Offset="0x2357E78", VA="0x2357E78")]
		public MethodProviderWithContainer(ModestTree.Util.Func<DiContainer, TParam1, TParam2, TParam3, TParam4, TValue> method)
		{
		}

		[Address(RVA="0x2357F24", Offset="0x2357F24", VA="0x2357F24", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1073904", Offset="0x1073904")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x2357EB0", Offset="0x2357EB0", VA="0x2357EB0", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DFA8", Offset="0x104DFA8")]
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
			public MethodProviderWithContainer<TParam1, TParam2, TParam3, TParam4, TValue> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x2357E00", Offset="0x2357E00", VA="0x2357E00", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x2357E70", Offset="0x2357E70", VA="0x2357E70", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x2357660", Offset="0x2357660", VA="0x2357660")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__3(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x235769C", Offset="0x235769C", VA="0x235769C", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x2357E08", Offset="0x2357E08", VA="0x2357E08", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x2357698", Offset="0x2357698", VA="0x2357698", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}