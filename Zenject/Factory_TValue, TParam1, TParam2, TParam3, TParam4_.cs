using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class Factory<TValue, TParam1, TParam2, TParam3, TParam4> : PlaceholderFactory<TValue>, IFactory<TParam1, TParam2, TParam3, TParam4, TValue>, IFactory
	{
		protected sealed override IEnumerable<Type> ParamTypes
		{
			[Address(RVA="0x234A154", Offset="0x234A154", VA="0x234A154", Slot="6")]
			[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10727F4", Offset="0x10727F4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x234A1B4", Offset="0x234A1B4", VA="0x234A1B4")]
		public Factory()
		{
		}

		[Address(RVA="0x2349FB8", Offset="0x2349FB8", VA="0x2349FB8", Slot="7")]
		[Attribute(Name="NotNullAttribute", RVA="0x10727E4", Offset="0x10727E4")]
		public TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DC58", Offset="0x104DC58")]
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
				[Address(RVA="0x2349E70", Offset="0x2349E70", VA="0x2349E70", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x2349EE0", Offset="0x2349EE0", VA="0x2349EE0", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x2349CB0", Offset="0x2349CB0", VA="0x2349CB0")]
			[DebuggerHidden]
			public <get_ParamTypes>d__2(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x2349CF8", Offset="0x2349CF8", VA="0x2349CF8", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x2349EE8", Offset="0x2349EE8", VA="0x2349EE8", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x2349F7C", Offset="0x2349F7C", VA="0x2349F7C", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x2349E78", Offset="0x2349E78", VA="0x2349E78", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x2349CF4", Offset="0x2349CF4", VA="0x2349CF4", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}