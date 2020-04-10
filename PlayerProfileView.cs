using Gamedata;
using Glunies;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerProfileView : AStandardView
{
	[Attribute(Name="InjectAttribute", RVA="0x105BB30", Offset="0x105BB30")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105BB40", Offset="0x105BB40")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDc;

	private PlayerProfileView.SerializedFields Fields
	{
		[Address(RVA="0x1342CC8", Offset="0x1342CC8", VA="0x1342CC8")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x13441A8", Offset="0x13441A8", VA="0x13441A8")]
	public PlayerProfileView()
	{
	}

	[Address(RVA="0x13441B0", Offset="0x13441B0", VA="0x13441B0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10706B4", Offset="0x10706B4")]
	private void <ViewAssetLoaded>b__8_0()
	{
	}

	[Address(RVA="0x1344234", Offset="0x1344234", VA="0x1344234")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10706C4", Offset="0x10706C4")]
	private void <ViewAssetLoaded>b__8_1()
	{
	}

	[Address(RVA="0x13442B8", Offset="0x13442B8", VA="0x13442B8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10706D4", Offset="0x10706D4")]
	private void <ViewAssetLoaded>b__8_2()
	{
	}

	[Address(RVA="0x134433C", Offset="0x134433C", VA="0x134433C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10706E4", Offset="0x10706E4")]
	private void <ViewAssetLoaded>b__8_3()
	{
	}

	[Address(RVA="0x1343888", Offset="0x1343888", VA="0x1343888")]
	public void AvatarChanged()
	{
	}

	[Address(RVA="0x1343434", Offset="0x1343434", VA="0x1343434")]
	private PlayerProfileSquadListItem GetSquad(Gamedata.GameMode mode)
	{
		return null;
	}

	[Address(RVA="0x13EBF14", Offset="0x13EBF14", VA="0x13EBF14")]
	private List<T> MakeList<T>(Dictionary<ulong, T> definitions, RepeatedField<ulong> ids)
	{
		return null;
	}

	[Address(RVA="0x13434D4", Offset="0x13434D4", VA="0x13434D4")]
	public void SetClub(string clubName, Gamedata.InventoryItem? clubAvatar)
	{
	}

	[Address(RVA="0x13437F8", Offset="0x13437F8", VA="0x13437F8")]
	public void SetClubDonations(ulong lifetimeDonations)
	{
	}

	[Address(RVA="0x134369C", Offset="0x134369C", VA="0x134369C")]
	public void SetClubEmpty()
	{
	}

	[Address(RVA="0x1342DF4", Offset="0x1342DF4", VA="0x1342DF4")]
	public void SetIsLocalPlayer(bool isLocalPlayer)
	{
	}

	[Address(RVA="0x1341A88", Offset="0x1341A88", VA="0x1341A88")]
	public void SetPlayer(Player player)
	{
	}

	[Address(RVA="0x1342FC4", Offset="0x1342FC4", VA="0x1342FC4")]
	public void SetPvpData(PvpRank? currentSeasonRank, ulong currentSeasonScore, PvpRank? highestRank)
	{
	}

	[Address(RVA="0x134394C", Offset="0x134394C", VA="0x134394C")]
	public void ShowFriendInvite(bool show)
	{
	}

	[Address(RVA="0x13439AC", Offset="0x13439AC", VA="0x13439AC", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1343F08", Offset="0x1343F08", VA="0x1343F08", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public PlayerXpContainer PlayerXpContainer;

		[FieldOffset(Offset="0x30")]
		public UiBarcode UiBarcode;

		[FieldOffset(Offset="0x38")]
		public Button UsernameAvatarEditButton;

		[FieldOffset(Offset="0x40")]
		public Button AvatarButton;

		[FieldOffset(Offset="0x48")]
		public UnityEngine.GameObject UsernameAvatarEditIcon;

		[FieldOffset(Offset="0x50")]
		public UiLabel CollectionPowerLabel;

		[FieldOffset(Offset="0x58")]
		public UiLabel PlayerIDLabel;

		[FieldOffset(Offset="0x60")]
		public UiLabel CharacterCountLabel;

		[FieldOffset(Offset="0x68")]
		public UiLabel SpellCountLabel;

		[FieldOffset(Offset="0x70")]
		public UiLabel PinCountLabel;

		[FieldOffset(Offset="0x78")]
		public Image VipImage;

		[Attribute(Name="HeaderAttribute", RVA="0x106B514", Offset="0x106B514")]
		[FieldOffset(Offset="0x80")]
		public RawImage PvpRankIcon;

		[FieldOffset(Offset="0x88")]
		public RawImage PvpSquadIcon;

		[FieldOffset(Offset="0x90")]
		public UiLabel PvpScore;

		[FieldOffset(Offset="0x98")]
		public UiLabel PvpRank;

		[FieldOffset(Offset="0xA0")]
		public UiLabel PvpHighestRank;

		[Attribute(Name="HeaderAttribute", RVA="0x106B54C", Offset="0x106B54C")]
		[FieldOffset(Offset="0xA8")]
		public Image KothRankIcon;

		[FieldOffset(Offset="0xB0")]
		public Image KothSquadIcon;

		[FieldOffset(Offset="0xB8")]
		public UiLabel KothRank;

		[FieldOffset(Offset="0xC0")]
		public PlayerRankSpriteLookup KothRankConfig;

		[Attribute(Name="HeaderAttribute", RVA="0x106B584", Offset="0x106B584")]
		[FieldOffset(Offset="0xC8")]
		public RawImage ClubImage;

		[FieldOffset(Offset="0xD0")]
		public UiLabel ClubName;

		[FieldOffset(Offset="0xD8")]
		public UiLabel ClubRole;

		[FieldOffset(Offset="0xE0")]
		public UiLabel ClubDonations;

		[FieldOffset(Offset="0xE8")]
		public Button ClubButton;

		[FieldOffset(Offset="0xF0")]
		public UnityEngine.GameObject[] ClubVisibilityGroup;

		[Attribute(Name="HeaderAttribute", RVA="0x106B5BC", Offset="0x106B5BC")]
		[FieldOffset(Offset="0xF8")]
		public Button AddFriendButton;

		[Attribute(Name="HeaderAttribute", RVA="0x106B5F4", Offset="0x106B5F4")]
		[FieldOffset(Offset="0x100")]
		public PlayerProfileSquadListItem[] Squads;

		[Attribute(Name="HeaderAttribute", RVA="0x106B62C", Offset="0x106B62C")]
		[FieldOffset(Offset="0x108")]
		public ParticleSystem AvatarChangedVfx;

		[Address(RVA="0x13443C0", Offset="0x13443C0", VA="0x13443C0")]
		public SerializedFields()
		{
		}
	}
}