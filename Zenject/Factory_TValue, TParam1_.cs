using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class Factory<TValue, TParam1> : PlaceholderFactory<TValue>, IFactory<TParam1, TValue>, IFactory
	{
		protected sealed override IEnumerable<Type> ParamTypes
		{
			[Address(RVA="0x2349308", Offset="0x2349308", VA="0x2349308", Slot="6")]
			[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1072698", Offset="0x1072698")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2349368", Offset="0x2349368", VA="0x2349368")]
		public Factory()
		{
		}

		[Address(RVA="0x2349230", Offset="0x2349230", VA="0x2349230", Slot="7")]
		[Attribute(Name="NotNullAttribute", RVA="0x1072688", Offset="0x1072688")]
		public TValue Create(TParam1 param)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DC28", Offset="0x104DC28")]
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
				[Address(RVA="0x23490E8", Offset="0x23490E8", VA="0x23490E8", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x2349158", Offset="0x2349158", VA="0x2349158", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x2348FE8", Offset="0x2348FE8", VA="0x2348FE8")]
			[DebuggerHidden]
			public <get_ParamTypes>d__2(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x2349030", Offset="0x2349030", VA="0x2349030", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x2349160", Offset="0x2349160", VA="0x2349160", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x23491F4", Offset="0x23491F4", VA="0x23491F4", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x23490F0", Offset="0x23490F0", VA="0x23490F0", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x234902C", Offset="0x234902C", VA="0x234902C", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}