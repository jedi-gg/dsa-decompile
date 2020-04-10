using Il2CppDummyDll;
using System;

namespace Glunies
{
	public class TabViewController<T> : IDispatchHandler<DUiTabGroupAction>, IDispatchHandler
	where T : ATabView, new()
	{
		[Attribute(Name="InjectAttribute", RVA="0x1064478", Offset="0x1064478")]
		[FieldOffset(Offset="0x0")]
		protected DispatchSystem _dispatchSystem;

		[Attribute(Name="InjectAttribute", RVA="0x1064488", Offset="0x1064488")]
		[FieldOffset(Offset="0x0")]
		protected ViewController _viewController;

		[FieldOffset(Offset="0x0")]
		protected T _view;

		[FieldOffset(Offset="0x0")]
		private bool _isShutdown;

		[Address(RVA="0x1C02864", Offset="0x1C02864", VA="0x1C02864")]
		public TabViewController()
		{
		}

		[Address(RVA="0x1C02738", Offset="0x1C02738", VA="0x1C02738", Slot="4")]
		public void HandleDispatchAction(DUiTabGroupAction action)
		{
		}

		[Address(RVA="0x1C02510", Offset="0x1C02510", VA="0x1C02510")]
		public void Initialize(int initialSelectedTab, Action finished)
		{
		}

		[Address(RVA="0x1C02824", Offset="0x1C02824", VA="0x1C02824", Slot="5")]
		protected virtual void InitializeView(int initialSelectedTab)
		{
		}

		[Address(RVA="0x1C0285C", Offset="0x1C0285C", VA="0x1C0285C")]
		private bool IsShutdown()
		{
			return new bool();
		}

		[Address(RVA="0x1C026F8", Offset="0x1C026F8", VA="0x1C026F8")]
		public void RevertToPreviousSelectedIndex()
		{
		}

		[Address(RVA="0x1C02690", Offset="0x1C02690", VA="0x1C02690")]
		public void Shutdown()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10510A8", Offset="0x10510A8")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset="0x0")]
			public TabViewController<T> <>4__this;

			[FieldOffset(Offset="0x0")]
			public int initialSelectedTab;

			[FieldOffset(Offset="0x0")]
			public Action finished;

			[Address(RVA="0x1C0242C", Offset="0x1C0242C", VA="0x1C0242C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Address(RVA="0x1C02458", Offset="0x1C02458", VA="0x1C02458")]
			internal void <Initialize>b__0(T view)
			{
			}
		}
	}
}