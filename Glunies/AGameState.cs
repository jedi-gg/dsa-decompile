using Il2CppDummyDll;
using System;
using Zenject;

namespace Glunies
{
	public abstract class AGameState : AState, ILoggable<LogCategory>
	{
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106404C", Offset="0x106404C")]
		[FieldOffset(Offset="0x10")]
		private readonly bool <CanBeNavigatedBackInto>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106405C", Offset="0x106405C")]
		[FieldOffset(Offset="0x11")]
		private readonly bool <CanBeDeepLinkedAwayFrom>k__BackingField;

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106406C", Offset="0x106406C")]
		[FieldOffset(Offset="0x12")]
		private readonly bool <ShowGlobalBackdrop>k__BackingField;

		[Attribute(Name="InjectAttribute", RVA="0x106407C", Offset="0x106407C")]
		[FieldOffset(Offset="0x18")]
		private DiContainer _diContainer;

		[FieldOffset(Offset="0x20")]
		protected AFeatureController _featureController;

		[FieldOffset(Offset="0x28")]
		private bool _hasExited;

		public virtual bool CanBeDeepLinkedAwayFrom
		{
			[Address(RVA="0x14F683C", Offset="0x14F683C", VA="0x14F683C", Slot="9")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A2F4", Offset="0x108A2F4")]
			get
			{
				return new bool();
			}
		}

		public virtual bool CanBeNavigatedBackInto
		{
			[Address(RVA="0x14F6834", Offset="0x14F6834", VA="0x14F6834", Slot="8")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A2E4", Offset="0x108A2E4")]
			get
			{
				return new bool();
			}
		}

		public virtual LogCategory LogCategory
		{
			[Address(RVA="0x14F682C", Offset="0x14F682C", VA="0x14F682C", Slot="7")]
			get
			{
				return new LogCategory();
			}
		}

		public virtual bool ShowGlobalBackdrop
		{
			[Address(RVA="0x14F6844", Offset="0x14F6844", VA="0x14F6844", Slot="10")]
			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A304", Offset="0x108A304")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x14F695C", Offset="0x14F695C", VA="0x14F695C")]
		protected AGameState()
		{
		}

		[Address(RVA="0x19A18A8", Offset="0x19A18A8", VA="0x19A18A8")]
		protected void CreateAndRegisterController<T>(ITransitionContext context)
		where T : AFeatureController
		{
		}

		[Address(RVA="0x14F6854", Offset="0x14F6854", VA="0x14F6854", Slot="5")]
		public override void Exiting()
		{
		}

		[Address(RVA="0x14F68A8", Offset="0x14F68A8", VA="0x14F68A8")]
		public GameStateTransitionContext GetCurrentContext()
		{
			return null;
		}

		[Address(RVA="0x14F68B8", Offset="0x14F68B8", VA="0x14F68B8")]
		public bool HandleNewContext(ITransitionContext context)
		{
			return new bool();
		}

		[Address(RVA="0x14F684C", Offset="0x14F684C", VA="0x14F684C")]
		public bool HasExited()
		{
			return new bool();
		}

		[Address(RVA="0x14F6890", Offset="0x14F6890", VA="0x14F6890", Slot="11")]
		public virtual void TickUpdate()
		{
		}
	}
}