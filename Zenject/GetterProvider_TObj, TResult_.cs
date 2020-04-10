using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class GetterProvider<TObj, TResult> : IProvider
	{
		[FieldOffset(Offset="0x0")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x0")]
		private readonly object _identifier;

		[FieldOffset(Offset="0x0")]
		private readonly Func<TObj, TResult> _method;

		[Address(RVA="0x234C640", Offset="0x234C640", VA="0x234C640")]
		public GetterProvider(object identifier, Func<TObj, TResult> method, DiContainer container)
		{
		}

		[Address(RVA="0x234C7D0", Offset="0x234C7D0", VA="0x234C7D0", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1073254", Offset="0x1073254")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x234C68C", Offset="0x234C68C", VA="0x234C68C", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Address(RVA="0x234C700", Offset="0x234C700", VA="0x234C700")]
		private InjectContext GetSubContext(InjectContext parent)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DEA8", Offset="0x104DEA8")]
		private sealed class <GetAllInstancesWithInjectSplit>d__6 : IEnumerator<List<object>>, IEnumerator, IDisposable
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
			public GetterProvider<TObj, TResult> <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x234C5C8", Offset="0x234C5C8", VA="0x234C5C8", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x234C638", Offset="0x234C638", VA="0x234C638", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x234C204", Offset="0x234C204", VA="0x234C204")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__6(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x234C240", Offset="0x234C240", VA="0x234C240", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x234C5D0", Offset="0x234C5D0", VA="0x234C5D0", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x234C23C", Offset="0x234C23C", VA="0x234C23C", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}