using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Gamedata.Json
{
	[Serializable]
	public class BattleMapEncounterLoc
	{
		[FieldOffset(Offset="0x10")]
		[SerializeField]
		private string id;

		[FieldOffset(Offset="0x18")]
		[SerializeField]
		private float x;

		[FieldOffset(Offset="0x1C")]
		[SerializeField]
		private float y;

		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private byte num_lanes;

		[FieldOffset(Offset="0x21")]
		[SerializeField]
		private byte grid_gap;

		[FieldOffset(Offset="0x24")]
		[SerializeField]
		private float verticality;

		public byte GridGap
		{
			[Address(RVA="0x2518C64", Offset="0x2518C64", VA="0x2518C64")]
			get
			{
				return new byte();
			}
			[Address(RVA="0x2518C6C", Offset="0x2518C6C", VA="0x2518C6C")]
			set
			{
			}
		}

		public string Id
		{
			[Address(RVA="0x2518BB0", Offset="0x2518BB0", VA="0x2518BB0")]
			get
			{
				return null;
			}
		}

		public byte NumLanes
		{
			[Address(RVA="0x2518C54", Offset="0x2518C54", VA="0x2518C54")]
			get
			{
				return new byte();
			}
			[Address(RVA="0x2518C5C", Offset="0x2518C5C", VA="0x2518C5C")]
			set
			{
			}
		}

		public Vector3 Position
		{
			[Address(RVA="0x2518BB8", Offset="0x2518BB8", VA="0x2518BB8")]
			get
			{
				return new Vector3();
			}
			[Address(RVA="0x2518BF4", Offset="0x2518BF4", VA="0x2518BF4")]
			set
			{
			}
		}

		public Vector3 Size
		{
			[Address(RVA="0x2518C00", Offset="0x2518C00", VA="0x2518C00")]
			get
			{
				return new Vector3();
			}
		}

		[Address(RVA="0x2518C74", Offset="0x2518C74", VA="0x2518C74")]
		public BattleMapEncounterLoc()
		{
		}
	}
}