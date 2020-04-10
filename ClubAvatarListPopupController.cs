using Glunies;
using Il2CppDummyDll;
using System;

public class ClubAvatarListPopupController : APopupController, IDispatchHandler<DClubAvatarListItemClickedAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1055DF8", Offset="0x1055DF8")]
	[FieldOffset(Offset="0x38")]
	private InventoryUtility _inventoryUtility;

	[FieldOffset(Offset="0x40")]
	private ClubAvatarListPopupController.Context _context;

	[Address(RVA="0x14680D4", Offset="0x14680D4", VA="0x14680D4")]
	public ClubAvatarListPopupController()
	{
	}

	[Address(RVA="0x1467F94", Offset="0x1467F94", VA="0x1467F94", Slot="14")]
	public void HandleDispatchAction(DClubAvatarListItemClickedAction action)
	{
	}

	[Address(RVA="0x1467E3C", Offset="0x1467E3C", VA="0x1467E3C", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B5EC", Offset="0x104B5EC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubAvatarListPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x1467F8C", Offset="0x1467F8C", VA="0x1467F8C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x14680DC", Offset="0x14680DC", VA="0x14680DC")]
		internal void <Initialize>b__0(ClubAvatarListPopupView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly ulong AvatarId;

		[Address(RVA="0x1468264", Offset="0x1468264", VA="0x1468264")]
		public Context(ulong avatarId)
		{
		}
	}
}