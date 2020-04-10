using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class TutorialMessageBubbleView : AView
{
	[FieldOffset(Offset="0x68")]
	private Sequence _showSequence;

	[FieldOffset(Offset="0x70")]
	private RectTransform _rootRect;

	public override bool CanTriggerContextualMessages
	{
		[Address(RVA="0x143D91C", Offset="0x143D91C", VA="0x143D91C", Slot="7")]
		get
		{
			return new bool();
		}
	}

	public override ViewDepth Depth
	{
		[Address(RVA="0x143D914", Offset="0x143D914", VA="0x143D914", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private TutorialMessageBubbleView.SerializedFields Fields
	{
		[Address(RVA="0x143DACC", Offset="0x143DACC", VA="0x143DACC")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x143DFB8", Offset="0x143DFB8", VA="0x143DFB8")]
	public TutorialMessageBubbleView()
	{
	}

	[Address(RVA="0x143D924", Offset="0x143D924", VA="0x143D924")]
	public void Configure(string messageKey, string buttonKey, Vector2? positionOffset = // 
	// Current member / type: System.Void TutorialMessageBubbleView::Configure(System.String,System.String,System.Nullable`1<UnityEngine.Vector2>)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void Configure(System.String,System.String,System.Nullable<UnityEngine.Vector2>)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x143DF34", Offset="0x143DF34", VA="0x143DF34")]
	private void ContinueClicked()
	{
	}

	[Address(RVA="0x143DBAC", Offset="0x143DBAC", VA="0x143DBAC", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x143DF1C", Offset="0x143DF1C", VA="0x143DF1C", Slot="14")]
	protected override void ViewHidden()
	{
	}

	[Address(RVA="0x143DEBC", Offset="0x143DEBC", VA="0x143DEBC", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x143DE30", Offset="0x143DE30", VA="0x143DE30", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public CanvasGroup TweenRoot;

		[FieldOffset(Offset="0x30")]
		public UiLabel MessageLabel;

		[FieldOffset(Offset="0x38")]
		public LabelButton ContinueButton;

		[Address(RVA="0x143DFC0", Offset="0x143DFC0", VA="0x143DFC0")]
		public SerializedFields()
		{
		}
	}
}