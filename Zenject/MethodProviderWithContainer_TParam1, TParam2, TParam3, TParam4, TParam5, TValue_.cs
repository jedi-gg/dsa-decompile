using Il2CppDummyDll;
using ModestTree.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class MethodProviderWithContainer<TParam1, TParam2, TParam3, TParam4, TParam5, TValue> : IProvider
	{
		[FieldOffset(Offset="0x0")]
		private readonly ModestTree.Util.Func<DiContainer, TParam1, TParam2, TParam3, TParam4, TParam5, TValue> _method;

		[Address(RVA="0x235890C", Offset="0x235890C", VA="0x235890C")]
		public MethodProviderWithContainer(ModestTree.Util.Func<DiContainer, TParam1, TParam2, TParam3, TParam4, TParam5, TValue> method)
		{
		}

		[Address(RVA="0x23589B8", Offset="0x23589B8", VA="0x23589B8", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1073968", Offset="0x1073968")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x2358944", Offset="0x2358944", VA="0x2358944", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DFB8", Offset="0x104DFB8")]
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
			public MethodProviderWithContainer<TParam1, TParam2, TParam3, TParam4, TParam5, TValue> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x2358894", Offset="0x2358894", VA="0x2358894", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x2358904", Offset="0x2358904", VA="0x2358904", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x2357FD8", Offset="0x2357FD8", VA="0x2357FD8")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__3(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x2358014", Offset="0x2358014", VA="0x2358014", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x235889C", Offset="0x235889C", VA="0x235889C", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x2358010", Offset="0x2358010", VA="0x2358010", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}