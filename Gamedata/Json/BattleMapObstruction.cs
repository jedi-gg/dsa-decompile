using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Gamedata.Json
{
	[Serializable]
	public class BattleMapObstruction
	{
		[FieldOffset(Offset="0x10")]
		[SerializeField]
		private short x_start;

		[FieldOffset(Offset="0x12")]
		[SerializeField]
		private short x_end;

		[FieldOffset(Offset="0x14")]
		[SerializeField]
		private short y;

		public short EndX
		{
			[Address(RVA="0x2518C94", Offset="0x2518C94", VA="0x2518C94")]
			get
			{
				return new short();
			}
			[Address(RVA="0x2518C9C", Offset="0x2518C9C", VA="0x2518C9C")]
			set
			{
			}
		}

		public short StartX
		{
			[Address(RVA="0x2518C84", Offset="0x2518C84", VA="0x2518C84")]
			get
			{
				return new short();
			}
			[Address(RVA="0x2518C8C", Offset="0x2518C8C", VA="0x2518C8C")]
			set
			{
			}
		}

		public short Y
		{
			[Address(RVA="0x2518CA4", Offset="0x2518CA4", VA="0x2518CA4")]
			get
			{
				return new short();
			}
			[Address(RVA="0x2518CAC", Offset="0x2518CAC", VA="0x2518CAC")]
			set
			{
			}
		}

		[Address(RVA="0x2518CB4", Offset="0x2518CB4", VA="0x2518CB4")]
		public BattleMapObstruction()
		{
		}
	}
}