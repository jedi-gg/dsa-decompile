using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;

public class AuraListView : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private WidgetDependencyContainer _dependencies;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private AuraWidget _widget;

	[Address(RVA="0x115DEF0", Offset="0x115DEF0", VA="0x115DEF0")]
	public AuraListView()
	{
	}

	[Address(RVA="0x115DC5C", Offset="0x115DC5C", VA="0x115DC5C")]
	public void AddAura(Aura aura, BattleLib_Bootstrap.Types.Unit unit, int abilityId)
	{
	}

	[Address(RVA="0x115D864", Offset="0x115D864", VA="0x115D864")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x115D86C", Offset="0x115D86C", VA="0x115D86C")]
	public void Shutdown()
	{
	}
}