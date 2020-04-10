using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PvpBattleHudView : AStandardView
{
	[Attribute(Name="InjectAttribute", RVA="0x1054520", Offset="0x1054520")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	private PvpBattleHudView.SerializedFields Fields
	{
		[Address(RVA="0x1282820", Offset="0x1282820", VA="0x1282820")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1282BAC", Offset="0x1282BAC", VA="0x1282BAC")]
	public PvpBattleHudView()
	{
	}

	[Address(RVA="0x1282900", Offset="0x1282900", VA="0x1282900")]
	private void SetPlayer(Player player, PvpBattleHudView.PlayerContainer container)
	{
	}

	[Address(RVA="0x12827B4", Offset="0x12827B4", VA="0x12827B4")]
	public void SetPlayers(Player playerOne, Player playerTwo)
	{
	}

	[Address(RVA="0x1282B7C", Offset="0x1282B7C", VA="0x1282B7C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1282B84", Offset="0x1282B84", VA="0x1282B84", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class PlayerContainer
	{
		[FieldOffset(Offset="0x10")]
		public RawImage PlayerIcon;

		[FieldOffset(Offset="0x18")]
		public UnityEngine.GameObject PlayerVipIconBg;

		[FieldOffset(Offset="0x20")]
		public UiLabel PlayerName;

		[FieldOffset(Offset="0x28")]
		public UiLabel ClubName;

		[Address(RVA="0x1282BB4", Offset="0x1282BB4", VA="0x1282BB4")]
		public PlayerContainer()
		{
		}
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x1069BBC", Offset="0x1069BBC")]
		[FieldOffset(Offset="0x28")]
		public PvpBattleHudView.PlayerContainer PlayerOne;

		[FieldOffset(Offset="0x30")]
		public PvpBattleHudView.PlayerContainer PlayerTwo;

		[Address(RVA="0x1282BBC", Offset="0x1282BBC", VA="0x1282BBC")]
		public SerializedFields()
		{
		}
	}
}