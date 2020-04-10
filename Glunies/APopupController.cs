using Il2CppDummyDll;
using System;

namespace Glunies
{
	public abstract class APopupController : IDispatchHandler<DViewAction>, IDispatchHandler, IDispatchHandler<DPopupViewAction>, ILoggable<LogCategory>
	{
		[Attribute(Name="InjectAttribute", RVA="0x106419C", Offset="0x106419C")]
		[FieldOffset(Offset="0x10")]
		protected GameStateMachine _gameStateMachine;

		[Attribute(Name="InjectAttribute", RVA="0x10641AC", Offset="0x10641AC")]
		[FieldOffset(Offset="0x18")]
		protected DispatchSystem _dispatchSystem;

		[Attribute(Name="InjectAttribute", RVA="0x10641BC", Offset="0x10641BC")]
		[FieldOffset(Offset="0x20")]
		protected ViewController _viewController;

		[FieldOffset(Offset="0x28")]
		protected bool _isShutdown;

		[FieldOffset(Offset="0x30")]
		private APopupView _view;

		public LogCategory LogCategory
		{
			[Address(RVA="0x14F6E80", Offset="0x14F6E80", VA="0x14F6E80", Slot="6")]
			get
			{
				return new LogCategory();
			}
		}

		public virtual bool ShouldBeRestoredFromHistory
		{
			[Address(RVA="0x14F6E88", Offset="0x14F6E88", VA="0x14F6E88", Slot="7")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x14EC4D4", Offset="0x14EC4D4", VA="0x14EC4D4")]
		protected APopupController()
		{
		}

		[Address(RVA="0x14EC434", Offset="0x14EC434", VA="0x14EC434")]
		public void Close()
		{
		}

		[Address(RVA="0x14F6F54", Offset="0x14F6F54", VA="0x14F6F54", Slot="13")]
		protected virtual void ControllerClosing()
		{
		}

		[Address(RVA="0x19A1950", Offset="0x19A1950", VA="0x19A1950")]
		protected void EnterState<TState>(GameStateTransitionContext context = // 
		// Current member / type: System.Void Glunies.APopupController::EnterState(Glunies.GameStateTransitionContext)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void EnterState(Glunies.GameStateTransitionContext)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x14F6F08", Offset="0x14F6F08", VA="0x14F6F08", Slot="11")]
		public virtual ITransitionContext GetCurrentContext()
		{
			return null;
		}

		[Address(RVA="0x14F6F50", Offset="0x14F6F50", VA="0x14F6F50", Slot="12")]
		protected virtual void HandleBackButton(AView view)
		{
		}

		[Address(RVA="0x14F6F10", Offset="0x14F6F10", VA="0x14F6F10", Slot="4")]
		public void HandleDispatchAction(DViewAction viewAction)
		{
		}

		[Address(RVA="0x14F6F30", Offset="0x14F6F30", VA="0x14F6F30", Slot="5")]
		public void HandleDispatchAction(DPopupViewAction viewAction)
		{
		}

		[Address(RVA="0x14EC3F8", Offset="0x14EC3F8", VA="0x14EC3F8", Slot="8")]
		public virtual void Initialize(ITransitionContext context, Action completed)
		{
		}

		[Address(RVA="0x14F6F48", Offset="0x14F6F48", VA="0x14F6F48")]
		protected bool IsShutdown()
		{
			return new bool();
		}

		[Address(RVA="0x19A1A3C", Offset="0x19A1A3C", VA="0x19A1A3C")]
		protected void LoadView<T>(Action<T> viewLoaded, bool startActive = true)
		where T : APopupView, new()
		{
		}

		[Address(RVA="0x14F6E90", Offset="0x14F6E90", VA="0x14F6E90", Slot="9")]
		public virtual void Shutdown()
		{
		}

		[Address(RVA="0x14F6F04", Offset="0x14F6F04", VA="0x14F6F04", Slot="10")]
		public virtual void TickUpdate()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050F78", Offset="0x1050F78")]
		private sealed class <>c__DisplayClass15_0<T>
		where T : APopupView, new()
		{
			[FieldOffset(Offset="0x0")]
			public APopupController <>4__this;

			[FieldOffset(Offset="0x0")]
			public Action<T> viewLoaded;

			[Address(RVA="0x1BFFB7C", Offset="0x1BFFB7C", VA="0x1BFFB7C")]
			public <>c__DisplayClass15_0()
			{
			}

			[Address(RVA="0x1BFFBA8", Offset="0x1BFFBA8", VA="0x1BFFBA8")]
			internal void <LoadView>b__0(T view)
			{
			}
		}
	}
}