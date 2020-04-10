using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class MethodProvider<TReturn> : IProvider
	{
		[FieldOffset(Offset="0x0")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x0")]
		private readonly Func<InjectContext, TReturn> _method;

		[Address(RVA="0x2358DC4", Offset="0x2358DC4", VA="0x2358DC4")]
		public MethodProvider(Func<InjectContext, TReturn> method, DiContainer container)
		{
		}

		[Address(RVA="0x2358E7C", Offset="0x2358E7C", VA="0x2358E7C", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10735E4", Offset="0x10735E4")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x2358E08", Offset="0x2358E08", VA="0x2358E08", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DF28", Offset="0x104DF28")]
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
			public MethodProvider<TReturn> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x2358D4C", Offset="0x2358D4C", VA="0x2358D4C", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x2358DBC", Offset="0x2358DBC", VA="0x2358DBC", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x2358A6C", Offset="0x2358A6C", VA="0x2358A6C")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__4(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x2358AA8", Offset="0x2358AA8", VA="0x2358AA8", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x2358D54", Offset="0x2358D54", VA="0x2358D54", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x2358AA4", Offset="0x2358AA4", VA="0x2358AA4", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}