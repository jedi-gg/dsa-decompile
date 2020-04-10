using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public enum LootTag
	{
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061CE4", Offset="0x1061CE4")]
		[FieldOffset(Offset="0x0")]
		None,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061D1C", Offset="0x1061D1C")]
		[FieldOffset(Offset="0x0")]
		FirstTimeReward,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061D54", Offset="0x1061D54")]
		[FieldOffset(Offset="0x0")]
		BonusLoot,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061D8C", Offset="0x1061D8C")]
		[FieldOffset(Offset="0x0")]
		PersistentLoot,
		[Attribute(Name="OriginalNameAttribute", RVA="0x1061DC4", Offset="0x1061DC4")]
		[FieldOffset(Offset="0x0")]
		PersistentGoal
	}
}