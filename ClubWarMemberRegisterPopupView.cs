using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ClubWarMemberRegisterPopupView : APopupView
{
	[FieldOffset(Offset="0x68")]
	private Sequence _showSequence;

	private ClubWarMemberRegisterPopupView.SerializedFields Fields
	{
		[Address(RVA="0x14CF824", Offset="0x14CF824", VA="0x14CF824")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14CFA8C", Offset="0x14CFA8C", VA="0x14CFA8C")]
	public ClubWarMemberRegisterPopupView()
	{
	}

	[Address(RVA="0x14CF9D8", Offset="0x14CF9D8", VA="0x14CF9D8")]
	private void RegisterClicked()
	{
	}

	[Address(RVA="0x14CF730", Offset="0x14CF730", VA="0x14CF730", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x14CF994", Offset="0x14CF994", VA="0x14CF994", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x14CF904", Offset="0x14CF904", VA="0x14CF904", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public Toggle AutoRegisterToggle;

		[FieldOffset(Offset="0x38")]
		public Button RegisterButton;

		[FieldOffset(Offset="0x40")]
		public CanvasGroup WindowRoot;

		[Address(RVA="0x14CFA94", Offset="0x14CFA94", VA="0x14CFA94")]
		public SerializedFields()
		{
		}
	}
}