using Glunies;
using Il2CppDummyDll;
using System;
using Zenject;

namespace Glunies.Inferno
{
	public class InfernoStateMachine : Machine<AInfernoState>
	{
		[Attribute(Name="InjectAttribute", RVA="0x1064B10", Offset="0x1064B10")]
		[FieldOffset(Offset="0x40")]
		private DiContainer _container;

		[Attribute(Name="InjectAttribute", RVA="0x1064B20", Offset="0x1064B20")]
		[FieldOffset(Offset="0x48")]
		private AssetManager _assetManager;

		[FieldOffset(Offset="0x50")]
		private SyncJobExecutor _exitStateExecutor;

		[Address(RVA="0x1524470", Offset="0x1524470", VA="0x1524470")]
		public InfernoStateMachine()
		{
		}

		[Address(RVA="0x28C6224", Offset="0x28C6224", VA="0x28C6224", Slot="5")]
		public override void EnterState<TState>(ITransitionContext context = // 
		// Current member / type: System.Void Glunies.Inferno.InfernoStateMachine::EnterState(Glunies.ITransitionContext)
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


		[Address(RVA="0x1524410", Offset="0x1524410", VA="0x1524410")]
		private void FinishedExitingState(Action finish)
		{
		}

		[Address(RVA="0x1524330", Offset="0x1524330", VA="0x1524330", Slot="10")]
		protected override void FinishExitingState(AInfernoState nextState, Action finished)
		{
		}

		[Address(RVA="0x1524318", Offset="0x1524318", VA="0x1524318")]
		public void TickUpdate()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051258", Offset="0x1051258")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset="0x10")]
			public InfernoStateMachine <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action finished;

			[FieldOffset(Offset="0x20")]
			public Action <>9__1;

			[Address(RVA="0x1524408", Offset="0x1524408", VA="0x1524408")]
			public <>c__DisplayClass2_0()
			{
			}

			[Address(RVA="0x15244E0", Offset="0x15244E0", VA="0x15244E0")]
			internal void <FinishExitingState>b__0()
			{
			}

			[Address(RVA="0x152460C", Offset="0x152460C", VA="0x152460C")]
			internal void <FinishExitingState>b__1()
			{
			}
		}
	}
}