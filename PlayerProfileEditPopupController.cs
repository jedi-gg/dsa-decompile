using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class PlayerProfileEditPopupController : APopupController, IDispatchHandler<DPlayerProfileEditUsernameAction>, IDispatchHandler, IDispatchHandler<DPlayerProfileEditAvatarAction>, IDispatchHandler<DPlayerProfileApplyChangesAction>, IDispatchHandler<DPlayerProfileEditVipBgAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105B9E0", Offset="0x105B9E0")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105B9F0", Offset="0x105B9F0")]
	[FieldOffset(Offset="0x40")]
	private InventoryUtility _inventoryUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105BA00", Offset="0x105BA00")]
	[FieldOffset(Offset="0x48")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105BA10", Offset="0x105BA10")]
	[FieldOffset(Offset="0x50")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x105BA20", Offset="0x105BA20")]
	[FieldOffset(Offset="0x58")]
	private ProfanityFilter _profanityFilter;

	[Attribute(Name="InjectAttribute", RVA="0x105BA30", Offset="0x105BA30")]
	[FieldOffset(Offset="0x60")]
	private SystemDialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x105BA40", Offset="0x105BA40")]
	[FieldOffset(Offset="0x68")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x70")]
	private PlayerProfileEditPopupView _view;

	[FieldOffset(Offset="0x78")]
	private string _pendingUsername;

	[FieldOffset(Offset="0x80")]
	private ulong _pendingAvatarId;

	[FieldOffset(Offset="0x88")]
	private bool _pendingVipBg;

	[Address(RVA="0x133F6F4", Offset="0x133F6F4", VA="0x133F6F4")]
	public PlayerProfileEditPopupController()
	{
	}

	[Address(RVA="0x133EF78", Offset="0x133EF78", VA="0x133EF78")]
	private void ApplyChanges()
	{
	}

	[Address(RVA="0x133EB80", Offset="0x133EB80", VA="0x133EB80", Slot="14")]
	public void HandleDispatchAction(DPlayerProfileEditUsernameAction action)
	{
	}

	[Address(RVA="0x133EC7C", Offset="0x133EC7C", VA="0x133EC7C", Slot="15")]
	public void HandleDispatchAction(DPlayerProfileEditAvatarAction action)
	{
	}

	[Address(RVA="0x133EF2C", Offset="0x133EF2C", VA="0x133EF2C", Slot="17")]
	public void HandleDispatchAction(DPlayerProfileEditVipBgAction action)
	{
	}

	[Address(RVA="0x133EF74", Offset="0x133EF74", VA="0x133EF74", Slot="16")]
	public void HandleDispatchAction(DPlayerProfileApplyChangesAction action)
	{
	}

	[Address(RVA="0x133EA78", Offset="0x133EA78", VA="0x133EA78", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x133F640", Offset="0x133F640", VA="0x133F640")]
	private bool IsAvatarDirty()
	{
		return new bool();
	}

	[Address(RVA="0x133F5C8", Offset="0x133F5C8", VA="0x133F5C8")]
	private bool IsUsernameDirty()
	{
		return new bool();
	}

	[Address(RVA="0x133F69C", Offset="0x133F69C", VA="0x133F69C")]
	private bool IsVipBgDirty()
	{
		return new bool();
	}

	[Address(RVA="0x133F420", Offset="0x133F420", VA="0x133F420")]
	private void SetPlayerAvatar()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C7CC", Offset="0x104C7CC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static PlayerProfileEditPopupController.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Func<bool> <>9__6_2;

		[Address(RVA="0x133F6FC", Offset="0x133F6FC", VA="0x133F6FC")]
		static <>c()
		{
		}

		[Address(RVA="0x133F760", Offset="0x133F760", VA="0x133F760")]
		public <>c()
		{
		}

		[Address(RVA="0x133F768", Offset="0x133F768", VA="0x133F768")]
		internal bool <ApplyChanges>b__6_2()
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C7AC", Offset="0x104C7AC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public PlayerProfileEditPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x133EB78", Offset="0x133EB78", VA="0x133EB78")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x133F770", Offset="0x133F770", VA="0x133F770")]
		internal void <Initialize>b__0(PlayerProfileEditPopupView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C7BC", Offset="0x104C7BC")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset="0x10")]
		public bool nameChanged;

		[FieldOffset(Offset="0x18")]
		public PlayerProfileEditPopupController <>4__this;

		[FieldOffset(Offset="0x20")]
		public bool avatarChanged;

		[FieldOffset(Offset="0x21")]
		public bool vipBgChanged;

		[Address(RVA="0x133F5C0", Offset="0x133F5C0", VA="0x133F5C0")]
		public <>c__DisplayClass6_0()
		{
		}

		[Address(RVA="0x133FA34", Offset="0x133FA34", VA="0x133FA34")]
		internal void <ApplyChanges>b__0(UpdatePlayerProfileResponse response)
		{
		}

		[Address(RVA="0x133FCF4", Offset="0x133FCF4", VA="0x133FCF4")]
		internal void <ApplyChanges>b__1(long errorCode)
		{
		}
	}
}