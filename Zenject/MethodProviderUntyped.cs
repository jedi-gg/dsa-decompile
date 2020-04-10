using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class MethodProviderUntyped : IProvider
	{
		[FieldOffset(Offset="0x10")]
		private readonly DiContainer _container;

		[FieldOffset(Offset="0x18")]
		private readonly Func<InjectContext, object> _method;

		[Address(RVA="0x183667C", Offset="0x183667C", VA="0x183667C")]
		public MethodProviderUntyped(Func<InjectContext, object> method, DiContainer container)
		{
		}

		[Address(RVA="0x183D7A4", Offset="0x183D7A4", VA="0x183D7A4", Slot="5")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1073710", Offset="0x1073710")]
		public IEnumerator<List<object>> GetAllInstancesWithInjectSplit(InjectContext context, List<TypeValuePair> args)
		{
			return null;
		}

		[Address(RVA="0x183D778", Offset="0x183D778", VA="0x183D778", Slot="4")]
		public Type GetInstanceType(InjectContext context)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DF58", Offset="0x104DF58")]
		private sealed class <GetAllInstancesWithInjectSplit>d__4 : IEnumerator<List<object>>, IEnumerator, IDisposable
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
			public MethodProviderUntyped <>4__this;

			private List<object> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<System.Object>>.Current
			{
				[Address(RVA="0x183DAFC", Offset="0x183DAFC", VA="0x183DAFC", Slot="4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x183DB6C", Offset="0x183DB6C", VA="0x183DB6C", Slot="7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x183D850", Offset="0x183D850", VA="0x183D850")]
			[DebuggerHidden]
			public <GetAllInstancesWithInjectSplit>d__4(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x183D880", Offset="0x183D880", VA="0x183D880", Slot="6")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x183DB04", Offset="0x183DB04", VA="0x183DB04", Slot="8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x183D87C", Offset="0x183D87C", VA="0x183D87C", Slot="5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}