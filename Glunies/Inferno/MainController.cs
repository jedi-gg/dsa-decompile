using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using Zenject;

namespace Glunies.Inferno
{
	public class MainController : AInfernoController, IDispatchHandler<DInfernoAction>, IDispatchHandler
	{
		[Attribute(Name="InjectAttribute", RVA="0x1064AB0", Offset="0x1064AB0")]
		[FieldOffset(Offset="0x28")]
		private DiContainer _container;

		[Attribute(Name="InjectAttribute", RVA="0x1064AC0", Offset="0x1064AC0")]
		[FieldOffset(Offset="0x30")]
		private DispatchSystem _dispatchSystem;

		[Attribute(Name="InjectAttribute", RVA="0x1064AD0", Offset="0x1064AD0")]
		[FieldOffset(Offset="0x38")]
		private InfernoStateMachine _stateMachine;

		[FieldOffset(Offset="0x40")]
		private List<AInfernoController> _subControllers;

		[Address(RVA="0x15251A0", Offset="0x15251A0", VA="0x15251A0")]
		public MainController()
		{
		}

		[Address(RVA="0x1525210", Offset="0x1525210", VA="0x1525210")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x108A820", Offset="0x108A820")]
		private void <Initialize>b__0_0(Action executed)
		{
		}

		[Address(RVA="0x15250FC", Offset="0x15250FC", VA="0x15250FC", Slot="7")]
		public void HandleDispatchAction(DInfernoAction action)
		{
		}

		[Address(RVA="0x1524A80", Offset="0x1524A80", VA="0x1524A80", Slot="4")]
		public override void Initialize(Action finished = // 
		// Current member / type: System.Void Glunies.Inferno.MainController::Initialize(System.Action)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void Initialize(System.Action)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1524E54", Offset="0x1524E54", VA="0x1524E54", Slot="5")]
		public override void Shutdown()
		{
		}

		[Address(RVA="0x1524FD0", Offset="0x1524FD0", VA="0x1524FD0", Slot="6")]
		public override void TickUpdate()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051228", Offset="0x1051228")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset="0x10")]
			public Action executed;

			[Address(RVA="0x15252D4", Offset="0x15252D4", VA="0x15252D4")]
			public <>c__DisplayClass0_0()
			{
			}

			[Address(RVA="0x15252DC", Offset="0x15252DC", VA="0x15252DC")]
			internal void <Initialize>b__1(MenuBarView view)
			{
			}
		}
	}
}