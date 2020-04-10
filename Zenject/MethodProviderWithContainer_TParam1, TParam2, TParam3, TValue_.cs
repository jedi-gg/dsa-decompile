using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class MethodProviderWithContainer<TParam1, TParam2, TParam3, TValue> : IProvider
	{
		[FieldOffset(Offset="0x0")]
		private readonly Func<DiContainer, TParam1, TParam2, TParam3, TValue> _method;

		[Address(RVA="0x2357500", Offset="0x2357500", VA="0x2357500")]
		public MethodProviderWithContainer(Func<DiContainer, TParam1, TParam2, TParam3, TValue> method)
		{
		}

		[Address(RVA="0x23575AC", Offset="0x23575AC", VA="0x23575AC", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10738A0", Offset="0x10738A0")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x2357538", Offset="0x2357538", VA="0x2357538", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DF98", Offset="0x104DF98")]
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
			public MethodProviderWithContainer<TParam1, TParam2, TParam3, TValue> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x2357488", Offset="0x2357488", VA="0x2357488", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x23574F8", Offset="0x23574F8", VA="0x23574F8", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x2356E00", Offset="0x2356E00", VA="0x2356E00")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__3(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x2356E3C", Offset="0x2356E3C", VA="0x2356E3C", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x2357490", Offset="0x2357490", VA="0x2357490", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x2356E38", Offset="0x2356E38", VA="0x2356E38", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}