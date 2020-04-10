using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zenject
{
	public class Factory<TValue, TParam1, TParam2, TParam3> : PlaceholderFactory<TValue>, IFactory<TParam1, TParam2, TParam3, TValue>, IFactory
	{
		protected sealed override IEnumerable<Type> ParamTypes
		{
			[Address(RVA="0x2349C14", Offset="0x2349C14", VA="0x2349C14", Slot="6")]
			[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1072780", Offset="0x1072780")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2349C74", Offset="0x2349C74", VA="0x2349C74")]
		public Factory()
		{
		}

		[Address(RVA="0x2349AB4", Offset="0x2349AB4", VA="0x2349AB4", Slot="7")]
		[Attribute(Name="NotNullAttribute", RVA="0x1072770", Offset="0x1072770")]
		public TValue Create(TParam1 param1, TParam2 param2, TParam3 param3)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104DC48", Offset="0x104DC48")]
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
				[Address(RVA="0x234996C", Offset="0x234996C", VA="0x234996C", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x23499DC", Offset="0x23499DC", VA="0x23499DC", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x23497E8", Offset="0x23497E8", VA="0x23497E8")]
			[DebuggerHidden]
			public <get_ParamTypes>d__2(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x2349830", Offset="0x2349830", VA="0x2349830", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x23499E4", Offset="0x23499E4", VA="0x23499E4", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x2349A78", Offset="0x2349A78", VA="0x2349A78", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x2349974", Offset="0x2349974", VA="0x2349974", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x234982C", Offset="0x234982C", VA="0x234982C", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}