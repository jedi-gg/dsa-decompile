using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class Factory<TValue, TParam1, TParam2, TParam3, TParam4, TParam5> : PlaceholderFactory<TValue>, IFactory<TParam1, TParam2, TParam3, TParam4, TParam5, TValue>, IFactory
	{
		protected sealed override IEnumerable<Type> ParamTypes
		{
			[Address(RVA="0x234A714", Offset="0x234A714", VA="0x234A714", Slot="6")]
			[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1072868", Offset="0x1072868")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x234A774", Offset="0x234A774", VA="0x234A774")]
		public Factory()
		{
		}

		[Address(RVA="0x234A534", Offset="0x234A534", VA="0x234A534", Slot="7")]
		[Attribute(Name="NotNullAttribute", RVA="0x1072858", Offset="0x1072858")]
		public TValue Create(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DC68", Offset="0x104DC68")]
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
				[Address(RVA="0x234A3EC", Offset="0x234A3EC", VA="0x234A3EC", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x234A45C", Offset="0x234A45C", VA="0x234A45C", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x234A1F0", Offset="0x234A1F0", VA="0x234A1F0")]
			[DebuggerHidden]
			public <get_ParamTypes>d__2(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x234A238", Offset="0x234A238", VA="0x234A238", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x234A464", Offset="0x234A464", VA="0x234A464", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x234A4F8", Offset="0x234A4F8", VA="0x234A4F8", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x234A3F4", Offset="0x234A3F4", VA="0x234A3F4", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x234A234", Offset="0x234A234", VA="0x234A234", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}