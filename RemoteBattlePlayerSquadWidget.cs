using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemoteBattlePlayerSquadWidget : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private AssetRegistry _assetRegistry;

	[FieldOffset(Offset="0x20")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x28")]
	private LocalizationManager _lm;

	[Attribute(Name="HeaderAttribute", RVA="0x1053B30", Offset="0x1053B30")]
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private RawImage _profileImage;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private GameObject _profileVipBg;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private UiLabel _playerNameLabel;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private UiLabel _clubNameLabel;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private UiLabel _playerPowerLabel;

	[Attribute(Name="HeaderAttribute", RVA="0x1053BBC", Offset="0x1053BBC")]
	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private GameObject _pvpStatsContainer;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private RawImage _pvpRankIcon;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private UiLabel _pvpRankLabel;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private UiLabel _pvpScoreLabel;

	[Attribute(Name="HeaderAttribute", RVA="0x1053C38", Offset="0x1053C38")]
	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private GameObject _kothStatsContainer;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private UiLabel _kothRankLabel;

	[Attribute(Name="HeaderAttribute", RVA="0x1053C94", Offset="0x1053C94")]
	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private List<UnitListItem> _units;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private List<SpellListItem> _spells;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private GameObject _spellCardBack1;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private GameObject _spellCardBack2;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private GameObject _cardBacksContainer;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private GameObject _cardFrontsContainer;

	[Address(RVA="0x2C2CF10", Offset="0x2C2CF10", VA="0x2C2CF10")]
	public RemoteBattlePlayerSquadWidget()
	{
	}

	[Address(RVA="0x2C2BEA8", Offset="0x2C2BEA8", VA="0x2C2BEA8")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x2C2C538", Offset="0x2C2C538", VA="0x2C2C538")]
	public void SetPlayerData(RemoteBattlePlayerSquadWidget.Data playerData, RemoteBattlePlayerSquadWidget.ExtraCardDisplay extraCardDisplay)
	{
	}

	[Address(RVA="0x2C2C260", Offset="0x2C2C260", VA="0x2C2C260")]
	public void ShowKothStats(bool showing)
	{
	}

	[Address(RVA="0x2C2C1B0", Offset="0x2C2C1B0", VA="0x2C2C1B0")]
	public void ShowPvpStats(bool showing)
	{
	}

	[Address(RVA="0x2C2C310", Offset="0x2C2C310", VA="0x2C2C310")]
	public void Shutdown()
	{
	}

	public class Data
	{
		[FieldOffset(Offset="0x10")]
		public readonly List<Serverproto.Unit> SquadUnits;

		[FieldOffset(Offset="0x18")]
		public readonly List<Serverproto.Spell> SquadSpells;

		[FieldOffset(Offset="0x20")]
		public readonly string PlayerName;

		[FieldOffset(Offset="0x28")]
		public readonly string ClubName;

		[FieldOffset(Offset="0x30")]
		public readonly ulong SquadPower;

		[FieldOffset(Offset="0x38")]
		public readonly ulong PlayerProfileIconId;

		[FieldOffset(Offset="0x40")]
		public readonly bool ShowVipProfileBg;

		[FieldOffset(Offset="0x48")]
		public readonly ulong PvpScore;

		[FieldOffset(Offset="0x50")]
		public readonly PvpRank? PvpRank;

		[FieldOffset(Offset="0x68")]
		public readonly ulong LeaderUnitId;

		[FieldOffset(Offset="0x70")]
		public readonly ulong KothRank;

		[Address(RVA="0x2C2CF18", Offset="0x2C2CF18", VA="0x2C2CF18")]
		public Data(Player player, IList<Serverproto.Unit> squadUnits, IList<Serverproto.Spell> squadSpells, ulong pvpScore, PvpRank? pvpRank, ulong leaderUnitId, ulong kothRank)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051518", Offset="0x1051518")]
		[Serializable]
		private sealed class <>c
		{
			[FieldOffset(Offset="0x0")]
			public readonly static RemoteBattlePlayerSquadWidget.Data.<>c <>9;

			[FieldOffset(Offset="0x8")]
			public static Predicate<Serverproto.Unit> <>9__11_0;

			[FieldOffset(Offset="0x10")]
			public static Predicate<Serverproto.Spell> <>9__11_1;

			[Address(RVA="0x2C2D42C", Offset="0x2C2D42C", VA="0x2C2D42C")]
			static <>c()
			{
			}

			[Address(RVA="0x2C2D490", Offset="0x2C2D490", VA="0x2C2D490")]
			public <>c()
			{
			}

			[Address(RVA="0x2C2D498", Offset="0x2C2D498", VA="0x2C2D498")]
			internal bool <.ctor>b__11_0(Serverproto.Unit u)
			{
				return new bool();
			}

			[Address(RVA="0x2C2D4A4", Offset="0x2C2D4A4", VA="0x2C2D4A4")]
			internal bool <.ctor>b__11_1(Serverproto.Spell s)
			{
				return new bool();
			}
		}
	}

	public enum ExtraCardDisplay
	{
		[FieldOffset(Offset="0x0")]
		None,
		[FieldOffset(Offset="0x0")]
		CardBacks,
		[FieldOffset(Offset="0x0")]
		CardFronts
	}
}