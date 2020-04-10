using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gamedata.Json
{
	[Serializable]
	public class BattleMapEncounters
	{
		[FieldOffset(Offset="0x10")]
		[SerializeField]
		private List<Gamedata.Json.BattleMapEncounterLoc> encounters;

		public List<Gamedata.Json.BattleMapEncounterLoc> Encounters
		{
			[Address(RVA="0x2518A18", Offset="0x2518A18", VA="0x2518A18")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2518C7C", Offset="0x2518C7C", VA="0x2518C7C")]
		public BattleMapEncounters()
		{
		}
	}
}