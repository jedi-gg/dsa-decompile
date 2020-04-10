using Il2CppDummyDll;
using System;
using System.Diagnostics;

namespace Zenject
{
	[DebuggerStepThrough]
	public class Kernel : IInitializable, IDisposable, ITickable, ILateTickable, IFixedTickable, ILateDisposable
	{
		[Attribute(Name="InjectLocalAttribute", RVA="0x1060744", Offset="0x1060744")]
		[FieldOffset(Offset="0x10")]
		private TickableManager _tickableManager;

		[Attribute(Name="InjectLocalAttribute", RVA="0x1060754", Offset="0x1060754")]
		[FieldOffset(Offset="0x18")]
		private InitializableManager _initializableManager;

		[Attribute(Name="InjectLocalAttribute", RVA="0x1060764", Offset="0x1060764")]
		[FieldOffset(Offset="0x20")]
		private DisposableManager _disposablesManager;

		[Address(RVA="0x183D1F4", Offset="0x183D1F4", VA="0x183D1F4")]
		public Kernel()
		{
		}

		[Address(RVA="0x183D10C", Offset="0x183D10C", VA="0x183D10C", Slot="11")]
		public virtual void Dispose()
		{
		}

		[Address(RVA="0x183D1C4", Offset="0x183D1C4", VA="0x183D1C4", Slot="15")]
		public virtual void FixedTick()
		{
		}

		[Address(RVA="0x183D0E0", Offset="0x183D0E0", VA="0x183D0E0", Slot="10")]
		public virtual void Initialize()
		{
		}

		[Address(RVA="0x183D138", Offset="0x183D138", VA="0x183D138", Slot="12")]
		public virtual void LateDispose()
		{
		}

		[Address(RVA="0x183D194", Offset="0x183D194", VA="0x183D194", Slot="14")]
		public virtual void LateTick()
		{
		}

		[Address(RVA="0x183D164", Offset="0x183D164", VA="0x183D164", Slot="13")]
		public virtual void Tick()
		{
		}
	}
}