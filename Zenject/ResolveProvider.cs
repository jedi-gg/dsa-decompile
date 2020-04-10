using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class ResolveProvider : IProvider
	{
		[FieldOffset(Offset="0x10")]
		private readonly object _identifier;

		[FieldOffset(Offset="0x18")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x20")]
		private readonly Type _contractType;

		[FieldOffset(Offset="0x28")]
		private readonly bool _isOptional;

		[FieldOffset(Offset="0x2C")]
		private readonly InjectSources _source;

		[Address(RVA="0x1835FE0", Offset="0x1835FE0", VA="0x1835FE0")]
		public ResolveProvider(Type contractType, DiContainer container, object identifier, bool isOptional, InjectSources source)
		{
		}

		[Address(RVA="0x18446EC", Offset="0x18446EC", VA="0x18446EC", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1073A94", Offset="0x1073A94")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x18446E4", Offset="0x18446E4", VA="0x18446E4", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Address(RVA="0x18447C4", Offset="0x18447C4", VA="0x18447C4")]
		private InjectContext GetSubContext(InjectContext parent)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DFE8", Offset="0x104DFE8")]
		private sealed class <GetAllInstancesWithInjectSplit>d__7 : IEnumerator<List<object>>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private List<object> <>2__current;

			[FieldOffset(Offset="0x20")]
			public List<TypeValuePair> args;

			[FieldOffset(Offset="0x28")]
			public InjectContext context;

			[FieldOffset(Offset="0x30")]
			public ResolveProvider <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x1844978", Offset="0x1844978", VA="0x1844978", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x18449E8", Offset="0x18449E8", VA="0x18449E8", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1844798", Offset="0x1844798", VA="0x1844798")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__7(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x184484C", Offset="0x184484C", VA="0x184484C", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1844980", Offset="0x1844980", VA="0x1844980", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1844848", Offset="0x1844848", VA="0x1844848", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}