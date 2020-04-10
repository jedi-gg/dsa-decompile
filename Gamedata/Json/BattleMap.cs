using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gamedata.Json
{
	[Serializable]
	public class BattleMap
	{
		[Attribute(Name="HideInInspector", RVA="0x1063C1C", Offset="0x1063C1C")]
		[FieldOffset(Offset="0x10")]
		[SerializeField]
		private string id;

		[Attribute(Name="HideInInspector", RVA="0x1063C54", Offset="0x1063C54")]
		[FieldOffset(Offset="0x18")]
		[SerializeField]
		private string tool_display_name;

		[Attribute(Name="HideInInspector", RVA="0x1063C8C", Offset="0x1063C8C")]
		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private string[] tool_tags;

		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private float size_x;

		[FieldOffset(Offset="0x2C")]
		[SerializeField]
		private float size_y;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private Gamedata.Json.BattleMapEncounters encounters;

		[Attribute(Name="HideInInspector", RVA="0x1063CF4", Offset="0x1063CF4")]
		[FieldOffset(Offset="0x38")]
		[SerializeField]
		private List<Gamedata.Json.BattleMapObstruction> obstructions;

		public string DisplayName
		{
			[Address(RVA="0x25189E4", Offset="0x25189E4", VA="0x25189E4")]
			get
			{
				return null;
			}
		}

		public List<Gamedata.Json.BattleMapEncounterLoc> Encounters
		{
			[Address(RVA="0x25189EC", Offset="0x25189EC", VA="0x25189EC")]
			get
			{
				return null;
			}
		}

		public float Height
		{
			[Address(RVA="0x2518A30", Offset="0x2518A30", VA="0x2518A30")]
			get
			{
				return new float();
			}
			[Address(RVA="0x2518A38", Offset="0x2518A38", VA="0x2518A38")]
			set
			{
			}
		}

		public string Id
		{
			[Address(RVA="0x25189DC", Offset="0x25189DC", VA="0x25189DC")]
			get
			{
				return null;
			}
		}

		public uint NumTilesX
		{
			[Address(RVA="0x2518A48", Offset="0x2518A48", VA="0x2518A48")]
			get
			{
				return new uint();
			}
		}

		public uint NumTilesY
		{
			[Address(RVA="0x2518AC0", Offset="0x2518AC0", VA="0x2518AC0")]
			get
			{
				return new uint();
			}
		}

		public List<Gamedata.Json.BattleMapObstruction> Obstructions
		{
			[Address(RVA="0x2518A40", Offset="0x2518A40", VA="0x2518A40")]
			get
			{
				return null;
			}
		}

		public float Width
		{
			[Address(RVA="0x2518A20", Offset="0x2518A20", VA="0x2518A20")]
			get
			{
				return new float();
			}
			[Address(RVA="0x2518A28", Offset="0x2518A28", VA="0x2518A28")]
			set
			{
			}
		}

		[Address(RVA="0x2518B40", Offset="0x2518B40", VA="0x2518B40")]
		public BattleMap()
		{
		}

		[Address(RVA="0x2518B38", Offset="0x2518B38", VA="0x2518B38")]
		public void SetObstructions(List<Gamedata.Json.BattleMapObstruction> newObstructions)
		{
		}
	}
}