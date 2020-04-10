using Glunies;
using Il2CppDummyDll;
using System;

namespace Glunies.Inferno
{
	public abstract class AInfernoController
	{
		[Attribute(Name="InjectAttribute", RVA="0x1064B00", Offset="0x1064B00")]
		[FieldOffset(Offset="0x10")]
		protected ViewController _viewController;

		[FieldOffset(Offset="0x18")]
		protected AView _view;

		[FieldOffset(Offset="0x20")]
		private bool _isShutdown;

		[Address(RVA="0x142C228", Offset="0x142C228", VA="0x142C228")]
		protected AInfernoController()
		{
		}

		public abstract void Initialize(Action finished);

		[Address(RVA="0x142C220", Offset="0x142C220", VA="0x142C220")]
		protected bool IsShutdown()
		{
			return new bool();
		}

		[Address(RVA="0x28C60CC", Offset="0x28C60CC", VA="0x28C60CC")]
		protected void LoadView<T>(Action<T> finished, bool startActive = true)
		where T : AView, new()
		{
		}

		[Address(RVA="0x142C1C4", Offset="0x142C1C4", VA="0x142C1C4", Slot="5")]
		public virtual void Shutdown()
		{
		}

		[Address(RVA="0x142C21C", Offset="0x142C21C", VA="0x142C21C", Slot="6")]
		public virtual void TickUpdate()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051248", Offset="0x1051248")]
		private sealed class <>c__DisplayClass4_0<T>
		where T : AView, new()
		{
			[FieldOffset(Offset="0x0")]
			public AInfernoController <>4__this;

			[FieldOffset(Offset="0x0")]
			public Action<T> finished;

			[Address(RVA="0x1C01644", Offset="0x1C01644", VA="0x1C01644")]
			public <>c__DisplayClass4_0()
			{
			}

			[Address(RVA="0x1C01670", Offset="0x1C01670", VA="0x1C01670")]
			internal void <LoadView>b__0(T view)
			{
			}
		}
	}
}