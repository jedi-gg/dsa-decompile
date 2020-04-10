using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;

[Attribute(Name="CreateAssetMenuAttribute", RVA="0x10489F8", Offset="0x10489F8")]
public class MockPvpData : ScriptableObject
{
	[FieldOffset(Offset="0x18")]
	public bool DesaturateOpponent;

	[FieldOffset(Offset="0x20")]
	public MockPvpData.Environment EnvironmentOverride;

	[FieldOffset(Offset="0x28")]
	public MockPvpData.Player LocalPlayer;

	[FieldOffset(Offset="0x30")]
	public MockPvpData.Player Opponent;

	[Address(RVA="0x12F42C4", Offset="0x12F42C4", VA="0x12F42C4")]
	public MockPvpData()
	{
	}

	[Serializable]
	public class Environment
	{
		[Attribute(Name="TooltipAttribute", RVA="0x106AF3C", Offset="0x106AF3C")]
		[FieldOffset(Offset="0x10")]
		public string EnvironmentAsset;

		[FieldOffset(Offset="0x18")]
		public float MapSizeX;

		[FieldOffset(Offset="0x1C")]
		public float MapSizeY;

		[FieldOffset(Offset="0x20")]
		public float EncounterX;

		[FieldOffset(Offset="0x24")]
		public float EncounterY;

		[FieldOffset(Offset="0x28")]
		public float Verticality;

		[Address(RVA="0x12F42CC", Offset="0x12F42CC", VA="0x12F42CC")]
		public Environment()
		{
		}
	}

	[Serializable]
	public class Player
	{
		[FieldOffset(Offset="0x10")]
		[SerializeField]
		private string _name;

		[FieldOffset(Offset="0x18")]
		[SerializeField]
		private string _clubName;

		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private ulong _avatarId;

		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private bool _showVip;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private ulong _unitAbilityLevel;

		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private ulong[] _unitIds;

		[FieldOffset(Offset="0x40")]
		[SerializeField]
		private ulong[] _spellIds;

		[Address(RVA="0x12F45C4", Offset="0x12F45C4", VA="0x12F45C4")]
		public Player()
		{
		}

		[Address(RVA="0x12F42D4", Offset="0x12F42D4", VA="0x12F42D4")]
		public BattleSim_SimplePlayer ToBattleSimPlayer()
		{
			return null;
		}

		[Address(RVA="0x12F44B8", Offset="0x12F44B8", VA="0x12F44B8")]
		public Serverproto.Player ToPlayer()
		{
			return null;
		}
	}
}