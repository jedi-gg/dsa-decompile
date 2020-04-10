using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenericActionPopupView : APopupView
{
	[FieldOffset(Offset="0x0")]
	private const int TOP_LEFT = 1;

	[FieldOffset(Offset="0x0")]
	private const int TOP_RIGHT = 2;

	[FieldOffset(Offset="0x0")]
	private const int BOTTOM_RIGHT = 3;

	[FieldOffset(Offset="0x68")]
	private float _totalHeight;

	[FieldOffset(Offset="0x70")]
	private Sequence _revealSequence;

	private GenericActionPopupView.SerializedFields Fields
	{
		[Address(RVA="0x14EB390", Offset="0x14EB390", VA="0x14EB390")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14EC25C", Offset="0x14EC25C", VA="0x14EC25C")]
	public GenericActionPopupView()
	{
	}

	[Address(RVA="0x14EB470", Offset="0x14EB470", VA="0x14EB470")]
	public void ConfigureButtons(IReadOnlyList<DGenericActionPopupButtonConfig> buttonConfigs)
	{
	}

	[Address(RVA="0x14EB98C", Offset="0x14EB98C", VA="0x14EB98C")]
	private LabelButton GetButtonInstance(DGenericActionPopupButtonConfig.ButtonType buttonType)
	{
		return null;
	}

	[Address(RVA="0x14EC124", Offset="0x14EC124", VA="0x14EC124")]
	private LabelButton GetPreallocatedButtonInstance(DGenericActionPopupButtonConfig.ButtonType buttonType)
	{
		return null;
	}

	[Address(RVA="0x14EACFC", Offset="0x14EACFC", VA="0x14EACFC")]
	public void PlayRevealAnimation()
	{
	}

	[Address(RVA="0x14EAD10", Offset="0x14EAD10", VA="0x14EAD10")]
	public void SetPosition(RectTransform popperTransform, GenericActionPopupViewDirection direction, RectTransform boundsTransform = // 
	// Current member / type: System.Void GenericActionPopupView::SetPosition(UnityEngine.RectTransform,GenericActionPopupViewDirection,UnityEngine.RectTransform)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void SetPosition(UnityEngine.RectTransform,GenericActionPopupViewDirection,UnityEngine.RectTransform)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x14EBB2C", Offset="0x14EBB2C", VA="0x14EBB2C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x14EC0E0", Offset="0x14EC0E0", VA="0x14EC0E0", Slot="14")]
	protected override void ViewHidden()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public VerticalLayoutGroup LayoutGroup;

		[FieldOffset(Offset="0x38")]
		public RectTransform PopupTransform;

		[FieldOffset(Offset="0x40")]
		public RectTransform PopupArrowTransform;

		[FieldOffset(Offset="0x48")]
		public RectTransform PopupArrowSafeZoneTransform;

		[Attribute(Name="HeaderAttribute", RVA="0x106A5D4", Offset="0x106A5D4")]
		[FieldOffset(Offset="0x50")]
		public float RevealTweenDuration;

		[FieldOffset(Offset="0x54")]
		public Ease RevealTweenEase;

		[FieldOffset(Offset="0x58")]
		public float PunchTweenDuration;

		[FieldOffset(Offset="0x5C")]
		public float PunchTweenMagnitude;

		[Attribute(Name="HeaderAttribute", RVA="0x106A60C", Offset="0x106A60C")]
		[FieldOffset(Offset="0x60")]
		public LabelButton StandardButtonTemplate;

		[FieldOffset(Offset="0x68")]
		public LabelButton ActionButtonTemplate;

		[FieldOffset(Offset="0x70")]
		public LabelButton NegativeButtonTemplate;

		[Attribute(Name="HeaderAttribute", RVA="0x106A644", Offset="0x106A644")]
		[FieldOffset(Offset="0x78")]
		public LabelButton[] StandardButtonPool;

		[FieldOffset(Offset="0x80")]
		public LabelButton[] ActionButtonPool;

		[FieldOffset(Offset="0x88")]
		public LabelButton[] NegativeButtonPool;

		[Address(RVA="0x14EC264", Offset="0x14EC264", VA="0x14EC264")]
		public SerializedFields()
		{
		}
	}
}