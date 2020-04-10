using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class SubContainerDependencyProvider : IProvider
	{
		[FieldOffset(Offset="0x10")]
		private readonly ISubContainerCreator _subContainerCreator;

		[FieldOffset(Offset="0x18")]
		private readonly Type _dependencyType;

		[FieldOffset(Offset="0x20")]
		private readonly object _identifier;

		[Address(RVA="0x2336AFC", Offset="0x2336AFC", VA="0x2336AFC")]
		public SubContainerDependencyProvider(Type dependencyType, object identifier, ISubContainerCreator subContainerCreator)
		{
		}

		[Address(RVA="0x2336B44", Offset="0x2336B44", VA="0x2336B44")]
		private InjectContext CreateSubContext(InjectContext parent, DiContainer subContainer)
		{
			return null;
		}

		[Address(RVA="0x2336BDC", Offset="0x2336BDC", VA="0x2336BDC", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1073C40", Offset="0x1073C40")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x2336B3C", Offset="0x2336B3C", VA="0x2336B3C", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E098", Offset="0x104E098")]
		private sealed class <GetAllInstancesWithInjectSplit>d__6 : IEnumerator<List<object>>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x10")]
			private int <>1__state;

			[FieldOffset(Offset="0x18")]
			private List<object> <>2__current;

			[FieldOffset(Offset="0x20")]
			public InjectContext context;

			[FieldOffset(Offset="0x28")]
			public SubContainerDependencyProvider <>4__this;

			[FieldOffset(Offset="0x30")]
			public List<TypeValuePair> args;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x2336E40", Offset="0x2336E40", VA="0x2336E40", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x2336EB0", Offset="0x2336EB0", VA="0x2336EB0", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x2336C88", Offset="0x2336C88", VA="0x2336C88")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__6(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x2336CB8", Offset="0x2336CB8", VA="0x2336CB8", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x2336E48", Offset="0x2336E48", VA="0x2336E48", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x2336CB4", Offset="0x2336CB4", VA="0x2336CB4", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}