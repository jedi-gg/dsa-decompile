using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Glunies
{
	public class PooledMachine<TState> : Machine<TState>
	where TState : AState
	{
		[FieldOffset(Offset="0x0")]
		protected Dictionary<Type, TState> _pool;

		[Address(RVA="0x1C023A4", Offset="0x1C023A4", VA="0x1C023A4")]
		public PooledMachine()
		{
		}

		[Address(RVA="0x1C021E0", Offset="0x1C021E0", VA="0x1C021E0")]
		public void AddState(TState state)
		{
		}

		[Address(RVA="0x1387DA8", Offset="0x1387DA8", VA="0x1387DA8", Slot="5")]
		public override void EnterState<UState>(ITransitionContext context = // 
		// Current member / type: System.Void Glunies.PooledMachine`1::EnterState(Glunies.ITransitionContext)
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

	}
}