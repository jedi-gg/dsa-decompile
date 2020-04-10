using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class ClubCreateController : APopupController, IDispatchHandler<DClubCreateViewAction>, IDispatchHandler, IDispatchHandler<DClubAvatarChangedAction>, IDispatchHandler<DPlayerClubChangedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1055E18", Offset="0x1055E18")]
	[FieldOffset(Offset="0x38")]
	private ClubServiceUtility _clubServiceUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1055E28", Offset="0x1055E28")]
	[FieldOffset(Offset="0x40")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1055E38", Offset="0x1055E38")]
	[FieldOffset(Offset="0x48")]
	private InventoryUtility _inventoryUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1055E48", Offset="0x1055E48")]
	[FieldOffset(Offset="0x50")]
	private LocalizationManager _lm;

	[Attribute(Name="InjectAttribute", RVA="0x1055E58", Offset="0x1055E58")]
	[FieldOffset(Offset="0x58")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1055E68", Offset="0x1055E68")]
	[FieldOffset(Offset="0x60")]
	private ProfanityFilter _profanityFilter;

	[Attribute(Name="InjectAttribute", RVA="0x1055E78", Offset="0x1055E78")]
	[FieldOffset(Offset="0x68")]
	private SystemDialogManager _dialogManager;

	[FieldOffset(Offset="0x0")]
	private const ClubInvitePolicy DEFAULT_INVITE_POLICY = ClubInvitePolicy.OpenInvitePolicy;

	[FieldOffset(Offset="0x70")]
	private ClubCreateView _view;

	[FieldOffset(Offset="0x78")]
	private ClubSettings _clubSettings;

	[Address(RVA="0x14694E0", Offset="0x14694E0", VA="0x14694E0")]
	public ClubCreateController()
	{
	}

	[Address(RVA="0x14692F4", Offset="0x14692F4", VA="0x14692F4")]
	private Tuple<Gamedata.InventoryItem, uint> GetCreateClubCost()
	{
		return null;
	}

	[Address(RVA="0x1468904", Offset="0x1468904", VA="0x1468904")]
	private Gamedata.InventoryItem? GetDefaultClubIcon()
	{
		return null;
	}

	[Address(RVA="0x1468B1C", Offset="0x1468B1C", VA="0x1468B1C", Slot="14")]
	public void HandleDispatchAction(DClubCreateViewAction action)
	{
	}

	[Address(RVA="0x1469018", Offset="0x1469018", VA="0x1469018", Slot="15")]
	public void HandleDispatchAction(DClubAvatarChangedAction action)
	{
	}

	[Address(RVA="0x1469238", Offset="0x1469238", VA="0x1469238", Slot="16")]
	public void HandleDispatchAction(DPlayerClubChangedAction action)
	{
	}

	[Address(RVA="0x146872C", Offset="0x146872C", VA="0x146872C", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x1468F14", Offset="0x1468F14", VA="0x1468F14")]
	private bool IsDescriptionValid()
	{
		return new bool();
	}

	[Address(RVA="0x1468EC4", Offset="0x1468EC4", VA="0x1468EC4")]
	private bool IsNameValid()
	{
		return new bool();
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B5FC", Offset="0x104B5FC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubCreateController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Gamedata.InventoryItem? defaultIcon;

		[FieldOffset(Offset="0x30")]
		public Action completed;

		[Address(RVA="0x14688FC", Offset="0x14688FC", VA="0x14688FC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x14694E8", Offset="0x14694E8", VA="0x14694E8")]
		internal void <Initialize>b__0(ClubCreateView view)
		{
		}
	}
}