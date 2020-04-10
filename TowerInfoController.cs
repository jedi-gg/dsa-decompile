using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class TowerInfoController : APopupController
{
	[Address(RVA="0x1435E50", Offset="0x1435E50", VA="0x1435E50")]
	public TowerInfoController()
	{
	}

	[Address(RVA="0x1435C78", Offset="0x1435C78", VA="0x1435C78", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CEDC", Offset="0x104CEDC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public TowerInfoController.Context towerContext;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x1435E48", Offset="0x1435E48", VA="0x1435E48")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1435E58", Offset="0x1435E58", VA="0x1435E58")]
		internal void <Initialize>b__0(TowerInfoView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly TowerMap TowerMap;

		[Address(RVA="0x143605C", Offset="0x143605C", VA="0x143605C")]
		public Context(TowerMap towerMap)
		{
		}
	}
}