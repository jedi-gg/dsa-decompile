using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Glunies
{
	public class GameStateMachineNavigationTracker
	{
		[Attribute(Name="InjectAttribute", RVA="0x106410C", Offset="0x106410C")]
		[FieldOffset(Offset="0x10")]
		private DispatchSystem _dispatchSystem;

		[Attribute(Name="InjectAttribute", RVA="0x106411C", Offset="0x106411C")]
		[FieldOffset(Offset="0x18")]
		private GameStateMachine _gameStateMachine;

		[FieldOffset(Offset="0x20")]
		private List<DGameStateEnvelope> _history;

		[Address(RVA="0x1427664", Offset="0x1427664", VA="0x1427664")]
		public GameStateMachineNavigationTracker()
		{
		}

		[Address(RVA="0x1426E3C", Offset="0x1426E3C", VA="0x1426E3C")]
		public void ClearHistory()
		{
		}

		[Address(RVA="0x1427020", Offset="0x1427020", VA="0x1427020")]
		private void EnterState(DGameStateEnvelope history, GameStateTransitionContext context = // 
		// Current member / type: System.Void Glunies.GameStateMachineNavigationTracker::EnterState(Glunies.DGameStateEnvelope,Glunies.GameStateTransitionContext)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void EnterState(Glunies.DGameStateEnvelope,Glunies.GameStateTransitionContext)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x14274D4", Offset="0x14274D4", VA="0x14274D4")]
		private void HandleStateEntering(AState state)
		{
		}

		[Address(RVA="0x14273E4", Offset="0x14273E4", VA="0x14273E4")]
		private void HandleStateExiting(AState state)
		{
		}

		[Address(RVA="0x1426C44", Offset="0x1426C44", VA="0x1426C44")]
		public void Initialize()
		{
		}

		[Address(RVA="0x1426E9C", Offset="0x1426E9C", VA="0x1426E9C")]
		public void NavigateBack()
		{
		}

		[Address(RVA="0x28C6028", Offset="0x28C6028", VA="0x28C6028")]
		public void NavigateBackTo<T>(GameStateTransitionContext context = // 
		// Current member / type: System.Void Glunies.GameStateMachineNavigationTracker::NavigateBackTo(Glunies.GameStateTransitionContext)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void NavigateBackTo(Glunies.GameStateTransitionContext)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x14271AC", Offset="0x14271AC", VA="0x14271AC")]
		public void NavigateBackTo(Type stateType, GameStateTransitionContext context = // 
		// Current member / type: System.Void Glunies.GameStateMachineNavigationTracker::NavigateBackTo(System.Type,Glunies.GameStateTransitionContext)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void NavigateBackTo(System.Type,Glunies.GameStateTransitionContext)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1426D40", Offset="0x1426D40", VA="0x1426D40")]
		public void Shutdown()
		{
		}
	}
}