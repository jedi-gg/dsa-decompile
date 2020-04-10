using Il2CppDummyDll;
using ModestTree.Util;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class DisposableManager : IDisposable
	{
		[FieldOffset(Offset="0x10")]
		private readonly List<DisposableManager.DisposableInfo> _disposables;

		[FieldOffset(Offset="0x18")]
		private readonly List<DisposableManager.LateDisposableInfo> _lateDisposables;

		[FieldOffset(Offset="0x20")]
		private bool _disposed;

		[FieldOffset(Offset="0x21")]
		private bool _lateDisposed;

		[Address(RVA="0x1832738", Offset="0x1832738", VA="0x1832738")]
		[Attribute(Name="InjectAttribute", RVA="0x1073D8C", Offset="0x1073D8C")]
		public DisposableManager([Attribute(Name="InjectAttribute", RVA="0x10912A4", Offset="0x10912A4")] List<IDisposable> disposables, [Attribute(Name="InjectAttribute", RVA="0x10912EC", Offset="0x10912EC")] List<ValuePair<Type, int>> priorities, [Attribute(Name="InjectAttribute", RVA="0x1091334", Offset="0x1091334")] List<ILateDisposable> lateDisposables, [Attribute(Name="InjectAttribute", RVA="0x109137C", Offset="0x109137C")] List<ValuePair<Type, int>> latePriorities)
		{
		}

		[Address(RVA="0x1832E84", Offset="0x1832E84", VA="0x1832E84")]
		public void Add(IDisposable disposable)
		{
		}

		[Address(RVA="0x1832E8C", Offset="0x1832E8C", VA="0x1832E8C")]
		public void Add(IDisposable disposable, int priority)
		{
		}

		[Address(RVA="0x183342C", Offset="0x183342C", VA="0x183342C", Slot="4")]
		public void Dispose()
		{
		}

		[Address(RVA="0x1833018", Offset="0x1833018", VA="0x1833018")]
		public void LateDispose()
		{
		}

		[Address(RVA="0x1832F24", Offset="0x1832F24", VA="0x1832F24")]
		public void Remove(IDisposable disposable)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E0F8", Offset="0x104E0F8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static DisposableManager.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<ValuePair<Type, int>, int> <>9__4_1;

			[FieldOffset(Offset="0x10")]
			public static Func<ValuePair<Type, int>, int> <>9__4_3;

			[FieldOffset(Offset="0x18")]
			public static Func<DisposableManager.LateDisposableInfo, int> <>9__8_0;

			[FieldOffset(Offset="0x20")]
			public static Func<DisposableManager.DisposableInfo, int> <>9__9_0;

			[Address(RVA="0x1833840", Offset="0x1833840", VA="0x1833840")]
			static <>c()
			{
			}

			[Address(RVA="0x18338A4", Offset="0x18338A4", VA="0x18338A4")]
			public <>c()
			{
			}

			[Address(RVA="0x18338AC", Offset="0x18338AC", VA="0x18338AC")]
			internal int <.ctor>b__4_1(ValuePair<Type, int> x)
			{
				return new int();
			}

			[Address(RVA="0x18338D8", Offset="0x18338D8", VA="0x18338D8")]
			internal int <.ctor>b__4_3(ValuePair<Type, int> x)
			{
				return new int();
			}

			[Address(RVA="0x1833930", Offset="0x1833930", VA="0x1833930")]
			internal int <Dispose>b__9_0(DisposableManager.DisposableInfo x)
			{
				return new int();
			}

			[Address(RVA="0x1833904", Offset="0x1833904", VA="0x1833904")]
			internal int <LateDispose>b__8_0(DisposableManager.LateDisposableInfo x)
			{
				return new int();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E0D8", Offset="0x104E0D8")]
		private sealed class <>c__DisplayClass4_0
		{
			[FieldOffset(Offset="0x10")]
			public IDisposable disposable;

			[Address(RVA="0x1832DFC", Offset="0x1832DFC", VA="0x1832DFC")]
			public <>c__DisplayClass4_0()
			{
			}

			[Address(RVA="0x183395C", Offset="0x183395C", VA="0x183395C")]
			internal bool <.ctor>b__0(ValuePair<Type, int> x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E0E8", Offset="0x104E0E8")]
		private sealed class <>c__DisplayClass4_1
		{
			[FieldOffset(Offset="0x10")]
			public ILateDisposable lateDisposable;

			[Address(RVA="0x1832E40", Offset="0x1832E40", VA="0x1832E40")]
			public <>c__DisplayClass4_1()
			{
			}

			[Address(RVA="0x18339B0", Offset="0x18339B0", VA="0x18339B0")]
			internal bool <.ctor>b__2(ValuePair<Type, int> x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E108", Offset="0x104E108")]
		private sealed class <>c__DisplayClass7_0
		{
			[FieldOffset(Offset="0x10")]
			public IDisposable disposable;

			[Address(RVA="0x1833010", Offset="0x1833010", VA="0x1833010")]
			public <>c__DisplayClass7_0()
			{
			}

			[Address(RVA="0x1833A04", Offset="0x1833A04", VA="0x1833A04")]
			internal bool <Remove>b__0(DisposableManager.DisposableInfo x)
			{
				return new bool();
			}
		}

		private class DisposableInfo
		{
			[FieldOffset(Offset="0x10")]
			public IDisposable Disposable;

			[FieldOffset(Offset="0x18")]
			public int Priority;

			[Address(RVA="0x1832E04", Offset="0x1832E04", VA="0x1832E04")]
			public DisposableInfo(IDisposable disposable, int priority)
			{
			}
		}

		private class LateDisposableInfo
		{
			[FieldOffset(Offset="0x10")]
			public ILateDisposable LateDisposable;

			[FieldOffset(Offset="0x18")]
			public int Priority;

			[Address(RVA="0x1832E48", Offset="0x1832E48", VA="0x1832E48")]
			public LateDisposableInfo(ILateDisposable lateDisposable, int priority)
			{
			}
		}
	}
}