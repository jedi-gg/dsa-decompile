using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class InstanceProvider : IProvider
	{
		[FieldOffset(Offset="0x10")]
		private readonly object _instance;

		[FieldOffset(Offset="0x18")]
		private readonly Type _instanceType;

		[FieldOffset(Offset="0x20")]
		private readonly DiContainer _container;

		[Address(RVA="0x1836730", Offset="0x1836730", VA="0x1836730")]
		public InstanceProvider(Type instanceType, object instance, DiContainer container)
		{
		}

		[Address(RVA="0x183BA00", Offset="0x183BA00", VA="0x183BA00", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1073510", Offset="0x1073510")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x183B9F8", Offset="0x183B9F8", VA="0x183B9F8", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DF18", Offset="0x104DF18")]
		private sealed class <GetAllInstancesWithInjectSplit>d__5 : IEnumerator<List<object>>, IEnumerator, IDisposable
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
			public InstanceProvider <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x183BC48", Offset="0x183BC48", VA="0x183BC48", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x183BCB8", Offset="0x183BCB8", VA="0x183BCB8", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x183BAAC", Offset="0x183BAAC", VA="0x183BAAC")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__5(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x183BADC", Offset="0x183BADC", VA="0x183BADC", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x183BC50", Offset="0x183BC50", VA="0x183BC50", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x183BAD8", Offset="0x183BAD8", VA="0x183BAD8", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}