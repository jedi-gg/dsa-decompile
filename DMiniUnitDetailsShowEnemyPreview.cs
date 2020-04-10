using Il2CppDummyDll;
using Serverproto;
using System;

public struct DMiniUnitDetailsShowEnemyPreview
{
	[FieldOffset(Offset="0x0")]
	public readonly Serverproto.EnemyUnitPreview EnemyUnitPreview;

	[FieldOffset(Offset="0x8")]
	public readonly Serverproto.UnitStatOverride UnitStatOverride;

	[Address(RVA="0xEFE464", Offset="0xEFE464", VA="0xEFE464")]
	public DMiniUnitDetailsShowEnemyPreview(Serverproto.EnemyUnitPreview enemyUnitPreview, Serverproto.UnitStatOverride unitStatOverride)
	{
	}
}