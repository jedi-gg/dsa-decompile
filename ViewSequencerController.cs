using Glunies;
using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class ViewSequencerController
{
	[Attribute(Name="InjectAttribute", RVA="0x105D608", Offset="0x105D608")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x18")]
	private List<ViewSequencer> _activeSequencers;

	[FieldOffset(Offset="0x20")]
	private List<ViewSequencerController.DelayedViewSequencer> _delayedSequencers;

	[Address(RVA="0x15A3F88", Offset="0x15A3F88", VA="0x15A3F88")]
	public ViewSequencerController()
	{
	}

	[Address(RVA="0x15A38F4", Offset="0x15A38F4", VA="0x15A38F4")]
	public void Play(ViewSequencer sequencer, AView view, Action<ASequenceAction> actionPreInitializeCallback = // 
	// Current member / type: System.Void ViewSequencerController::Play(ViewSequencer,Glunies.AView,System.Action`1<Glunies.Sequencer.ASequenceAction>,System.Single)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void Play(ViewSequencer,Glunies.AView,System.Action<Glunies.Sequencer.ASequenceAction>,System.Single)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x15A3CE4", Offset="0x15A3CE4", VA="0x15A3CE4")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x15A3A28", Offset="0x15A3A28", VA="0x15A3A28")]
	public void TickUpdate()
	{
	}

	private class DelayedViewSequencer
	{
		[FieldOffset(Offset="0x10")]
		public ViewSequencer Sequencer;

		[FieldOffset(Offset="0x18")]
		public float Delay;

		[Address(RVA="0x15A3A20", Offset="0x15A3A20", VA="0x15A3A20")]
		public DelayedViewSequencer()
		{
		}
	}
}