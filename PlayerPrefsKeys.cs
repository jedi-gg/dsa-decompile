using Gamedata;
using Il2CppDummyDll;
using Serverproto;
using System;

public static class PlayerPrefsKeys
{
	[FieldOffset(Offset="0x0")]
	public const string AUTOBATTLE_ENABLED_PLAYER_PREF_KEY = "autobattle-enabled";

	[FieldOffset(Offset="0x0")]
	public const string AUTOBATTLE_ENABLED_CLUB_DUNGEON_PLAYER_PREF_KEY = "autobattle-enabled-club-dungeon";

	[FieldOffset(Offset="0x0")]
	public const string AUTOBATTLE_ENABLED_CLUB_WAR_PLAYER_PREF_KEY = "autobattle-enabled-club-war";

	[FieldOffset(Offset="0x0")]
	public const string AUTOBATTLE_ENABLED_EVENT_PLAYER_PREF_KEY = "autobattle-enabled-event";

	[FieldOffset(Offset="0x0")]
	public const string AUTOBATTLE_ENABLED_KOTH_PLAYER_PREF_KEY = "autobattle-enabled-koth";

	[FieldOffset(Offset="0x0")]
	public const string AUTOBATTLE_ENABLED_PVP_PLAYER_PREF_KEY = "autobattle-enabled-pvp";

	[FieldOffset(Offset="0x0")]
	public const string AUTOBATTLE_ENABLED_TOWER_PLAYER_PREF_KEY = "autobattle-enabled-tower";

	[FieldOffset(Offset="0x0")]
	public const string AUTOBATTLE_SPEED_PLAYER_PREF_KEY = "autobattle-speed";

	[FieldOffset(Offset="0x0")]
	public const string AUTOBATTLE_SPEED_CLUB_DUNGEON_PLAYER_PREF_KEY = "autobattle-speed-club-dungeon";

	[FieldOffset(Offset="0x0")]
	public const string AUTOBATTLE_SPEED_CLUB_WAR_PLAYER_PREF_KEY = "autobattle-speed-club-war";

	[FieldOffset(Offset="0x0")]
	public const string AUTOBATTLE_SPEED_EVENT_PLAYER_PREF_KEY = "autobattle-speed-event";

	[FieldOffset(Offset="0x0")]
	public const string AUTOBATTLE_SPEED_KOTH_PLAYER_PREF_KEY = "autobattle-speed-koth";

	[FieldOffset(Offset="0x0")]
	public const string AUTOBATTLE_SPEED_PVP_PLAYER_PREF_KEY = "autobattle-speed-pvp";

	[FieldOffset(Offset="0x0")]
	public const string AUTOBATTLE_SPEED_TOWER_PLAYER_PREF_KEY = "autobattle-speed-tower";

	[FieldOffset(Offset="0x0")]
	public const string CARD_UNLOCK_TRACKER_CARD_SHOWN = "CARD_UNLOCK_TRACKER_CARD_SHOWN_";

	[FieldOffset(Offset="0x0")]
	public const string NEWSLETTER_LAST_VIEWED = "NEWSLETTER_LAST_VIEWED";

	[FieldOffset(Offset="0x0")]
	public const string UNLOCKED_FEATURE_BADGE_KEY = "UNLOCKED_FEATURE_BADGE_KEY_";

	[FieldOffset(Offset="0x0")]
	public const string LAST_MP_START_TIMESTAMP = "LAST_MP_START_TIMESTAMP";

	[FieldOffset(Offset="0x0")]
	public const string LAST_MP_TYPE = "LAST_MP_TYPE";

	[FieldOffset(Offset="0x0")]
	public const string LAST_MP_GAMEDATA_VERSION = "LAST_MP_GAMEDATA_VERSION";

	[FieldOffset(Offset="0x0")]
	public const string LAST_MP_BUNDLE_VERSION = "LAST_MP_BUNDLE_VERSION";

	[FieldOffset(Offset="0x0")]
	public const string LAST_PVE_BATTLE_ID = "LAST_BATTLE_ID";

	[FieldOffset(Offset="0x0")]
	public const string CLUB_DUNGEON_LAST_SEEN_ID = "CLUB_DUNGEON_LAST_SEEN_ID";

	[FieldOffset(Offset="0x0")]
	public const string LAST_HERO_BATTLE_ID = "LAST_HERO_BATTLE_ID";

	[FieldOffset(Offset="0x0")]
	public const string LAST_VILLAIN_BATTLE_ID = "LAST_VILLAIN_BATTLE_ID";

	[FieldOffset(Offset="0x0")]
	public const string LAST_GRAND_BATTLE_ID = "LAST_GRAND_BATTLE_ID";

	[FieldOffset(Offset="0x0")]
	public const string LAST_SEEN_CLUB_ITEM_REQUEST_CREATED = "LAST_SEEN_CLUB_ITEM_REQUEST_CREATED";

	[FieldOffset(Offset="0x0")]
	public const string CLUB_ACTIVITIES_LAST_VIEWED_PLAYER_DATE = "CLUB_ACTIVITIES_LAST_VIEWED_PLAYER_DATE";

	[FieldOffset(Offset="0x0")]
	public const string NEW_UNIT_SKIN_UNIT_IDS = "NEW_UNIT_SKIN_UNIT_IDS";

	[FieldOffset(Offset="0x0")]
	public const string LAST_KOTH_SHARD = "LAST_KOTH_SHARD";

	[FieldOffset(Offset="0x0")]
	public const string LAST_KOTH_RANK = "LAST_KOTH_RANK";

	[FieldOffset(Offset="0x0")]
	public const string LAST_KOTH_COOLDOWN_EXPIRED_SEEN = "LAST_KOTH_COOLDOWN_EXPIRED_SEEN";

	[FieldOffset(Offset="0x0")]
	public const string NEW_EMOTES = "NEW_EMOTES";

	[FieldOffset(Offset="0x0")]
	public const string NEW_PINS = "NEW_PINS";

	[FieldOffset(Offset="0x0")]
	public const string CLUB_WAR_LAST_SEEN_REGISTRATION_END_TIME = "CLUB_WAR_LAST_SEEN_REGISTRATION_END_TIME";

	[FieldOffset(Offset="0x0")]
	public const string AVAILABLE_STORE_PACK_IDS = "AVAILABLE_STORE_PACK_IDS";

	[FieldOffset(Offset="0x0")]
	public const string NEW_STORE_PACK_IDS = "NEW_STORE_PACK_IDS";

	[FieldOffset(Offset="0x0")]
	public const string SEND_CLUB_GIFTS_ANONYMOUSLY = "SEND_CLUB_GIFTS_ANONYMOUSLY";

	[FieldOffset(Offset="0x0")]
	public const string AUTO_AUTO_FILL_SQUAD = "AUTO_AUTO_FILL_SQUAD";

	[FieldOffset(Offset="0x0")]
	public const string SPECIAL_OFFER_SEEN = "SPECIAL_OFFER_SEEN";

	[FieldOffset(Offset="0x0")]
	public const string SPECIAL_OFFER_SEEN_LIMIT_COUNT = "SPECIAL_OFFER_SEEN_LIMIT_COUNT";

	[FieldOffset(Offset="0x0")]
	public const string SPECIAL_OFFER_SEEN_LIMIT_COOLDOWN_START = "SPECIAL_OFFER_SEEN_LIMIT_COOLDOWN_START";

	[FieldOffset(Offset="0x0")]
	public const string TOWER_SCENE_VIEWED = "TOWER_SCENE_VIEWED";

	[FieldOffset(Offset="0x0")]
	public const string CHARACTER_LEVEL_TO_12_LOGGED = "CHARACTER_LEVEL_TO_12_LOGGED";

	[FieldOffset(Offset="0x0")]
	public const string CHARACTER_PROMOTE_TO_3_LOGGED = "CHARACTER_PROMOTE_TO_3_LOGGED";

	[FieldOffset(Offset="0x0")]
	public const string CHARACTER_TIER_TO_3_LOGGED = "CHARACTER_TIER_TO_3_LOGGED";

	[FieldOffset(Offset="0x0")]
	public const string DAILY_PVP_PACK_LOGGED = "DAILY_PVP_PACK_LOGGED";

	[FieldOffset(Offset="0x0")]
	public const string PURCHASED_PASSHOLDER_LOGGED = "PURCHASED_PASSHOLDER_LOGGED";

	[FieldOffset(Offset="0x0")]
	public const string CHARACTER_4_STAR_AND_GEAR_TIER_3_LOGGED = "CHARACTER_4_STAR_AND_GEAR_TIER_3_LOGGED";

	[FieldOffset(Offset="0x0")]
	public const string PURCHASED_20_DOLLAR_GEM_PACK_LOGGED = "PURCHASED_20_DOLLAR_GEM_PACK_LOGGED";

	[FieldOffset(Offset="0x0")]
	public const string PURCHASED_5_DOLLAR_STARTER_PACK_LOGGED = "PURCHASED_5_DOLLAR_STARTER_PACK_LOGGED";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B784", Offset="0x105B784")]
	[FieldOffset(Offset="0x0")]
	public const string CACHED_CONSOLE_COMMAND = "CACHED_CONSOLE_COMMAND";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B798", Offset="0x105B798")]
	[FieldOffset(Offset="0x0")]
	public const string CACHED_DEVICE_ID = "CACHED_DEVICE_ID";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B7AC", Offset="0x105B7AC")]
	[FieldOffset(Offset="0x0")]
	public const string DEEP_LINK_PREF_KEY = "DEEP_LINK_PREF_KEY";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B7C0", Offset="0x105B7C0")]
	[FieldOffset(Offset="0x0")]
	public const string ANDROID_TEST_LOOP_PREF_KEY = "ANDROID_TEST_LOOP_PREF_KEY";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B7D4", Offset="0x105B7D4")]
	[FieldOffset(Offset="0x0")]
	public const string GAME_LANGUAGE_PREFERENCE = "GAME_LANGUAGE_PREFERENCE";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B7E8", Offset="0x105B7E8")]
	[FieldOffset(Offset="0x0")]
	public const string MUSIC_ENABLED = "MUSIC_ENABLED";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B7FC", Offset="0x105B7FC")]
	[FieldOffset(Offset="0x0")]
	public const string SFX_ENABLED = "SFX_ENABLED";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B810", Offset="0x105B810")]
	[FieldOffset(Offset="0x0")]
	public const string CHAT_PREVIEW_ENABLED = "CHAT_PREVIEW_ENABLED";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B824", Offset="0x105B824")]
	[FieldOffset(Offset="0x0")]
	public const string SKIP_TITLE_TAP_TO_CONTINUE = "SKIP_TITLE_TAP_TO_CONTINUE";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B838", Offset="0x105B838")]
	[FieldOffset(Offset="0x0")]
	public const string SYSTEM_TIMEZONE_OVERRIDE = "SYSTEM_TIMEZONE_OVERRIDE";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B84C", Offset="0x105B84C")]
	[FieldOffset(Offset="0x0")]
	public const string BATTLE_DAMAGE_NUMBERS_ENABLED_V2 = "BATTLE_DAMAGE_NUMBERS_ENABLED_V2";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B860", Offset="0x105B860")]
	[FieldOffset(Offset="0x0")]
	public const string BATTLE_ABILITY_CAMERAS_ENABLED = "BATTLE_ABILITY_CAMERAS_ENABLED";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B874", Offset="0x105B874")]
	[FieldOffset(Offset="0x0")]
	public const string GRAPHICS_SETTINGS = "GRAPHICS_SETTINGS";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B888", Offset="0x105B888")]
	[FieldOffset(Offset="0x0")]
	public const string AUTO_GRAPHICS_SETTINGS = "AUTO_GRAPHICS_SETTINGS";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B89C", Offset="0x105B89C")]
	[FieldOffset(Offset="0x0")]
	public const string NOTIFICATIONS_ENABLED = "NOTIFICATIONS_ENABLED";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B8B0", Offset="0x105B8B0")]
	[FieldOffset(Offset="0x0")]
	public const string VIBRATION_ENABLED = "VIBRATION_ENABLED";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B8C4", Offset="0x105B8C4")]
	[FieldOffset(Offset="0x0")]
	public const string FIRST_LAUNCH_TIME = "FIRST_LAUNCH_TIME";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B8D8", Offset="0x105B8D8")]
	[FieldOffset(Offset="0x0")]
	public const string FORCE_ANON = "FORCE_ANON";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B8EC", Offset="0x105B8EC")]
	[FieldOffset(Offset="0x0")]
	public const string BATTLE_EMOTES_MUTED = "BATTLE_EMOTES_MUTED";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B900", Offset="0x105B900")]
	[FieldOffset(Offset="0x0")]
	public const string HAS_SEEN_INTRO_CINEMATIC = "HAS_SEEN_INTRO_CINEMATIC";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B914", Offset="0x105B914")]
	[FieldOffset(Offset="0x0")]
	public const string HAS_EVER_PASSED_AUTH = "HAS_EVER_PASSED_AUTH";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B928", Offset="0x105B928")]
	[FieldOffset(Offset="0x0")]
	public const string HAS_EVER_USED_SOCIAL_AUTH = "HAS_EVER_USED_SOCIAL_AUTH";

	[Attribute(Name="PlayerPrefsTypeAttribute", RVA="0x105B93C", Offset="0x105B93C")]
	[FieldOffset(Offset="0x0")]
	public const string TURN_ORDER_COLLAPSED = "TURN_ORDER_COLLAPSED";

	[Address(RVA="0x133E010", Offset="0x133E010", VA="0x133E010")]
	public static string ConvertCampaignIdentifierToPlayerPrefsValue(CampaignIdentifier campaignIdentifier)
	{
		return null;
	}

	[Address(RVA="0x133E41C", Offset="0x133E41C", VA="0x133E41C")]
	public static string GetAutoAutoFillSquadPlayerPrefsKey(CampaignIdentifier campaignIdentifier)
	{
		return null;
	}

	[Address(RVA="0x133E4D0", Offset="0x133E4D0", VA="0x133E4D0")]
	public static string GetAutoAutoFillSquadPlayerPrefsKey(Gamedata.GameMode gameMode)
	{
		return null;
	}

	[Address(RVA="0x133E26C", Offset="0x133E26C", VA="0x133E26C")]
	public static bool GetCampaignIdentifierFromPlayerPrefsValue(string playerPrefsValue, out ulong campaignId, out int mapIndex, out int nodeIndex, out int battleIndex)
	{
		campaignId = 0L;
		mapIndex = 0;
		nodeIndex = 0;
		battleIndex = 0;
		return new bool();
	}

	[Address(RVA="0x133E558", Offset="0x133E558", VA="0x133E558")]
	public static string GetSpecialOfferSeenKey(ulong storeItemId)
	{
		return null;
	}

	[Address(RVA="0x133E5E0", Offset="0x133E5E0", VA="0x133E5E0")]
	public static string GetTowerSceneViewedKey(ulong towerId, ulong mapId)
	{
		return null;
	}
}