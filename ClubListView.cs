using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClubListView : AStandardView
{
	[Attribute(Name="InjectAttribute", RVA="0x105653C", Offset="0x105653C")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105654C", Offset="0x105654C")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDC;

	[FieldOffset(Offset="0x78")]
	private List<Club> _clubs;

	[FieldOffset(Offset="0x80")]
	private int _pageStartIndex;

	[FieldOffset(Offset="0x88")]
	private Club _selectedClub;

	private ClubListView.SerializedFields Fields
	{
		[Address(RVA="0x125CEB0", Offset="0x125CEB0", VA="0x125CEB0")]
		get
		{
			return null;
		}
	}

	public RectTransform ListBounds
	{
		[Address(RVA="0x125B658", Offset="0x125B658", VA="0x125B658")]
		get
		{
			return null;
		}
	}

	public string SearchText
	{
		[Address(RVA="0x125B158", Offset="0x125B158", VA="0x125B158")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x125DB14", Offset="0x125DB14", VA="0x125DB14")]
	public ClubListView()
	{
	}

	[Address(RVA="0x125DB1C", Offset="0x125DB1C", VA="0x125DB1C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EE74", Offset="0x106EE74")]
	private void <ViewAssetLoaded>b__13_0()
	{
	}

	[Address(RVA="0x125DBA0", Offset="0x125DBA0", VA="0x125DBA0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EE84", Offset="0x106EE84")]
	private void <ViewAssetLoaded>b__13_1()
	{
	}

	[Address(RVA="0x125DC24", Offset="0x125DC24", VA="0x125DC24")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EE94", Offset="0x106EE94")]
	private void <ViewAssetLoaded>b__13_2()
	{
	}

	[Address(RVA="0x125DCA8", Offset="0x125DCA8", VA="0x125DCA8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EEA4", Offset="0x106EEA4")]
	private void <ViewAssetLoaded>b__13_3()
	{
	}

	[Address(RVA="0x125D8F4", Offset="0x125D8F4", VA="0x125D8F4")]
	private void BindClubListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x125D620", Offset="0x125D620", VA="0x125D620")]
	private void CancelJoinSelectedClub()
	{
	}

	[Address(RVA="0x125D7A4", Offset="0x125D7A4", VA="0x125D7A4")]
	private void InitializeClubListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x125D598", Offset="0x125D598", VA="0x125D598")]
	private void JoinSelectedClub()
	{
	}

	[Address(RVA="0x125D6A8", Offset="0x125D6A8", VA="0x125D6A8")]
	private void SearchForClubs(string searchText)
	{
	}

	[Address(RVA="0x125D730", Offset="0x125D730", VA="0x125D730")]
	private char SearchInputValidator(string text, int charIndex, char addedChar)
	{
		return new char();
	}

	[Address(RVA="0x125AFF4", Offset="0x125AFF4", VA="0x125AFF4")]
	public void SetData(List<Club> clubs, int pageStartIndex)
	{
	}

	[Address(RVA="0x125B5B8", Offset="0x125B5B8", VA="0x125B5B8")]
	public void SetNextPageButtonInteractable(bool interactable)
	{
	}

	[Address(RVA="0x125B600", Offset="0x125B600", VA="0x125B600")]
	public void SetPrevPageButtonInteractable(bool interactable)
	{
	}

	[Address(RVA="0x125B570", Offset="0x125B570", VA="0x125B570")]
	public void SetSearchInputInteractable(bool interactable)
	{
	}

	[Address(RVA="0x125BC54", Offset="0x125BC54", VA="0x125BC54")]
	public void SetSearchText(string searchText)
	{
	}

	[Address(RVA="0x125BB2C", Offset="0x125BB2C", VA="0x125BB2C")]
	public void ShowCreateClubButton(bool showing)
	{
	}

	[Address(RVA="0x125B510", Offset="0x125B510", VA="0x125B510")]
	public void ShowEmptySearchResultsLabel(bool showing)
	{
	}

	[Address(RVA="0x125B4B0", Offset="0x125B4B0", VA="0x125B4B0")]
	public void ShowLoadingScrim(bool showing)
	{
	}

	[Address(RVA="0x125BB8C", Offset="0x125BB8C", VA="0x125BB8C")]
	public void ShowPlayerClubButton(bool showing, string clubName)
	{
	}

	[Address(RVA="0x125CF90", Offset="0x125CF90", VA="0x125CF90", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x125D510", Offset="0x125D510", VA="0x125D510")]
	private void ViewSelectedClub()
	{
	}

	[Address(RVA="0x125D34C", Offset="0x125D34C", VA="0x125D34C", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public WrappedScrollRect ClubsScrollRect;

		[FieldOffset(Offset="0x30")]
		public LabelButton PlayerClubButton;

		[FieldOffset(Offset="0x38")]
		public Button CreateClubButton;

		[FieldOffset(Offset="0x40")]
		public UiLabel NoClubsFoundLabel;

		[FieldOffset(Offset="0x48")]
		public UiInputField SearchInput;

		[FieldOffset(Offset="0x50")]
		public UnityEngine.GameObject LoadingScrim;

		[FieldOffset(Offset="0x58")]
		public Button NextPageButton;

		[FieldOffset(Offset="0x60")]
		public Button PrevPageButton;

		[Address(RVA="0x125DD2C", Offset="0x125DD2C", VA="0x125DD2C")]
		public SerializedFields()
		{
		}
	}
}