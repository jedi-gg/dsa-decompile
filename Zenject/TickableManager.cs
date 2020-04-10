using Il2CppDummyDll;
using ModestTree.Util;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class TickableManager
	{
		[Attribute(Name="InjectAttribute", RVA="0x10607A4", Offset="0x10607A4")]
		[FieldOffset(Offset="0x10")]
		private readonly Zenject.Lazy<List<TickableManager>> _parents;

		[Attribute(Name="InjectAttribute", RVA="0x10607EC", Offset="0x10607EC")]
		[FieldOffset(Offset="0x18")]
		private readonly List<ITickable> _tickables;

		[Attribute(Name="InjectAttribute", RVA="0x1060834", Offset="0x1060834")]
		[FieldOffset(Offset="0x20")]
		private readonly List<IFixedTickable> _fixedTickables;

		[Attribute(Name="InjectAttribute", RVA="0x106087C", Offset="0x106087C")]
		[FieldOffset(Offset="0x28")]
		private readonly List<ILateTickable> _lateTickables;

		[Attribute(Name="InjectAttribute", RVA="0x10608C4", Offset="0x10608C4")]
		[FieldOffset(Offset="0x30")]
		private readonly List<ValuePair<Type, int>> _priorities;

		[Attribute(Name="InjectAttribute", RVA="0x106090C", Offset="0x106090C")]
		[FieldOffset(Offset="0x38")]
		private readonly List<ValuePair<Type, int>> _fixedPriorities;

		[Attribute(Name="InjectAttribute", RVA="0x1060970", Offset="0x1060970")]
		[FieldOffset(Offset="0x40")]
		private readonly List<ValuePair<Type, int>> _latePriorities;

		[FieldOffset(Offset="0x48")]
		private readonly TickablesTaskUpdater _updater;

		[FieldOffset(Offset="0x50")]
		private readonly FixedTickablesTaskUpdater _fixedUpdater;

		[FieldOffset(Offset="0x58")]
		private readonly LateTickablesTaskUpdater _lateUpdater;

		[FieldOffset(Offset="0x60")]
		private bool _isPaused;

		public bool IsPaused
		{
			[Address(RVA="0x233A45C", Offset="0x233A45C", VA="0x233A45C")]
			get
			{
				return new bool();
			}
		}

		public IEnumerable<ITickable> Tickables
		{
			[Address(RVA="0x233A454", Offset="0x233A454", VA="0x233A454")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x233A360", Offset="0x233A360", VA="0x233A360")]
		[Attribute(Name="InjectAttribute", RVA="0x1073DBC", Offset="0x1073DBC")]
		public TickableManager()
		{
		}

		[Address(RVA="0x233B954", Offset="0x233B954", VA="0x233B954")]
		public void Add(ITickable tickable, int priority)
		{
		}

		[Address(RVA="0x233B9CC", Offset="0x233B9CC", VA="0x233B9CC")]
		public void Add(ITickable tickable)
		{
		}

		[Address(RVA="0x233BA54", Offset="0x233BA54", VA="0x233BA54")]
		public void AddFixed(IFixedTickable tickable, int priority)
		{
		}

		[Address(RVA="0x233BACC", Offset="0x233BACC", VA="0x233BACC")]
		public void AddFixed(IFixedTickable tickable)
		{
		}

		[Address(RVA="0x233B9D4", Offset="0x233B9D4", VA="0x233B9D4")]
		public void AddLate(ILateTickable tickable, int priority)
		{
		}

		[Address(RVA="0x233BA4C", Offset="0x233BA4C", VA="0x233BA4C")]
		public void AddLate(ILateTickable tickable)
		{
		}

		[Address(RVA="0x233BD2C", Offset="0x233BD2C", VA="0x233BD2C")]
		public void FixedUpdate()
		{
		}

		[Address(RVA="0x233AC3C", Offset="0x233AC3C", VA="0x233AC3C")]
		private void InitFixedTickables()
		{
		}

		[Address(RVA="0x233A590", Offset="0x233A590", VA="0x233A590")]
		[Attribute(Name="InjectAttribute", RVA="0x1073DCC", Offset="0x1073DCC")]
		public void Initialize()
		{
		}

		[Address(RVA="0x233B2BC", Offset="0x233B2BC", VA="0x233B2BC")]
		private void InitLateTickables()
		{
		}

		[Address(RVA="0x233A5BC", Offset="0x233A5BC", VA="0x233A5BC")]
		private void InitTickables()
		{
		}

		[Address(RVA="0x233BDC8", Offset="0x233BDC8", VA="0x233BDC8")]
		public void LateUpdate()
		{
		}

		[Address(RVA="0x233BE64", Offset="0x233BE64", VA="0x233BE64")]
		public void Pause()
		{
		}

		[Address(RVA="0x233BB40", Offset="0x233BB40", VA="0x233BB40")]
		public void Remove(ITickable tickable)
		{
		}

		[Address(RVA="0x233BC20", Offset="0x233BC20", VA="0x233BC20")]
		public void RemoveFixed(IFixedTickable tickable)
		{
		}

		[Address(RVA="0x233BBB0", Offset="0x233BBB0", VA="0x233BBB0")]
		public void RemoveLate(ILateTickable tickable)
		{
		}

		[Address(RVA="0x233BE70", Offset="0x233BE70", VA="0x233BE70")]
		public void Resume()
		{
		}

		[Address(RVA="0x233BC90", Offset="0x233BC90", VA="0x233BC90")]
		public void Update()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E188", Offset="0x104E188")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static TickableManager.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Func<ValuePair<Type, int>, Type> <>9__17_0;

			[FieldOffset(Offset="0x10")]
			public static Func<ValuePair<Type, int>, int> <>9__17_2;

			[FieldOffset(Offset="0x18")]
			public static Func<ValuePair<Type, int>, Type> <>9__18_0;

			[FieldOffset(Offset="0x20")]
			public static Func<ValuePair<Type, int>, int> <>9__18_2;

			[FieldOffset(Offset="0x28")]
			public static Func<ValuePair<Type, int>, Type> <>9__19_0;

			[FieldOffset(Offset="0x30")]
			public static Func<ValuePair<Type, int>, int> <>9__19_2;

			[Address(RVA="0x233BE78", Offset="0x233BE78", VA="0x233BE78")]
			static <>c()
			{
			}

			[Address(RVA="0x233BEDC", Offset="0x233BEDC", VA="0x233BEDC")]
			public <>c()
			{
			}

			[Address(RVA="0x233BEE4", Offset="0x233BEE4", VA="0x233BEE4")]
			internal Type <InitFixedTickables>b__17_0(ValuePair<Type, int> x)
			{
				return null;
			}

			[Address(RVA="0x233BF10", Offset="0x233BF10", VA="0x233BF10")]
			internal int <InitFixedTickables>b__17_2(ValuePair<Type, int> x)
			{
				return new int();
			}

			[Address(RVA="0x233BF94", Offset="0x233BF94", VA="0x233BF94")]
			internal Type <InitLateTickables>b__19_0(ValuePair<Type, int> x)
			{
				return null;
			}

			[Address(RVA="0x233BFC0", Offset="0x233BFC0", VA="0x233BFC0")]
			internal int <InitLateTickables>b__19_2(ValuePair<Type, int> x)
			{
				return new int();
			}

			[Address(RVA="0x233BF3C", Offset="0x233BF3C", VA="0x233BF3C")]
			internal Type <InitTickables>b__18_0(ValuePair<Type, int> x)
			{
				return null;
			}

			[Address(RVA="0x233BF68", Offset="0x233BF68", VA="0x233BF68")]
			internal int <InitTickables>b__18_2(ValuePair<Type, int> x)
			{
				return new int();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E178", Offset="0x104E178")]
		private sealed class <>c__DisplayClass17_0
		{
			[FieldOffset(Offset="0x10")]
			public IFixedTickable tickable;

			[Address(RVA="0x233B93C", Offset="0x233B93C", VA="0x233B93C")]
			public <>c__DisplayClass17_0()
			{
			}

			[Address(RVA="0x233BFEC", Offset="0x233BFEC", VA="0x233BFEC")]
			internal bool <InitFixedTickables>b__1(ValuePair<Type, int> x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E198", Offset="0x104E198")]
		private sealed class <>c__DisplayClass18_0
		{
			[FieldOffset(Offset="0x10")]
			public ITickable tickable;

			[Address(RVA="0x233B944", Offset="0x233B944", VA="0x233B944")]
			public <>c__DisplayClass18_0()
			{
			}

			[Address(RVA="0x233C040", Offset="0x233C040", VA="0x233C040")]
			internal bool <InitTickables>b__1(ValuePair<Type, int> x)
			{
				return new bool();
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104E1A8", Offset="0x104E1A8")]
		private sealed class <>c__DisplayClass19_0
		{
			[FieldOffset(Offset="0x10")]
			public ILateTickable tickable;

			[Address(RVA="0x233B94C", Offset="0x233B94C", VA="0x233B94C")]
			public <>c__DisplayClass19_0()
			{
			}

			[Address(RVA="0x233C094", Offset="0x233C094", VA="0x233C094")]
			internal bool <InitLateTickables>b__1(ValuePair<Type, int> x)
			{
				return new bool();
			}
		}
	}
}