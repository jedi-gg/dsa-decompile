using Il2CppDummyDll;
using ModestTree.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ModestTree
{
	public static class LinqExtensions
	{
		[Address(RVA="0x1F64FE4", Offset="0x1F64FE4", VA="0x1F64FE4")]
		public static bool ContainsItem<T>(IEnumerable<T> list, T value)
		{
			return new bool();
		}

		[Address(RVA="0x135B80C", Offset="0x135B80C", VA="0x135B80C")]
		public static IEnumerable<TSource> DistinctBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		[Address(RVA="0x135B820", Offset="0x135B820", VA="0x135B820")]
		public static IEnumerable<TSource> DistinctBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		[Address(RVA="0x135B8FC", Offset="0x135B8FC", VA="0x135B8FC")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1071754", Offset="0x1071754")]
		private static IEnumerable<TSource> DistinctByImpl<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		[Address(RVA="0x1355A64", Offset="0x1355A64", VA="0x1355A64")]
		public static IEnumerable<T> Except<T>(IEnumerable<T> list, T item)
		{
			return null;
		}

		[Address(RVA="0x1389B24", Offset="0x1389B24", VA="0x1389B24")]
		public static void ForEach<T>(IEnumerable<T> first, Action<T> action)
		{
		}

		[Address(RVA="0x1355AFC", Offset="0x1355AFC", VA="0x1355AFC")]
		public static IEnumerable<T> GetDuplicates<T>(IEnumerable<T> list)
		{
			return null;
		}

		[Address(RVA="0x16AB900", Offset="0x16AB900", VA="0x16AB900")]
		public static T GetSingle<T>(object[] objectArray, bool required)
		{
			return null;
		}

		[Address(RVA="0x1F650B4", Offset="0x1F650B4", VA="0x1F650B4")]
		public static bool HasAtLeast<T>(IEnumerable<T> enumerable, int amount)
		{
			return new bool();
		}

		[Address(RVA="0x1F650FC", Offset="0x1F650FC", VA="0x1F650FC")]
		public static bool HasAtMost<T>(IEnumerable<T> enumerable, int amount)
		{
			return new bool();
		}

		[Address(RVA="0x1F65148", Offset="0x1F65148", VA="0x1F65148")]
		public static bool HasLessThan<T>(IEnumerable<T> enumerable, int amount)
		{
			return new bool();
		}

		[Address(RVA="0x1F6515C", Offset="0x1F6515C", VA="0x1F6515C")]
		public static bool HasMoreThan<T>(IEnumerable<T> enumerable, int amount)
		{
			return new bool();
		}

		[Address(RVA="0x1F65170", Offset="0x1F65170", VA="0x1F65170")]
		public static bool IsEmpty<T>(IEnumerable<T> enumerable)
		{
			return new bool();
		}

		[Address(RVA="0x1F651C0", Offset="0x1F651C0", VA="0x1F651C0")]
		public static bool IsLength<T>(IEnumerable<T> enumerable, int amount)
		{
			return new bool();
		}

		[Address(RVA="0x1576AA0", Offset="0x1576AA0", VA="0x1576AA0")]
		public static TSource OnlyOrDefault<TSource>(IEnumerable<TSource> source)
		{
			return null;
		}

		[Address(RVA="0x1355F98", Offset="0x1355F98", VA="0x1355F98")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10714C4", Offset="0x10714C4")]
		public static IEnumerable<T> Prepend<T>(IEnumerable<T> first, IEnumerable<T> second)
		{
			return null;
		}

		[Address(RVA="0x1878AFC", Offset="0x1878AFC", VA="0x1878AFC")]
		public static int RemoveAll<T>(LinkedList<T> list, Func<T, bool> predicate)
		{
			return new int();
		}

		[Address(RVA="0x1356028", Offset="0x1356028", VA="0x1356028")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1071598", Offset="0x1071598")]
		public static IEnumerable<T> ReplaceOrAppend<T>(IEnumerable<T> enumerable, Predicate<T> match, T replacement)
		{
			return null;
		}

		[Address(RVA="0x13560D8", Offset="0x13560D8", VA="0x13560D8")]
		public static IEnumerable<T> Reversed<T>(IEnumerable<T> list)
		{
			return null;
		}

		[Address(RVA="0x16ABC48", Offset="0x16ABC48", VA="0x16ABC48")]
		public static T Second<T>(IEnumerable<T> list)
		{
			return null;
		}

		[Address(RVA="0x16ABC84", Offset="0x16ABC84", VA="0x16ABC84")]
		public static T SecondOrDefault<T>(IEnumerable<T> list)
		{
			return null;
		}

		[Address(RVA="0x135B9AC", Offset="0x135B9AC", VA="0x135B9AC")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1071430", Offset="0x1071430")]
		public static IEnumerable<TSource> TakeUntilInclusive<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return null;
		}

		[Address(RVA="0x135615C", Offset="0x135615C", VA="0x135615C")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x107160C", Offset="0x107160C")]
		public static IEnumerable<T> ToEnumerable<T>(IEnumerator enumerator)
		{
			return null;
		}

		[Address(RVA="0x13560E8", Offset="0x13560E8", VA="0x13560E8")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1071680", Offset="0x1071680")]
		public static IEnumerable<T> ToEnumerable<T>(IEnumerator<T> enumerator)
		{
			return null;
		}

		[Address(RVA="0x13555D8", Offset="0x13555D8", VA="0x13555D8")]
		public static HashSet<T> ToHashSet<T>(IEnumerable<T> enumerable)
		{
			return null;
		}

		[Address(RVA="0x13561D0", Offset="0x13561D0", VA="0x13561D0")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x10717F8", Offset="0x10717F8")]
		public static IEnumerable<T> Zipper<T, A, B>(IEnumerable<A> seqA, IEnumerable<B> seqB, Func<A, B, T> func)
		{
			return null;
		}

		[Address(RVA="0x13556C4", Offset="0x13556C4", VA="0x13556C4")]
		public static IEnumerable<ValuePair<A, B>> Zipper<A, B>(IEnumerable<A> seqA, IEnumerable<B> seqB)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D2A8", Offset="0x104D2A8")]
		[Serializable]
		private sealed class <>c__10<T>
		{
			[FieldOffset(Offset="0x0")]
			public readonly static LinqExtensions.<>c__10<T> <>9;

			[FieldOffset(Offset="0x0")]
			public static Func<T, T> <>9__10_0;

			[FieldOffset(Offset="0x0")]
			public static Func<IGrouping<T, T>, bool> <>9__10_1;

			[FieldOffset(Offset="0x0")]
			public static Func<IGrouping<T, T>, T> <>9__10_2;

			[Address(RVA="0x1D9207C", Offset="0x1D9207C", VA="0x1D9207C")]
			static <>c__10()
			{
			}

			[Address(RVA="0x1D92154", Offset="0x1D92154", VA="0x1D92154")]
			public <>c__10()
			{
			}

			[Address(RVA="0x1D92180", Offset="0x1D92180", VA="0x1D92180")]
			internal T <GetDuplicates>b__10_0(T x)
			{
				return null;
			}

			[Address(RVA="0x1D92188", Offset="0x1D92188", VA="0x1D92188")]
			internal bool <GetDuplicates>b__10_1(IGrouping<T, T> x)
			{
				return new bool();
			}

			[Address(RVA="0x1D921D4", Offset="0x1D921D4", VA="0x1D921D4")]
			internal T <GetDuplicates>b__10_2(IGrouping<T, T> x)
			{
				return null;
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D2E8", Offset="0x104D2E8")]
		[Serializable]
		private sealed class <>c__17<T>
		{
			[FieldOffset(Offset="0x0")]
			public readonly static LinqExtensions.<>c__17<T> <>9;

			[FieldOffset(Offset="0x0")]
			public static Func<object, bool> <>9__17_0;

			[FieldOffset(Offset="0x0")]
			public static Func<object, bool> <>9__17_1;

			[Address(RVA="0x1D92278", Offset="0x1D92278", VA="0x1D92278")]
			static <>c__17()
			{
			}

			[Address(RVA="0x1D92350", Offset="0x1D92350", VA="0x1D92350")]
			public <>c__17()
			{
			}

			[Address(RVA="0x1D9237C", Offset="0x1D9237C", VA="0x1D9237C")]
			internal bool <GetSingle>b__17_0(object x)
			{
				return new bool();
			}

			[Address(RVA="0x1D923C8", Offset="0x1D923C8", VA="0x1D923C8")]
			internal bool <GetSingle>b__17_1(object x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D308", Offset="0x104D308")]
		private sealed class <>c__DisplayClass24_0<T>
		{
			[FieldOffset(Offset="0x0")]
			public T @value;

			[Address(RVA="0x1D92414", Offset="0x1D92414", VA="0x1D92414")]
			public <>c__DisplayClass24_0()
			{
			}

			[Address(RVA="0x1D92440", Offset="0x1D92440", VA="0x1D92440")]
			internal bool <ContainsItem>b__0(T x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D2F8", Offset="0x104D2F8")]
		private sealed class <DistinctByImpl>d__20<TSource, TKey> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x0")]
			private int <>1__state;

			[FieldOffset(Offset="0x0")]
			private TSource <>2__current;

			[FieldOffset(Offset="0x0")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x0")]
			private IEqualityComparer<TKey> comparer;

			[FieldOffset(Offset="0x0")]
			public IEqualityComparer<TKey> <>3__comparer;

			[FieldOffset(Offset="0x0")]
			private IEnumerable<TSource> source;

			[FieldOffset(Offset="0x0")]
			public IEnumerable<TSource> <>3__source;

			[FieldOffset(Offset="0x0")]
			private Func<TSource, TKey> keySelector;

			[FieldOffset(Offset="0x0")]
			public Func<TSource, TKey> <>3__keySelector;

			[FieldOffset(Offset="0x0")]
			private HashSet<TKey> <knownKeys>5__2;

			[FieldOffset(Offset="0x0")]
			private IEnumerator<TSource> <>7__wrap2;

			private TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[Address(RVA="0x1D9290C", Offset="0x1D9290C", VA="0x1D9290C", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1D9297C", Offset="0x1D9297C", VA="0x1D9297C", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1D92454", Offset="0x1D92454", VA="0x1D92454")]
			[DebuggerHidden]
			public <DistinctByImpl>d__20(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1D9284C", Offset="0x1D9284C", VA="0x1D9284C")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x1D924C4", Offset="0x1D924C4", VA="0x1D924C4", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1D92984", Offset="0x1D92984", VA="0x1D92984", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1D92A68", Offset="0x1D92A68", VA="0x1D92A68", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1D92914", Offset="0x1D92914", VA="0x1D92914", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1D92498", Offset="0x1D92498", VA="0x1D92498", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D298", Offset="0x104D298")]
		private sealed class <Prepend>d__4<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x0")]
			private int <>1__state;

			[FieldOffset(Offset="0x0")]
			private T <>2__current;

			[FieldOffset(Offset="0x0")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x0")]
			private IEnumerable<T> second;

			[FieldOffset(Offset="0x0")]
			public IEnumerable<T> <>3__second;

			[FieldOffset(Offset="0x0")]
			private IEnumerable<T> first;

			[FieldOffset(Offset="0x0")]
			public IEnumerable<T> <>3__first;

			[FieldOffset(Offset="0x0")]
			private IEnumerator<T> <>7__wrap1;

			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Address(RVA="0x1D93170", Offset="0x1D93170", VA="0x1D93170", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1D931E0", Offset="0x1D931E0", VA="0x1D931E0", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1D92AA4", Offset="0x1D92AA4", VA="0x1D92AA4")]
			[DebuggerHidden]
			public <Prepend>d__4(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1D92FF0", Offset="0x1D92FF0", VA="0x1D92FF0")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x1D930B0", Offset="0x1D930B0", VA="0x1D930B0")]
			private void <>m__Finally2()
			{
			}

			[Address(RVA="0x1D92B38", Offset="0x1D92B38", VA="0x1D92B38", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1D931E8", Offset="0x1D931E8", VA="0x1D931E8", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1D932B0", Offset="0x1D932B0", VA="0x1D932B0", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1D93178", Offset="0x1D93178", VA="0x1D93178", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1D92AE8", Offset="0x1D92AE8", VA="0x1D92AE8", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D2B8", Offset="0x104D2B8")]
		private sealed class <ReplaceOrAppend>d__11<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x0")]
			private int <>1__state;

			[FieldOffset(Offset="0x0")]
			private T <>2__current;

			[FieldOffset(Offset="0x0")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x0")]
			private IEnumerable<T> enumerable;

			[FieldOffset(Offset="0x0")]
			public IEnumerable<T> <>3__enumerable;

			[FieldOffset(Offset="0x0")]
			private Predicate<T> match;

			[FieldOffset(Offset="0x0")]
			public Predicate<T> <>3__match;

			[FieldOffset(Offset="0x0")]
			private T replacement;

			[FieldOffset(Offset="0x0")]
			public T <>3__replacement;

			[FieldOffset(Offset="0x0")]
			private bool <replaced>5__2;

			[FieldOffset(Offset="0x0")]
			private IEnumerator<T> <>7__wrap2;

			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Address(RVA="0x1D93760", Offset="0x1D93760", VA="0x1D93760", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1D937D0", Offset="0x1D937D0", VA="0x1D937D0", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1D932EC", Offset="0x1D932EC", VA="0x1D932EC")]
			[DebuggerHidden]
			public <ReplaceOrAppend>d__11(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1D936A0", Offset="0x1D936A0", VA="0x1D936A0")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x1D9336C", Offset="0x1D9336C", VA="0x1D9336C", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1D937D8", Offset="0x1D937D8", VA="0x1D937D8", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1D938BC", Offset="0x1D938BC", VA="0x1D938BC", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1D93768", Offset="0x1D93768", VA="0x1D93768", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1D93330", Offset="0x1D93330", VA="0x1D93330", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D288", Offset="0x104D288")]
		private sealed class <TakeUntilInclusive>d__1<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x0")]
			private int <>1__state;

			[FieldOffset(Offset="0x0")]
			private TSource <>2__current;

			[FieldOffset(Offset="0x0")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x0")]
			private IEnumerable<TSource> source;

			[FieldOffset(Offset="0x0")]
			public IEnumerable<TSource> <>3__source;

			[FieldOffset(Offset="0x0")]
			private Func<TSource, bool> predicate;

			[FieldOffset(Offset="0x0")]
			public Func<TSource, bool> <>3__predicate;

			[FieldOffset(Offset="0x0")]
			private IEnumerator<TSource> <>7__wrap1;

			[FieldOffset(Offset="0x0")]
			private TSource <item>5__3;

			private TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[Address(RVA="0x1D93D44", Offset="0x1D93D44", VA="0x1D93D44", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1D93DB4", Offset="0x1D93DB4", VA="0x1D93DB4", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1D938F8", Offset="0x1D938F8", VA="0x1D938F8")]
			[DebuggerHidden]
			public <TakeUntilInclusive>d__1(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1D93C84", Offset="0x1D93C84", VA="0x1D93C84")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x1D93968", Offset="0x1D93968", VA="0x1D93968", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1D93DBC", Offset="0x1D93DBC", VA="0x1D93DBC", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1D93E84", Offset="0x1D93E84", VA="0x1D93E84", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1D93D4C", Offset="0x1D93D4C", VA="0x1D93D4C", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1D9393C", Offset="0x1D9393C", VA="0x1D9393C", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D2C8", Offset="0x104D2C8")]
		private sealed class <ToEnumerable>d__12<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x0")]
			private int <>1__state;

			[FieldOffset(Offset="0x0")]
			private T <>2__current;

			[FieldOffset(Offset="0x0")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x0")]
			private IEnumerator enumerator;

			[FieldOffset(Offset="0x0")]
			public IEnumerator <>3__enumerator;

			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Address(RVA="0x1D940F8", Offset="0x1D940F8", VA="0x1D940F8", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1D94168", Offset="0x1D94168", VA="0x1D94168", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1D93EC0", Offset="0x1D93EC0", VA="0x1D93EC0")]
			[DebuggerHidden]
			public <ToEnumerable>d__12(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1D93F08", Offset="0x1D93F08", VA="0x1D93F08", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1D94170", Offset="0x1D94170", VA="0x1D94170", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1D9421C", Offset="0x1D9421C", VA="0x1D9421C", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1D94100", Offset="0x1D94100", VA="0x1D94100", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1D93F04", Offset="0x1D93F04", VA="0x1D93F04", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D2D8", Offset="0x104D2D8")]
		private sealed class <ToEnumerable>d__13<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x0")]
			private int <>1__state;

			[FieldOffset(Offset="0x0")]
			private T <>2__current;

			[FieldOffset(Offset="0x0")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x0")]
			private IEnumerator<T> enumerator;

			[FieldOffset(Offset="0x0")]
			public IEnumerator<T> <>3__enumerator;

			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Address(RVA="0x1D9441C", Offset="0x1D9441C", VA="0x1D9441C", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1D9448C", Offset="0x1D9448C", VA="0x1D9448C", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1D94258", Offset="0x1D94258", VA="0x1D94258")]
			[DebuggerHidden]
			public <ToEnumerable>d__13(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1D942A0", Offset="0x1D942A0", VA="0x1D942A0", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1D94494", Offset="0x1D94494", VA="0x1D94494", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1D94540", Offset="0x1D94540", VA="0x1D94540", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1D94424", Offset="0x1D94424", VA="0x1D94424", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1D9429C", Offset="0x1D9429C", VA="0x1D9429C", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D318", Offset="0x104D318")]
		private sealed class <Zipper>d__25<T, A, B> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x0")]
			private int <>1__state;

			[FieldOffset(Offset="0x0")]
			private T <>2__current;

			[FieldOffset(Offset="0x0")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x0")]
			private IEnumerable<A> seqA;

			[FieldOffset(Offset="0x0")]
			public IEnumerable<A> <>3__seqA;

			[FieldOffset(Offset="0x0")]
			private IEnumerable<B> seqB;

			[FieldOffset(Offset="0x0")]
			public IEnumerable<B> <>3__seqB;

			[FieldOffset(Offset="0x0")]
			private Func<A, B, T> func;

			[FieldOffset(Offset="0x0")]
			public Func<A, B, T> <>3__func;

			[FieldOffset(Offset="0x0")]
			private IEnumerator<A> <iteratorA>5__2;

			[FieldOffset(Offset="0x0")]
			private IEnumerator<B> <iteratorB>5__3;

			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Address(RVA="0x1D94CC8", Offset="0x1D94CC8", VA="0x1D94CC8", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x1D94D38", Offset="0x1D94D38", VA="0x1D94D38", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x1D9457C", Offset="0x1D9457C", VA="0x1D9457C")]
			[DebuggerHidden]
			public <Zipper>d__25(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x1D94B48", Offset="0x1D94B48", VA="0x1D94B48")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x1D94C08", Offset="0x1D94C08", VA="0x1D94C08")]
			private void <>m__Finally2()
			{
			}

			[Address(RVA="0x1D9465C", Offset="0x1D9465C", VA="0x1D9465C", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x1D94D40", Offset="0x1D94D40", VA="0x1D94D40", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1D94E24", Offset="0x1D94E24", VA="0x1D94E24", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x1D94CD0", Offset="0x1D94CD0", VA="0x1D94CD0", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x1D945C0", Offset="0x1D945C0", VA="0x1D945C0", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}