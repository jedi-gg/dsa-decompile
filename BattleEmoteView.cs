using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleEmoteView : AStandardView
{
	[Attribute(Name="InjectAttribute", RVA="0x10531F4", Offset="0x10531F4")]
	[FieldOffset(Offset="0x68")]
	private AccountPrefs _accountPrefs;

	[FieldOffset(Offset="0x70")]
	private List<PlayerEmoteWidget> _playerEmoteWidgets;

	private BattleEmoteView.SerializedFields Fields
	{
		[Address(RVA="0x1142AC0", Offset="0x1142AC0", VA="0x1142AC0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11431D8", Offset="0x11431D8", VA="0x11431D8")]
	public BattleEmoteView()
	{
	}

	[Address(RVA="0x11426B0", Offset="0x11426B0", VA="0x11426B0")]
	public void LoadEmotesForPlayer(uint playerId, bool isLocalPlayer, List<InventoryItem> emotes, Action finished)
	{
	}

	[Address(RVA="0x1142BA0", Offset="0x1142BA0", VA="0x1142BA0")]
	public void PlayEmote(uint playerId, ulong emoteId)
	{
	}

	[Address(RVA="0x1142D34", Offset="0x1142D34", VA="0x1142D34")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1142E5C", Offset="0x1142E5C", VA="0x1142E5C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1143068", Offset="0x1143068", VA="0x1143068", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AF8C", Offset="0x104AF8C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public List<InventoryItem> emotes;

		[FieldOffset(Offset="0x18")]
		public BattleEmoteView <>4__this;

		[FieldOffset(Offset="0x20")]
		public PlayerEmoteWidget widget;

		[FieldOffset(Offset="0x28")]
		public bool isLocalPlayer;

		[FieldOffset(Offset="0x30")]
		public Action finished;

		[Address(RVA="0x1142AB8", Offset="0x1142AB8", VA="0x1142AB8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1143248", Offset="0x1143248", VA="0x1143248")]
		internal void <LoadEmotesForPlayer>b__0(AssetCollection collection)
		{
		}
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public UnityEngine.GameObject LocalPlayerEmoteRoot;

		[FieldOffset(Offset="0x30")]
		public EmoteWidget LocalPlayerEmote;

		[FieldOffset(Offset="0x38")]
		public UnityEngine.GameObject OtherPlayerEmoteRoot;

		[FieldOffset(Offset="0x40")]
		public EmoteWidget OtherPlayerEmote;

		[Attribute(Name="HeaderAttribute", RVA="0x10699AC", Offset="0x10699AC")]
		[FieldOffset(Offset="0x48")]
		public EmoteKeyboardWidget Keyboard;

		[Address(RVA="0x114363C", Offset="0x114363C", VA="0x114363C")]
		public SerializedFields()
		{
		}
	}
}