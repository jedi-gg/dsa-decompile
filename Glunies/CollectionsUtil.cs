using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Glunies
{
	public static class CollectionsUtil
	{
		[FieldOffset(Offset="0x0")]
		private readonly static Random s_random;

		[Address(RVA="0x1420970", Offset="0x1420970", VA="0x1420970")]
		static CollectionsUtil()
		{
		}

		[Address(RVA="0x19A21FC", Offset="0x19A21FC", VA="0x19A21FC")]
		public static void InsertionSort<T>(IList<T> list, Comparison<T> comparison)
		{
		}

		[Address(RVA="0x13559F0", Offset="0x13559F0", VA="0x13559F0")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x108A4C4", Offset="0x108A4C4")]
		public static IEnumerable<T> RandomlyIterateThroughList<T>(IList<T> list)
		{
			return null;
		}

		[Address(RVA="0x19A2AC8", Offset="0x19A2AC8", VA="0x19A2AC8")]
		public static void Shuffle<T>(IList<T> list)
		{
		}

		[Address(RVA="0x19A2E54", Offset="0x19A2E54", VA="0x19A2E54")]
		public static void Swap<T>(IList<T> list, int leftIndex, int rightIndex)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051108", Offset="0x1051108")]
		private sealed class <RandomlyIterateThroughList>d__3<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x0")]
			private int <>1__state;

			[FieldOffset(Offset="0x0")]
			private T <>2__current;

			[FieldOffset(Offset="0x0")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x0")]
			private IList<T> list;

			[FieldOffset(Offset="0x0")]
			public IList<T> <>3__list;

			[FieldOffset(Offset="0x0")]
			private List<int> <randomIndices>5__2;

			[FieldOffset(Offset="0x0")]
			private int <i>5__3;

			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Address(RVA="0x1C00A04", Offset="0x1C00A04", VA="0x1C00A04", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1C00A80", Offset="0x1C00A80", VA="0x1C00A80", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1C00644", Offset="0x1C00644", VA="0x1C00644")]
			[DebuggerHidden]
			public <RandomlyIterateThroughList>d__3(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1C0068C", Offset="0x1C0068C", VA="0x1C0068C", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1C00AD8", Offset="0x1C00AD8", VA="0x1C00AD8", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1C00B84", Offset="0x1C00B84", VA="0x1C00B84", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1C00A18", Offset="0x1C00A18", VA="0x1C00A18", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1C00688", Offset="0x1C00688", VA="0x1C00688", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}