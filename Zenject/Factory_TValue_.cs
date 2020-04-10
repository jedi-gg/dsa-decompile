using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class Factory<TValue> : PlaceholderFactory<TValue>, IFactory<TValue>, IFactory
	{
		protected sealed override IEnumerable<Type> ParamTypes
		{
			[Address(RVA="0x2348F4C", Offset="0x2348F4C", VA="0x2348F4C", Slot="6")]
			[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1072624", Offset="0x1072624")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2348FAC", Offset="0x2348FAC", VA="0x2348FAC")]
		public Factory()
		{
		}

		[Address(RVA="0x2348EB8", Offset="0x2348EB8", VA="0x2348EB8", Slot="7")]
		[Attribute(Name="NotNullAttribute", RVA="0x1072614", Offset="0x1072614")]
		public TValue Create()
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DC18", Offset="0x104DC18")]
		private sealed class <get_ParamTypes>d__2 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x0")]
			private int <>1__state;

			[FieldOffset(Offset="0x0")]
			private Type <>2__current;

			[FieldOffset(Offset="0x0")]
			private int <>l__initialThreadId;

			private Type System.Collections.Generic.IEnumerator<System.Type>.Current
			{
				[Address(RVA="0x2348D70", Offset="0x2348D70", VA="0x2348D70", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x2348DE0", Offset="0x2348DE0", VA="0x2348DE0", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x2348D10", Offset="0x2348D10", VA="0x2348D10")]
			[DebuggerHidden]
			public <get_ParamTypes>d__2(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x2348D58", Offset="0x2348D58", VA="0x2348D58", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x2348DE8", Offset="0x2348DE8", VA="0x2348DE8", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x2348E7C", Offset="0x2348E7C", VA="0x2348E7C", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x2348D78", Offset="0x2348D78", VA="0x2348D78", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x2348D54", Offset="0x2348D54", VA="0x2348D54", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}