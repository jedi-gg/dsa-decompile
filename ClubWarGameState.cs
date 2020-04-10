using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class ClubWarGameState : AGameState
{
	public override bool ShowGlobalBackdrop
	{
		[Address(RVA="0x14CF058", Offset="0x14CF058", VA="0x14CF058", Slot="10")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x14CF0C0", Offset="0x14CF0C0", VA="0x14CF0C0")]
	public ClubWarGameState()
	{
	}

	[Address(RVA="0x14CF060", Offset="0x14CF060", VA="0x14CF060", Slot="4")]
	public override void Entering(ITransitionContext context)
	{
	}

	public class TransitionContext : GameStateTransitionContext
	{
		[FieldOffset(Offset="0x20")]
		public readonly Club Club;

		[Address(RVA="0x14CF0C8", Offset="0x14CF0C8", VA="0x14CF0C8")]
		public TransitionContext(Club club = // 
		// Current member / type: System.Void ClubWarGameState/TransitionContext::.ctor(Serverproto.Club)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void .ctor(Serverproto.Club)
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