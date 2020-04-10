using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Glunies
{
	public class GameStateMachine : Machine<AGameState>, IDispatchHandler<DFatalAction>, IDispatchHandler, IDispatchHandler<DAttemptFatalRecoveryAction>, IDispatchHandler<DWsTransportClosedAction>, IDispatchHandler<DWsTransportErrorAction>, IDispatchHandler<DEnterGameStateAction>
	{
		[FieldOffset(Offset="0x0")]
		private const float UPDATE_CONTENT_THROTTLE_S = 300f;

		[Attribute(Name="InjectAttribute", RVA="0x106408C", Offset="0x106408C")]
		[FieldOffset(Offset="0x40")]
		private DiContainer _container;

		[Attribute(Name="InjectAttribute", RVA="0x106409C", Offset="0x106409C")]
		[FieldOffset(Offset="0x48")]
		private DispatchSystem _dispatch;

		[Attribute(Name="InjectAttribute", RVA="0x10640AC", Offset="0x10640AC")]
		[FieldOffset(Offset="0x50")]
		private PlayerDomainController _playerDc;

		[Attribute(Name="InjectAttribute", RVA="0x10640BC", Offset="0x10640BC")]
		[FieldOffset(Offset="0x58")]
		private FeatureLockController _featureLockController;

		[Attribute(Name="InjectAttribute", RVA="0x10640CC", Offset="0x10640CC")]
		[FieldOffset(Offset="0x60")]
		private BackdropController _backdropController;

		[Attribute(Name="InjectAttribute", RVA="0x10640DC", Offset="0x10640DC")]
		[FieldOffset(Offset="0x68")]
		private IGameServiceTransport _gameServiceTransport;

		[Attribute(Name="InjectAttribute", RVA="0x10640EC", Offset="0x10640EC")]
		[FieldOffset(Offset="0x70")]
		private RevSdkController _revSdkController;

		[Attribute(Name="InjectAttribute", RVA="0x10640FC", Offset="0x10640FC")]
		[FieldOffset(Offset="0x78")]
		private AccountPrefs _accountPrefs;

		[FieldOffset(Offset="0x80")]
		private SyncJobExecutor _exitStateExecutor;

		[FieldOffset(Offset="0x88")]
		private float _nextMetadataUpdateS;

		[FieldOffset(Offset="0x8C")]
		private bool _hadFatalError;

		[FieldOffset(Offset="0x8D")]
		private bool _forceGetPlayerNextTransition;

		[Address(RVA="0x1426008", Offset="0x1426008", VA="0x1426008")]
		public GameStateMachine()
		{
		}

		[Address(RVA="0x1425B0C", Offset="0x1425B0C", VA="0x1425B0C", Slot="9")]
		protected override bool BeginEnteringState()
		{
			return new bool();
		}

		[Address(RVA="0x28C5F14", Offset="0x28C5F14", VA="0x28C5F14", Slot="5")]
		public override void EnterState<TState>(ITransitionContext context = // 
		// Current member / type: System.Void Glunies.GameStateMachine::EnterState(Glunies.ITransitionContext)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void EnterState(Glunies.ITransitionContext)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x14253D4", Offset="0x14253D4", VA="0x14253D4", Slot="6")]
		public override void EnterState(AGameState state, ITransitionContext context = // 
		// Current member / type: System.Void Glunies.GameStateMachine::EnterState(Glunies.AGameState,Glunies.ITransitionContext)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void EnterState(Glunies.AGameState,Glunies.ITransitionContext)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x14256FC", Offset="0x14256FC", VA="0x14256FC")]
		public void EnterState(Type type, ITransitionContext context = // 
		// Current member / type: System.Void Glunies.GameStateMachine::EnterState(System.Type,Glunies.ITransitionContext)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void EnterState(System.Type,Glunies.ITransitionContext)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1425CD4", Offset="0x1425CD4", VA="0x1425CD4", Slot="10")]
		protected override void FinishExitingState(AGameState nextState, Action finished)
		{
		}

		[Address(RVA="0x1425984", Offset="0x1425984", VA="0x1425984")]
		public void ForceContentFetchNextTransition()
		{
		}

		[Address(RVA="0x142598C", Offset="0x142598C", VA="0x142598C")]
		public void ForceGetPlayerNextTransition()
		{
		}

		[Address(RVA="0x14255F4", Offset="0x14255F4", VA="0x14255F4")]
		private bool GameStateIsFeatureLocked(Type type, ITransitionContext context = // 
		// Current member / type: System.Boolean Glunies.GameStateMachine::GameStateIsFeatureLocked(System.Type,Glunies.ITransitionContext)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Boolean GameStateIsFeatureLocked(System.Type,Glunies.ITransitionContext)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1425998", Offset="0x1425998", VA="0x1425998", Slot="11")]
		public void HandleDispatchAction(DFatalAction action)
		{
		}

		[Address(RVA="0x14259A4", Offset="0x14259A4", VA="0x14259A4", Slot="12")]
		public void HandleDispatchAction(DAttemptFatalRecoveryAction action)
		{
		}

		[Address(RVA="0x1425A20", Offset="0x1425A20", VA="0x1425A20", Slot="13")]
		public void HandleDispatchAction(DWsTransportClosedAction action)
		{
		}

		[Address(RVA="0x1425A2C", Offset="0x1425A2C", VA="0x1425A2C", Slot="14")]
		public void HandleDispatchAction(DWsTransportErrorAction action)
		{
		}

		[Address(RVA="0x1425A38", Offset="0x1425A38", VA="0x1425A38", Slot="15")]
		public void HandleDispatchAction(DEnterGameStateAction action)
		{
		}

		[Address(RVA="0x1425E1C", Offset="0x1425E1C", VA="0x1425E1C")]
		private void HandleSceneUnloaded(Scene scene)
		{
		}

		[Address(RVA="0x1425244", Offset="0x1425244", VA="0x1425244", Slot="7")]
		public override void Initialize()
		{
		}

		[Address(RVA="0x142590C", Offset="0x142590C", VA="0x142590C")]
		public bool IsSafeToProcessDeepLink()
		{
			return new bool();
		}

		[Address(RVA="0x1425484", Offset="0x1425484", VA="0x1425484")]
		private bool RedirectToAgeGate()
		{
			return new bool();
		}

		[Address(RVA="0x1425EA8", Offset="0x1425EA8", VA="0x1425EA8")]
		private bool ShouldFetchContent(AGameState nextState)
		{
			return new bool();
		}

		[Address(RVA="0x1425328", Offset="0x1425328", VA="0x1425328", Slot="8")]
		public override void Shutdown()
		{
		}

		[Address(RVA="0x1425898", Offset="0x1425898", VA="0x1425898")]
		public void TickUpdate()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050EF8", Offset="0x1050EF8")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static GameStateMachine.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static AnonymousJob.Work <>9__15_3;

			[Address(RVA="0x1426080", Offset="0x1426080", VA="0x1426080")]
			static <>c()
			{
			}

			[Address(RVA="0x14260E4", Offset="0x14260E4", VA="0x14260E4")]
			public <>c()
			{
			}

			[Address(RVA="0x14260EC", Offset="0x14260EC", VA="0x14260EC")]
			internal void <FinishExitingState>b__15_3(Action jobFinished)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050EB8", Offset="0x1050EB8")]
		private sealed class <>c__DisplayClass15_0
		{
			[FieldOffset(Offset="0x10")]
			public GameStateMachine <>4__this;

			[FieldOffset(Offset="0x18")]
			public AGameState nextState;

			[FieldOffset(Offset="0x20")]
			public Action finished;

			[FieldOffset(Offset="0x28")]
			public Action <>9__4;

			[Address(RVA="0x1425E14", Offset="0x1425E14", VA="0x1425E14")]
			public <>c__DisplayClass15_0()
			{
			}

			[Address(RVA="0x14261C4", Offset="0x14261C4", VA="0x14261C4")]
			internal void <FinishExitingState>b__0()
			{
			}

			[Address(RVA="0x142660C", Offset="0x142660C", VA="0x142660C")]
			internal void <FinishExitingState>b__4()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050EC8", Offset="0x1050EC8")]
		private sealed class <>c__DisplayClass15_1
		{
			[FieldOffset(Offset="0x10")]
			public FetchContentJob fetchContentJob;

			[FieldOffset(Offset="0x18")]
			public bool authenticated;

			[FieldOffset(Offset="0x20")]
			public GameStateMachine.<>c__DisplayClass15_0 CS$<>8__locals1;

			[Address(RVA="0x1426604", Offset="0x1426604", VA="0x1426604")]
			public <>c__DisplayClass15_1()
			{
			}

			[Address(RVA="0x142666C", Offset="0x142666C", VA="0x142666C")]
			internal void <FinishExitingState>b__1(Action jobFinished)
			{
			}

			[Address(RVA="0x14269F8", Offset="0x14269F8", VA="0x14269F8")]
			internal void <FinishExitingState>b__2(Action jobFinished)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050ED8", Offset="0x1050ED8")]
		private sealed class <>c__DisplayClass15_2
		{
			[FieldOffset(Offset="0x10")]
			public bool dayHasEnded;

			[FieldOffset(Offset="0x18")]
			public Action jobFinished;

			[FieldOffset(Offset="0x20")]
			public GameStateMachine.<>c__DisplayClass15_1 CS$<>8__locals2;

			[Address(RVA="0x14269F0", Offset="0x14269F0", VA="0x14269F0")]
			public <>c__DisplayClass15_2()
			{
			}

			[Address(RVA="0x1426B0C", Offset="0x1426B0C", VA="0x1426B0C")]
			internal void <FinishExitingState>b__5()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050EE8", Offset="0x1050EE8")]
		private sealed class <>c__DisplayClass15_3
		{
			[FieldOffset(Offset="0x10")]
			public Action jobFinished;

			[Address(RVA="0x14261BC", Offset="0x14261BC", VA="0x14261BC")]
			public <>c__DisplayClass15_3()
			{
			}

			[Address(RVA="0x1426C14", Offset="0x1426C14", VA="0x1426C14")]
			internal void <FinishExitingState>b__6(AsyncOperation op)
			{
			}
		}
	}
}