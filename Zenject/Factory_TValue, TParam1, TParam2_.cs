using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class Factory<TValue, TParam1, TParam2> : PlaceholderFactory<TValue>, IFactory<TParam1, TParam2, TValue>, IFactory
	{
		protected sealed override IEnumerable<Type> ParamTypes
		{
			[Address(RVA="0x234974C", Offset="0x234974C", VA="0x234974C", Slot="6")]
			[Attribute(Name="IteratorStateMachineAttribute", RVA="0x107270C", Offset="0x107270C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x23497AC", Offset="0x23497AC", VA="0x23497AC")]
		public Factory()
		{
		}

		[Address(RVA="0x2349630", Offset="0x2349630", VA="0x2349630", Slot="7")]
		[Attribute(Name="NotNullAttribute", RVA="0x10726FC", Offset="0x10726FC")]
		public TValue Create(TParam1 param1, TParam2 param2)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DC38", Offset="0x104DC38")]
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
				[Address(RVA="0x23494E8", Offset="0x23494E8", VA="0x23494E8", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x2349558", Offset="0x2349558", VA="0x2349558", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x23493A4", Offset="0x23493A4", VA="0x23493A4")]
			[DebuggerHidden]
			public <get_ParamTypes>d__2(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x23493EC", Offset="0x23493EC", VA="0x23493EC", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x2349560", Offset="0x2349560", VA="0x2349560", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x23495F4", Offset="0x23495F4", VA="0x23495F4", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x23494F0", Offset="0x23494F0", VA="0x23494F0", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x23493E8", Offset="0x23493E8", VA="0x23493E8", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}