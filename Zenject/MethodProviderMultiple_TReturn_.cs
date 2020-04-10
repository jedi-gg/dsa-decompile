using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class MethodProviderMultiple<TReturn> : IProvider
	{
		[FieldOffset(Offset="0x0")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x0")]
		private readonly Func<InjectContext, IEnumerable<TReturn>> _method;

		[Address(RVA="0x23556BC", Offset="0x23556BC", VA="0x23556BC")]
		public MethodProviderMultiple(Func<InjectContext, IEnumerable<TReturn>> method, DiContainer container)
		{
		}

		[Address(RVA="0x2355774", Offset="0x2355774", VA="0x2355774", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1073648", Offset="0x1073648")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x2355700", Offset="0x2355700", VA="0x2355700", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DF38", Offset="0x104DF38")]
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
			public MethodProviderMultiple<TReturn> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x2355644", Offset="0x2355644", VA="0x2355644", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x23556B4", Offset="0x23556B4", VA="0x23556B4", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x23552AC", Offset="0x23552AC", VA="0x23552AC")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__4(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x23552E8", Offset="0x23552E8", VA="0x23552E8", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x235564C", Offset="0x235564C", VA="0x235564C", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x23552E4", Offset="0x23552E4", VA="0x23552E4", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}