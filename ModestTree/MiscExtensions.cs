using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ModestTree
{
	public static class MiscExtensions
	{
		[Address(RVA="0x12F63C0", Offset="0x12F63C0", VA="0x12F63C0")]
		public static string Fmt(string s, params object[] args)
		{
			return null;
		}

		[Address(RVA="0x157A4A4", Offset="0x157A4A4", VA="0x157A4A4")]
		public static TVal GetValueAndRemove<TVal, TKey>(IDictionary<TKey, TVal> dictionary, TKey key)
		{
			return null;
		}

		[Address(RVA="0x12F63C8", Offset="0x12F63C8", VA="0x12F63C8")]
		public static string Join(IEnumerable<string> values, string separator)
		{
			return null;
		}

		[Address(RVA="0x1389F08", Offset="0x1389F08", VA="0x1389F08")]
		public static void RemoveWithConfirm<T>(IList<T> list, T item)
		{
		}

		[Address(RVA="0x1389FC4", Offset="0x1389FC4", VA="0x1389FC4")]
		public static void RemoveWithConfirm<T>(LinkedList<T> list, T item)
		{
		}

		[Address(RVA="0x1389DF8", Offset="0x1389DF8", VA="0x1389DF8")]
		public static void RemoveWithConfirm<TKey, TVal>(IDictionary<TKey, TVal> dictionary, TKey key)
		{
		}

		[Address(RVA="0x1389EB4", Offset="0x1389EB4", VA="0x1389EB4")]
		public static void RemoveWithConfirm<T>(HashSet<T> set, T item)
		{
		}

		[Address(RVA="0x1356280", Offset="0x1356280", VA="0x1356280")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10718C4", Offset="0x10718C4")]
		public static IEnumerable<T> Yield<T>(T item)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D328", Offset="0x104D328")]
		private sealed class <Yield>d__1<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x0")]
			private int <>1__state;

			[FieldOffset(Offset="0x0")]
			private T <>2__current;

			[FieldOffset(Offset="0x0")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x0")]
			private T item;

			[FieldOffset(Offset="0x0")]
			public T <>3__item;

			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Address(RVA="0x1D94EE8", Offset="0x1D94EE8", VA="0x1D94EE8", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1D94F58", Offset="0x1D94F58", VA="0x1D94F58", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1D94E60", Offset="0x1D94E60", VA="0x1D94E60")]
			[DebuggerHidden]
			public <Yield>d__1(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1D94EA8", Offset="0x1D94EA8", VA="0x1D94EA8", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1D94F60", Offset="0x1D94F60", VA="0x1D94F60", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1D9500C", Offset="0x1D9500C", VA="0x1D9500C", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1D94EF0", Offset="0x1D94EF0", VA="0x1D94EF0", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1D94EA4", Offset="0x1D94EA4", VA="0x1D94EA4", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}